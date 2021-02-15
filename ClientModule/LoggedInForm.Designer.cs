
namespace ClientModule
{
    partial class LoggedInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggedInForm));
            this.helloLabel = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settings = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.orderDetailsLabel = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.orderDetails = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helloLabel.Location = new System.Drawing.Point(237, 31);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(86, 31);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "Name";
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 123);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(330, 361);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Orders history:";
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create.Location = new System.Drawing.Point(473, 443);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(210, 41);
            this.create.TabIndex = 7;
            this.create.Text = "Create new order";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(609, 56);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(45, 24);
            this.time.TabIndex = 9;
            this.time.Text = "time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.helloLabel);
            this.groupBox1.Controls.Add(this.time);
            this.groupBox1.Controls.Add(this.settings);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 92);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // settings
            // 
            this.settings.BackgroundImage = global::ClientModule.Properties.Resources.settings_min_min1;
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settings.Location = new System.Drawing.Point(757, 12);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(37, 36);
            this.settings.TabIndex = 8;
            this.settings.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // orderDetailsLabel
            // 
            this.orderDetailsLabel.AutoSize = true;
            this.orderDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDetailsLabel.Location = new System.Drawing.Point(512, 95);
            this.orderDetailsLabel.Name = "orderDetailsLabel";
            this.orderDetailsLabel.Size = new System.Drawing.Size(141, 25);
            this.orderDetailsLabel.TabIndex = 12;
            this.orderDetailsLabel.Text = "Order details:";
            // 
            // picture
            // 
            this.picture.Image = global::ClientModule.Properties.Resources.happyyyyPC;
            this.picture.Location = new System.Drawing.Point(349, 123);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(438, 314);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 13;
            this.picture.TabStop = false;
            // 
            // orderDetails
            // 
            this.orderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDetails.Location = new System.Drawing.Point(351, 123);
            this.orderDetails.Multiline = true;
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.Size = new System.Drawing.Size(439, 314);
            this.orderDetails.TabIndex = 14;
            // 
            // LoggedInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.orderDetails);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.orderDetailsLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoggedInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logged client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoggedInForm_FormClosing);
            this.Load += new System.EventHandler(this.LoggedInForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label orderDetailsLabel;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox orderDetails;
    }
}