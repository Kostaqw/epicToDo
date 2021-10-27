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
        public Task Task;
        private MainForm MainForm;
        private TaskController TK;

        public bool edit = false;
        public TaskAdd(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
        }

        public TaskAdd(MainForm form, Task task):this(form)
        {
            Task = task ?? throw new ArgumentNullException("task не может быть равен null",nameof(task));
        }

        private void TaskAdd_Load(object sender, EventArgs e)
        {

            TK = new TaskController(user);
            var abil = TK.GetAbillites();
            foreach (var item in abil)
            {
                comboBox1.Items.Add(item.Name);
            }

            comboBox2.DataSource = Enum.GetValues(typeof(Dificults));

            if (edit)
            {
                textBox1.Text = Task.Name;
                textBox2.Text = Task.Description;
                comboBox2.SelectedItem = Task.Dificult;
                comboBox1.SelectedItem = Task.Ability;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string description = textBox2.Text;
            string ablity = null;
            
            if (comboBox1.SelectedItem != null)
            {
                ablity = comboBox1.SelectedItem.ToString();
            }

            Dificults dificult;
            switch (comboBox2.SelectedIndex)
            {
                case 0: { dificult = Dificults.Легкий; break; }
                case 1: { dificult = Dificults.Средний; break; }
                case 2: { dificult = Dificults.Сложный; break; }
                case 3: { dificult = Dificults.Легендарный; break; }
                default: { dificult = Dificults.Легкий; break; }
            }

            if (!edit)
            {
                TK.TaskAdd(name, description, ablity, dificult, user.UserId);
                MessageBox.Show($"Задание: {name} было успешно добавлено");
            }
            else
            {
                TK.EditTask(Task, name, description, ablity, dificult);
                MessageBox.Show($"Задание: {name} было успешно изменено");
            }
        }

        private void TaskAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.UpdateTaskTable();
        }
    }
}
