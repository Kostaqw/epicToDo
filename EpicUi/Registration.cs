﻿using BLEpicToDo.controller;
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
            string login, password;
            login = textBox1.Text;
            password = textBox2.Text;
            if (AC.Registration(login, password))
            {
                MessageBox.Show("Вы успешно зарегестрированы", "успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует", "Неудача", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}