using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectCombo;
using ProjectList;
using ProjectRepayment;
using ProjectScrollBar;
using ProjectTextFormat;
using ProjetCalculette;
using ProjetTransactions;

namespace ProjectFinal
{
    public partial class FormFinal : Form
    {
        private double test;

        public FormFinal()
        {
            InitializeComponent();
            this.test = Math.Pow(-3.6, -5.2);
        }

        #region Events
        private void timer_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel.Text = DateTime.Now.ToString();
        }

        private void calculetteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculette f = new FormCalculette();
            f.MdiParent = this;
            f.Text += " n°" + FormCalculette.InstanciationCount.ToString();
            f.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransactions f = new FormTransactions();
            f.MdiParent = this;
            f.Text += " n°" + FormTransactions.InstanciationCount.ToString();
            f.Show();
        }

        private void textFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTextFormat f = new FormTextFormat();
            f.MdiParent = this;
            f.Text += " n°" + FormTextFormat.InstanciationCount.ToString();
            f.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormList f = new FormList();
            f.MdiParent = this;
            f.Text += " n°" + FormList.InstanciationCount.ToString();
            f.Show();
        }

        private void comboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCombo f = new FormCombo();
            f.MdiParent = this;
            f.Text += " n°" + FormCombo.InstanciationCount.ToString();
            f.Show();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormScrollBar f = new FormScrollBar();
            f.MdiParent = this;
            f.Text += " n°" + FormScrollBar.InstanciationCount.ToString();
            f.Show();
        }

        private void repaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRepayment f = new FormRepayment();
            f.MdiParent = this;
            f.Text += " n°" + FormRepayment.InstanciationCount.ToString();
            f.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowLogin();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonLogin_Click(object sender, EventArgs e)
        {
            this.ShowLogin();
        }
        #endregion

        #region Methods
        private void ShowLogin()
        {
            if (FormLogin.InstanceCount == 0)
            {
                FormLogin f = new FormLogin();
                // abonnement de la méthode formLogin_Connected à l'événement Connected de f
                f.Connected += formLogin_Connected;
                f.MdiParent = this;
                f.Show();
            }      
        }

        private void formLogin_Connected(object? sender, EventArgs e)
        {
            this.GiveAccess();
        }

        private void GiveAccess()
        {
            this.phase1ToolStripMenuItem.Enabled = true;
            this.phase2ToolStripMenuItem.Enabled = true;
            this.phase3ToolStripMenuItem.Enabled = true;
            this.windowToolStripMenuItem.Enabled = true;
        }
        #endregion
    }
}
