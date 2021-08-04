namespace EpicUi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskDificult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControllTasks = new System.Windows.Forms.GroupBox();
            this.BCompleteTask = new System.Windows.Forms.Button();
            this.BEditTask = new System.Windows.Forms.Button();
            this.BDeleteTask = new System.Windows.Forms.Button();
            this.BAddTask = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ControllTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.TaskDescription,
            this.TaskDificult});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 424);
            this.dataGridView1.TabIndex = 0;
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Название";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // TaskDescription
            // 
            this.TaskDescription.HeaderText = "Описание";
            this.TaskDescription.Name = "TaskDescription";
            this.TaskDescription.ReadOnly = true;
            // 
            // TaskDificult
            // 
            this.TaskDificult.HeaderText = "Сложность";
            this.TaskDificult.Name = "TaskDificult";
            this.TaskDificult.ReadOnly = true;
            // 
            // ControllTasks
            // 
            this.ControllTasks.Controls.Add(this.BCompleteTask);
            this.ControllTasks.Controls.Add(this.BEditTask);
            this.ControllTasks.Controls.Add(this.BDeleteTask);
            this.ControllTasks.Controls.Add(this.BAddTask);
            this.ControllTasks.Location = new System.Drawing.Point(369, 12);
            this.ControllTasks.Name = "ControllTasks";
            this.ControllTasks.Size = new System.Drawing.Size(157, 136);
            this.ControllTasks.TabIndex = 1;
            this.ControllTasks.TabStop = false;
            this.ControllTasks.Text = "Управление задачами";
            // 
            // BCompleteTask
            // 
            this.BCompleteTask.Location = new System.Drawing.Point(6, 77);
            this.BCompleteTask.Name = "BCompleteTask";
            this.BCompleteTask.Size = new System.Drawing.Size(145, 23);
            this.BCompleteTask.TabIndex = 3;
            this.BCompleteTask.Text = "Выполнено";
            this.BCompleteTask.UseVisualStyleBackColor = true;
            // 
            // BEditTask
            // 
            this.BEditTask.Location = new System.Drawing.Point(6, 48);
            this.BEditTask.Name = "BEditTask";
            this.BEditTask.Size = new System.Drawing.Size(145, 23);
            this.BEditTask.TabIndex = 2;
            this.BEditTask.Text = "Редактировать";
            this.BEditTask.UseVisualStyleBackColor = true;
            // 
            // BDeleteTask
            // 
            this.BDeleteTask.Location = new System.Drawing.Point(6, 106);
            this.BDeleteTask.Name = "BDeleteTask";
            this.BDeleteTask.Size = new System.Drawing.Size(145, 23);
            this.BDeleteTask.TabIndex = 1;
            this.BDeleteTask.Text = "Удалить";
            this.BDeleteTask.UseVisualStyleBackColor = true;
            // 
            // BAddTask
            // 
            this.BAddTask.Location = new System.Drawing.Point(6, 19);
            this.BAddTask.Name = "BAddTask";
            this.BAddTask.Size = new System.Drawing.Size(145, 23);
            this.BAddTask.TabIndex = 0;
            this.BAddTask.Text = "Добавить";
            this.BAddTask.UseVisualStyleBackColor = true;
            this.BAddTask.Click += new System.EventHandler(this.BAddTask_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Задачи",
            "Повторяющиеся задачи",
            "Выполненые задачи"});
            this.comboBox1.Location = new System.Drawing.Point(369, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.TabIndexChanged += new System.EventHandler(this.comboBox1_TabIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Навыки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ControllTasks);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Epic to do";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ControllTasks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox ControllTasks;
        private System.Windows.Forms.Button BCompleteTask;
        private System.Windows.Forms.Button BEditTask;
        private System.Windows.Forms.Button BDeleteTask;
        private System.Windows.Forms.Button BAddTask;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDificult;
        private System.Windows.Forms.Button button1;
    }
}