
namespace ClientModule
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.apartment = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.city = new System.Windows.Forms.ComboBox();
            this.show = new System.Windows.Forms.CheckBox();
            this.block = new System.Windows.Forms.ComboBox();
            this.level = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(149, 547);
            this.create.Margin = new System.Windows.Forms.Padding(6);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(224, 53);
            this.create.TabIndex = 0;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unique ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Street:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Number of block:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Number of apartment:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(48, 254);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(133, 29);
            this.name.TabIndex = 12;
            this.name.Click += new System.EventHandler(this.name_Click);
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(359, 254);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(133, 29);
            this.patronymic.TabIndex = 13;
            this.patronymic.Click += new System.EventHandler(this.patronymic_Click);
            this.patronymic.TextChanged += new System.EventHandler(this.patronymic_TextChanged);
            this.patronymic.Leave += new System.EventHandler(this.patronymic_Leave);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(206, 254);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(133, 29);
            this.surname.TabIndex = 14;
            this.surname.Click += new System.EventHandler(this.surname_Click);
            this.surname.TextChanged += new System.EventHandler(this.surname_TextChanged);
            this.surname.Leave += new System.EventHandler(this.surname_Leave);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(245, 299);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(62, 29);
            this.age.TabIndex = 16;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(245, 379);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(121, 29);
            this.street.TabIndex = 17;
            // 
            // apartment
            // 
            this.apartment.Location = new System.Drawing.Point(245, 451);
            this.apartment.Name = "apartment";
            this.apartment.Size = new System.Drawing.Size(75, 29);
            this.apartment.TabIndex = 19;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(245, 486);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(181, 29);
            this.password.TabIndex = 20;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "years";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientModule.Properties.Resources.clientImageIco;
            this.pictureBox1.Location = new System.Drawing.Point(171, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // city
            // 
            this.city.FormattingEnabled = true;
            this.city.Items.AddRange(new object[] {
            "Kyiv",
            "Kharkov",
            "Lviv",
            "Ternopil",
            "Odessa"});
            this.city.Location = new System.Drawing.Point(245, 339);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(121, 32);
            this.city.TabIndex = 23;
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show.Location = new System.Drawing.Point(245, 521);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(60, 20);
            this.show.TabIndex = 24;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.CheckedChanged += new System.EventHandler(this.show_CheckedChanged);
            // 
            // block
            // 
            this.block.FormattingEnabled = true;
            this.block.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.block.Location = new System.Drawing.Point(245, 414);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(75, 32);
            this.block.TabIndex = 25;
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(442, 491);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(0, 24);
            this.level.TabIndex = 26;
            // 
            // id
            // 
            this.id.ForeColor = System.Drawing.Color.Red;
            this.id.Location = new System.Drawing.Point(206, 207);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(133, 29);
            this.id.TabIndex = 27;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(397, 347);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 24);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "no city?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 615);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.level);
            this.Controls.Add(this.block);
            this.Controls.Add(this.show);
            this.Controls.Add(this.city);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.password);
            this.Controls.Add(this.apartment);
            this.Controls.Add(this.street);
            this.Controls.Add(this.age);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.Shown += new System.EventHandler(this.SignUpForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox apartment;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.CheckBox show;
        private System.Windows.Forms.ComboBox block;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}