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
            this.RefreshCheckBoxes();
            this.FormatText();
        }

        private void checkBox_CheckedChange(object sender, EventArgs e)
        {
            this.RefreshRadioButtons();
            this.FormatText();
        }

        private void radioButton_CheckedChange(object sender, EventArgs e)
        {
            this.FormatText();
        }

        private void FormatText()
        {
            #region background
            if (this.checkBoxBackgroundColor.Checked)
            {
                if (this.radioButtonBackgroundRed.Checked)
                {
                    this.textBoxOutput.BackColor = System.Drawing.Color.Red;
                }
                else if (this.radioButtonBackgroundGreen.Checked)
                {
                    this.textBoxOutput.BackColor = System.Drawing.Color.Green;
                }
                else if (this.radioButtonBackgroundBlue.Checked)
                {
                    this.textBoxOutput.BackColor = System.Drawing.Color.Blue;
                }
                else
                {
                    this.textBoxOutput.BackColor = SystemColors.Control;
                }
            }
            else
            {
                this.textBoxOutput.BackColor = SystemColors.Control;
            }
            #endregion

            #region font color
            if (this.checkBoxFontColor.Checked)
            {
                if (this.radioButtonFontRed.Checked)
                {
                    this.textBoxOutput.ForeColor = System.Drawing.Color.Red;
                }
                else if (this.radioButtonFontWhite.Checked)
                {
                    this.textBoxOutput.ForeColor = System.Drawing.Color.White;
                }
                else if (this.radioButtonFontBlack.Checked)
                {
                    this.textBoxOutput.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    this.textBoxOutput.ForeColor = SystemColors.WindowText;
                }
            }
            else
            {
                this.textBoxOutput.ForeColor = SystemColors.WindowText;
            }
            #endregion

            #region case
            if (this.checkBoxCase.Checked)
            {
                if (this.radioButtonLowerCase.Checked)
                {
                    this.textBoxOutput.Text = this.textBox.Text.ToLower();
                }
                else if (this.radioButtonUpperCase.Checked)
                {
                    this.textBoxOutput.Text = this.textBox.Text.ToUpper();
                }
                else
                {
                    this.textBoxOutput.Text = this.textBox.Text;
                }
            }
            else
            {
                this.textBoxOutput.Text = this.textBox.Text;
            }
            #endregion
        }

        private void RefreshCheckBoxes()
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

        private void RefreshRadioButtons()
        {
            this.groupBoxBackgroundColor.Visible = this.checkBoxBackgroundColor.Checked;
            this.groupBoxFontColor.Visible = this.checkBoxFontColor.Checked;
            this.groupBoxCase.Visible = this.checkBoxCase.Checked;
        }
    }
}
