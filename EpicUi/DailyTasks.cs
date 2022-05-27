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
    public partial class DailyTasks : Form
    {
        private List<Daily> Dailies = new List<Daily>();
        TaskController TC;
        UserController UC;
        Daily CurrentDaily;
        string CurrentDailyName;

        private User User;
        private Form ParrentForm;
 

        public DailyTasks(User user, Form parrentForm)
        {

            InitializeComponent();
            User = user;
            ParrentForm = parrentForm;
            TC = new TaskController(user);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DailyAdd dailyAdd = new DailyAdd(User, this, false);
            dailyAdd.ShowDialog();
        }

        public void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            Dailies = TC.GetDailys();
            if (Dailies.Count != 0)
            {
                foreach (var daily in Dailies)
                {
                    if (daily.complete == false)
                    {
                        //TODO: Придумать что получше
                        if (daily.Ability == null)
                            daily.Ability = "";
                        dataGridView1.Rows.Add(daily.Name, daily.Description, daily.Dificult, daily.Ability.ToString());
                    }
                }
                CurrentDailyName = Dailies[0].Name;
            }

        }

        private void DailyTasks_Load(object sender, EventArgs e)
        {
            UC = new UserController(User);
            UpdateTable();
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            CurrentDailyName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CurrentDaily = TC.FindDaily(CurrentDailyName);
        }
    }
}
