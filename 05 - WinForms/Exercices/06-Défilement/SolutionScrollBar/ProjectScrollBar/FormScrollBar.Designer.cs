namespace ProjectScrollBar
{
    partial class FormScrollBar
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
            labelRed = new Label();
            hScrollBarRed = new HScrollBar();
            numericUpDownRed = new NumericUpDown();
            panelRed = new Panel();
            labelGreen = new Label();
            hScrollBarGreen = new HScrollBar();
            numericUpDownGreen = new NumericUpDown();
            panelGreen = new Panel();
            labelBlue = new Label();
            hScrollBarBlue = new HScrollBar();
            numericUpDownBlue = new NumericUpDown();
            panelBlue = new Panel();
            panelColor = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).BeginInit();
            SuspendLayout();
            // 
            // labelRed
            // 
            labelRed.AutoSize = true;
            labelRed.Location = new Point(12, 54);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(41, 15);
            labelRed.TabIndex = 0;
            labelRed.Text = "Rouge";
            // 
            // hScrollBarRed
            // 
            hScrollBarRed.LargeChange = 1;
            hScrollBarRed.Location = new Point(81, 54);
            hScrollBarRed.Maximum = 255;
            hScrollBarRed.Name = "hScrollBarRed";
            hScrollBarRed.Size = new Size(308, 17);
            hScrollBarRed.TabIndex = 1;
            hScrollBarRed.Scroll += hScrollBarRed_Scroll;
            // 
            // numericUpDownRed
            // 
            numericUpDownRed.Location = new Point(392, 52);
            numericUpDownRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownRed.Name = "numericUpDownRed";
            numericUpDownRed.Size = new Size(50, 23);
            numericUpDownRed.TabIndex = 2;
            numericUpDownRed.ValueChanged += numericUpDownRed_ValueChanged;
            // 
            // panelRed
            // 
            panelRed.BorderStyle = BorderStyle.Fixed3D;
            panelRed.Location = new Point(448, 52);
            panelRed.Name = "panelRed";
            panelRed.Size = new Size(99, 23);
            panelRed.TabIndex = 3;
            // 
            // labelGreen
            // 
            labelGreen.AutoSize = true;
            labelGreen.Location = new Point(12, 84);
            labelGreen.Name = "labelGreen";
            labelGreen.Size = new Size(27, 15);
            labelGreen.TabIndex = 4;
            labelGreen.Text = "Vert";
            // 
            // hScrollBarGreen
            // 
            hScrollBarGreen.LargeChange = 1;
            hScrollBarGreen.Location = new Point(81, 84);
            hScrollBarGreen.Maximum = 255;
            hScrollBarGreen.Name = "hScrollBarGreen";
            hScrollBarGreen.Size = new Size(308, 17);
            hScrollBarGreen.TabIndex = 5;
            hScrollBarGreen.Scroll += hScrollBarGreen_Scroll;
            // 
            // numericUpDownGreen
            // 
            numericUpDownGreen.Location = new Point(392, 81);
            numericUpDownGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownGreen.Name = "numericUpDownGreen";
            numericUpDownGreen.Size = new Size(50, 23);
            numericUpDownGreen.TabIndex = 6;
            numericUpDownGreen.ValueChanged += numericUpDownGreen_ValueChanged;
            // 
            // panelGreen
            // 
            panelGreen.BorderStyle = BorderStyle.Fixed3D;
            panelGreen.Location = new Point(448, 81);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(99, 23);
            panelGreen.TabIndex = 4;
            // 
            // labelBlue
            // 
            labelBlue.AutoSize = true;
            labelBlue.Location = new Point(12, 114);
            labelBlue.Name = "labelBlue";
            labelBlue.Size = new Size(30, 15);
            labelBlue.TabIndex = 7;
            labelBlue.Text = "Bleu";
            // 
            // hScrollBarBlue
            // 
            hScrollBarBlue.LargeChange = 1;
            hScrollBarBlue.Location = new Point(81, 112);
            hScrollBarBlue.Maximum = 255;
            hScrollBarBlue.Name = "hScrollBarBlue";
            hScrollBarBlue.Size = new Size(308, 17);
            hScrollBarBlue.TabIndex = 8;
            hScrollBarBlue.Scroll += hScrollBarBlue_Scroll;
            // 
            // numericUpDownBlue
            // 
            numericUpDownBlue.Location = new Point(392, 110);
            numericUpDownBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownBlue.Name = "numericUpDownBlue";
            numericUpDownBlue.Size = new Size(50, 23);
            numericUpDownBlue.TabIndex = 9;
            numericUpDownBlue.ValueChanged += numericUpDownBlue_ValueChanged;
            // 
            // panelBlue
            // 
            panelBlue.BorderStyle = BorderStyle.Fixed3D;
            panelBlue.Location = new Point(448, 110);
            panelBlue.Name = "panelBlue";
            panelBlue.Size = new Size(99, 23);
            panelBlue.TabIndex = 5;
            // 
            // panelColor
            // 
            panelColor.BorderStyle = BorderStyle.Fixed3D;
            panelColor.Location = new Point(15, 146);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(532, 135);
            panelColor.TabIndex = 10;
            // 
            // FormScrollBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 293);
            Controls.Add(panelColor);
            Controls.Add(panelBlue);
            Controls.Add(numericUpDownBlue);
            Controls.Add(hScrollBarBlue);
            Controls.Add(labelBlue);
            Controls.Add(panelGreen);
            Controls.Add(numericUpDownGreen);
            Controls.Add(hScrollBarGreen);
            Controls.Add(labelGreen);
            Controls.Add(panelRed);
            Controls.Add(numericUpDownRed);
            Controls.Add(hScrollBarRed);
            Controls.Add(labelRed);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormScrollBar";
            Text = "Couleurs";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRed;
        private HScrollBar hScrollBarRed;
        private NumericUpDown numericUpDownRed;
        private Panel panelRed;
        private Label labelGreen;
        private HScrollBar hScrollBarGreen;
        private NumericUpDown numericUpDownGreen;
        private Panel panelGreen;
        private Label labelBlue;
        private HScrollBar hScrollBarBlue;
        private NumericUpDown numericUpDownBlue;
        private Panel panelBlue;
        private Panel panelColor;
    }
}