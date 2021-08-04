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
        public Abylites()
        {
            InitializeComponent();
        }

        private void Abylites_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbylitesAdd AbAdd = new AbylitesAdd();
            AbAdd.user = User;
            AbAdd.Show();
        }
    }
}
