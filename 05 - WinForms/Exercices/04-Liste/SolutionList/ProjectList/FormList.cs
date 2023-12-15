using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectList
{
    public partial class FormList : Form
    {
        static private int instanciationCount = 0;

        private List<string> list;

        public FormList()
        {
            InitializeComponent();
            this.list = new List<String> { };

            FormList.instanciationCount++;
        }

        static public int InstanciationCount { get { return FormList.instanciationCount; } }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            int matchIndex = this.listBox.FindString(this.textBoxNewElement.Text);

            if (matchIndex == ListBox.NoMatches)
            {
                this.listBox.Items.Add(this.textBoxNewElement.Text);
                this.textBoxNewElement.Text = "";
                this.errorProviderNewElement.SetError(this.textBoxNewElement, "");
                this.RefreshProperties();
            }
            else
            {
                this.errorProviderNewElement.SetError(this.textBoxNewElement, "L'élément est déjà présent dans la liste");
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshProperties();
        }

        private void buttonEmptyList_Click(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();
            this.textBoxItemsCount.Text = "";
            this.textBoxSelectedIndex.Text = "";
            this.textBoxText.Text = "";
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            int elementIndex;

            if (int.TryParse(this.textBoxElementIndex.Text, out elementIndex))
            {
                int itemCount = this.listBox.Items.Count;

                if (itemCount > 0)
                {
                    if (elementIndex >= 0 && elementIndex < itemCount)
                    {
                        this.errorProviderElementIndex.SetError(this.textBoxElementIndex, "");
                        this.listBox.SelectedIndex = elementIndex;
                    }
                    else
                    {
                        this.errorProviderElementIndex.SetError(this.textBoxElementIndex, "L'indice doit être compris entre 0 et " + (itemCount - 1));
                    }
                }
                else
                {
                    this.errorProviderElementIndex.SetError(this.textBoxElementIndex, "La liste est vide");
                }


            }
            else
            {
                this.errorProviderElementIndex.SetError(this.textBoxElementIndex, "L'indice doit être un nombre entier");
            }
        }

        private void RefreshProperties()
        {
            this.textBoxItemsCount.Text = this.listBox.Items.Count.ToString();

            if (this.listBox.SelectedIndex != -1)
            {
                this.textBoxSelectedIndex.Text = this.listBox.SelectedIndex.ToString();
                this.textBoxText.Text = this.listBox.SelectedItem.ToString();
            }
        }
    }
}
