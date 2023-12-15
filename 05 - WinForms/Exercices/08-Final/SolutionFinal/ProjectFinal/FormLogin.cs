using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinal
{
    public partial class FormLogin : Form
    {

        static private string correctUserName = "Foyan";
        static private string correctPassword = "123456789";
        static private int instanceCount = 0;

        public event EventHandler Connected;

        private bool isConnected;


        public FormLogin()
        {
            FormLogin.instanceCount++;
            InitializeComponent();
            this.isConnected = false;
        }

        public static int InstanceCount { get { return FormLogin.instanceCount; } }

        public bool IsConnected { get { return this.isConnected; } }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string userName = this.textBoxLogin.Text;
            string password = this.textBoxPassword.Text;

            if (
                userName == FormLogin.correctUserName &&
                password == FormLogin.correctPassword
            )
            {
                MessageBox.Show("Vous êtes connecté", "Connexion", MessageBoxButtons.OK);
                this.isConnected = true;

                // Déclenchement de l'évenement
                if (Connected != null)// si quelqu'un s'est abonné à l'événement
                {
                    Connected(this, new EventArgs());
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("La connexion a échoué", "Connexion", MessageBoxButtons.OK);
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLogin.instanceCount--;
        }
    }
}
