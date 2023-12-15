using CL_Production;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectToutembal
{
    public partial class FormProductionManager : Form
    {
        // Attributes
        private Production[] productions;

        // Constructors
        public FormProductionManager(Production[] _productions)
        {
            InitializeComponent();
            this.productions = _productions;

            this.productionPanelA.Production = this.productions[0];
            this.productionPanelB.Production = this.productions[1];
            this.productionPanelC.Production = this.productions[2];

            this.labelProductionAName.Text = this.productions[0].Name;
            this.labelProductionBName.Text = this.productions[1].Name;
            this.labelProductionCName.Text = this.productions[2].Name;

            this.progressBarA.Maximum = this.productions[0].MAX_CRATE_NUMBER;
            this.progressBarB.Maximum = this.productions[1].MAX_CRATE_NUMBER;
            this.progressBarC.Maximum = this.productions[2].MAX_CRATE_NUMBER;

            this.Refresh();
        }

        // Operations
        public void RefreshIHM()
        {
            this.startAToolStripMenuItem.Enabled = this.productions[0].Status == ProductionStatus.WaitingStart;
            this.startBToolStripMenuItem.Enabled = this.productions[1].Status == ProductionStatus.WaitingStart;
            this.startCToolStripMenuItem.Enabled = this.productions[2].Status == ProductionStatus.WaitingStart;

            this.stopAToolStripMenuItem.Enabled = this.productions[0].Status == ProductionStatus.Started;
            this.stopBToolStripMenuItem.Enabled = this.productions[1].Status == ProductionStatus.Started;
            this.stopCToolStripMenuItem.Enabled = this.productions[2].Status == ProductionStatus.Started;

            this.continueAToolStripMenuItem.Enabled = this.productions[0].Status == ProductionStatus.Paused;
            this.continueBToolStripMenuItem.Enabled = this.productions[1].Status == ProductionStatus.Paused;
            this.continueCToolStripMenuItem.Enabled = this.productions[2].Status == ProductionStatus.Paused;


            this.productionPanelA.RefreshIHM();
            this.productionPanelB.RefreshIHM();
            this.productionPanelC.RefreshIHM();

            this.progressBarA.Value = this.productions[0].CrateCount();
            this.progressBarB.Value = this.productions[1].CrateCount();
            this.progressBarC.Value = this.productions[2].CrateCount();
        }

        // Events
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.RefreshIHM();
        }

        private void startAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.productions[0].Status == ProductionStatus.WaitingStart)
            {
                this.productions[0].Start();
            }

        }

        private void startBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.productions[1].Status == ProductionStatus.WaitingStart)
            {
                this.productions[1].Start();
            }
        }

        private void startCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.productions[2].Status == ProductionStatus.WaitingStart)
            {
                this.productions[2].Start();
            }
        }

        private void stopAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.productions[0].Pause();
        }

        private void stopBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.productions[1].Pause();
        }

        private void stopCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.productions[2].Pause();
        }

        private void continueAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.productions[0].Status == ProductionStatus.Paused)
            {
                this.productions[0].Start();
            }
        }

        private void continueBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.productions[1].Status == ProductionStatus.Paused)
            {
                this.productions[1].Start();
            }
        }

        private void continueCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.productions[2].Status == ProductionStatus.Paused)
            {
                this.productions[2].Start();
            }
        }
    }
}
