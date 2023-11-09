using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCalculette
{
    public partial class FormCalculette : Form
    {
        private int sum;
        private bool newlLine;

        public FormCalculette()
        {
            InitializeComponent();
            this.sum = 0;
            this.newlLine = true;
        }

        private void FormCalculette_Load(object sender, EventArgs e)
        {

        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            this.evaluate();
        }

        private void FormCalculette_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            this.empty();
        }

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            this.addTerm((int)((Button)sender).Tag);
        }

        private void addTerm(int _term)
        {
            if (this.newlLine)
            {
                this.textBox.Text += _term.ToString();
            }
            else
            {
                this.textBox.Text += " + " + _term.ToString();
            }

            this.newlLine = false;
            this.sum += _term;
        }

        private void evaluate()
        {
            this.textBox.Text += " =\r\n" + this.sum.ToString();
        }

        private void empty()
        {
            this.textBox.Text = "";
            this.sum = 0;
            this.newlLine = true;
        }


    }
}
