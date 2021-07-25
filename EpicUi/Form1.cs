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
    public partial class Form1 : Form
    {
        private User cUser;
        ControllerAutorize CA = new ControllerAutorize();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login, password;
            login = textBox1.Text;
            password = textBox2.Text;
            try
            {
                cUser = CA.LogIn(login, password);
                MainForm mainForm = new MainForm();

                if (cUser == null)
                    throw new NullReferenceException("Пользователь не найден");

                mainForm.user = cUser;
                mainForm.Show();
                this.Hide();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }
    }
}
