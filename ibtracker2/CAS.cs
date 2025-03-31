using System;
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
    public partial class CAS : Form
    {
        DataTable table = new DataTable("table");
        int index;

        public CAS()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CAS_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Activity", typeof(string));
            table.Columns.Add("Title of Activity", typeof(string));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Start Date", typeof(DateTime));
            table.Columns.Add("End Date", typeof(DateTime));
            table.Columns.Add("Hours", typeof(int));
            table.Columns.Add("Progress", typeof(string));

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(comboBox1, textBox1.Text, textBox3.Text, dateTimePicker1.Value, dateTimePicker2.Value, textBox2.Text, comboBox2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[2].Value.ToString();
            textBox3.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[index];
            newDataRow.Cells[0].Value = comboBox1.Text;
            newDataRow.Cells[1].Value = textBox1.Text;
            newDataRow.Cells[2].Value = textBox3.Text;
            newDataRow.Cells[3].Value = dateTimePicker1.Value;
            newDataRow.Cells[4].Value = dateTimePicker2.Value;
            newDataRow.Cells[5].Value = textBox2.Text;
            newDataRow.Cells[6].Value = comboBox2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
