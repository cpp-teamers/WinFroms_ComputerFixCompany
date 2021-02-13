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
    public partial class SignUpForm : Form
    {
        ClientDataManager cdm = new ClientDataManager();
        Client c = new Client();
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            id.ReadOnly = true;
            name.Text = "Name";
            name.ForeColor = Color.Gray;

            surname.Text = "Surname";
            surname.ForeColor = Color.Gray;

            patronymic.Text = "Patronymic";
            patronymic.ForeColor = Color.Gray;
            // Unique Id
            cdm.Registration(c);
            MessageBox.Show(cdm.ID);
            password.UseSystemPasswordChar = true;
        }
        // Clear Fields
        private void name_Click(object sender, EventArgs e)
        {
            name.Text = "";
        }
        private void patronymic_Click(object sender, EventArgs e)
        {
            patronymic.Text = "";
        }
        private void surname_Click(object sender, EventArgs e)
        {
            surname.Text = "";
        }
        // If user input no data
        private void name_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(name.Text))
            {
                name.Text = "Name";
                name.ForeColor = Color.Gray;
            }
        }
        private void surname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(surname.Text))
            {
                surname.Text = "Surname";
                surname.ForeColor = Color.Gray;
            }
        }
        private void patronymic_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(patronymic.Text))
            {
                patronymic.Text = "Patronymic";
                patronymic.ForeColor = Color.Gray;
            }
        }
        //
        private void name_TextChanged(object sender, EventArgs e)
        {
            name.ForeColor = Color.Black;
        }
        private void surname_TextChanged(object sender, EventArgs e)
        {
            surname.ForeColor = Color.Black;
        }
        private void patronymic_TextChanged(object sender, EventArgs e)
        {
            patronymic.ForeColor = Color.Black;
        }

        private void create_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            // Assignment fields from textBoxes to object properties
            client.AccountData = new AccountData() { Login = id.Text, Password = password.Text };
            client.Name = name.Text;
            client.Surname = surname.Text;
            client.Patronymic = patronymic.Text;

            client.Adress = new Adress() { City = city.Text, Street = street.Text, NumOfBlock = block.Text, NumOfApartment = Convert.ToInt32(apartment.Text) };
            client.Age = Convert.ToInt32(age); //  !!!! !!!! !!!! !!!! !!!!!! !!!!! !! !!!!! !!!!!! 

        }
        private void show_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked)
                password.UseSystemPasswordChar = false;
            else
                password.UseSystemPasswordChar = true;
        }
    }
}
