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
        
        public MainForm()
        {
            InitializeComponent();
            TC = new TaskController(user);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Tasks = TC.GetTasks();
            if (Tasks.Count != 0)
            { 
                
            }
        }

        private void comboBox1_TabIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.Columns.Add("TaskName", "Задание");
                dataGridView1.Columns.Add("TaskDescription", "Описание");
                dataGridView1.Columns.Add("TaskDificult", "Сложность");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.Columns.Add("TaskName", "Задание");
                dataGridView1.Columns.Add("TaskDescription", "Описание");
                dataGridView1.Columns.Add("TaskDificult", "Сложность");
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
    }
}
