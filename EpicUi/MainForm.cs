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

        string CurrentTaskName;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TC = new TaskController(user);
            Tasks = TC.GetTasks();
            if (Tasks.Count != 0)
            {
                foreach (var task in Tasks)
                {
                    dataGridView1.Rows.Add(task.Name, task.Description, task.Dificult, task.Ability.ToString());
                }
            }
            if (dataGridView1.Rows.Count != 0)
            {
                string currentRow = dataGridView1.SelectedRows[0].ge
                MessageBox.Show(currentRow);
                
            }
        }



        private void BAddTask_Click(object sender, EventArgs e)
        {
            TaskAdd taskAdd = new TaskAdd();
            taskAdd.user = user;
            taskAdd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abylites abyl = new Abylites();
            abyl.User = user;
            abyl.Show();
        }

        private void BEditTask_Click(object sender, EventArgs e)
        {
            TaskAdd taskAdd = new TaskAdd();
            taskAdd.user = user;
            taskAdd.edit = true;
            taskAdd.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
