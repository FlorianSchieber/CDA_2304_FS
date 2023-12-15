namespace ProjectToutembal
{
    partial class FormProductionManager
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
            fileToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            productionToolStripMenuItem = new ToolStripMenuItem();
            startToolStripMenuItem = new ToolStripMenuItem();
            startAToolStripMenuItem = new ToolStripMenuItem();
            startBToolStripMenuItem = new ToolStripMenuItem();
            startCToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            stopAToolStripMenuItem = new ToolStripMenuItem();
            stopBToolStripMenuItem = new ToolStripMenuItem();
            stopCToolStripMenuItem = new ToolStripMenuItem();
            continueToolStripMenuItem = new ToolStripMenuItem();
            continueAToolStripMenuItem = new ToolStripMenuItem();
            continueBToolStripMenuItem = new ToolStripMenuItem();
            continueCToolStripMenuItem = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            timer = new System.Windows.Forms.Timer(components);
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            productionPanelA = new CL_ProductionPanel.ProductionPanel();
            tabPage2 = new TabPage();
            productionPanelB = new CL_ProductionPanel.ProductionPanel();
            tabPage3 = new TabPage();
            productionPanelC = new CL_ProductionPanel.ProductionPanel();
            labelProductionAName = new Label();
            progressBarA = new ProgressBar();
            labelProductionBName = new Label();
            progressBarB = new ProgressBar();
            labelProductionCName = new Label();
            progressBarC = new ProgressBar();
            menuStrip.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 20);
            fileToolStripMenuItem.Text = "&Fichier";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(111, 22);
            quitToolStripMenuItem.Text = "&Quitter";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // productionToolStripMenuItem
            // 
            productionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startToolStripMenuItem, stopToolStripMenuItem, continueToolStripMenuItem });
            productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            productionToolStripMenuItem.Size = new Size(78, 20);
            productionToolStripMenuItem.Text = "&Production";
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startAToolStripMenuItem, startBToolStripMenuItem, startCToolStripMenuItem });
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(180, 22);
            startToolStripMenuItem.Text = "&Démarrer";
            // 
            // startAToolStripMenuItem
            // 
            startAToolStripMenuItem.Enabled = false;
            startAToolStripMenuItem.Name = "startAToolStripMenuItem";
            startAToolStripMenuItem.Size = new Size(180, 22);
            startAToolStripMenuItem.Text = "&A";
            startAToolStripMenuItem.Click += startAToolStripMenuItem_Click;
            // 
            // startBToolStripMenuItem
            // 
            startBToolStripMenuItem.Enabled = false;
            startBToolStripMenuItem.Name = "startBToolStripMenuItem";
            startBToolStripMenuItem.Size = new Size(180, 22);
            startBToolStripMenuItem.Text = "&B";
            startBToolStripMenuItem.Click += startBToolStripMenuItem_Click;
            // 
            // startCToolStripMenuItem
            // 
            startCToolStripMenuItem.Enabled = false;
            startCToolStripMenuItem.Name = "startCToolStripMenuItem";
            startCToolStripMenuItem.Size = new Size(180, 22);
            startCToolStripMenuItem.Text = "&C";
            startCToolStripMenuItem.Click += startCToolStripMenuItem_Click;
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stopAToolStripMenuItem, stopBToolStripMenuItem, stopCToolStripMenuItem });
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(180, 22);
            stopToolStripMenuItem.Text = "&Arrêter";
            // 
            // stopAToolStripMenuItem
            // 
            stopAToolStripMenuItem.Enabled = false;
            stopAToolStripMenuItem.Name = "stopAToolStripMenuItem";
            stopAToolStripMenuItem.Size = new Size(180, 22);
            stopAToolStripMenuItem.Text = "&A";
            stopAToolStripMenuItem.Click += stopAToolStripMenuItem_Click;
            // 
            // stopBToolStripMenuItem
            // 
            stopBToolStripMenuItem.Enabled = false;
            stopBToolStripMenuItem.Name = "stopBToolStripMenuItem";
            stopBToolStripMenuItem.Size = new Size(180, 22);
            stopBToolStripMenuItem.Text = "&B";
            stopBToolStripMenuItem.Click += stopBToolStripMenuItem_Click;
            // 
            // stopCToolStripMenuItem
            // 
            stopCToolStripMenuItem.Enabled = false;
            stopCToolStripMenuItem.Name = "stopCToolStripMenuItem";
            stopCToolStripMenuItem.Size = new Size(180, 22);
            stopCToolStripMenuItem.Text = "&C";
            stopCToolStripMenuItem.Click += stopCToolStripMenuItem_Click;
            // 
            // continueToolStripMenuItem
            // 
            continueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { continueAToolStripMenuItem, continueBToolStripMenuItem, continueCToolStripMenuItem });
            continueToolStripMenuItem.Name = "continueToolStripMenuItem";
            continueToolStripMenuItem.Size = new Size(180, 22);
            continueToolStripMenuItem.Text = "&Continuer";
            // 
            // continueAToolStripMenuItem
            // 
            continueAToolStripMenuItem.Enabled = false;
            continueAToolStripMenuItem.Name = "continueAToolStripMenuItem";
            continueAToolStripMenuItem.Size = new Size(180, 22);
            continueAToolStripMenuItem.Text = "&A";
            continueAToolStripMenuItem.Click += continueAToolStripMenuItem_Click;
            // 
            // continueBToolStripMenuItem
            // 
            continueBToolStripMenuItem.Enabled = false;
            continueBToolStripMenuItem.Name = "continueBToolStripMenuItem";
            continueBToolStripMenuItem.Size = new Size(180, 22);
            continueBToolStripMenuItem.Text = "&B";
            continueBToolStripMenuItem.Click += continueBToolStripMenuItem_Click;
            // 
            // continueCToolStripMenuItem
            // 
            continueCToolStripMenuItem.Enabled = false;
            continueCToolStripMenuItem.Name = "continueCToolStripMenuItem";
            continueCToolStripMenuItem.Size = new Size(180, 22);
            continueCToolStripMenuItem.Text = "&C";
            continueCToolStripMenuItem.Click += continueCToolStripMenuItem_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, productionToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(572, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(171, 61);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(389, 173);
            tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(productionPanelA);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(381, 145);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Type A";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // productionPanelA
            // 
            productionPanelA.Location = new Point(0, 0);
            productionPanelA.Name = "productionPanelA";
            productionPanelA.Production = null;
            productionPanelA.Size = new Size(380, 149);
            productionPanelA.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(productionPanelB);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(381, 145);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Type B";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // productionPanelB
            // 
            productionPanelB.Location = new Point(0, 0);
            productionPanelB.Name = "productionPanelB";
            productionPanelB.Production = null;
            productionPanelB.Size = new Size(380, 149);
            productionPanelB.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(productionPanelC);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(381, 145);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Type C";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // productionPanelC
            // 
            productionPanelC.Location = new Point(0, 0);
            productionPanelC.Name = "productionPanelC";
            productionPanelC.Production = null;
            productionPanelC.Size = new Size(380, 149);
            productionPanelC.TabIndex = 0;
            // 
            // labelProductionAName
            // 
            labelProductionAName.AutoSize = true;
            labelProductionAName.Location = new Point(29, 269);
            labelProductionAName.Name = "labelProductionAName";
            labelProductionAName.Size = new Size(10, 15);
            labelProductionAName.TabIndex = 2;
            labelProductionAName.Text = " ";
            // 
            // progressBarA
            // 
            progressBarA.Location = new Point(171, 261);
            progressBarA.Name = "progressBarA";
            progressBarA.Size = new Size(389, 23);
            progressBarA.TabIndex = 3;
            // 
            // labelProductionBName
            // 
            labelProductionBName.AutoSize = true;
            labelProductionBName.Location = new Point(29, 308);
            labelProductionBName.Name = "labelProductionBName";
            labelProductionBName.Size = new Size(10, 15);
            labelProductionBName.TabIndex = 4;
            labelProductionBName.Text = " ";
            // 
            // progressBarB
            // 
            progressBarB.Location = new Point(171, 300);
            progressBarB.Name = "progressBarB";
            progressBarB.Size = new Size(389, 23);
            progressBarB.TabIndex = 5;
            // 
            // labelProductionCName
            // 
            labelProductionCName.AutoSize = true;
            labelProductionCName.Location = new Point(29, 348);
            labelProductionCName.Name = "labelProductionCName";
            labelProductionCName.Size = new Size(10, 15);
            labelProductionCName.TabIndex = 6;
            labelProductionCName.Text = " ";
            // 
            // progressBarC
            // 
            progressBarC.Location = new Point(171, 340);
            progressBarC.Name = "progressBarC";
            progressBarC.Size = new Size(389, 23);
            progressBarC.TabIndex = 7;
            // 
            // FormProductionManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 385);
            Controls.Add(progressBarC);
            Controls.Add(labelProductionCName);
            Controls.Add(progressBarB);
            Controls.Add(labelProductionBName);
            Controls.Add(progressBarA);
            Controls.Add(labelProductionAName);
            Controls.Add(tabControl);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            Name = "FormProductionManager";
            Text = "FormProductionManager";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem startAToolStripMenuItem;
        private ToolStripMenuItem startBToolStripMenuItem;
        private ToolStripMenuItem startCToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem stopAToolStripMenuItem;
        private ToolStripMenuItem stopBToolStripMenuItem;
        private ToolStripMenuItem stopCToolStripMenuItem;
        private ToolStripMenuItem continueToolStripMenuItem;
        private ToolStripMenuItem continueAToolStripMenuItem;
        private ToolStripMenuItem continueBToolStripMenuItem;
        private ToolStripMenuItem continueCToolStripMenuItem;
        private MenuStrip menuStrip;
        private System.Windows.Forms.Timer timer;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private CL_ProductionPanel.ProductionPanel productionPanelA;
        private CL_ProductionPanel.ProductionPanel productionPanelB;
        private CL_ProductionPanel.ProductionPanel productionPanelC;
        private Label labelProductionAName;
        private ProgressBar progressBarA;
        private Label labelProductionBName;
        private ProgressBar progressBarB;
        private Label labelProductionCName;
        private ProgressBar progressBarC;
    }
}