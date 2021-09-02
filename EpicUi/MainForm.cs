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
            TaskAdd taskAdd = new TaskAdd(this, CurrentTask);
            taskAdd.user = user;
            taskAdd.edit = true;
            taskAdd.ShowDialog();
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
                    dataGridView1.Rows.Add(task.Name, task.Description, task.Dificult, task.Ability.ToString());
                }
                CurrentTaskName = Tasks[0].Name;
            }
        }
    }
}
