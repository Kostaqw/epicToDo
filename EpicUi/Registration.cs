using BLEpicToDo.controller;
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
    public partial class Registration : Form
    {
        ControllerAutorize AC = new ControllerAutorize();
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Проверка на корректность
            string login, password;
            int age = Convert.ToByte(textBox3.Text);

            login = textBox1.Text;
            password = textBox2.Text;
            if (AC.Registration(login, password, age))
            {
                MessageBox.Show("Вы успешно зарегестрированы", "успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует", "Неудача", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
