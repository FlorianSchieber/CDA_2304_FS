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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // buttonValidate
            // 
            buttonValidate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonValidate.Location = new Point(336, 343);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(75, 23);
            buttonValidate.TabIndex = 0;
            buttonValidate.Text = "Valider";
            buttonValidate.UseVisualStyleBackColor = true;
            // 
            // buttonEmpty
            // 
            buttonEmpty.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEmpty.Location = new Point(12, 343);
            buttonEmpty.Name = "buttonEmpty";
            buttonEmpty.Size = new Size(75, 23);
            buttonEmpty.TabIndex = 1;
            buttonEmpty.Text = "Vider";
            buttonEmpty.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 194);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(12, 212);
            button1.Name = "button1";
            button1.Size = new Size(75, 54);
            button1.TabIndex = 3;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(93, 212);
            button2.Name = "button2";
            button2.Size = new Size(75, 54);
            button2.TabIndex = 4;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(174, 212);
            button3.Name = "button3";
            button3.Size = new Size(75, 54);
            button3.TabIndex = 5;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(255, 212);
            button4.Name = "button4";
            button4.Size = new Size(75, 54);
            button4.TabIndex = 6;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(336, 212);
            button5.Name = "button5";
            button5.Size = new Size(75, 54);
            button5.TabIndex = 7;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 272);
            button6.Name = "button6";
            button6.Size = new Size(75, 54);
            button6.TabIndex = 8;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(93, 272);
            button7.Name = "button7";
            button7.Size = new Size(75, 54);
            button7.TabIndex = 9;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(174, 272);
            button8.Name = "button8";
            button8.Size = new Size(75, 54);
            button8.TabIndex = 10;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(255, 272);
            button9.Name = "button9";
            button9.Size = new Size(75, 54);
            button9.TabIndex = 11;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(336, 272);
            button10.Name = "button10";
            button10.Size = new Size(75, 54);
            button10.TabIndex = 12;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            // 
            // FormCalculette
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(423, 378);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(buttonEmpty);
            Controls.Add(buttonValidate);
            MinimumSize = new Size(100, 100);
            Name = "FormCalculette";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCalculette";
            Load += FormCalculette_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonValidate;
        private Button buttonEmpty;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}