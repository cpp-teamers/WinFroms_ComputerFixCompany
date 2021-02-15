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
    public partial class LoggedInForm : Form
    {
        public Client Client = new Client();
        List<Order> orders = new List<Order>();
        ClientDataManager cdm = new ClientDataManager();
        private int index = -1;
        public LoggedInForm()
        {
            InitializeComponent();
        }
        private void LoggedInForm_Load(object sender, EventArgs e)
        {
            //
            helloLabel.Text = $"Welcome, {Client.Name}!";
            cdm.ShowAllOrders(Client.AccountData.Login, orders);
            time.Text = DateTime.Now.ToString();

            if (orders != null)
            {
                int count = 0;
                foreach (var order in orders)
                {
                    listView.Items.Add(order.Description);
                    if (order.Actual)
                        listView.Items[count].ForeColor = Color.DarkGreen;
                    else
                        listView.Items[count].ForeColor = Color.Red;
                    count++;
                }
            }
            else
                listView.Items[0].Text = "You haven't got an orders yet!";
            // Start time
            timer.Start();
            // 
            orderDetailsLabel.Visible = false;
            orderDetails.Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            picture.Visible = false;

            orderDetailsLabel.Visible = true;
            orderDetails.Visible = true;

            index = listView.FocusedItem.Index;
            orderDetails.Text = $" Description: {orders[index].Description}." +
                $" \r\n Deadline: {orders[index].DeadLine}. \r\n Order type: {orders[index].OrderType}.";
            if (orders[index].Actual)
                orderDetails.Text += "\r\n Done";
            else
                orderDetails.Text += "\r\n Not Done";
        }

        private void LoggedInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var answer = MessageBox.Show("Do you really want to exit? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(answer)
            {
                case DialogResult.OK:
                    Visible = false;
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {

        }
    }
}
