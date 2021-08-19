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

        List<Ability> abilities = new List<Ability>();
        List<ProgressBar> progressBars = new List<ProgressBar>();
        List<Label> labels = new List<Label>();

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
            int index = 0;
            int dy = 0;

            EpicToDo.Attribute atr = TK.StringToAttribute(comboBox1.SelectedItem.ToString());

            abilities = TK.GetAbillites(atr);

            ClearForm();

            foreach (var abil in abilities)
            {
                CreateAbilytyViev(index, 10, 10 + dy, abil);
                index++;
                dy += 30;
            }
        }

        private void CreateAbilytyViev(int number, int x, int y, Ability abil)
        {
            ProgressBar expanation = new ProgressBar();
            Label labelName = new Label();
            Label AbilityLvl = new Label();
            Label labelExponetion = new Label();
            //полоска опыта
            expanation.Location = new System.Drawing.Point(x + 50, y);
            expanation.Maximum = abil.MaxExp;
            expanation.Name = "progressBar" + number;
            expanation.Size = new System.Drawing.Size(200, 23);
            expanation.TabIndex = number;
            expanation.Value = abil.Exp;
            Controls.Add(expanation);
            progressBars.Add(expanation);

            //название навыка
            labelName.AutoSize = true;
            labelName.Location = new System.Drawing.Point(0, y);
            labelName.Name = "label"+number;
            labelName.Size = new System.Drawing.Size(25, 13);
            labelName.TabIndex = number;
            labelName.Text = abil.Name;
            Controls.Add(labelName);
            labels.Add(labelName);

            //уровень навыка навыка
            AbilityLvl.AutoSize = true;
            AbilityLvl.Location = new System.Drawing.Point(260, y+5);
            AbilityLvl.Name = "labelLvl" + number;
            AbilityLvl.Size = new System.Drawing.Size(25, 13);
            AbilityLvl.TabIndex = number;
            AbilityLvl.Text = $"Lvl: {abil.Level} | {abil.Exp}/{abil.MaxExp}";
            Controls.Add(AbilityLvl);
            labels.Add(AbilityLvl);

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        public void ClearForm()
        {
            foreach (var pb in progressBars)
            {
                Controls.Remove(pb);
            }
            foreach (var label in labels)
            {
                Controls.Remove(label);
            }
        }
    }
}
