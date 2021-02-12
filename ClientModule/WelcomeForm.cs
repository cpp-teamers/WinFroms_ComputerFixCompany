using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            logInForm.ShowDialog();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            SignUpForm sign = new SignUpForm();
            sign.ShowDialog();
        }
    }
}
