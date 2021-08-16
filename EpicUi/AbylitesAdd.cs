using BLEpicToDo.controller;
using EpicToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EpicUi
{
    public partial class AbylitesAdd : Form
    {
        public User user;
        TaskController TK;
        public AbylitesAdd()
        {
            InitializeComponent();           
        }
        private void AbylitesAdd_Load(object sender, EventArgs e)
        {
            TK = new TaskController(user);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string name;
            EpicToDo.Attribute attribute;
            name = textBox1.Text;
            attribute = TK.StringToAttribute(comboBox1.SelectedItem.ToString());
            Ability abil = new Ability(name, attribute, user);

            if (TK.AddAbility(abil))
            {
                MessageBox.Show($"Способность {name} с атрибутом {attribute} была добавлена", "успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Не удалось добавить способность", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

  
    }
}
