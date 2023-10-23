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
            SuspendLayout();
            // 
            // buttonValidate
            // 
            buttonValidate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonValidate.Location = new Point(554, 319);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(75, 23);
            buttonValidate.TabIndex = 0;
            buttonValidate.Text = "Valider";
            buttonValidate.UseVisualStyleBackColor = true;
            buttonValidate.Click += buttonValidate_Click;
            // 
            // FormCalculette
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 354);
            Controls.Add(buttonValidate);
            Name = "FormCalculette";
            Text = "FormCalculette";
            Load += FormCalculette_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonValidate;
    }
}