using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryExceptions;
using Library1;

namespace ClientModule
{
    public partial class CreateOrderForm : Form
    {
        public Order Order = new Order();
        public CreateOrderForm()
        {
            InitializeComponent();
        }
        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            orderType.SelectedIndex = 0;
        }

        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(description.Text))
                    throw new StringException("Decsription can not be an empty!", description.Text);
                else if (dateTime.Value < DateTime.Now)
                    throw new DateException("Deadline can not be lower today!", dateTime.Value.ToString());
                else
                {
                    Order.Actual = true;
                    Order.DeadLine = dateTime.Value;
                    Order.Description = description.Text.Trim();
                    // All is OK
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Order was successfully created!");
                }
            }
            catch(StringException sErr)
            {
                MessageBox.Show($"{sErr.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DateException dateErr)
            {
                MessageBox.Show($"{dateErr.Message} -> {dateErr.Parametr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
