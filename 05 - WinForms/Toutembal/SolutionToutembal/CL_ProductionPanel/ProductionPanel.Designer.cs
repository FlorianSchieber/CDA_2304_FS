namespace CL_ProductionPanel
{
    partial class ProductionPanel
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            labelCrateNumber = new Label();
            textBoxCrateNumber = new TextBox();
            labelHourErrorRate = new Label();
            textBoxHourErrorRate = new TextBox();
            labelTotalErrorRate = new Label();
            textBoxTotalErrorRate = new TextBox();
            SuspendLayout();
            // 
            // labelCrateNumber
            // 
            labelCrateNumber.AutoSize = true;
            labelCrateNumber.Location = new Point(14, 23);
            labelCrateNumber.Name = "labelCrateNumber";
            labelCrateNumber.Size = new Size(216, 15);
            labelCrateNumber.TabIndex = 1;
            labelCrateNumber.Text = "Nombre de caisses depuis le démarrage";
            // 
            // textBoxCrateNumber
            // 
            textBoxCrateNumber.BackColor = SystemColors.Control;
            textBoxCrateNumber.Location = new Point(259, 20);
            textBoxCrateNumber.Name = "textBoxCrateNumber";
            textBoxCrateNumber.ReadOnly = true;
            textBoxCrateNumber.Size = new Size(100, 23);
            textBoxCrateNumber.TabIndex = 2;
            // 
            // labelHourErrorRate
            // 
            labelHourErrorRate.AutoSize = true;
            labelHourErrorRate.Location = new Point(14, 63);
            labelHourErrorRate.Name = "labelHourErrorRate";
            labelHourErrorRate.Size = new Size(101, 15);
            labelHourErrorRate.TabIndex = 3;
            labelHourErrorRate.Text = "Taux défaut heure";
            // 
            // textBoxHourErrorRate
            // 
            textBoxHourErrorRate.BackColor = SystemColors.Control;
            textBoxHourErrorRate.Location = new Point(259, 60);
            textBoxHourErrorRate.Name = "textBoxHourErrorRate";
            textBoxHourErrorRate.ReadOnly = true;
            textBoxHourErrorRate.Size = new Size(100, 23);
            textBoxHourErrorRate.TabIndex = 4;
            // 
            // labelTotalErrorRate
            // 
            labelTotalErrorRate.AutoSize = true;
            labelTotalErrorRate.Location = new Point(14, 103);
            labelTotalErrorRate.Name = "labelTotalErrorRate";
            labelTotalErrorRate.Size = new Size(178, 15);
            labelTotalErrorRate.TabIndex = 5;
            labelTotalErrorRate.Text = "Taux défaut depuis le démarrage";
            labelTotalErrorRate.Click += labelTotalErrorRate_Click;
            // 
            // textBoxTotalErrorRate
            // 
            textBoxTotalErrorRate.BackColor = SystemColors.Control;
            textBoxTotalErrorRate.Location = new Point(259, 100);
            textBoxTotalErrorRate.Name = "textBoxTotalErrorRate";
            textBoxTotalErrorRate.ReadOnly = true;
            textBoxTotalErrorRate.Size = new Size(100, 23);
            textBoxTotalErrorRate.TabIndex = 6;
            // 
            // ProductionPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxTotalErrorRate);
            Controls.Add(labelTotalErrorRate);
            Controls.Add(textBoxHourErrorRate);
            Controls.Add(labelHourErrorRate);
            Controls.Add(textBoxCrateNumber);
            Controls.Add(labelCrateNumber);
            Name = "ProductionPanel";
            Size = new Size(381, 145);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCrateNumber;
        private TextBox textBoxCrateNumber;
        private Label labelHourErrorRate;
        private TextBox textBoxHourErrorRate;
        private Label labelTotalErrorRate;
        private TextBox textBoxTotalErrorRate;
    }
}
