﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта функциия дорабатывается...", "ОШИБКА");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dc = new Form1();
            dc.ShowDialog();
        }
    }
}
