﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLIPPRSApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Tovar();
            ifrm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            ifrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new Prixod();
            ifrm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            ifrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new Real_prodaji();
            ifrm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            ifrm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form ifrm = new Prodaji();
            ifrm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            ifrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ifrm = new Ostatki();
            ifrm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            ifrm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form ifrm = new Vozvrat();
            ifrm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            ifrm.Show();
        }
    }
}
