namespace WinFormsContacts
{
    partial class FormContact
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
            labelFirstName = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            textBoxBirthDate = new TextBox();
            labelBirthDate = new Label();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            textBoxZipCode = new TextBox();
            labelZipCode = new Label();
            textBoxPhoneNumber = new TextBox();
            labelPhoneNumber = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            buttonValidate = new Button();
            buttonErase = new Button();
            errorProviderFirstName = new ErrorProvider(components);
            errorProviderLastName = new ErrorProvider(components);
            errorProviderBirthDate = new ErrorProvider(components);
            errorProviderAddress = new ErrorProvider(components);
            errorProviderZipCode = new ErrorProvider(components);
            errorProviderPhoneNumber = new ErrorProvider(components);
            errorProviderEmail = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderFirstName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderLastName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderBirthDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderZipCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPhoneNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEmail).BeginInit();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(12, 39);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(49, 15);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "Prénom";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(154, 36);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(213, 23);
            textBoxFirstName.TabIndex = 1;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            textBoxFirstName.Leave += textBoxFirstName_Leave;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(154, 65);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(213, 23);
            textBoxLastName.TabIndex = 3;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            textBoxLastName.Leave += textBoxLastName_Leave;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(12, 68);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(34, 15);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Nom";
            // 
            // textBoxBirthDate
            // 
            textBoxBirthDate.Location = new Point(154, 94);
            textBoxBirthDate.Name = "textBoxBirthDate";
            textBoxBirthDate.PlaceholderText = "jj/mm/aaaa";
            textBoxBirthDate.Size = new Size(213, 23);
            textBoxBirthDate.TabIndex = 5;
            textBoxBirthDate.TextChanged += textBoxBirthDate_TextChanged;
            textBoxBirthDate.Leave += textBoxBirthDate_Leave;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(12, 97);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(101, 15);
            labelBirthDate.TabIndex = 4;
            labelBirthDate.Text = "Date de naissance";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(154, 123);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(213, 23);
            textBoxAddress.TabIndex = 7;
            textBoxAddress.TextChanged += textBoxAddress_TextChanged;
            textBoxAddress.Leave += textBoxAddress_Leave;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(12, 126);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(89, 15);
            labelAddress.TabIndex = 6;
            labelAddress.Text = "Adresse postale";
            // 
            // textBoxZipCode
            // 
            textBoxZipCode.Location = new Point(154, 152);
            textBoxZipCode.Name = "textBoxZipCode";
            textBoxZipCode.Size = new Size(213, 23);
            textBoxZipCode.TabIndex = 9;
            textBoxZipCode.TextChanged += textBoxZipCode_TextChanged;
            textBoxZipCode.Leave += textBoxZipCode_Leave;
            // 
            // labelZipCode
            // 
            labelZipCode.AutoSize = true;
            labelZipCode.Location = new Point(12, 155);
            labelZipCode.Name = "labelZipCode";
            labelZipCode.Size = new Size(70, 15);
            labelZipCode.TabIndex = 8;
            labelZipCode.Text = "Code postal";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(154, 181);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(213, 23);
            textBoxPhoneNumber.TabIndex = 11;
            textBoxPhoneNumber.TextChanged += textBoxPhoneNumber_TextChanged;
            textBoxPhoneNumber.Leave += textBoxPhoneNumber_Leave;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(12, 184);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(61, 15);
            labelPhoneNumber.TabIndex = 10;
            labelPhoneNumber.Text = "Téléphone";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(154, 210);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "exemple@mail.com";
            textBoxEmail.Size = new Size(213, 23);
            textBoxEmail.TabIndex = 13;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            textBoxEmail.Leave += textBoxEmail_Leave;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 213);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(41, 15);
            labelEmail.TabIndex = 12;
            labelEmail.Text = "E-mail";
            // 
            // buttonValidate
            // 
            buttonValidate.Location = new Point(325, 258);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(75, 23);
            buttonValidate.TabIndex = 14;
            buttonValidate.Text = "Valider";
            buttonValidate.UseVisualStyleBackColor = true;
            buttonValidate.Click += buttonValidate_Click;
            // 
            // buttonErase
            // 
            buttonErase.Location = new Point(244, 258);
            buttonErase.Name = "buttonErase";
            buttonErase.Size = new Size(75, 23);
            buttonErase.TabIndex = 15;
            buttonErase.Text = "Effacer";
            buttonErase.UseVisualStyleBackColor = true;
            buttonErase.Click += buttonErase_Click;
            // 
            // errorProviderFirstName
            // 
            errorProviderFirstName.ContainerControl = this;
            // 
            // errorProviderLastName
            // 
            errorProviderLastName.ContainerControl = this;
            // 
            // errorProviderBirthDate
            // 
            errorProviderBirthDate.ContainerControl = this;
            // 
            // errorProviderAddress
            // 
            errorProviderAddress.ContainerControl = this;
            // 
            // errorProviderZipCode
            // 
            errorProviderZipCode.ContainerControl = this;
            // 
            // errorProviderPhoneNumber
            // 
            errorProviderPhoneNumber.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            errorProviderEmail.ContainerControl = this;
            // 
            // FormContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 293);
            Controls.Add(buttonErase);
            Controls.Add(buttonValidate);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(labelPhoneNumber);
            Controls.Add(textBoxZipCode);
            Controls.Add(labelZipCode);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(textBoxBirthDate);
            Controls.Add(labelBirthDate);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormContact";
            Text = "Création de contact";
            ((System.ComponentModel.ISupportInitialize)errorProviderFirstName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderLastName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderBirthDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderZipCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPhoneNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEmail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxBirthDate;
        private Label labelBirthDate;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private TextBox textBoxZipCode;
        private Label labelZipCode;
        private TextBox textBoxPhoneNumber;
        private Label labelPhoneNumber;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Button buttonValidate;
        private Button buttonErase;
        private ErrorProvider errorProviderFirstName;
        private ErrorProvider errorProviderLastName;
        private ErrorProvider errorProviderBirthDate;
        private ErrorProvider errorProviderAddress;
        private ErrorProvider errorProviderZipCode;
        private ErrorProvider errorProviderPhoneNumber;
        private ErrorProvider errorProviderEmail;
    }
}