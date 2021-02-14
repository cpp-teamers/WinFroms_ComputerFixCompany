
namespace RepairManModule
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.taskList = new System.Windows.Forms.ListBox();
			this.orderTypesBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.descriptionOfTask = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.actualityBox = new System.Windows.Forms.ComboBox();
			this.welcomeEmpLabel = new System.Windows.Forms.Label();
			this.MarkTasksProgress = new System.Windows.Forms.Button();
			this.InProcessRadioB = new System.Windows.Forms.RadioButton();
			this.readyRadioB = new System.Windows.Forms.RadioButton();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// taskList
			// 
			this.taskList.DisplayMember = "DeadLine";
			this.taskList.FormattingEnabled = true;
			resources.ApplyResources(this.taskList, "taskList");
			this.taskList.Name = "taskList";
			this.taskList.SelectedIndexChanged += new System.EventHandler(this.taskList_SelectedIndexChanged);
			// 
			// orderTypesBox
			// 
			this.orderTypesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.orderTypesBox.FormattingEnabled = true;
			resources.ApplyResources(this.orderTypesBox, "orderTypesBox");
			this.orderTypesBox.Name = "orderTypesBox";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// descriptionOfTask
			// 
			resources.ApplyResources(this.descriptionOfTask, "descriptionOfTask");
			this.descriptionOfTask.Name = "descriptionOfTask";
			this.descriptionOfTask.ReadOnly = true;
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// actualityBox
			// 
			this.actualityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.actualityBox.FormattingEnabled = true;
			resources.ApplyResources(this.actualityBox, "actualityBox");
			this.actualityBox.Name = "actualityBox";
			// 
			// welcomeEmpLabel
			// 
			resources.ApplyResources(this.welcomeEmpLabel, "welcomeEmpLabel");
			this.welcomeEmpLabel.Name = "welcomeEmpLabel";
			// 
			// MarkTasksProgress
			// 
			resources.ApplyResources(this.MarkTasksProgress, "MarkTasksProgress");
			this.MarkTasksProgress.Name = "MarkTasksProgress";
			this.MarkTasksProgress.UseVisualStyleBackColor = true;
			this.MarkTasksProgress.Click += new System.EventHandler(this.MarkTasksProgress_Click);
			// 
			// InProcessRadioB
			// 
			resources.ApplyResources(this.InProcessRadioB, "InProcessRadioB");
			this.InProcessRadioB.Name = "InProcessRadioB";
			this.InProcessRadioB.UseVisualStyleBackColor = true;
			this.InProcessRadioB.Click += new System.EventHandler(this.InProcessRadioB_Click);
			// 
			// readyRadioB
			// 
			resources.ApplyResources(this.readyRadioB, "readyRadioB");
			this.readyRadioB.Checked = true;
			this.readyRadioB.Name = "readyRadioB";
			this.readyRadioB.TabStop = true;
			this.readyRadioB.UseVisualStyleBackColor = true;
			this.readyRadioB.Click += new System.EventHandler(this.readyRadioB_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 3000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.InProcessRadioB);
			this.Controls.Add(this.readyRadioB);
			this.Controls.Add(this.MarkTasksProgress);
			this.Controls.Add(this.welcomeEmpLabel);
			this.Controls.Add(this.actualityBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.descriptionOfTask);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.orderTypesBox);
			this.Controls.Add(this.taskList);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox taskList;
		private System.Windows.Forms.ComboBox orderTypesBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox descriptionOfTask;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox actualityBox;
		private System.Windows.Forms.Label welcomeEmpLabel;
		private System.Windows.Forms.Button MarkTasksProgress;
		private System.Windows.Forms.RadioButton InProcessRadioB;
		private System.Windows.Forms.RadioButton readyRadioB;
		private System.Windows.Forms.Timer timer1;
	}
}

