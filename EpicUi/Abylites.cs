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
    public partial class Abylites : Form
    {
        public User User;
        TaskController TK;
        public Abylites()
        {
            InitializeComponent();
        }

        private void Abylites_Load(object sender, EventArgs e)
        {
            TK = new TaskController(User);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbylitesAdd AbAdd = new AbylitesAdd();
            AbAdd.user = User;
            AbAdd.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Ability> abilities = new List<Ability>();
            List<ProgressBar> progressBars = new List<ProgressBar>();
            List<Label> labels = new List<Label>();


            abilities = TK.GetAbillites();
            CreateAbilytyViev(1, 10, 10);
            foreach (var abil in abilities)
            {

            }

   
        }

        private void CreateAbilytyViev(int number, int x, int y)
        {
            ProgressBar expanation = new ProgressBar();

            expanation.Location = new System.Drawing.Point(x + 250, y);
            expanation.Maximum = 100;
            expanation.Name = "progressBar" + number;
            expanation.Size = new System.Drawing.Size(100, 23);
            expanation.TabIndex = number;
            expanation.Value = 0;
        }
    }
}
