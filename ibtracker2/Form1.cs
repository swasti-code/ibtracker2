﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ibtracker2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculator Calc = new calculator();
            Calc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calendar Cal = new calendar();
            Cal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CAS cas = new CAS();
            cas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
