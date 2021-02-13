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
	public partial class AuthorizationForm : Form
	{
		RepairManDataManager rmdm;

		public AuthorizationForm()
		{
			InitializeComponent();
			rmdm = new RepairManDataManager();
		}

		private void LogInOkButton_Click(object sender, EventArgs e)
		{
			try
			{
				string name = AuthNameField.Text;
				string password = AuthPasswordField.Text;



				if (String.IsNullOrWhiteSpace(name))
				{
					throw new Exception("You didn't entered name!");
				}
				
				if (String.IsNullOrWhiteSpace(password))
				{
					throw new Exception("You didn't entered password!");
				}

				name = name.ToLower();


				if (rmdm.IsValid(name))
				{
					if (rmdm.CheckPassword(name, password))
					{

					}
				}


				DialogResult = DialogResult.OK;
			}
			catch (Exception err)
			{
				MessageBox.Show($"{err.Message}", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}




	}
}
