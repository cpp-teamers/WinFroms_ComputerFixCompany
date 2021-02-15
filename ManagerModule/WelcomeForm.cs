using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerModule
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.ShowDialog();

            var res = logInForm.DialogResult;
            if (res == DialogResult.OK)
            {
                this.Visible = false;

                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();

                this.Visible = true;
            }
        }
    }
}
