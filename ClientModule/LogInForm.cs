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
using LibraryExceptions;

namespace ClientModule
{
    public partial class LogInForm : Form
    {
        public Client Client = new Client();
        ClientDataManager cdm = new ClientDataManager();
        private int attempt = 3;
        //private string path = @"..\..\Data\clients";
        public bool Success { get; set; }
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
            try
            {
                string id = this.id.Text;
                string password = passwordBox.Text;
                Client client = new Client();
                // 
                if (!cdm.FindDirectory(id))
                    throw new IdException("User with this ID was not found!", id);
                else
                {
                    client = cdm.LoadClient(id);
                    Success = true;
                }
                if (Success && attempt > 0)
                {
                    if (client.AccountData.Password != password)
                    {
                        throw new PasswordException($"Password mismatch! You have {attempt--} attempts.", password);
                    }
                    else
                    {
                        // OK
                        Client = client;
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    Visible = false;
                }
            }
            catch(IdException Id_err)
            {
                MessageBox.Show($"{Id_err.Message} -> {Id_err.Parametr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(PasswordException passErr)
            {
                MessageBox.Show($"{passErr.Message} -> {passErr.Parametr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
