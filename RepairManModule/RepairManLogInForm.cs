using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RepairManModule
{
	public partial class RepairManLogInForm : Form
	{
		readonly string DefaultLabel2Text;
		int ban_time;


		public RepairManLogInForm()
		{
			InitializeComponent();
			DefaultLabel2Text = label2.Text;
		}
		
		private void LogInButton_Click(object sender, EventArgs e)
		{
			AuthorizationForm af = new AuthorizationForm();

			var res = af.ShowDialog();

			if (res == DialogResult.OK)
			{
				Form1 main_form = new Form1(af.rmdm);
				main_form.ShowDialog();

			}
			else if(res == DialogResult.Abort)
			{
				LogInButton.Enabled = false;

				
				label2.Text = "Authorization is unavailable.";

				ban_time = 60;
				label3.Visible = true;
				timer2.Start();
				timer1.Start();
				
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label3.Visible = false;
			
			timer2.Stop();

			label2.Text = DefaultLabel2Text;
			LogInButton.Enabled = true;

			timer1.Stop();

			label3.Text = "";
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			label3.Text = (--ban_time).ToString(". sec");
		}
	}
}
