using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ManagerModule
{
    public partial class LogInForm : Form
    {
        private ManagerDataManager dataManager = new ManagerDataManager();

        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            idField.Text = "123456";
            idField.ForeColor = Color.Gray;

            passwordField.UseSystemPasswordChar = true;
            idField.Focus();
        }

        private void idField_Click(object sender, EventArgs e)
        {
            idField.Text = "";
        }

        private void idField_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(idField.Text))
            {
                idField.Text = "123456";
                idField.ForeColor = Color.Gray;
            }
        }

        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheckBox.Checked)
                passwordField.UseSystemPasswordChar = false;
            else
                passwordField.UseSystemPasswordChar = true;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists($@"..\..\..\Data\managers\{idField.Text.Trim()}")){
                MessageBox.Show("You are enter not exist ID", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                idField.Text = "";
                idField.Focus();
                passwordField.Text = "";
            }
            else if (!dataManager.PasswordIsCorrect(idField.Text, passwordField.Text))
            {
                MessageBox.Show("You are enter incorrect password", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                idField.Text = "";
                idField.Focus();
                passwordField.Text = "";
            }
            else
            {
                MessageBox.Show("congrat");
            }
        }
    }
}
