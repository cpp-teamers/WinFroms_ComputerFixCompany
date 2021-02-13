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
	public partial class AuthorizationForm : Form
	{

		public AuthorizationForm()
		{
			InitializeComponent();
		}

		private void LogInOkButton_Click(object sender, EventArgs e)
		{
			try
			{
				
				//AuthNameField.
			}
			catch (Exception err)
			{
				MessageBox.Show($"{err.Message}", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
