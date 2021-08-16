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
            
            int index = 0;
            int dy = 0;

            EpicToDo.Attribute atr = TK.StringToAttribute(comboBox1.SelectedItem.ToString());
            

            abilities = TK.GetAbillites(atr);
            
            foreach (var abil in abilities)
            {
                this.Controls.Add(CreateAbilytyViev(index, 10, 10+dy));
                index++;
                dy += 20;
                
            }

   
        }

        private ProgressBar CreateAbilytyViev(int number, int x, int y)
        {
            ProgressBar expanation = new ProgressBar();

            expanation.Location = new System.Drawing.Point(x + 250, y);
            expanation.Maximum = 100;
            expanation.Name = "progressBar" + number;
            expanation.Size = new System.Drawing.Size(100, 23);
            expanation.TabIndex = number;
            expanation.Value = 0;

            return expanation;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
