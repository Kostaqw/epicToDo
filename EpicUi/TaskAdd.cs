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
    public partial class TaskAdd : Form
    {
        public User user;
        public Task task;
        private MainForm MainForm;
        private TaskController TK;

        public bool edit = false;
        public TaskAdd(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void TaskAdd_Load(object sender, EventArgs e)
        {

            TK = new TaskController(user);
            var abil = TK.GetAbillites();
            foreach (var item in abil)
            {
                comboBox1.Items.Add(item.Name);
            }
            comboBox2.Items.Add("Легкий");
            comboBox2.Items.Add("Средний");
            comboBox2.Items.Add("Тяжелый");
            comboBox2.Items.Add("Легендарный");
            if (edit)
            {
                textBox1.Text = task.Name;
                textBox2.Text = task.Description;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                string name = textBox1.Text;
                string description = textBox2.Text;
                string ablity = comboBox1.SelectedItem.ToString();
                Dificults dificult;
                switch (comboBox2.SelectedIndex)
                {
                    case 0: { dificult = Dificults.easy; break; }
                    case 1: { dificult = Dificults.midle; break; }
                    case 2: { dificult = Dificults.hard; break; }
                    case 3: { dificult = Dificults.legendary; break; }
                    default: { dificult = Dificults.easy; break; }
                }

                TK.TaskAdd(name, description, ablity, dificult, user.UserId);
                MessageBox.Show($"Задание: {name} было успешно добавлено");
            }
        }

        private void TaskAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.UpdateTaskTable();
        }
    }
}
