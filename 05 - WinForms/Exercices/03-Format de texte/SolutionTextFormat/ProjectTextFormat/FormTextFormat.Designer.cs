namespace ProjectTextFormat
{
    partial class FormTextFormat
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
            label1 = new Label();
            textBox = new TextBox();
            groupBoxChoice = new GroupBox();
            checkBoxCase = new CheckBox();
            checkBoxFontColor = new CheckBox();
            checkBoxBackgroundColor = new CheckBox();
            groupBoxBackgroundColor = new GroupBox();
            radioButtonBackgroundBlue = new RadioButton();
            radioButtonBackgroundGreen = new RadioButton();
            radioButtonBackgroundRed = new RadioButton();
            groupBoxFontColor = new GroupBox();
            radioButtonFontBlack = new RadioButton();
            radioButtonFontWhite = new RadioButton();
            radioButtonFontRed = new RadioButton();
            groupBoxCase = new GroupBox();
            radioButtonUpperCase = new RadioButton();
            radioButtonLowerCase = new RadioButton();
            textBoxOutput = new TextBox();
            groupBoxChoice.SuspendLayout();
            groupBoxBackgroundColor.SuspendLayout();
            groupBoxFontColor.SuspendLayout();
            groupBoxCase.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Tapez votre texte";
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 27);
            textBox.Name = "textBox";
            textBox.Size = new Size(242, 23);
            textBox.TabIndex = 1;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // groupBoxChoice
            // 
            groupBoxChoice.Controls.Add(checkBoxCase);
            groupBoxChoice.Controls.Add(checkBoxFontColor);
            groupBoxChoice.Controls.Add(checkBoxBackgroundColor);
            groupBoxChoice.Enabled = false;
            groupBoxChoice.Location = new Point(260, 9);
            groupBoxChoice.Name = "groupBoxChoice";
            groupBoxChoice.Size = new Size(210, 101);
            groupBoxChoice.TabIndex = 2;
            groupBoxChoice.TabStop = false;
            groupBoxChoice.Text = "Choix";
            // 
            // checkBoxCase
            // 
            checkBoxCase.AutoSize = true;
            checkBoxCase.Location = new Point(6, 72);
            checkBoxCase.Name = "checkBoxCase";
            checkBoxCase.Size = new Size(56, 19);
            checkBoxCase.TabIndex = 2;
            checkBoxCase.Text = "Casse";
            checkBoxCase.UseVisualStyleBackColor = true;
            checkBoxCase.CheckedChanged += checkBox_CheckedChange;
            // 
            // checkBoxFontColor
            // 
            checkBoxFontColor.AutoSize = true;
            checkBoxFontColor.Location = new Point(6, 47);
            checkBoxFontColor.Name = "checkBoxFontColor";
            checkBoxFontColor.Size = new Size(145, 19);
            checkBoxFontColor.TabIndex = 1;
            checkBoxFontColor.Text = "Couleur des caractères";
            checkBoxFontColor.UseVisualStyleBackColor = true;
            checkBoxFontColor.CheckedChanged += checkBox_CheckedChange;
            // 
            // checkBoxBackgroundColor
            // 
            checkBoxBackgroundColor.AutoSize = true;
            checkBoxBackgroundColor.Location = new Point(6, 22);
            checkBoxBackgroundColor.Name = "checkBoxBackgroundColor";
            checkBoxBackgroundColor.Size = new Size(113, 19);
            checkBoxBackgroundColor.TabIndex = 0;
            checkBoxBackgroundColor.Text = "Couleur du fond";
            checkBoxBackgroundColor.UseVisualStyleBackColor = true;
            checkBoxBackgroundColor.CheckedChanged += checkBox_CheckedChange;
            // 
            // groupBoxBackgroundColor
            // 
            groupBoxBackgroundColor.Controls.Add(radioButtonBackgroundBlue);
            groupBoxBackgroundColor.Controls.Add(radioButtonBackgroundGreen);
            groupBoxBackgroundColor.Controls.Add(radioButtonBackgroundRed);
            groupBoxBackgroundColor.Location = new Point(12, 132);
            groupBoxBackgroundColor.Name = "groupBoxBackgroundColor";
            groupBoxBackgroundColor.Size = new Size(83, 97);
            groupBoxBackgroundColor.TabIndex = 3;
            groupBoxBackgroundColor.TabStop = false;
            groupBoxBackgroundColor.Text = "Fond";
            groupBoxBackgroundColor.Visible = false;
            // 
            // radioButtonBackgroundBlue
            // 
            radioButtonBackgroundBlue.AutoSize = true;
            radioButtonBackgroundBlue.Location = new Point(6, 72);
            radioButtonBackgroundBlue.Name = "radioButtonBackgroundBlue";
            radioButtonBackgroundBlue.Size = new Size(48, 19);
            radioButtonBackgroundBlue.TabIndex = 2;
            radioButtonBackgroundBlue.TabStop = true;
            radioButtonBackgroundBlue.Text = "Bleu";
            radioButtonBackgroundBlue.UseVisualStyleBackColor = true;
            radioButtonBackgroundBlue.CheckedChanged += radioButton_CheckedChange;
            // 
            // radioButtonBackgroundGreen
            // 
            radioButtonBackgroundGreen.AutoSize = true;
            radioButtonBackgroundGreen.Location = new Point(6, 47);
            radioButtonBackgroundGreen.Name = "radioButtonBackgroundGreen";
            radioButtonBackgroundGreen.Size = new Size(45, 19);
            radioButtonBackgroundGreen.TabIndex = 1;
            radioButtonBackgroundGreen.TabStop = true;
            radioButtonBackgroundGreen.Text = "Vert";
            radioButtonBackgroundGreen.UseVisualStyleBackColor = true;
            radioButtonBackgroundGreen.CheckedChanged += radioButton_CheckedChange;
            // 
            // radioButtonBackgroundRed
            // 
            radioButtonBackgroundRed.AutoSize = true;
            radioButtonBackgroundRed.Location = new Point(6, 22);
            radioButtonBackgroundRed.Name = "radioButtonBackgroundRed";
            radioButtonBackgroundRed.Size = new Size(59, 19);
            radioButtonBackgroundRed.TabIndex = 0;
            radioButtonBackgroundRed.TabStop = true;
            radioButtonBackgroundRed.Text = "Rouge";
            radioButtonBackgroundRed.UseVisualStyleBackColor = true;
            radioButtonBackgroundRed.CheckedChanged += radioButton_CheckedChange;
            // 
            // groupBoxFontColor
            // 
            groupBoxFontColor.Controls.Add(radioButtonFontBlack);
            groupBoxFontColor.Controls.Add(radioButtonFontWhite);
            groupBoxFontColor.Controls.Add(radioButtonFontRed);
            groupBoxFontColor.Location = new Point(101, 132);
            groupBoxFontColor.Name = "groupBoxFontColor";
            groupBoxFontColor.Size = new Size(83, 97);
            groupBoxFontColor.TabIndex = 4;
            groupBoxFontColor.TabStop = false;
            groupBoxFontColor.Text = "Caractères";
            groupBoxFontColor.Visible = false;
            // 
            // radioButtonFontBlack
            // 
            radioButtonFontBlack.AutoSize = true;
            radioButtonFontBlack.Location = new Point(6, 72);
            radioButtonFontBlack.Name = "radioButtonFontBlack";
            radioButtonFontBlack.Size = new Size(48, 19);
            radioButtonFontBlack.TabIndex = 2;
            radioButtonFontBlack.TabStop = true;
            radioButtonFontBlack.Text = "Noir";
            radioButtonFontBlack.UseVisualStyleBackColor = true;
            radioButtonFontBlack.CheckedChanged += radioButton_CheckedChange;
            // 
            // radioButtonFontWhite
            // 
            radioButtonFontWhite.AutoSize = true;
            radioButtonFontWhite.Location = new Point(6, 47);
            radioButtonFontWhite.Name = "radioButtonFontWhite";
            radioButtonFontWhite.Size = new Size(54, 19);
            radioButtonFontWhite.TabIndex = 1;
            radioButtonFontWhite.TabStop = true;
            radioButtonFontWhite.Text = "Blanc";
            radioButtonFontWhite.UseVisualStyleBackColor = true;
            radioButtonFontWhite.CheckedChanged += radioButton_CheckedChange;
            // 
            // radioButtonFontRed
            // 
            radioButtonFontRed.AutoSize = true;
            radioButtonFontRed.Location = new Point(6, 22);
            radioButtonFontRed.Name = "radioButtonFontRed";
            radioButtonFontRed.Size = new Size(59, 19);
            radioButtonFontRed.TabIndex = 0;
            radioButtonFontRed.TabStop = true;
            radioButtonFontRed.Text = "Rouge";
            radioButtonFontRed.UseVisualStyleBackColor = true;
            radioButtonFontRed.CheckedChanged += radioButton_CheckedChange;
            // 
            // groupBoxCase
            // 
            groupBoxCase.Controls.Add(radioButtonUpperCase);
            groupBoxCase.Controls.Add(radioButtonLowerCase);
            groupBoxCase.Location = new Point(190, 154);
            groupBoxCase.Name = "groupBoxCase";
            groupBoxCase.Size = new Size(98, 75);
            groupBoxCase.TabIndex = 5;
            groupBoxCase.TabStop = false;
            groupBoxCase.Text = "Casse";
            groupBoxCase.Visible = false;
            // 
            // radioButtonUpperCase
            // 
            radioButtonUpperCase.AutoSize = true;
            radioButtonUpperCase.Location = new Point(6, 47);
            radioButtonUpperCase.Name = "radioButtonUpperCase";
            radioButtonUpperCase.Size = new Size(84, 19);
            radioButtonUpperCase.TabIndex = 1;
            radioButtonUpperCase.TabStop = true;
            radioButtonUpperCase.Text = "Majuscules";
            radioButtonUpperCase.UseVisualStyleBackColor = true;
            radioButtonUpperCase.CheckedChanged += radioButton_CheckedChange;
            // 
            // radioButtonLowerCase
            // 
            radioButtonLowerCase.AutoSize = true;
            radioButtonLowerCase.Location = new Point(6, 22);
            radioButtonLowerCase.Name = "radioButtonLowerCase";
            radioButtonLowerCase.Size = new Size(85, 19);
            radioButtonLowerCase.TabIndex = 0;
            radioButtonLowerCase.TabStop = true;
            radioButtonLowerCase.Text = "Minuscules";
            radioButtonLowerCase.UseVisualStyleBackColor = true;
            radioButtonLowerCase.CheckedChanged += radioButton_CheckedChange;
            // 
            // textBoxOutput
            // 
            textBoxOutput.BackColor = SystemColors.Control;
            textBoxOutput.Location = new Point(12, 77);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(242, 23);
            textBoxOutput.TabIndex = 6;
            // 
            // FormTextFormat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 241);
            Controls.Add(textBoxOutput);
            Controls.Add(groupBoxCase);
            Controls.Add(groupBoxFontColor);
            Controls.Add(groupBoxBackgroundColor);
            Controls.Add(groupBoxChoice);
            Controls.Add(textBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormTextFormat";
            Text = "FormTextFormat";
            groupBoxChoice.ResumeLayout(false);
            groupBoxChoice.PerformLayout();
            groupBoxBackgroundColor.ResumeLayout(false);
            groupBoxBackgroundColor.PerformLayout();
            groupBoxFontColor.ResumeLayout(false);
            groupBoxFontColor.PerformLayout();
            groupBoxCase.ResumeLayout(false);
            groupBoxCase.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox;
        private GroupBox groupBoxChoice;
        private CheckBox checkBoxCase;
        private CheckBox checkBoxFontColor;
        private CheckBox checkBoxBackgroundColor;
        private GroupBox groupBoxBackgroundColor;
        private RadioButton radioButtonBackgroundBlue;
        private RadioButton radioButtonBackgroundGreen;
        private RadioButton radioButtonBackgroundRed;
        private GroupBox groupBoxFontColor;
        private RadioButton radioButtonFontBlack;
        private RadioButton radioButtonFontWhite;
        private RadioButton radioButtonFontRed;
        private GroupBox groupBoxCase;
        private RadioButton radioButtonUpperCase;
        private RadioButton radioButtonLowerCase;
        private TextBox textBoxOutput;
    }
}