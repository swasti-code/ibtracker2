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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Sockets;

namespace ibtracker2
{
    public partial class calculator : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public calculator()
        {
            InitializeComponent();
            lb4.Text = "0";
            label5.Text = "0";
        }

        private void calculator_Load(object sender, EventArgs e)
        {
            
            Paper1.Minimum = 0;
            Paper1.Maximum = 45;
            Paper1.TickFrequency = 1;
            Paper1.TickStyle = TickStyle.BottomRight;

            trackBar2.Minimum = 0;
            trackBar2.Maximum = 30;
            trackBar2.TickFrequency = 1;
            trackBar2.TickStyle = TickStyle.BottomRight;

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

            if ((comboBox1.SelectedItem.ToString() == "Group 1: Studies in Language and Literature" &&
                comboBox2.SelectedItem.ToString() == "Language A: Literature" &&
                comboBox3.SelectedItem.ToString() == "HL") ||
                (comboBox1.SelectedItem.ToString() == "Group 2: Language Acquisition" &&
                comboBox4.SelectedItem.ToString() == "Language A: Language & Literature" &&
                comboBox3.SelectedItem.ToString() == "HL"))
            {
                Paper1Spanish.Visible = true;
                Paper2Spanish.Visible = true;
                HLEssaySpanish.Visible = true;
                IASpanish.Visible = true;
                Paper1.Visible = true;
                lbPaper1.Visible = true;
                trackBar2.Visible = true;
                trackBar3.Visible = true;
                trackBar4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                lb4.Visible = true;
            }
       
            else { Paper1Spanish.Visible = false; Paper2Spanish.Visible = false; HLEssaySpanish.Visible = false; IASpanish.Visible = false; Paper1.Visible = false; lbPaper1.Visible = false; trackBar2.Visible = false; trackBar3.Visible = false; trackBar4.Visible = false; label5.Visible = false; label6.Visible = false; label7.Visible = false; lb4.Visible = false; }
            if (comboBox1.SelectedItem.ToString() == "Group 3: Individuals and Society" &&
             comboBox5.SelectedItem.ToString() == "Psychology" &&
             comboBox3.SelectedItem.ToString() == "SL")
            {
                btnPaper1.Visible = true;
                btnPaper2.Visible = true;
                btnIA.Visible = true;
                track1.Visible = true;
                track2.Visible = true;
                track3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                lb4.Visible = true;
            }
            
            if (comboBox1.SelectedItem.ToString() == "Group 4: Sciences" &&
            comboBox6.SelectedItem.ToString() == "Physics " &&
            comboBox3.SelectedItem.ToString() == "HL")
            {
                btn2Physics.Visible = true;
                btn3Physics.Visible = true;
                btn4Physics.Visible = true;
                trackPhysics1.Visible = true;
                trackPhysics5.Visible = true;
                trackPhysics6.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                lb4.Visible = true;
            }

            if (comboBox1.SelectedItem.ToString() == "Group 5: Mathematics" &&
         comboBox7.SelectedItem.ToString() == "Mathematics: Applications And Interpretation" &&
         comboBox3.SelectedItem.ToString() == "SL") //need to fix this 
            {
                btn2Math.Visible = true;
                btn3Math.Visible = true;
                btn4Math.Visible = true;
                trackMath1.Visible = true;
                trackMath2.Visible = true;
                trackMath3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                lb4.Visible = true;
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lb4.Text = Paper1.Value.ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            calculations calc2 = new calculations();
            calc2.Show();
        }

        private void Paper1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void calculator_Load_1(object sender, EventArgs e)
        {
            table.Columns.Add("Group", typeof(string));
            table.Columns.Add("Subject", typeof(string));
            table.Columns.Add("Lvl", typeof(string));
            table.Columns.Add("Total", typeof(string));
            table.Columns.Add("Awarded Mark", typeof(string));
          

            dataGridView1.DataSource = table;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar3.Value.ToString();
        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar4.Value.ToString();
        }

        private void calcTot_Click(object sender, EventArgs e)
        {
            double total = 0;
            if ((comboBox1.SelectedItem.ToString() == "Group 1: Studies in Language and Literature" &&
              comboBox2.SelectedItem.ToString() == "Language A: Literature" &&
              comboBox3.SelectedItem.ToString() == "HL") ||
              (comboBox1.SelectedItem.ToString() == "Group 2: Language Acquisition" &&
              comboBox4.SelectedItem.ToString() == "Language A: Language & Literature" &&
              comboBox3.SelectedItem.ToString() == "HL"))
            {
                total = 35 * (Paper1.Value / 40.0) + 25 * (trackBar2.Value / 30.0) + 20 * (trackBar3.Value / 20.0) + 20 * (trackBar4.Value / 40.0);
            }
            else if (comboBox1.SelectedItem.ToString() == "Group 3: Individuals and Society" &&
                     comboBox5.SelectedItem.ToString() == "Psychology" &&
                     comboBox3.SelectedItem.ToString() == "SL")
            {
                total = 50 * (track1.Value / 40.0) + 25 * (track2.Value / 30.0) + 25 * (track3.Value / 20.0);
            }
            else if (comboBox1.SelectedItem.ToString() == "Group 4: Sciences" &&
                     comboBox6.SelectedItem.ToString() == "Physics " &&
                     comboBox3.SelectedItem.ToString() == "HL")
            {
                total = 36 * (trackPhysics1.Value / 60.0) + 44 * (trackPhysics5.Value / 90.0) + 20 * (trackPhysics6.Value / 24.0);
            }
            else if (comboBox1.SelectedItem.ToString() == "Group 5: Mathematics" &&
                     comboBox7.SelectedItem.ToString() == "Mathematics: Applications And Interpretation" &&
                     comboBox3.SelectedItem.ToString() == "SL")
            {
                total = 40 * (trackMath1.Value / 20.0) + 40 * (trackMath2.Value / 30.0) + 20 * (trackMath3.Value / 30.0);
            }


                textBox1.Text = Math.Round(total).ToString();
            textBox2_TextChanged(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int score;
            if (int.TryParse(textBox1.Text, out score))
            {
                if (comboBox1.SelectedItem.ToString() == "Group 1: Studies in Language and Literature" || comboBox1.SelectedItem.ToString() == "Group 2: Language Acquisition")
                {
                    if (score <= 12)
                    {
                        textBox2.Text = "1";
                    }
                    else if (score <= 25)
                    {
                        textBox2.Text = "2";
                    }
                    else if (score <= 39)
                    {
                        textBox2.Text = "3";
                    }
                    else if (score <= 52)
                    {
                        textBox2.Text = "4";
                    }
                    else if (score <= 65)
                    {
                        textBox2.Text = "5";
                    }
                    else if (score <= 78)
                    {
                        textBox2.Text = "6";
                    }
                    else
                    {
                        textBox2.Text = "7";
                    }
                }
                if (comboBox1.SelectedItem.ToString() == "Group 3: Individuals and Society")
                {
                    if (score <= 8)
                    {
                        textBox2.Text = "1";
                    }
                    else if (score <= 19)
                    {
                        textBox2.Text = "2";
                    }
                    else if (score <= 30)
                    {
                        textBox2.Text = "3";
                    }
                    else if (score <= 44)
                    {
                        textBox2.Text = "4";
                    }
                    else if (score <= 58)
                    {
                        textBox2.Text = "5";
                    }
                    else if (score <= 72)
                    {
                        textBox2.Text = "6";
                    }
                    else
                    {
                        textBox2.Text = "7";
                    }
                }
                if (comboBox1.SelectedItem.ToString() == "Group 4: Sciences")
                {
                    if (score <= 14)
                    {
                        textBox2.Text = "1";
                    }
                    else if (score <= 23)
                    {
                        textBox2.Text = "2";
                    }
                    else if (score <= 38)
                    {
                        textBox2.Text = "3";
                    }
                    else if (score <= 49)
                    {
                        textBox2.Text = "4";
                    }
                    else if (score <= 60)
                    {
                        textBox2.Text = "5";
                    }
                    else if (score <= 72)
                    {
                        textBox2.Text = "6";
                    }
                    else
                    {
                        textBox2.Text = "7";
                    }
                }

                if (comboBox1.SelectedItem.ToString() == "Group 5: Mathematics")
                {
                    if (score <= 12)
                    {
                        textBox2.Text = "1";
                    }
                    else if (score <= 24)
                    {
                        textBox2.Text = "2";
                    }
                    else if (score <= 37)
                    {
                        textBox2.Text = "3";
                    }
                    else if (score <= 50)
                    {
                        textBox2.Text = "4";
                    }
                    else if (score <= 64)
                    {
                        textBox2.Text = "5";
                    }
                    else if (score <= 76)
                    {
                        textBox2.Text = "6";
                    }
                    else
                    {
                        textBox2.Text = "7";
                    }
                }

            }
            else
            {
                textBox2.Text = "Invalid input";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string subject = string.Empty;

            if (comboBox2.Visible && !string.IsNullOrEmpty(comboBox2.Text))
            {
                subject = comboBox2.Text;
            }
            else if (comboBox4.Visible && !string.IsNullOrEmpty(comboBox4.Text))
            {
                subject = comboBox4.Text;
            }
            else if (comboBox5.Visible && !string.IsNullOrEmpty(comboBox5.Text))
            {
                subject = comboBox5.Text;
            }
            else if (comboBox6.Visible && !string.IsNullOrEmpty(comboBox6.Text))
            {
                subject = comboBox6.Text;
            }
            else if (comboBox7.Visible && !string.IsNullOrEmpty(comboBox7.Text))
            {
                subject = comboBox7.Text;
            }
            else if (comboBox8.Visible && !string.IsNullOrEmpty(comboBox8.Text))
            {
                subject = comboBox8.Text;
            }

            table.Rows.Add(comboBox1.Text, subject, comboBox3.Text, textBox1.Text, textBox2.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            comboBox1.Text = selectedRow.Cells[0].Value.ToString();
            comboBox2.Text = selectedRow.Cells[1].Value.ToString();
            comboBox4.Text = selectedRow.Cells[1].Value.ToString();
            comboBox5.Text = selectedRow.Cells[1].Value.ToString();
            comboBox6.Text = selectedRow.Cells[1].Value.ToString();
            comboBox7.Text = selectedRow.Cells[1].Value.ToString();
            comboBox8.Text = selectedRow.Cells[1].Value.ToString();
            comboBox3.Text = selectedRow.Cells[2].Value.ToString();
            textBox1.Text = selectedRow.Cells[3].Value.ToString();
            textBox2.Text = selectedRow.Cells[4].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[index];
            newDataRow.Cells[0].Value = comboBox1.Text;
            newDataRow.Cells[1].Value = comboBox2.Text;
            newDataRow.Cells[1].Value = comboBox4.Text;
            newDataRow.Cells[1].Value = comboBox5.Text;
            newDataRow.Cells[1].Value = comboBox6.Text;
            newDataRow.Cells[1].Value = comboBox7.Text;
            newDataRow.Cells[1].Value = comboBox8.Text;
            newDataRow.Cells[2].Value = comboBox3.Text;
            newDataRow.Cells[3].Value = textBox1.Text;
            newDataRow.Cells[4].Value = textBox2.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void track1_Scroll(object sender, EventArgs e)
        {
            lb4.Text = track1.Value.ToString();
        }
       

        private void track2_Scroll_1(object sender, EventArgs e)
        {
            label5.Text = track2.Value.ToString();
        }

        private void track3_Scroll(object sender, EventArgs e)
        {
            label6.Text = track3.Value.ToString();
        }

        private void trackPhysics1_Scroll(object sender, EventArgs e)
        {
            lb4.Text = trackPhysics1.Value.ToString();
        }

        private void trackPhysics5_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackPhysics5.Value.ToString();
        }

        private void trackPhysics6_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackPhysics6.Value.ToString();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Paper1Spanish.Visible = false;
            Paper2Spanish.Visible = false;
            HLEssaySpanish.Visible = false;
            IASpanish.Visible = false;
            Paper1.Visible = false;
            lbPaper1.Visible = false;
            trackBar2.Visible = false;
            trackBar3.Visible = false;
            trackBar4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            lb4.Visible = false;
            btnPaper1.Visible = false;
            btnPaper2.Visible = false;
            btnIA.Visible = false;
            track1.Visible = false;
            track2.Visible = false;
            track3.Visible = false;
            btn2Physics.Visible = false;
            btn3Physics.Visible = false;
            btn4Physics.Visible = false;
            trackPhysics1.Visible = false;
            trackPhysics5.Visible = false;
            trackPhysics6.Visible = false;
            textBox2.Text = "";
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox3.Text = "";
            btn2Math.Visible = false;
            btn3Math.Visible = false;
            btn4Math.Visible = false;
            trackMath1.Visible = false;
            trackMath2.Visible = false;
            trackMath3.Visible = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void trackMath1_Scroll(object sender, EventArgs e)
        {
            lb4.Text = trackMath1.Value.ToString();

        }

        private void trackMath2_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackMath2.Value.ToString();
        }

        private void trackMath3_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackMath3.Value.ToString();
        }
    }
    
}
