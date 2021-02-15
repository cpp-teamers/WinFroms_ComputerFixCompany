
namespace ManagerModule
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.repairManList = new System.Windows.Forms.ComboBox();
            this.ordersList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeOrderField = new System.Windows.Forms.TextBox();
            this.deadLineField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.expField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rateField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.surNameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.patronomicField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.distributeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.patronomicField);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.surNameField);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nameField);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rateField);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.expField);
            this.groupBox1.Controls.Add(this.repairManList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RepairMan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.descriptionField);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.deadLineField);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.typeOrderField);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ordersList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(477, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 403);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NotDistributedOrders";
            // 
            // repairManList
            // 
            this.repairManList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.repairManList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repairManList.FormattingEnabled = true;
            this.repairManList.Location = new System.Drawing.Point(12, 19);
            this.repairManList.Name = "repairManList";
            this.repairManList.Size = new System.Drawing.Size(235, 33);
            this.repairManList.TabIndex = 2;
            this.repairManList.SelectedIndexChanged += new System.EventHandler(this.repairManList_SelectedIndexChanged);
            // 
            // ordersList
            // 
            this.ordersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ordersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersList.FormattingEnabled = true;
            this.ordersList.Location = new System.Drawing.Point(14, 19);
            this.ordersList.Name = "ordersList";
            this.ordersList.Size = new System.Drawing.Size(235, 33);
            this.ordersList.TabIndex = 3;
            this.ordersList.SelectedIndexChanged += new System.EventHandler(this.ordersList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type:";
            // 
            // typeOrderField
            // 
            this.typeOrderField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOrderField.Location = new System.Drawing.Point(14, 84);
            this.typeOrderField.Name = "typeOrderField";
            this.typeOrderField.ReadOnly = true;
            this.typeOrderField.Size = new System.Drawing.Size(235, 31);
            this.typeOrderField.TabIndex = 5;
            // 
            // deadLineField
            // 
            this.deadLineField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deadLineField.Location = new System.Drawing.Point(14, 155);
            this.deadLineField.Name = "deadLineField";
            this.deadLineField.ReadOnly = true;
            this.deadLineField.Size = new System.Drawing.Size(235, 31);
            this.deadLineField.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "DeadLine:";
            // 
            // descriptionField
            // 
            this.descriptionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionField.Location = new System.Drawing.Point(15, 224);
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.ReadOnly = true;
            this.descriptionField.Size = new System.Drawing.Size(235, 173);
            this.descriptionField.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description:";
            // 
            // expField
            // 
            this.expField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expField.Location = new System.Drawing.Point(12, 295);
            this.expField.Name = "expField";
            this.expField.ReadOnly = true;
            this.expField.Size = new System.Drawing.Size(235, 31);
            this.expField.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Expierence:";
            // 
            // rateField
            // 
            this.rateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateField.Location = new System.Drawing.Point(12, 366);
            this.rateField.Name = "rateField";
            this.rateField.ReadOnly = true;
            this.rateField.Size = new System.Drawing.Size(235, 31);
            this.rateField.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rate:";
            // 
            // surNameField
            // 
            this.surNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surNameField.Location = new System.Drawing.Point(12, 155);
            this.surNameField.Name = "surNameField";
            this.surNameField.ReadOnly = true;
            this.surNameField.Size = new System.Drawing.Size(235, 31);
            this.surNameField.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "SurName:";
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.Location = new System.Drawing.Point(12, 84);
            this.nameField.Name = "nameField";
            this.nameField.ReadOnly = true;
            this.nameField.Size = new System.Drawing.Size(235, 31);
            this.nameField.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name:";
            // 
            // patronomicField
            // 
            this.patronomicField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronomicField.Location = new System.Drawing.Point(12, 224);
            this.patronomicField.Name = "patronomicField";
            this.patronomicField.ReadOnly = true;
            this.patronomicField.Size = new System.Drawing.Size(235, 31);
            this.patronomicField.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Patronymic:";
            // 
            // distributeButton
            // 
            this.distributeButton.Enabled = false;
            this.distributeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distributeButton.Location = new System.Drawing.Point(264, 306);
            this.distributeButton.Name = "distributeButton";
            this.distributeButton.Size = new System.Drawing.Size(207, 91);
            this.distributeButton.TabIndex = 2;
            this.distributeButton.Text = "Distribute";
            this.distributeButton.UseVisualStyleBackColor = true;
            this.distributeButton.Click += new System.EventHandler(this.distributeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManagerModule.Properties.Resources.Manager;
            this.pictureBox1.Location = new System.Drawing.Point(264, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(293, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 33);
            this.label9.TabIndex = 4;
            this.label9.Text = "Happy PC";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(738, 403);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.distributeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Manager Module";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ordersList;
        private System.Windows.Forms.ComboBox repairManList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deadLineField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeOrderField;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patronomicField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox surNameField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rateField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox expField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button distributeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
    }
}