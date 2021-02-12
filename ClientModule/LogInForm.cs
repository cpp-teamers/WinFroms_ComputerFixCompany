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
    public partial class LogInForm : Form
    {
        //private string path = @"..\..\Data\clients";
        public bool Success { get; set; }
        //private List<Client> clients { get; set; }
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            Success = false;
            passwordBox.UseSystemPasswordChar = true;
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked)
                passwordBox.UseSystemPasswordChar = false;
            else
                passwordBox.UseSystemPasswordChar = true;
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string password = passwordBox.Text;

            // 
            
            MessageBox.Show(name);
            MessageBox.Show(password);
        }
    }
}
