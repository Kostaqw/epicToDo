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
    public partial class Character : Form
    {
        Form ParentForm;
        User User;
        UserController UC;
        public Character(Form parentForm, User user)
        {
            InitializeComponent();
            ParentForm = parentForm;
            User = user;
            UC = new UserController(User);
        }

        private void Character_Load(object sender, EventArgs e)
        {
            NameLabel.Text += User.Name;
            LvlLabel.Text += User.Level;
            if (User.photo == null)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Zver\source\repos\epicToDo\EpicUi\image\standAvatar.jpg"); //TODO: разобраться с относительным путем
            }
            else
            {
                pictureBox1.Image = UC.Download();
            }
        }



        private void сменитьАватарToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                UC.UploadImage((Bitmap)pictureBox1.Image);
            }
        }
    }
}
