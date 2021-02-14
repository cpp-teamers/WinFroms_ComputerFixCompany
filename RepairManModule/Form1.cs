using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RepairManModule.Helpers;
using Library1;

namespace RepairManModule
{
    public partial class Form1 : Form
    {
		readonly RepairManDataManager current_manager;
		
		readonly List<OrderType> order_types;
		readonly List<string> actualities;


		public Form1(in RepairManDataManager entry_Manager)
		{
            InitializeComponent();
			current_manager = entry_Manager;

			order_types = new List<OrderType>
			{
				OrderType.Diagnostics,
				OrderType.HardwareRepair,
				OrderType.Diagnostics,
				OrderType.SoftwareRepair
			};
			actualities = new List<string>
			{
				"Done",
				"In proccess"
			};

			orderTypesBox.DataSource = order_types;
			actualityBox.DataSource = actualities;
			taskList.DataSource = current_manager.LoadTasks();





		}

		private void Form1_Load(object sender, EventArgs e)
		{
			welcomeEmpLabel.Text = $"Welcome, {current_manager.rm.Name}.";

		}

		private void taskList_SelectedIndexChanged(object sender, EventArgs e)
		{
			taskList.SelectedIndex = 0;

			Order current_task = (taskList.SelectedItem as Order);

			// setting categories

			int index_type = 0;
			string curr_orderType = current_task.OrderType.ToString();

			foreach (var o in orderTypesBox.Items)
			{
				if (curr_orderType == o.ToString())
				{
					break;
				}
				++index_type;
			}
			orderTypesBox.SelectedIndex = index_type;
			
			//

			int index_actuality = 0;
			string curr_actuality = current_task.Actual ? actualities[0] : actualities[1];

			foreach (var act in actualityBox.Items)
			{
				if (curr_actuality == act as string)
				{
					break;
				}
				index_actuality++;
			}
			actualityBox.SelectedIndex = index_actuality;

			// setting description

			descriptionOfTask.Text = current_task.Description;

		}
	}
}
