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
        public User user = new User();
        public TaskAdd()
        {
            InitializeComponent();
        }

        private void TaskAdd_Load(object sender, EventArgs e)
        {
            foreach (var item in user.Abilities)
            {
                comboBox1.Items.Add(item.Name);
            }
            comboBox2.Items.Add("Легкий");
            comboBox2.Items.Add("Средний");
            comboBox2.Items.Add("Тяжелый");
            comboBox2.Items.Add("Легендарный");
        }
    }
}
