
namespace ClientModule
{
    partial class LogInForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.logIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.show = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // logIn
            // 
            this.logIn.Location = new System.Drawing.Point(40, 168);
            this.logIn.Margin = new System.Windows.Forms.Padding(6);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(384, 32);
            this.logIn.TabIndex = 0;
            this.logIn.Text = "Sign in";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(180, 34);
            this.id.Margin = new System.Windows.Forms.Padding(6);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(208, 29);
            this.id.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(180, 79);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(6);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(208, 29);
            this.passwordBox.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show.Location = new System.Drawing.Point(180, 117);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(60, 20);
            this.show.TabIndex = 6;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.CheckedChanged += new System.EventHandler(this.show_CheckedChanged);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 230);
            this.Controls.Add(this.show);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logIn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox show;
    }
}