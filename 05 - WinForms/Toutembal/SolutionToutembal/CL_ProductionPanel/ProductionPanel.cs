using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Production;

namespace CL_ProductionPanel
{
    public partial class ProductionPanel : UserControl
    {
        // Class operations
        static public string ToPercent(double _double)
        {
            return (_double * 100).ToString("0.0") + " %";
        }

        // Attributes
        private Production production;

        // Constructor
        public ProductionPanel()
        {
            InitializeComponent();
        }

        // Getters-setters
        public Production Production
        {
            get
            {
                return this.production;
            }
            set
            {
                this.production = value;
            }
        }

        // Operations
        public void RefreshIHM()
        {
            this.textBoxCrateNumber.Text = this.production.CrateCount().ToString();
            this.textBoxHourErrorRate.Text = ProductionPanel.ToPercent(this.production.ErrorRateOfLastHour());
            this.textBoxTotalErrorRate.Text = ProductionPanel.ToPercent(this.production.ErrorRateFromStart());
        }

        private void labelTotalErrorRate_Click(object sender, EventArgs e)
        {

        }
    }
}
