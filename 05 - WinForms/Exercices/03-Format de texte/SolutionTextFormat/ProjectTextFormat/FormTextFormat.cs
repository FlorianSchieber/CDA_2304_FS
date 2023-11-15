using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTextFormat
{
    public partial class FormTextFormat : Form
    {
        public FormTextFormat()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox.Text.Length > 0)
            {
                this.groupBoxChoice.Enabled = true;
            }
            else
            {
                this.checkBoxBackgroundColor.Checked = false;
                this.checkBoxFontColor.Checked = false;
                this.checkBoxCase.Checked = false;
                this.groupBoxChoice.Enabled = false;
            }
        }
    }
}
