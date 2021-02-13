
namespace RepairManModule
{
	partial class AuthorizationForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
			this.LogInOkButton = new System.Windows.Forms.Button();
			this.AuthNameField = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.AuthPasswordField = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// LogInOkButton
			// 
			this.LogInOkButton.Location = new System.Drawing.Point(302, 91);
			this.LogInOkButton.Margin = new System.Windows.Forms.Padding(7);
			this.LogInOkButton.Name = "LogInOkButton";
			this.LogInOkButton.Size = new System.Drawing.Size(128, 46);
			this.LogInOkButton.TabIndex = 0;
			this.LogInOkButton.Text = "Ok";
			this.LogInOkButton.UseVisualStyleBackColor = true;
			this.LogInOkButton.Click += new System.EventHandler(this.LogInOkButton_Click);
			// 
			// AuthNameField
			// 
			this.AuthNameField.ForeColor = System.Drawing.Color.Gainsboro;
			this.AuthNameField.Location = new System.Drawing.Point(34, 61);
			this.AuthNameField.Name = "AuthNameField";
			this.AuthNameField.Size = new System.Drawing.Size(220, 35);
			this.AuthNameField.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Your name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password:";
			// 
			// AuthPasswordField
			// 
			this.AuthPasswordField.ForeColor = System.Drawing.Color.Gainsboro;
			this.AuthPasswordField.Location = new System.Drawing.Point(34, 140);
			this.AuthPasswordField.Name = "AuthPasswordField";
			this.AuthPasswordField.Size = new System.Drawing.Size(220, 35);
			this.AuthPasswordField.TabIndex = 3;
			// 
			// AuthorizationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 208);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AuthPasswordField);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AuthNameField);
			this.Controls.Add(this.LogInOkButton);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(7);
			this.MaximizeBox = false;
			this.Name = "AuthorizationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Authorization";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button LogInOkButton;
		private System.Windows.Forms.TextBox AuthNameField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox AuthPasswordField;
	}
}