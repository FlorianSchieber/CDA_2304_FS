namespace ProjetCalculette
{
    partial class FormCalculette
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
            buttonValidate = new Button();
            buttonEmpty = new Button();
            textBox = new TextBox();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // buttonValidate
            // 
            buttonValidate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonValidate.Location = new Point(336, 336);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(75, 23);
            buttonValidate.TabIndex = 0;
            buttonValidate.Text = "Valider";
            buttonValidate.UseVisualStyleBackColor = true;
            buttonValidate.Click += buttonValidate_Click;
            // 
            // buttonEmpty
            // 
            buttonEmpty.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEmpty.Location = new Point(12, 336);
            buttonEmpty.Name = "buttonEmpty";
            buttonEmpty.Size = new Size(75, 23);
            buttonEmpty.TabIndex = 1;
            buttonEmpty.Text = "Vider";
            buttonEmpty.UseVisualStyleBackColor = true;
            buttonEmpty.Click += buttonEmpty_Click;
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BackColor = SystemColors.GradientActiveCaption;
            textBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(12, 12);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Size = new Size(399, 194);
            textBox.TabIndex = 2;
            // 
            // button0
            // 
            button0.Location = new Point(12, 212);
            button0.Name = "button0";
            button0.Size = new Size(75, 54);
            button0.TabIndex = 3;
            button0.Tag = 0;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += buttonDigit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(93, 212);
            button1.Name = "button1";
            button1.Size = new Size(75, 54);
            button1.TabIndex = 4;
            button1.Tag = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonDigit_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 212);
            button2.Name = "button2";
            button2.Size = new Size(75, 54);
            button2.TabIndex = 5;
            button2.Tag = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonDigit_Click;
            // 
            // button3
            // 
            button3.Location = new Point(255, 212);
            button3.Name = "button3";
            button3.Size = new Size(75, 54);
            button3.TabIndex = 6;
            button3.Tag = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonDigit_Click;
            // 
            // button4
            // 
            button4.Location = new Point(336, 212);
            button4.Name = "button4";
            button4.Size = new Size(75, 54);
            button4.TabIndex = 7;
            button4.Tag = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonDigit_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 272);
            button5.Name = "button5";
            button5.Size = new Size(75, 54);
            button5.TabIndex = 8;
            button5.Tag = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonDigit_Click;
            // 
            // button6
            // 
            button6.Location = new Point(93, 272);
            button6.Name = "button6";
            button6.Size = new Size(75, 54);
            button6.TabIndex = 9;
            button6.Tag = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonDigit_Click;
            // 
            // button7
            // 
            button7.Location = new Point(174, 272);
            button7.Name = "button7";
            button7.Size = new Size(75, 54);
            button7.TabIndex = 10;
            button7.Tag = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonDigit_Click;
            // 
            // button8
            // 
            button8.Location = new Point(255, 272);
            button8.Name = "button8";
            button8.Size = new Size(75, 54);
            button8.TabIndex = 11;
            button8.Tag = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonDigit_Click;
            // 
            // button9
            // 
            button9.Location = new Point(336, 272);
            button9.Name = "button9";
            button9.Size = new Size(75, 54);
            button9.TabIndex = 12;
            button9.Tag = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonDigit_Click;
            // 
            // FormCalculette
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(419, 367);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(textBox);
            Controls.Add(buttonEmpty);
            Controls.Add(buttonValidate);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormCalculette";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculette";
            Load += FormCalculette_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonValidate;
        private Button buttonEmpty;
        private TextBox textBox;
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}