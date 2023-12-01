namespace ProjectRepayment
{
    partial class FormRepayment
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
            components = new System.ComponentModel.Container();
            labelName = new Label();
            textBoxName = new TextBox();
            labelLoanBalance = new Label();
            labelRepaymentTime = new Label();
            numericUpDownRepaymentTime = new NumericUpDown();
            hScrollBarRepaymentTime = new HScrollBar();
            labelCompound = new Label();
            comboBoxCompound = new ComboBox();
            labelMonth = new Label();
            groupBoxAnnualInterestRate = new GroupBox();
            radioButton9Percent = new RadioButton();
            radioButton8Percent = new RadioButton();
            radioButton7Percent = new RadioButton();
            groupBoxRepayment = new GroupBox();
            textBoxRepayment = new TextBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            maskedTextBoxLoanBalance = new MaskedTextBox();
            labelCurrency = new Label();
            errorProviderLoanBalance = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownRepaymentTime).BeginInit();
            groupBoxAnnualInterestRate.SuspendLayout();
            groupBoxRepayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderLoanBalance).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(35, 31);
            labelName.Name = "labelName";
            labelName.Size = new Size(34, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Nom";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(182, 28);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(142, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelLoanBalance
            // 
            labelLoanBalance.AutoSize = true;
            labelLoanBalance.Location = new Point(35, 76);
            labelLoanBalance.Name = "labelLoanBalance";
            labelLoanBalance.Size = new Size(99, 15);
            labelLoanBalance.TabIndex = 2;
            labelLoanBalance.Text = "Capital emprunté";
            // 
            // labelRepaymentTime
            // 
            labelRepaymentTime.AutoSize = true;
            labelRepaymentTime.Location = new Point(35, 125);
            labelRepaymentTime.Name = "labelRepaymentTime";
            labelRepaymentTime.Size = new Size(143, 15);
            labelRepaymentTime.TabIndex = 4;
            labelRepaymentTime.Text = "Durée du remboursement";
            // 
            // numericUpDownRepaymentTime
            // 
            numericUpDownRepaymentTime.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownRepaymentTime.Location = new Point(182, 123);
            numericUpDownRepaymentTime.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDownRepaymentTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRepaymentTime.Name = "numericUpDownRepaymentTime";
            numericUpDownRepaymentTime.Size = new Size(58, 23);
            numericUpDownRepaymentTime.TabIndex = 5;
            numericUpDownRepaymentTime.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRepaymentTime.ValueChanged += numericUpDownRepaymentTime_ValueChanged;
            // 
            // hScrollBarRepaymentTime
            // 
            hScrollBarRepaymentTime.LargeChange = 1;
            hScrollBarRepaymentTime.Location = new Point(182, 155);
            hScrollBarRepaymentTime.Maximum = 360;
            hScrollBarRepaymentTime.Minimum = 1;
            hScrollBarRepaymentTime.Name = "hScrollBarRepaymentTime";
            hScrollBarRepaymentTime.Size = new Size(142, 17);
            hScrollBarRepaymentTime.TabIndex = 6;
            hScrollBarRepaymentTime.Value = 1;
            hScrollBarRepaymentTime.Scroll += hScrollBarRepaymentTime_Scroll;
            hScrollBarRepaymentTime.ValueChanged += hScrollBarRepaymentTime_ValueChanged;
            // 
            // labelCompound
            // 
            labelCompound.AutoSize = true;
            labelCompound.Location = new Point(35, 205);
            labelCompound.Name = "labelCompound";
            labelCompound.Size = new Size(63, 15);
            labelCompound.TabIndex = 7;
            labelCompound.Text = "Périodicité";
            // 
            // comboBoxCompound
            // 
            comboBoxCompound.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCompound.FormattingEnabled = true;
            comboBoxCompound.Location = new Point(182, 202);
            comboBoxCompound.Name = "comboBoxCompound";
            comboBoxCompound.Size = new Size(142, 23);
            comboBoxCompound.TabIndex = 8;
            comboBoxCompound.SelectedIndexChanged += comboBoxCompound_SelectedIndexChanged;
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.Location = new Point(246, 125);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(33, 15);
            labelMonth.TabIndex = 9;
            labelMonth.Text = "mois";
            // 
            // groupBoxAnnualInterestRate
            // 
            groupBoxAnnualInterestRate.Controls.Add(radioButton9Percent);
            groupBoxAnnualInterestRate.Controls.Add(radioButton8Percent);
            groupBoxAnnualInterestRate.Controls.Add(radioButton7Percent);
            groupBoxAnnualInterestRate.Location = new Point(35, 262);
            groupBoxAnnualInterestRate.Name = "groupBoxAnnualInterestRate";
            groupBoxAnnualInterestRate.Size = new Size(141, 155);
            groupBoxAnnualInterestRate.TabIndex = 10;
            groupBoxAnnualInterestRate.TabStop = false;
            groupBoxAnnualInterestRate.Text = "Taux d'intérêt annuel";
            // 
            // radioButton9Percent
            // 
            radioButton9Percent.AutoSize = true;
            radioButton9Percent.Location = new Point(44, 111);
            radioButton9Percent.Name = "radioButton9Percent";
            radioButton9Percent.Size = new Size(44, 19);
            radioButton9Percent.TabIndex = 2;
            radioButton9Percent.TabStop = true;
            radioButton9Percent.Text = "9 %";
            radioButton9Percent.UseVisualStyleBackColor = true;
            radioButton9Percent.CheckedChanged += radioButton9Percent_CheckedChanged;
            // 
            // radioButton8Percent
            // 
            radioButton8Percent.AutoSize = true;
            radioButton8Percent.Location = new Point(44, 71);
            radioButton8Percent.Name = "radioButton8Percent";
            radioButton8Percent.Size = new Size(44, 19);
            radioButton8Percent.TabIndex = 1;
            radioButton8Percent.TabStop = true;
            radioButton8Percent.Text = "8 %";
            radioButton8Percent.UseVisualStyleBackColor = true;
            radioButton8Percent.CheckedChanged += radioButton8Percent_CheckedChanged;
            // 
            // radioButton7Percent
            // 
            radioButton7Percent.AutoSize = true;
            radioButton7Percent.Location = new Point(44, 33);
            radioButton7Percent.Name = "radioButton7Percent";
            radioButton7Percent.Size = new Size(44, 19);
            radioButton7Percent.TabIndex = 0;
            radioButton7Percent.TabStop = true;
            radioButton7Percent.Text = "7 %";
            radioButton7Percent.UseVisualStyleBackColor = true;
            radioButton7Percent.CheckedChanged += radioButton7Percent_CheckedChanged;
            // 
            // groupBoxRepayment
            // 
            groupBoxRepayment.Controls.Add(textBoxRepayment);
            groupBoxRepayment.Location = new Point(182, 262);
            groupBoxRepayment.Name = "groupBoxRepayment";
            groupBoxRepayment.Size = new Size(142, 75);
            groupBoxRepayment.TabIndex = 11;
            groupBoxRepayment.TabStop = false;
            groupBoxRepayment.Text = "Remboursements";
            // 
            // textBoxRepayment
            // 
            textBoxRepayment.BackColor = SystemColors.Control;
            textBoxRepayment.Location = new Point(6, 29);
            textBoxRepayment.Name = "textBoxRepayment";
            textBoxRepayment.Size = new Size(130, 23);
            textBoxRepayment.TabIndex = 0;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(204, 355);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(101, 23);
            buttonOK.TabIndex = 12;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(204, 394);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(101, 23);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // maskedTextBoxLoanBalance
            // 
            maskedTextBoxLoanBalance.Location = new Point(182, 73);
            maskedTextBoxLoanBalance.Name = "maskedTextBoxLoanBalance";
            maskedTextBoxLoanBalance.Size = new Size(123, 23);
            maskedTextBoxLoanBalance.TabIndex = 14;
            maskedTextBoxLoanBalance.ValidatingType = typeof(int);
            maskedTextBoxLoanBalance.TextChanged += maskedTextBoxLoanBalance_TextChanged;
            maskedTextBoxLoanBalance.Leave += maskedTextBoxLoanBalance_Leave;
            // 
            // labelCurrency
            // 
            labelCurrency.AutoSize = true;
            labelCurrency.Location = new Point(311, 76);
            labelCurrency.Name = "labelCurrency";
            labelCurrency.Size = new Size(13, 15);
            labelCurrency.TabIndex = 15;
            labelCurrency.Text = "€";
            // 
            // errorProviderLoanBalance
            // 
            errorProviderLoanBalance.ContainerControl = this;
            // 
            // FormRepayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 446);
            Controls.Add(labelCurrency);
            Controls.Add(maskedTextBoxLoanBalance);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(groupBoxRepayment);
            Controls.Add(groupBoxAnnualInterestRate);
            Controls.Add(labelMonth);
            Controls.Add(comboBoxCompound);
            Controls.Add(labelCompound);
            Controls.Add(hScrollBarRepaymentTime);
            Controls.Add(numericUpDownRepaymentTime);
            Controls.Add(labelRepaymentTime);
            Controls.Add(labelLoanBalance);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "FormRepayment";
            Text = "Prêt";
            FormClosing += FormRepayment_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numericUpDownRepaymentTime).EndInit();
            groupBoxAnnualInterestRate.ResumeLayout(false);
            groupBoxAnnualInterestRate.PerformLayout();
            groupBoxRepayment.ResumeLayout(false);
            groupBoxRepayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderLoanBalance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private Label labelLoanBalance;
        private MaskedTextBox maskedTextBoxLoanBalance;
        private Label labelRepaymentTime;
        private NumericUpDown numericUpDownRepaymentTime;
        private HScrollBar hScrollBarRepaymentTime;
        private Label labelCompound;
        private ComboBox comboBoxCompound;
        private Label labelMonth;
        private GroupBox groupBoxAnnualInterestRate;
        private RadioButton radioButton7Percent;
        private RadioButton radioButton9Percent;
        private RadioButton radioButton8Percent;
        private GroupBox groupBoxRepayment;
        private TextBox textBoxRepayment;
        private Button buttonOK;
        private Button buttonCancel;
        private Label labelCurrency;
        private ErrorProvider errorProviderLoanBalance;
    }
}