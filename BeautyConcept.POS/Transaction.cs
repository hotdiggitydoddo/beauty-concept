using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyConcept.POS
{
    [Serializable]
    public class Transaction
    {
        private StringBuilder _sb;

        public DateTime Date { get; set; }
        public Dictionary<TotalType, Decimal> Totals { get; set; }
        public Dictionary<PaymentMethod, Decimal> PaymentsApplied { get; set; }
        public List<LineItem> LineItems { get; set; }
        public bool Complete { get; set; }
        public TransactionType TransactionType { get; set; }

        public Transaction()
        {
            TransactionType = TransactionType.Sale;
            Totals = new Dictionary<TotalType, decimal>
            {
                {TotalType.Subtotal, 0.0M},
                {TotalType.Tax, 0.0M},
                {TotalType.Total, 0.0M},
                {TotalType.Change, 0.0M}
            };
            PaymentsApplied = new Dictionary<PaymentMethod, decimal>
            {
                {PaymentMethod.Cash, 0.0M},
                {PaymentMethod.Charge, 0.0M}
            };

            LineItems = new List<LineItem>();
            Date = DateTime.Now;
        }

        public string ToPrintableString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Beauty Concept");
            sb.AppendLine("15264 Rosecrans Ave.");
            sb.AppendLine("La Mirada, CA 90638");
            sb.AppendLine("Tel: 714.523.5641");
            sb.AppendLine();
            sb.AppendLine();
            sb.Append(Date.ToString("MM/dd/yyyy")).Append("\t\t                ").AppendLine(Date.ToString("h:mm tt"));
            sb.AppendLine();
            sb.AppendLine(TransactionType.ToString());
            for (int i = 0; i < TransactionType.ToString().Length; i++)
                sb.Append("- ");
            sb.AppendLine().AppendLine();
            return string.Concat(sb.ToString(), this.ToString()).ToUpper();
        }

        public override string ToString()
        {
            _sb = new StringBuilder();

            foreach (var lineItem in LineItems)
            {
                if (lineItem.Taxable)
                    _sb.AppendLine(lineItem.Amount.ToString("$0.00 + tx"));
                else
                    _sb.AppendLine(lineItem.Amount.ToString("$0.00"));
            }
            _sb.AppendLine();
            _sb.AppendLine("---------------------");
            _sb.Append("Subtotal:\t\t");
            _sb.AppendLine(Totals[TotalType.Subtotal].ToString("$0.00"));
            _sb.Append("Tax 10%:\t\t");
            _sb.AppendLine(Totals[TotalType.Tax].ToString("$0.00"));
            _sb.Append("Total:\t\t");
            _sb.AppendLine(Totals[TotalType.Total].ToString("$0.00"));

            if (PaymentsApplied.Values.Any(x => x > 0))
            {
                _sb.AppendLine("---------------------");
                if (PaymentsApplied[PaymentMethod.Cash] > 0)
                {
                    _sb.Append("Cash:\t\t");
                    _sb.AppendLine(PaymentsApplied[PaymentMethod.Cash].ToString("$0.00"));
                }
                if (PaymentsApplied[PaymentMethod.Charge] > 0)
                {
                    _sb.Append("Charge:\t\t");
                    _sb.AppendLine(PaymentsApplied[PaymentMethod.Charge].ToString("$0.00"));
                }
                if (Complete)
                {
                    _sb.Append("Change:\t\t");
                    _sb.AppendLine((PaymentsApplied.Values.Sum() - Totals[TotalType.Total]).ToString("$0.00"));
                }
                else
                {
                    _sb.Append("Balance:\t\t");
                    _sb.AppendLine((Totals[TotalType.Total] - PaymentsApplied.Values.Sum()).ToString("$0.00"));
                }
                            }
            return _sb.ToString();
        }
    }

    [Serializable]
    public class LineItem
    {
        public decimal Amount { get; set; }
        public bool Taxable { get; set; }
    }

    [Serializable]
    public enum PaymentMethod
    {
        Cash,
        Charge
    }

    [Serializable]
    public enum TotalType
    {
        Subtotal,
        Tax,
        Total,
        Change
    }

    [Serializable]
    public enum TransactionType
    {
        Sale,
        StoreCredit
    }


}
