﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Drinks
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dc = new Form1();
            dc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex > 1)
            {
                listBox1.Items.Add(listBox3.SelectedIndex);
            }
            if (listBox3.SelectedIndex > 1)
            {
                listBox1.Items.Add(listBox4.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта функциия дорабатывается...", "ОШИБКА");
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Value.ToString() + " по " + dateTimePicker2.Value.ToString() + " заказ " + listBox3.SelectedItem);
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Value.ToString() + " по " + dateTimePicker2.Value.ToString() + " заказ " + listBox4.SelectedItem);
        }
    }
}
