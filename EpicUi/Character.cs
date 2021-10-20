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
            LoadInfo();
        }



        private void сменитьАватарToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                UC.UploadImage((Bitmap)pictureBox1.Image);
            }
        }

        private void LoadInfo()
        {
            NameLabel.Text = $"Имя: {User.Name}";
            AgeLabel.Text = $"Возраст: {User.Age}";
            LvlLabel.Text = $"Уровень: {User.Level}";
            ExpLabel.Text = $"Опыт: {User.Exp} / {User.MaxExp}";
            StrengthLabel.Text = $"Сила: {User.Strength}";
            IntelectLabel.Text = $"Интилект: {User.Intelect}";
            CreativeLabel.Text = $"Творчество: {User.Creative}";
            HealthLabel.Text = $"Здоровье: {User.Health}";

            ExpBar.Maximum = User.MaxExp;
            ExpBar.Value = User.Exp;

            StrengthBar.Maximum = User.MaxStrengthExp;
            StrengthBar.Value = User.StrengthExp;

            IntelectBar.Maximum = User.MaxIntelExp;
            IntelectBar.Value = User.IntelExp;

            CreativeBar.Maximum = User.MaxCreativeExp;
            CreativeBar.Value = User.CreativeExp;

            HealthBar.Maximum = User.MaxHealthExp;
            HealthBar.Value = User.HealthExp;
        }
    }
}
