using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Xml.Serialization;


namespace BeautyConcept.POS
{
    public partial class Form1 : Form
    {
        private List<Transaction> _transactions;
        private Transaction _currentTransaction;
        private decimal _lastAmount = 0.0M;
        private bool _taxable = true;
        private bool _refundOn = false;
        private CustomButton button;

        private string _directory = string.Empty; 
        private string _filePath = string.Empty;  

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            _transactions = new List<Transaction>();
            StartNewTransaction();
            currTransTextBox.TextAlign = HorizontalAlignment.Right;
            currTransTextBox.Text = _currentTransaction.ToString();
            _directory = string.Format("C:\\Beauty Concept\\Transaction Data\\{0}\\", DateTime.Now.ToString("MM-dd-yyyy"));
            _filePath = _directory + string.Format("Journal - {0}.dat", DateTime.Now.ToString("MM-dd-yyyy"));
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                var amount = ConvertToCurrency(currentAmtTxtBx.Text);
                if (amount <= 0)
                {
                    if (_lastAmount > 0)
                        amount = _lastAmount;
                    else
                        return;
                }

                if (_refundOn)
                    amount *= -1;

                _currentTransaction.Totals[TotalType.Subtotal] += amount;

                if (_taxable)
                    _currentTransaction.Totals[TotalType.Tax] += amount / Constants.TaxRate;

                _currentTransaction.Totals[TotalType.Total] = _currentTransaction.Totals[TotalType.Subtotal] + _currentTransaction.Totals[TotalType.Tax];
                _currentTransaction.LineItems.Add(new LineItem { Amount = amount, Taxable = _taxable });
                _lastAmount = amount;
                ClearCurrentAmountBox();
                currTransTextBox.Text = _currentTransaction.ToString();
                return;
            }
            else if (e.KeyChar == (char)27)
            {
                ClearCurrentAmountBox();
            }

            var number = 0;
            e.Handled = int.TryParse(e.KeyChar.ToString(), out number);
            if (!e.Handled)
                return;

            if (currentAmtTxtBx.Text == "$0.00")
            {
                currentAmtTxtBx.Clear();
                currentAmtTxtBx.Text = String.Concat(Constants.CurrencyPrefix, number);
            }
            else
            {
                currentAmtTxtBx.Text += number;
            }
            currentAmtTxtBx.Text = ConvertToCurrency(currentAmtTxtBx.Text).ToString("$0.00");
        }

        private decimal ConvertToCurrency(string input)
        {
            var noDecimal = input.Replace(".", "");
            var result = decimal.Parse(noDecimal, NumberStyles.Currency);
            result /= 100;

            return result;
        }

        private void ClearCurrentAmountBox()
        {
            currentAmtTxtBx.Text = "$0.00";
        }

        private void StartNewTransaction()
        {
            ClearCurrentAmountBox();
            _currentTransaction = new Transaction();
            currTransTextBox.Text = _currentTransaction.ToString();
        }

        private void CompleteTransaction()
        {
            if (_currentTransaction.Totals[TotalType.Total] < 0)
                _currentTransaction.TransactionType = TransactionType.StoreCredit;
            var printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.PrinterSettings.PrinterName = "BTP-R880NP(U) 1";
            printDoc.PrintPage += PrintPage;
            printDoc.Print();
            _transactions.Add(_currentTransaction);
            transactionCountLabel.Text = _transactions.Count.ToString();
            grandTotalLabel.Text = _transactions.Sum(x => x.Totals[TotalType.Total]).ToString("$0.00");
            //cashTotalLabel.Text = _transactions.Sum(x => x.)
            PopulateTransactionHistory();
            StartNewTransaction();
        }

        private void ProcessPayment(PaymentMethod paymentMethod)
        {
            var amountTendered = ConvertToCurrency(currentAmtTxtBx.Text);

            if (amountTendered <= 0 && _currentTransaction.Totals[TotalType.Total] > 0)
            {
                if (_currentTransaction.PaymentsApplied.Values.Sum() > 0)
                    amountTendered = _currentTransaction.Totals[TotalType.Total] - _currentTransaction.PaymentsApplied.Values.Sum();
                else
                    amountTendered = _currentTransaction.Totals[TotalType.Total];
            }
            _currentTransaction.PaymentsApplied[paymentMethod] += amountTendered;
            _currentTransaction.Complete = _currentTransaction.PaymentsApplied.Values.Sum() >= _currentTransaction.Totals[TotalType.Total];

            if (_currentTransaction.Complete)
                CompleteTransaction();

            currTransTextBox.Text = _currentTransaction.ToString();
            ClearCurrentAmountBox();
            groupBox1.Focus();
        }

        private void creditCardButton_Click(object sender, EventArgs e)
        {
            ProcessPayment(PaymentMethod.Charge);
        }
        private void cashButton_Click(object sender, EventArgs e)
        {
            ProcessPayment(PaymentMethod.Cash);
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Font printFont = new Font("Arial", 8);
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = 5;//ev.MarginBounds.Left;
            float topMargin = 5;//ev.MarginBounds.Top;
            float rightMargin = ev.MarginBounds.Right;

            String line = null;
            var tempStr = _currentTransaction.ToPrintableString().Replace("\r", "").Replace("\t", "          ");

            var streamToPrint = tempStr.Split('\n');

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            var centeredStringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
            };

            // Iterate over the file, printing each line. 
            while (count < linesPerPage &&
                //((line = sr.ReadLine()) != null))
               (count < streamToPrint.Length))
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));

                var place = rightMargin - ev.Graphics.MeasureString(streamToPrint[count], printFont).Width;

                ev.Graphics.DrawString(streamToPrint[count], printFont, Brushes.Black,
                    count < 10 ? rightMargin / 2 : rightMargin, yPos, count < 10 ? new StringFormat() { Alignment = StringAlignment.Center } : new StringFormat { Alignment = StringAlignment.Far });
                count++;
            }

            // If more lines exist, print another page. 
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
            //MessageBox.Show("Printed");

        }

        private void PopulateTransactionHistory()
        {
            var transactionListItem = new ListViewItem(_currentTransaction.Date.ToString("MM/dd/yyyy"));
            transactionListItem.SubItems.Add(_currentTransaction.Date.ToString("h:mm tt"));
            if (_currentTransaction.Totals[TotalType.Total] < 0)
                transactionListItem.SubItems.Add("Refund");
            else
                transactionListItem.SubItems.Add(_currentTransaction.TransactionType.ToString());
            transactionListItem.SubItems.Add(_currentTransaction.Totals[TotalType.Total].ToString("$0.00"));
           
            listView1.Items.Add(transactionListItem);
            saveTransactionDataToolStripMenuItem_Click(this, new EventArgs());
        }

        private void PopulateTransactionList()
        {
            if (_transactions != null && _transactions.Count > 0)
            {
                foreach (var transaction in _transactions)
                {
                    var transactionListItem = new ListViewItem(transaction.Date.ToString("MM/dd/yyyy"));
                    transactionListItem.SubItems.Add(transaction.Date.ToString("h:mm tt"));
                    if (_currentTransaction.Totals[TotalType.Total] < 0)
                        transactionListItem.SubItems.Add("Refund");
                    else
                        transactionListItem.SubItems.Add(transaction.TransactionType.ToString());
                    transactionListItem.SubItems.Add(transaction.Totals[TotalType.Total].ToString("$0.00"));

                    listView1.Items.Add(transactionListItem);
                }
                transactionCountLabel.Text = _transactions.Count.ToString();
                grandTotalLabel.Text = _transactions.Sum(x => x.Totals[TotalType.Total]).ToString("$0.00");
            }
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private void voidButton_Click(object sender, EventArgs e)
        {
            StartNewTransaction();
            groupBox1.Focus();
        }

        private void toggleTaxButton_Click(object sender, EventArgs e)
        {
            _taxable = !_taxable;
            toggleTaxButton.Text = _taxable ? "No Tax" : "Tax";
            groupBox1.Focus();
        }

        private void refundButton_Click(object sender, EventArgs e)
        {
            _refundOn = !_refundOn;
             currentAmtTxtBx.ForeColor = _refundOn ? Color.Red : Color.FromArgb(128,255,128);
             groupBox1.Focus();
        }

        private void saveTransactionDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = string.Format("C:\\Beauty Concept\\Transaction Data\\{0}\\", DateTime.Now.ToString("MM-dd-yyyy"));
            
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            //var writer = new XmlSerializer(typeof(Transaction));

            //using (
            //    var file =
            //        new StreamWriter(path + string.Format("Journal - {0}.xml", DateTime.Now.ToString("MM-dd-yyyy"))))
            //{
            //    writer.Serialize(file, _currentTransaction);
            //}

            var testfile = File.OpenWrite(_filePath);
            var serializer = new BinaryFormatter();

            serializer.Serialize(testfile, _transactions);


            //foreach (var transaction in _transactions)
            //{
            //    serializer.Serialize(testfile, transaction);
            //}

            testfile.Close();


            //using (var sw = File.CreateText(path + string.Format("Journal - {0}.txt", DateTime.Now.ToString("MM-dd-yyyy"))))
            //{
            //    sw.WriteLine(DateTime.Now.ToString("MM-dd-yyyy"));

            //    var count = 0;

            //    foreach (var transaction in _transactions)
            //    {
            //        sw.WriteLine("--------------------");
            //        sw.WriteLine("--------------------");
            //        sw.WriteLine(string.Format("Date: {0}  --  {1}  --  Transaction #: {2}", transaction.Date, transaction.TransactionType, count ));
            //        sw.WriteLine();
            //        sw.WriteLine(transaction.ToString());
            //        count++;
            //    }

            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(_filePath))
            {
                var stream = File.OpenRead(_filePath);
                var deserializer = new BinaryFormatter();
                _transactions = deserializer.Deserialize(stream) as List<Transaction>;
                stream.Close();
                PopulateTransactionList();
            }
        }
    }
}
