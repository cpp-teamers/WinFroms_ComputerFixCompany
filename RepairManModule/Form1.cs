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

namespace RepairManModule
{
    public partial class Form1 : Form
    {
		readonly RepairManDataManager current_manager;

        public Form1(in RepairManDataManager entry_Manager)
		{
            InitializeComponent();
			current_manager = entry_Manager;
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			welcomeEmpLabel.Text = $"Welcome, {current_manager.rm.Name}.";
			taskList.DataSource = current_manager.LoadTasks();
			
			taskList.DisplayMember = "DeadLine"; // output to task list



		}
	}
}
