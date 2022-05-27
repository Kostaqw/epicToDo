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
    public partial class DailyAdd : Form
    {
        private User User;
        private Form ParrentForm;
        private bool Edit = false;

        TaskController TC;
        public DailyAdd(User user, Form parrentForm, bool edit)
        {
            User = user;
            ParrentForm = parrentForm;
            Edit = edit;
            InitializeComponent();
            TC = new TaskController(user);
        }

        private void DailyAdd_Load(object sender, EventArgs e)
        {
            var abil = TC.GetAbillites();
            foreach (var item in abil)
            {
                AbiltyComboBox.Items.Add(item.Name);
            }
            DifficultComboBox.DataSource = Enum.GetValues(typeof(Dificults));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dificults dificults;
            bool[] dayOfweek = new bool[7];


            Enum.TryParse(AbiltyComboBox.SelectedItem.ToString(), out dificults);

            foreach (CheckBox checkBox in Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked == true)
                    dayOfweek[Convert.ToInt32(checkBox.Tag)] = true;
            }

            Daily daily = new Daily(textBox1.Text, textBox2.Text, dificults, dayOfweek, User, DifficultComboBox.SelectedItem.ToString());
            TC.DailyAdd(daily);
        }
    }
}
