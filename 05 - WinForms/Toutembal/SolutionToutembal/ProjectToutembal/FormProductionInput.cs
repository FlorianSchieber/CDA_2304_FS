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
    public partial class FormProductionInput : Form
    {
        Production[] productions;

        public FormProductionInput()
        {
            InitializeComponent();

            this.productions = new Production[] { };
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string nomA = this.textBoxNameA.Text;
            string nomB = this.textBoxNameB.Text;
            string nomC = this.textBoxNameC.Text;

            string typeA = this.textBoxTypeA.Text;
            string typeB = this.textBoxTypeB.Text;
            string typeC = this.textBoxTypeC.Text;

        }
    }
}
