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

		Order current_task;

		bool first_Ready_RadioClick = true;
		bool first_InProc_RadioClick = true;

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


			LoadDataToListBox();

			MarkTasksProgress.Enabled = false;

			// directed to account with 0 tasks !1!
			if (taskList.Items.Count == 0)
			{
				readyRadioB.Enabled = false;
				InProcessRadioB.Enabled = false;
			}
		}

		void LoadDataToListBox()
		{
			taskList.DataSource = current_manager.LoadTasks();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			welcomeEmpLabel.Text = $"Welcome, {current_manager.rm.Name}.";
		}

		private void taskList_SelectedIndexChanged(object sender, EventArgs e)
		{
			

			MarkTasksProgress.Enabled = false;

			current_task = taskList.SelectedItem as Order;

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
			string curr_actuality = current_task.Actual ? actualities[1] : actualities[0];

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

			if (current_task.Actual)
			{
				InProcessRadioB.Checked = true;
				readyRadioB.Checked = false;
			}
			else
			{
				InProcessRadioB.Checked = false;
				readyRadioB.Checked = true;
			}

			// directed to account with 0 tasks !2!
			if (taskList.Items.Count > 0)
			{
				readyRadioB.Enabled = true;
				InProcessRadioB.Enabled = true;
			}
		}

		private void MarkTasksProgress_Click(object sender, EventArgs e)
		{
			if (readyRadioB.Checked)
			{
				current_manager.curr_order[taskList.SelectedIndex].Actual = false;
			}
			else
			{
				current_manager.curr_order[taskList.SelectedIndex].Actual = true;
			}

			current_manager.SaveTasks();
			taskList.DataSource = current_manager.LoadTasks();

			MessageBox.Show("Progress has been marked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void InProcessRadioB_Click(object sender, EventArgs e)
		{
			if (first_InProc_RadioClick)
			{
				first_InProc_RadioClick = false;
			}
			else
			{
				UnableMaskProgressButton();
			}


		}

		private void readyRadioB_Click(object sender, EventArgs e)
		{
			if (first_Ready_RadioClick)
			{
				first_Ready_RadioClick = false;
			}
			else
			{
				UnableMaskProgressButton();
			}
		}

		void UnableMaskProgressButton()
		{
			MarkTasksProgress.Enabled = true;
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			MarkTasksProgress.Enabled = false;
			timer1.Stop();
		}

		
	}
}
