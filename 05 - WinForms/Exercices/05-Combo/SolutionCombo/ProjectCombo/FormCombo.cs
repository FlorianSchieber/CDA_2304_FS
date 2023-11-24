using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCombo
{
    public partial class FormCombo : Form
    {
        private static List<string> countries = new List<String> {
            "France",
            "Belgique",
            "Allemagne",
            "Japon",
            "Portugal",
            "Grèce"
        };

        public FormCombo()
        {
            InitializeComponent();

            foreach (string country in FormCombo.countries)
            {
                this.comboBoxSource.Items.Add(country);
            }
        }

        // Events

        private void comboBoxSource_DropDown(object sender, EventArgs e)
        {
            string customCountry = this.comboBoxSource.Text.Trim();

            if (customCountry.Length > 0 && !IsInAList(customCountry))
            {
                this.comboBoxSource.Items.Add(customCountry);
                this.ActualiseButtons();
            }
        }

        private void comboBoxSource_TextChanged(object sender, EventArgs e)
        {
            this.ActualiseButtons();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.AddCountry();
            this.ActualiseButtons();
        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            this.AddCountry();
            this.AddAllCountries();
            this.ActualiseButtons();
        }

        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualiseButtons();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            this.RemoveCountry();
            this.ActualiseButtons();
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            this.RemoveAllCountries();
            this.ActualiseButtons();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            this.MoveUp();
            this.ActualiseButtons();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            this.MoveDown();
            this.ActualiseButtons();
        }

        // Methods

        private void AddCountry()
        {
            string country = this.comboBoxSource.Text.Trim();

            if (country.Length > 0 && !IsInTarget(country))
            {
                this.listBoxTarget.Items.Add(country);

                if (IsInSource(country))
                {
                    this.comboBoxSource.Items.Remove(country);
                }

                this.comboBoxSource.Text = "";

            }
        }

        private void AddAllCountries()
        {
            foreach (string country in this.comboBoxSource.Items)
            {
                this.listBoxTarget.Items.Add(country);
            }

            this.comboBoxSource.Items.Clear();
            this.comboBoxSource.Text = "";
        }

        private void RemoveCountry()
        {
            if (this.TargetItemIsSelected())
            {
                string country = this.listBoxTarget.SelectedItem.ToString();

                if (!this.IsInSource(country))
                {
                    this.comboBoxSource.Items.Add(country);
                }

                this.listBoxTarget.Items.Remove(country);
            }
        }

        private void RemoveAllCountries()
        {
            foreach (string country in this.listBoxTarget.Items)
            {
                this.comboBoxSource.Items.Add(country);
            }

            this.listBoxTarget.Items.Clear();
        }

        private void ActualiseButtons()
        {
            // Actuablise Adding Buttons
            this.buttonAdd.Enabled = this.comboBoxSource.Text.Trim().Length > 0 && !this.IsInTarget(this.comboBoxSource.Text);
            this.buttonAddAll.Enabled = this.comboBoxSource.Items.Count > 0;

            // Actualise Removing Buttons
            this.buttonRemove.Enabled = this.TargetItemIsSelected();
            this.buttonRemoveAll.Enabled = !this.TargetIsEmpty();

            // Actualise Sorting Buttons
            this.buttonUp.Enabled = this.TargetItemIsSelected() && !this.SelectedTargetItemIsTop();
            this.buttonDown.Enabled = this.TargetItemIsSelected() && !this.SelectedTargetItemIsBottom();
        }

        private void MoveUp()
        {
            if (!this.SelectedTargetItemIsTop())
            {
                this.MoveItem(-1);
            }
        }

        private void MoveDown()
        {
            if (!this.SelectedTargetItemIsBottom())
            {
                this.MoveItem(1);
            }
        }

        private void MoveItem(int _step)
        {
            if (this.TargetItemIsSelected())
            {
                string country = (string)this.listBoxTarget.SelectedItem;
                int oldIndex = this.listBoxTarget.SelectedIndex;
                int newIndex = oldIndex + _step;

                this.listBoxTarget.Items.RemoveAt(oldIndex);
                this.listBoxTarget.Items.Insert(newIndex, country);
                this.listBoxTarget.SelectedIndex = newIndex;
            }
        }

        // Verifiers

        private bool IsInSource(string _country)
        {
            return this.comboBoxSource.FindStringExact(_country) != -1;
        }

        private bool IsInTarget(string _country)
        {
            return this.listBoxTarget.FindStringExact(_country) != -1;
        }

        private bool IsInAList(string _country)
        {
            return IsInSource(_country) || IsInTarget(_country);
        }

        private bool TargetIsEmpty()
        {
            return this.listBoxTarget.Items.Count == 0;
        }

        private bool TargetItemIsSelected()
        {
            return this.listBoxTarget.SelectedIndex != -1;
        }

        private bool SelectedTargetItemIsTop()
        {
            return this.listBoxTarget.SelectedIndex == 0;
        }

        private bool SelectedTargetItemIsBottom()
        {
            return this.listBoxTarget.SelectedIndex == this.listBoxTarget.Items.Count - 1;
        }


    }
}
