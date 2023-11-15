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
            groupBoxChoice.SuspendLayout();
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
            // 
            // FormTextFormat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 241);
            Controls.Add(groupBoxChoice);
            Controls.Add(textBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormTextFormat";
            Text = "FormTextFormat";
            groupBoxChoice.ResumeLayout(false);
            groupBoxChoice.PerformLayout();
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
    }
}