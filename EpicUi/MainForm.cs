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
        UserController UC;
        Task CurrentTask;
        string CurrentTaskName;

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TC = new TaskController(user);
            UC = new UserController(user);
            UC.newLvl += NewLwl;
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
                        //TODO: Придумать что получше
                        if (task.Ability == null)
                            task.Ability = "";
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

                CompleteTask();
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

        private void CompleteTask()
        {
            TC.EditTask(CurrentTask, true);
            UC.AddExpUser((int)CurrentTask.Dificult);

            if (CurrentTask.Ability != null)
            {
                Ability abil = UC.FindAbility(CurrentTask.Ability);
                UC.AddExpAbility((int)CurrentTask.Dificult / 2, abil);

                switch (abil.attribute)
                {
                    case EpicToDo.Attribute.Intelect:
                        {
                            UC.AddExpAttribut((int)CurrentTask.Dificult / 50, EpicToDo.Attribute.Intelect);
                            break;
                        }
                    case EpicToDo.Attribute.Strength:
                        {
                            UC.AddExpAttribut((int)CurrentTask.Dificult / 50, EpicToDo.Attribute.Strength);
                            break;
                        }
                    case EpicToDo.Attribute.Health:
                        {
                            UC.AddExpAttribut((int)CurrentTask.Dificult / 50, EpicToDo.Attribute.Health);
                            break;
                        }
                    case EpicToDo.Attribute.Creative:
                        {
                            UC.AddExpAttribut((int)CurrentTask.Dificult / 50, EpicToDo.Attribute.Creative);
                            break;
                        }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Character charForm = new Character(this, user);
            charForm.ShowDialog();
        }

        private void NewLwl(BLEpicToDo.controller.Action action, string message)
        {
            MessageBox.Show("Поздравляю новый уровень");
        }


    }
}
