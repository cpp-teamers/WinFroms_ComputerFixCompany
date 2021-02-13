﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RepairManModule.Helpers;
using LibraryExceptions;

namespace RepairManModule
{
	public partial class AuthorizationForm : Form
	{
		RepairManDataManager rmdm;
		public int Count_of_attempts { get; set; }


		public AuthorizationForm()
		{
			InitializeComponent();
			rmdm = new RepairManDataManager();
			Count_of_attempts = 3;
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
			catch (PasswordException pass_err)
			{
				--Count_of_attempts;

				MessageBox.Show($"{pass_err.Message}. You've got {Count_of_attempts} shots",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
				ClearFields();
			}
			catch (Exception err)
			{
				MessageBox.Show($"{err.Message}", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				if (Count_of_attempts == 0)
				{
					DialogResult = DialogResult.Abort;
				}
			}
			
			
		}

		void ClearFields()
		{
			AuthNameField.Clear();
			AuthPasswordField.Clear();
		}


	}
}
