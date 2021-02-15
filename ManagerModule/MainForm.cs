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

namespace ManagerModule
{
    public partial class MainForm : Form
    {

        bool selectedRepairMan;
        bool selectedOrder;
        ManagerDataManager dataManager = new ManagerDataManager();
        SortedList<string, Order> notDistributedOrder;
        SortedList<string, RepairMan> repairMen;


        public MainForm()
        {
            InitializeComponent();
        }

        private void repairManList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOrder = true;
            if (selectedRepairMan && selectedOrder)
                distributeButton.Enabled = true;
            RepairMan repairMan = repairManList.SelectedItem as RepairMan;
            nameField.Text = repairMan.Name;
            surNameField.Text = repairMan.Surname;
            patronomicField.Text = repairMan.Patronymic;
            expField.Text = repairMan.Experience.ToString();
            rateField.Text = repairMan.Rate.ToString();
        }

        private void ordersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRepairMan = true;
            if (selectedRepairMan && selectedOrder)
                distributeButton.Enabled = true;
            Order order = ordersList.SelectedItem as Order;
            typeOrderField.Text = order.OrderType.ToString();
            deadLineField.Text = order.DeadLine.ToString();
            descriptionField.Text = order.Description;
        }

        private void distributeButton_Click(object sender, EventArgs e)
        {
            int indexOrder = ordersList.SelectedIndex;
            int indexRepairMen = repairManList.SelectedIndex;
            notDistributedOrder.Values[indexOrder].Actual = false;
            repairMen.Values[indexRepairMen].PathsOfOrders.Add(notDistributedOrder.Keys[indexOrder]);
            dataManager.SaveOrder(notDistributedOrder.Values[indexOrder], notDistributedOrder.Keys[indexOrder]);
            dataManager.SaveRepairMan(repairMen.Values[indexRepairMen], repairMen.Keys[indexRepairMen]);
            
            LoadComboBoxes();
            Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            selectedOrder = false;
            selectedRepairMan = false;
            distributeButton.Enabled = false;
            notDistributedOrder = dataManager.GetNotDistributedOrders();
            repairMen = dataManager.GetRepairsMan();
            ordersList.Items.Clear();
            repairManList.Items.Clear();
            foreach (var order in notDistributedOrder.Values)
            {
                ordersList.Items.Add(order);
            }
            ordersList.DisplayMember = "Description";
            foreach(var repMan in repairMen.Values)
            {
                repairManList.Items.Add(repMan);
            }
            repairManList.DisplayMember = "Name";
        }

        private void Clear()
        {
            nameField.Text = "";
            surNameField.Text = "";
            patronomicField.Text = "";
            expField.Text = "";
            rateField.Text = "";
            typeOrderField.Text = "";
            deadLineField.Text = "";
            descriptionField.Text = "";
        }
    }
}
