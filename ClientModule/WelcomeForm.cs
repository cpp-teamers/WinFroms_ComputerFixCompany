using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library1;

namespace ClientModule
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            var res = logInForm.ShowDialog();

            if(res == DialogResult.OK)
            {
                Visible = false;

                LoggedInForm loggedIn = new LoggedInForm();
                loggedIn.Client = logInForm.Client;
                loggedIn.ShowDialog();

                
                this.Visible = true;
            }
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            SignUpForm sign = new SignUpForm();
            var res = sign.ShowDialog();

            if (res == DialogResult.OK)
                Visible = true;
        }
    }
}
