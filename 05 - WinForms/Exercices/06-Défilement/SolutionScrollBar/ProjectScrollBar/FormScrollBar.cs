using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectScrollBar
{
    public partial class FormScrollBar : Form
    {
        static private int instanciationCount = 0;

        private Color color;

        public FormScrollBar()
        {
            InitializeComponent();
            this.StoreColor();
            this.DisplayAllColors();

            FormScrollBar.instanciationCount++;
        }

        static public int InstanciationCount { get { return FormScrollBar.instanciationCount; } }

        // Events

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            this.numericUpDownRed.Value = (decimal)this.hScrollBarRed.Value;

            this.StoreColor();
            this.DisplayAllColors();
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            this.hScrollBarRed.Value = (int)this.numericUpDownRed.Value;

            this.StoreColor();
            this.DisplayAllColors();
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            this.numericUpDownGreen.Value = (decimal)this.hScrollBarGreen.Value;

            this.StoreColor();
            this.DisplayAllColors();
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            this.hScrollBarGreen.Value = (int)this.numericUpDownGreen.Value;

            this.StoreColor();
            this.DisplayAllColors();
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            this.numericUpDownBlue.Value = (decimal)this.hScrollBarBlue.Value;

            this.StoreColor();
            this.DisplayAllColors();
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            this.hScrollBarBlue.Value = (int)this.numericUpDownBlue.Value;

            this.StoreColor();
            this.DisplayAllColors();
        }

        // Methods

        private void StoreColor()
        {
            int redAmount = (int)this.numericUpDownRed.Value;
            int greenAmount = (int)this.numericUpDownGreen.Value;
            int blueAmount = (int)this.numericUpDownBlue.Value;

            this.color = Color.FromArgb(redAmount, greenAmount, blueAmount);
        }

        private void DisplayRed()
        {
            int redAmount = (int)this.color.R;

            this.panelRed.BackColor = Color.FromArgb(redAmount, 0, 0);
        }

        private void DisplayGreen()
        {
            int greenAmount = (int)this.color.G;

            this.panelGreen.BackColor = Color.FromArgb(0, greenAmount, 0);
        }

        private void DisplayBlue()
        {
            int blueAmount = (int)this.color.B;

            this.panelBlue.BackColor = Color.FromArgb(0, 0, blueAmount);
        }

        private void DisplayColorPanel()
        {
            this.panelColor.BackColor = this.color;
        }

        private void DisplayAllColors()
        {
            this.DisplayRed();
            this.DisplayGreen();
            this.DisplayBlue();
            this.DisplayColorPanel();
        }
    }
}
