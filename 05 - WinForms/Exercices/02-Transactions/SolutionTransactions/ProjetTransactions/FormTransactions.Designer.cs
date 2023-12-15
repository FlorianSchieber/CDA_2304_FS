namespace ProjetTransactions
{
    partial class FormTransactions
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
            textBoxName = new TextBox();
            labelName = new Label();
            labelDate = new Label();
            textBoxDate = new TextBox();
            textBoxAmount = new TextBox();
            textBoxZipcode = new TextBox();
            labelAmount = new Label();
            labelZipcode = new Label();
            buttonValidate = new Button();
            buttonErase = new Button();
            labelDateTip = new Label();
            labelCurrency = new Label();
            errorProviderName = new ErrorProvider(components);
            errorProviderDate = new ErrorProvider(components);
            errorProviderAmount = new ErrorProvider(components);
            errorProviderZipcode = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderZipcode).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(123, 51);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(178, 23);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.Leave += textBoxName_Leave;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(34, 54);
            labelName.Name = "labelName";
            labelName.Size = new Size(34, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Nom";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(34, 83);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 2;
            labelDate.Text = "Date";
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(123, 80);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(100, 23);
            textBoxDate.TabIndex = 3;
            textBoxDate.TextChanged += textBoxDate_TextChanged;
            textBoxDate.Leave += textBoxDate_Leave;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(123, 109);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(100, 23);
            textBoxAmount.TabIndex = 4;
            textBoxAmount.TextChanged += textBoxAmount_TextChanged;
            textBoxAmount.Leave += textBoxAmount_Leave;
            // 
            // textBoxZipcode
            // 
            textBoxZipcode.Location = new Point(123, 138);
            textBoxZipcode.Name = "textBoxZipcode";
            textBoxZipcode.Size = new Size(100, 23);
            textBoxZipcode.TabIndex = 5;
            textBoxZipcode.TextChanged += textBoxZipcode_TextChanged;
            textBoxZipcode.Leave += textBoxZipcode_Leave;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(34, 112);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(53, 15);
            labelAmount.TabIndex = 6;
            labelAmount.Text = "Montant";
            // 
            // labelZipcode
            // 
            labelZipcode.AutoSize = true;
            labelZipcode.Location = new Point(34, 141);
            labelZipcode.Name = "labelZipcode";
            labelZipcode.Size = new Size(70, 15);
            labelZipcode.TabIndex = 7;
            labelZipcode.Text = "Code Postal";
            // 
            // buttonValidate
            // 
            buttonValidate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonValidate.Enabled = false;
            buttonValidate.Location = new Point(321, 179);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(75, 23);
            buttonValidate.TabIndex = 8;
            buttonValidate.Text = "Valider";
            buttonValidate.UseVisualStyleBackColor = true;
            buttonValidate.Click += buttonValidate_Click;
            // 
            // buttonErase
            // 
            buttonErase.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonErase.Location = new Point(321, 208);
            buttonErase.Name = "buttonErase";
            buttonErase.Size = new Size(75, 23);
            buttonErase.TabIndex = 9;
            buttonErase.Text = "Effacer";
            buttonErase.UseVisualStyleBackColor = true;
            buttonErase.Click += buttonErase_Click;
            // 
            // labelDateTip
            // 
            labelDateTip.AutoSize = true;
            labelDateTip.Location = new Point(229, 83);
            labelDateTip.Name = "labelDateTip";
            labelDateTip.Size = new Size(87, 15);
            labelDateTip.TabIndex = 10;
            labelDateTip.Text = "(JJ/MM/AAAA)";
            // 
            // labelCurrency
            // 
            labelCurrency.AutoSize = true;
            labelCurrency.Location = new Point(229, 112);
            labelCurrency.Name = "labelCurrency";
            labelCurrency.Size = new Size(13, 15);
            labelCurrency.TabIndex = 11;
            labelCurrency.Text = "€";
            // 
            // errorProviderName
            // 
            errorProviderName.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            errorProviderDate.ContainerControl = this;
            // 
            // errorProviderAmount
            // 
            errorProviderAmount.ContainerControl = this;
            // 
            // errorProviderZipcode
            // 
            errorProviderZipcode.ContainerControl = this;
            // 
            // FormTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 243);
            Controls.Add(labelCurrency);
            Controls.Add(labelDateTip);
            Controls.Add(buttonErase);
            Controls.Add(buttonValidate);
            Controls.Add(labelZipcode);
            Controls.Add(labelAmount);
            Controls.Add(textBoxZipcode);
            Controls.Add(textBoxAmount);
            Controls.Add(textBoxDate);
            Controls.Add(labelDate);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(424, 282);
            Name = "FormTransactions";
            Text = "Transactions";
            FormClosing += FormTransactions_FormClosing;
            Load += FormTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderZipcode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label labelName;
        private Label labelDate;
        private TextBox textBoxDate;
        private TextBox textBoxAmount;
        private TextBox textBoxZipcode;
        private Label labelAmount;
        private Label labelZipcode;
        private Button buttonValidate;
        private Button buttonErase;
        private Label labelDateTip;
        private Label labelCurrency;
        private ErrorProvider errorProviderName;
        private ErrorProvider errorProviderDate;
        private ErrorProvider errorProviderAmount;
        private ErrorProvider errorProviderZipcode;
    }
}