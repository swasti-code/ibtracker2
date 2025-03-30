using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ibtracker2
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
            label4.Text = "0";
        }

        private void calculator_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 45;
            trackBar1.TickFrequency = 1;
            trackBar1.TickStyle = TickStyle.BottomRight;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (comboBox1.SelectedItem.ToString() == "Group 1: Studies in Language and Literature")
            {
                comboBox2.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
            }
            if (comboBox1.SelectedItem.ToString() == "Group 2: Language Acquisition")
            {
                comboBox4.Visible = true;
            }
            else
            {
                comboBox4.Visible = false;
            }
            comboBox5.Visible = comboBox1.SelectedItem.ToString() == "Group 3: Individuals and Society";
            if (comboBox1.SelectedItem.ToString() == "Group 4: Sciences")
            {
                comboBox6.Visible = true;
            }
            else
            {
                comboBox6.Visible = false;
            }
            if (comboBox1.SelectedItem.ToString() == "Group 5: Mathematics")
            {
                comboBox7.Visible = true;
            }
            else
            {
                comboBox7.Visible = false;
            }
            if (comboBox1.SelectedItem.ToString() == "Group 6: The Arts")
            {
                comboBox8.Visible = true;
            }
            else
            {
                comboBox8.Visible = false;
            }
        }


        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Group 1: Studies in Language and Literature" &&
                comboBox2.SelectedItem.ToString() == "English A: Literature" &&
                comboBox3.SelectedItem.ToString() == "HL")
            {
                button2.Visible = true;
                trackBar1.Visible = true;
                label4.Visible = true;
            }
            else
            {
                button2.Visible = false;
                trackBar1.Visible = false;
                label4.Visible = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
