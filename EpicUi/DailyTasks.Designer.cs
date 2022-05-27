
namespace EpicUi
{
    partial class DailyTasks
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
            this.NameTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbilityTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttributeTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeletteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTask,
            this.DescriptionTask,
            this.DifficultTask,
            this.AbilityTask,
            this.AttributeTask});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SizeChanged += new System.EventHandler(this.dataGridView1_SizeChanged);
            // 
            // NameTask
            // 
            this.NameTask.HeaderText = "Название";
            this.NameTask.Name = "NameTask";
            // 
            // DescriptionTask
            // 
            this.DescriptionTask.HeaderText = "Описание";
            this.DescriptionTask.Name = "DescriptionTask";
            // 
            // DifficultTask
            // 
            this.DifficultTask.HeaderText = "Сложность";
            this.DifficultTask.Name = "DifficultTask";
            // 
            // AbilityTask
            // 
            this.AbilityTask.HeaderText = "Способность";
            this.AbilityTask.Name = "AbilityTask";
            // 
            // AttributeTask
            // 
            this.AttributeTask.HeaderText = "Атрибут";
            this.AttributeTask.Name = "AttributeTask";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeletteButton);
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(588, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление задачами";
            // 
            // DeletteButton
            // 
            this.DeletteButton.Location = new System.Drawing.Point(6, 77);
            this.DeletteButton.Name = "DeletteButton";
            this.DeletteButton.Size = new System.Drawing.Size(188, 23);
            this.DeletteButton.TabIndex = 4;
            this.DeletteButton.Text = "Удалить";
            this.DeletteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(6, 48);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(188, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 19);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(188, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DailyTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DailyTasks";
            this.Text = "DailyTasks";
            this.Load += new System.EventHandler(this.DailyTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbilityTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttributeTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeletteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
    }
}