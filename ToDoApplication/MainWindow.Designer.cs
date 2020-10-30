namespace ToDoApplication
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.lblTaskDesc = new System.Windows.Forms.Label();
            this.txtTaskDesc = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.lblTaskList = new System.Windows.Forms.Label();
            this.lstTasksBox = new System.Windows.Forms.ListBox();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnTaskTitleDel = new System.Windows.Forms.Button();
            this.btnReadTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(137, 29);
            this.lblTaskTitle.TabIndex = 0;
            this.lblTaskTitle.Text = "Task Title:";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(147, 13);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTaskTitle.TabIndex = 1;
            // 
            // lblTaskDesc
            // 
            this.lblTaskDesc.AutoSize = true;
            this.lblTaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDesc.Location = new System.Drawing.Point(12, 61);
            this.lblTaskDesc.Name = "lblTaskDesc";
            this.lblTaskDesc.Size = new System.Drawing.Size(217, 29);
            this.lblTaskDesc.TabIndex = 2;
            this.lblTaskDesc.Text = "Task Description:";
            // 
            // txtTaskDesc
            // 
            this.txtTaskDesc.Location = new System.Drawing.Point(17, 95);
            this.txtTaskDesc.Multiline = true;
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(230, 206);
            this.txtTaskDesc.TabIndex = 3;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(13, 307);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 4;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(94, 307);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 5;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Location = new System.Drawing.Point(175, 307);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTask.TabIndex = 6;
            this.btnUpdateTask.Text = "Update";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // lblTaskList
            // 
            this.lblTaskList.AutoSize = true;
            this.lblTaskList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskList.Location = new System.Drawing.Point(471, 9);
            this.lblTaskList.Name = "lblTaskList";
            this.lblTaskList.Size = new System.Drawing.Size(90, 29);
            this.lblTaskList.TabIndex = 8;
            this.lblTaskList.Text = "Tasks:";
            // 
            // lstTasksBox
            // 
            this.lstTasksBox.FormattingEnabled = true;
            this.lstTasksBox.Location = new System.Drawing.Point(476, 61);
            this.lstTasksBox.Name = "lstTasksBox";
            this.lstTasksBox.Size = new System.Drawing.Size(312, 368);
            this.lstTasksBox.TabIndex = 9;
            this.lstTasksBox.SelectedIndexChanged += new System.EventHandler(this.lstTasksBox_SelectedIndexChanged);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(58, 336);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(75, 23);
            this.btnEditTask.TabIndex = 10;
            this.btnEditTask.Text = "Edit";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnTaskTitleDel
            // 
            this.btnTaskTitleDel.Location = new System.Drawing.Point(253, 11);
            this.btnTaskTitleDel.Name = "btnTaskTitleDel";
            this.btnTaskTitleDel.Size = new System.Drawing.Size(30, 23);
            this.btnTaskTitleDel.TabIndex = 11;
            this.btnTaskTitleDel.Text = "X";
            this.btnTaskTitleDel.UseVisualStyleBackColor = true;
            this.btnTaskTitleDel.Click += new System.EventHandler(this.btnTaskTitleDel_Click);
            // 
            // btnReadTask
            // 
            this.btnReadTask.Location = new System.Drawing.Point(139, 336);
            this.btnReadTask.Name = "btnReadTask";
            this.btnReadTask.Size = new System.Drawing.Size(75, 23);
            this.btnReadTask.TabIndex = 12;
            this.btnReadTask.Text = "Read";
            this.btnReadTask.UseVisualStyleBackColor = true;
            this.btnReadTask.Click += new System.EventHandler(this.btnReadTask_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReadTask);
            this.Controls.Add(this.btnTaskTitleDel);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.lstTasksBox);
            this.Controls.Add(this.lblTaskList);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtTaskDesc);
            this.Controls.Add(this.lblTaskDesc);
            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.lblTaskTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "ToDoApp";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Label lblTaskDesc;
        private System.Windows.Forms.TextBox txtTaskDesc;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.Label lblTaskList;
        private System.Windows.Forms.ListBox lstTasksBox;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnTaskTitleDel;
        private System.Windows.Forms.Button btnReadTask;
    }
}

