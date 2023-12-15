namespace ProjectFinal
{
    partial class FormFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinal));
            menuStrip = new MenuStrip();
            connexionToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparatorLogin = new ToolStripSeparator();
            quitToolStripMenuItem = new ToolStripMenuItem();
            phase1ToolStripMenuItem = new ToolStripMenuItem();
            calculetteToolStripMenuItem = new ToolStripMenuItem();
            phase2ToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            phase3ToolStripMenuItem = new ToolStripMenuItem();
            textFormatToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            comboToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            repaymentsToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparatorWindows = new ToolStripSeparator();
            toolStrip = new ToolStrip();
            toolStripButtonLogin = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            timer = new System.Windows.Forms.Timer(components);
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { connexionToolStripMenuItem, phase1ToolStripMenuItem, phase2ToolStripMenuItem, phase3ToolStripMenuItem, windowToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(591, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // connexionToolStripMenuItem
            // 
            connexionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, toolStripSeparatorLogin, quitToolStripMenuItem });
            connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            connexionToolStripMenuItem.Size = new Size(77, 20);
            connexionToolStripMenuItem.Text = "Connexion";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(130, 22);
            loginToolStripMenuItem.Text = "S'identifier";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // toolStripSeparatorLogin
            // 
            toolStripSeparatorLogin.Name = "toolStripSeparatorLogin";
            toolStripSeparatorLogin.Size = new Size(127, 6);
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(130, 22);
            quitToolStripMenuItem.Text = "Quitter";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // phase1ToolStripMenuItem
            // 
            phase1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculetteToolStripMenuItem });
            phase1ToolStripMenuItem.Enabled = false;
            phase1ToolStripMenuItem.Name = "phase1ToolStripMenuItem";
            phase1ToolStripMenuItem.Size = new Size(59, 20);
            phase1ToolStripMenuItem.Text = "Phase 1";
            // 
            // calculetteToolStripMenuItem
            // 
            calculetteToolStripMenuItem.Name = "calculetteToolStripMenuItem";
            calculetteToolStripMenuItem.Size = new Size(127, 22);
            calculetteToolStripMenuItem.Text = "Calculette";
            calculetteToolStripMenuItem.Click += calculetteToolStripMenuItem_Click;
            // 
            // phase2ToolStripMenuItem
            // 
            phase2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { transactionsToolStripMenuItem });
            phase2ToolStripMenuItem.Enabled = false;
            phase2ToolStripMenuItem.Name = "phase2ToolStripMenuItem";
            phase2ToolStripMenuItem.Size = new Size(59, 20);
            phase2ToolStripMenuItem.Text = "Phase 2";
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(139, 22);
            transactionsToolStripMenuItem.Text = "Transactions";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // phase3ToolStripMenuItem
            // 
            phase3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { textFormatToolStripMenuItem, listToolStripMenuItem, comboToolStripMenuItem, colorToolStripMenuItem, repaymentsToolStripMenuItem });
            phase3ToolStripMenuItem.Enabled = false;
            phase3ToolStripMenuItem.Name = "phase3ToolStripMenuItem";
            phase3ToolStripMenuItem.Size = new Size(59, 20);
            phase3ToolStripMenuItem.Text = "Phase 3";
            // 
            // textFormatToolStripMenuItem
            // 
            textFormatToolStripMenuItem.Name = "textFormatToolStripMenuItem";
            textFormatToolStripMenuItem.Size = new Size(180, 22);
            textFormatToolStripMenuItem.Text = "Format de Texte";
            textFormatToolStripMenuItem.Click += textFormatToolStripMenuItem_Click;
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(180, 22);
            listToolStripMenuItem.Text = "Liste";
            listToolStripMenuItem.Click += listToolStripMenuItem_Click;
            // 
            // comboToolStripMenuItem
            // 
            comboToolStripMenuItem.Name = "comboToolStripMenuItem";
            comboToolStripMenuItem.Size = new Size(180, 22);
            comboToolStripMenuItem.Text = "Combo";
            comboToolStripMenuItem.Click += comboToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "Couleurs";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // repaymentsToolStripMenuItem
            // 
            repaymentsToolStripMenuItem.Name = "repaymentsToolStripMenuItem";
            repaymentsToolStripMenuItem.Size = new Size(180, 22);
            repaymentsToolStripMenuItem.Text = "Remboursements";
            repaymentsToolStripMenuItem.Click += repaymentsToolStripMenuItem_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, horizontalToolStripMenuItem, verticalToolStripMenuItem, toolStripSeparatorWindows });
            windowToolStripMenuItem.Enabled = false;
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(63, 20);
            windowToolStripMenuItem.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(129, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(129, 22);
            horizontalToolStripMenuItem.Text = "Horizontal";
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(129, 22);
            verticalToolStripMenuItem.Text = "Vertical";
            // 
            // toolStripSeparatorWindows
            // 
            toolStripSeparatorWindows.Name = "toolStripSeparatorWindows";
            toolStripSeparatorWindows.Size = new Size(126, 6);
            toolStripSeparatorWindows.Visible = false;
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButtonLogin, toolStripSeparator1 });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(591, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonLogin
            // 
            toolStripButtonLogin.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonLogin.Image = (Image)resources.GetObject("toolStripButtonLogin.Image");
            toolStripButtonLogin.ImageTransparentColor = Color.Magenta;
            toolStripButtonLogin.Name = "toolStripButtonLogin";
            toolStripButtonLogin.Size = new Size(67, 22);
            toolStripButtonLogin.Text = "S'identifier";
            toolStripButtonLogin.Click += toolStripButtonLogin_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 451);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(591, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(31, 17);
            toolStripStatusLabel.Text = "Date";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // FormFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 473);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FormFinal";
            Text = "Bibliothèque d'exercices";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem connexionToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripSeparator toolStripSeparatorLogin;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem phase1ToolStripMenuItem;
        private ToolStripMenuItem phase2ToolStripMenuItem;
        private ToolStripMenuItem phase3ToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStrip toolStrip;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripSeparator toolStripSeparatorWindows;
        private ToolStripMenuItem calculetteToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem textFormatToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem comboToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem repaymentsToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timer;
        private ToolStripButton toolStripButtonLogin;
    }
}