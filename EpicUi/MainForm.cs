using BLEpicToDo.controller;
using EpicToDo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace EpicUi
{
    public partial class MainForm : Form
    {
        private List<Task> Tasks = new List<Task>();

        public User user;
        
        TaskController TC;
        Task CurrentTask;
        string CurrentTaskName;

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TC = new TaskController(user);
            UpdateTaskTable();
        }

        private void BAddTask_Click(object sender, EventArgs e)
        {
            TaskAdd taskAdd = new TaskAdd(this);
            taskAdd.user = user;
            taskAdd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abylites abyl = new Abylites();
            abyl.User = user;
            abyl.ShowDialog();
        }

        private void BEditTask_Click(object sender, EventArgs e)
        {
            if (CurrentTask != null)
            {
                TaskAdd taskAdd = new TaskAdd(this, CurrentTask);
                taskAdd.user = user;
                taskAdd.edit = true;
                taskAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не выбрано ни одно задание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            CurrentTaskName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CurrentTask = TC.FindTask(CurrentTaskName);
        }

        public void UpdateTaskTable()
        {
            dataGridView1.Rows.Clear();
            Tasks = TC.GetTasks();
            if (Tasks.Count != 0)
            {
                foreach (var task in Tasks)
                {
                    if (task.complite == false)
                    {
                        dataGridView1.Rows.Add(task.Name, task.Description, task.Dificult, task.Ability.ToString());
                    }
                }
                CurrentTaskName = Tasks[0].Name;
            }
        }

        private void BCompleteTask_Click(object sender, EventArgs e)
        {
            if (CurrentTask != null)
            {
                TC.EditTask(CurrentTask, true);
                UpdateTaskTable();
            }
            else
            {
                MessageBox.Show("Не выбрано ни одно задание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BDeleteTask_Click(object sender, EventArgs e)
        {
            if (CurrentTask != null)
            {
                DialogResult result = MessageBox.Show($"Вы хотите удалить задание {CurrentTask.Name}?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    TC.DeleteTask(CurrentTask);
                    UpdateTaskTable();
                }
            }
            else
            {
                MessageBox.Show("Не выбрано ни одно задание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
