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
using System.Text.RegularExpressions;

namespace ClientModule
{
    public partial class SignUpForm : Form
    {
        ClientDataManager cdm = new ClientDataManager();
        Client c = new Client();
        string regular = @"[a-zA-Z]{2,25}$";
        string regularNum = @"[10-120]";
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
        private void password_TextChanged(object sender, EventArgs e)
        {
            int length = password.Text.Length;
            if (length < 1)
                level.Text = "";
            if(length  > 1 && length <= 6)
            {
                level.Text = "Weak";
                level.ForeColor = Color.Red;
            }
            if (password.Text.Length > 6 && password.Text.Length <= 10)
            {
                level.Text = "Normal";
                level.ForeColor = Color.YellowGreen;
            }
            if (password.Text.Length > 10 && Regex.IsMatch(password.Text, regularNum))
            {
                level.Text = "Strong";
                level.ForeColor = Color.DarkGreen;
            }
        }
        //
        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (!Regex.IsMatch(name.Text, regular))
                    throw new FullNameException("Name did not pass validation!", name.Text);
                else if (!Regex.IsMatch(surname.Text, regular))
                    throw new FullNameException("Surname did not pass validation!", surname.Text);
                else if (!Regex.IsMatch(patronymic.Text, regular))
                    throw new FullNameException("Patronymic did not pass validation!", patronymic.Text);
                else if (!Regex.IsMatch(age.Text, regularNum))
                    throw new AgeLimitException("Age did not pass validation!", age.Text);
                else if (!Regex.IsMatch(street.Text, regular))
                    throw new ApartmentException("Street did not pass validation!", street.Text);
                else if (!Regex.IsMatch(apartment.Text, regularNum))
                    throw new ApartmentException("Apartment field did not pass validation!", apartment.Text);
                else if (String.IsNullOrWhiteSpace(password.Text))
                    throw new PasswordException("Password field did not pass validation!", password.Text);
            }
            catch (FullNameException err)
            {
                MessageBox.Show($"{err.Message} -> {err.Parametr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(ApartmentException appErr)
            {
                MessageBox.Show($"{appErr.Message} -> {appErr.Parametr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(PasswordException passErr)
            {
                MessageBox.Show($"{passErr.Message} -> {passErr.Parametr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AgeLimitException ageErr)
            {
                MessageBox.Show($"{ageErr.Message} -> {ageErr.Parametr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Client client = new Client();
            // Assignment fields from textBoxes to object properties
            /* client.AccountData = new AccountData() { Login = id.Text, Password = password.Text };
             client.Name = name.Text;
             client.Surname = surname.Text;
             client.Patronymic = patronymic.Text;

             client.Adress = new Adress() { City = city.Text, Street = street.Text, NumOfBlock = block.Text, NumOfApartment = Convert.ToInt32(apartment.Text) };
             client.Age = Convert.ToInt32(age); //  !!!! !!!! !!!! !!!! !!!!!! !!!!! !! !!!!! !!!!!! */
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
