namespace BeautyConcept.POS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.transHistGroupBox = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transactionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currTransTextBox = new System.Windows.Forms.TextBox();
            this.currentAmtTxtBx = new System.Windows.Forms.TextBox();
            this.cashButton = new System.Windows.Forms.Button();
            this.creditCardButton = new System.Windows.Forms.Button();
            this.voidButton = new System.Windows.Forms.Button();
            this.toggleTaxButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chargeTotalLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cashTotalLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transactionCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refundButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTransactionDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transHistGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transHistGroupBox
            // 
            this.transHistGroupBox.Controls.Add(this.listView1);
            this.transHistGroupBox.Location = new System.Drawing.Point(5, 41);
            this.transHistGroupBox.Name = "transHistGroupBox";
            this.transHistGroupBox.Size = new System.Drawing.Size(494, 459);
            this.transHistGroupBox.TabIndex = 0;
            this.transHistGroupBox.TabStop = false;
            this.transHistGroupBox.Text = "Transaction History";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.time,
            this.transactionType,
            this.amount});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(7, 14);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(481, 439);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 78;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 67;
            // 
            // transactionType
            // 
            this.transactionType.Text = "Type";
            this.transactionType.Width = 73;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currTransTextBox);
            this.groupBox1.Location = new System.Drawing.Point(520, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 459);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Transaction";
            // 
            // currTransTextBox
            // 
            this.currTransTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.currTransTextBox.Location = new System.Drawing.Point(6, 14);
            this.currTransTextBox.Multiline = true;
            this.currTransTextBox.Name = "currTransTextBox";
            this.currTransTextBox.ReadOnly = true;
            this.currTransTextBox.Size = new System.Drawing.Size(482, 439);
            this.currTransTextBox.TabIndex = 0;
            // 
            // currentAmtTxtBx
            // 
            this.currentAmtTxtBx.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentAmtTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAmtTxtBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.currentAmtTxtBx.Location = new System.Drawing.Point(808, 506);
            this.currentAmtTxtBx.Multiline = true;
            this.currentAmtTxtBx.Name = "currentAmtTxtBx";
            this.currentAmtTxtBx.ReadOnly = true;
            this.currentAmtTxtBx.Size = new System.Drawing.Size(203, 42);
            this.currentAmtTxtBx.TabIndex = 2;
            this.currentAmtTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cashButton
            // 
            this.cashButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(33)))));
            this.cashButton.FlatAppearance.BorderSize = 0;
            this.cashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashButton.ForeColor = System.Drawing.Color.White;
            this.cashButton.Location = new System.Drawing.Point(808, 554);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(203, 44);
            this.cashButton.TabIndex = 3;
            this.cashButton.Text = "Cash";
            this.cashButton.UseVisualStyleBackColor = false;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // creditCardButton
            // 
            this.creditCardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(33)))));
            this.creditCardButton.FlatAppearance.BorderSize = 0;
            this.creditCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardButton.ForeColor = System.Drawing.Color.White;
            this.creditCardButton.Location = new System.Drawing.Point(808, 604);
            this.creditCardButton.Name = "creditCardButton";
            this.creditCardButton.Size = new System.Drawing.Size(203, 44);
            this.creditCardButton.TabIndex = 4;
            this.creditCardButton.Text = "Charge";
            this.creditCardButton.UseVisualStyleBackColor = false;
            this.creditCardButton.Click += new System.EventHandler(this.creditCardButton_Click);
            // 
            // voidButton
            // 
            this.voidButton.BackColor = System.Drawing.Color.Red;
            this.voidButton.FlatAppearance.BorderSize = 0;
            this.voidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voidButton.ForeColor = System.Drawing.Color.White;
            this.voidButton.Location = new System.Drawing.Point(12, 604);
            this.voidButton.Name = "voidButton";
            this.voidButton.Size = new System.Drawing.Size(74, 44);
            this.voidButton.TabIndex = 5;
            this.voidButton.Text = "Void";
            this.voidButton.UseVisualStyleBackColor = false;
            this.voidButton.Click += new System.EventHandler(this.voidButton_Click);
            // 
            // toggleTaxButton
            // 
            this.toggleTaxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toggleTaxButton.FlatAppearance.BorderSize = 0;
            this.toggleTaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleTaxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleTaxButton.ForeColor = System.Drawing.Color.White;
            this.toggleTaxButton.Location = new System.Drawing.Point(449, 604);
            this.toggleTaxButton.Name = "toggleTaxButton";
            this.toggleTaxButton.Size = new System.Drawing.Size(113, 44);
            this.toggleTaxButton.TabIndex = 6;
            this.toggleTaxButton.Text = "No Tax";
            this.toggleTaxButton.UseVisualStyleBackColor = false;
            this.toggleTaxButton.Click += new System.EventHandler(this.toggleTaxButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chargeTotalLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cashTotalLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.transactionCountLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.grandTotalLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(5, 506);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 92);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daily Totals";
            // 
            // chargeTotalLabel
            // 
            this.chargeTotalLabel.AutoSize = true;
            this.chargeTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargeTotalLabel.Location = new System.Drawing.Point(152, 69);
            this.chargeTotalLabel.Name = "chargeTotalLabel";
            this.chargeTotalLabel.Size = new System.Drawing.Size(49, 20);
            this.chargeTotalLabel.TabIndex = 7;
            this.chargeTotalLabel.Text = "$0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Charge Total:";
            // 
            // cashTotalLabel
            // 
            this.cashTotalLabel.AutoSize = true;
            this.cashTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashTotalLabel.Location = new System.Drawing.Point(152, 48);
            this.cashTotalLabel.Name = "cashTotalLabel";
            this.cashTotalLabel.Size = new System.Drawing.Size(49, 20);
            this.cashTotalLabel.TabIndex = 5;
            this.cashTotalLabel.Text = "$0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cash Total:";
            // 
            // transactionCountLabel
            // 
            this.transactionCountLabel.AutoSize = true;
            this.transactionCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionCountLabel.Location = new System.Drawing.Point(463, 22);
            this.transactionCountLabel.Name = "transactionCountLabel";
            this.transactionCountLabel.Size = new System.Drawing.Size(18, 20);
            this.transactionCountLabel.TabIndex = 3;
            this.transactionCountLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transaction Count:";
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.AutoSize = true;
            this.grandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalLabel.Location = new System.Drawing.Point(147, 22);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(54, 20);
            this.grandTotalLabel.TabIndex = 1;
            this.grandTotalLabel.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grand Total:";
            // 
            // refundButton
            // 
            this.refundButton.BackColor = System.Drawing.Color.Red;
            this.refundButton.FlatAppearance.BorderSize = 0;
            this.refundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundButton.ForeColor = System.Drawing.Color.White;
            this.refundButton.Location = new System.Drawing.Point(92, 604);
            this.refundButton.Name = "refundButton";
            this.refundButton.Size = new System.Drawing.Size(113, 44);
            this.refundButton.TabIndex = 8;
            this.refundButton.Text = "Refund";
            this.refundButton.UseVisualStyleBackColor = false;
            this.refundButton.Click += new System.EventHandler(this.refundButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTransactionDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "File...";
            // 
            // saveTransactionDataToolStripMenuItem
            // 
            this.saveTransactionDataToolStripMenuItem.Name = "saveTransactionDataToolStripMenuItem";
            this.saveTransactionDataToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveTransactionDataToolStripMenuItem.Text = "Save Transaction Data";
            this.saveTransactionDataToolStripMenuItem.Click += new System.EventHandler(this.saveTransactionDataToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1020, 730);
            this.Controls.Add(this.refundButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toggleTaxButton);
            this.Controls.Add(this.voidButton);
            this.Controls.Add(this.creditCardButton);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.currentAmtTxtBx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.transHistGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1036, 768);
            this.Name = "Form1";
            this.Text = "Beauty Concept POS 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.transHistGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox transHistGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox currentAmtTxtBx;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.TextBox currTransTextBox;
        private System.Windows.Forms.Button creditCardButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader transactionType;
        private System.Windows.Forms.Button voidButton;
        private System.Windows.Forms.Button toggleTaxButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label transactionCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refundButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTransactionDataToolStripMenuItem;
        private System.Windows.Forms.Label chargeTotalLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cashTotalLabel;
        private System.Windows.Forms.Label label4;
    }
}

