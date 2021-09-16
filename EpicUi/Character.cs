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
    public partial class Character : Form
    {
        Form ParentForm;
        User User;
        public Character(Form parentForm, User user)
        {
            InitializeComponent();
            ParentForm = parentForm;
            User = user;
        }

        private void Character_Load(object sender, EventArgs e)
        {
            NameLabel.Text += User.Name;
            LvlLabel.Text += User.Level;
        }
    }
}
