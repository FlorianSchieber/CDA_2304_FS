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
        private Color color;

        public FormScrollBar()
        {
            InitializeComponent();
            this.RefreshAllColors();
        }

        // Events

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            this.numericUpDownRed.Value = (decimal)this.hScrollBarRed.Value;

            this.RefreshRed();
            this.RefreshColor();
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            this.hScrollBarRed.Value = (int)this.numericUpDownRed.Value;
            this.RefreshRed();
            this.RefreshColor();
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            this.numericUpDownGreen.Value = (decimal)this.hScrollBarGreen.Value;
            this.RefreshGreen();
            this.RefreshColor();
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            this.hScrollBarGreen.Value = (int)this.numericUpDownGreen.Value;
            this.RefreshGreen();
            this.RefreshColor();
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            this.numericUpDownBlue.Value = (decimal)this.hScrollBarBlue.Value;
            this.RefreshBlue();
            this.RefreshColor();
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            this.hScrollBarBlue.Value = (int)this.numericUpDownBlue.Value;
            this.RefreshBlue();
            this.RefreshColor();
        }

        // Methods

        private void RefreshRed()
        {
            int redAmount = (int)this.color.R;

            this.panelRed.BackColor = Color.FromArgb(redAmount, 0, 0);
        }

        private void RefreshGreen()
        {
            int greenAmount = (int)this.color.G;

            this.panelGreen.BackColor = Color.FromArgb(0, greenAmount, 0);
        }

        private void RefreshBlue()
        {
            int blueAmount = (int)this.color.B;

            this.panelBlue.BackColor = Color.FromArgb(0, 0, blueAmount);
        }

        private void RefreshColor()
        {
            this.panelColor.BackColor = this.color;
        }

        private void RefreshAllColors()
        {
            this.RefreshRed();
            this.RefreshGreen();
            this.RefreshBlue();
            this.RefreshColor();
        }
    }
}
