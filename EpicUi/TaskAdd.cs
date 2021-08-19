using BLEpicToDo.controller;
using EpicToDo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicUi
{
    public partial class TaskAdd : Form
    {
        public User user;

        private TaskController TK;
        public TaskAdd()
        {
            InitializeComponent();
           
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
        }

        private void button1_Click(object sender, EventArgs e)
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
        }
    }
}
