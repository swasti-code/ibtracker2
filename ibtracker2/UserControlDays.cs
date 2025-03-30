using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ibtracker2
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        private string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";


        public UserControlDays()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }

        public void days(int numday)
        {
            lbdays.Text = numday.ToString();
        }

        private void lbdays_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            EventForm ef = new EventForm();
            ef.Show();
        }

        private void displayEvent()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT * FROM Events_Table WHERE EventDate = @Date";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Date", calendar.static_month + "/" + static_day + "/" + calendar.static_year);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbevent.Text = reader["EventName"].ToString();
                }
                else
                {
                    lbevent.Text = string.Empty; // Clear the label if no event is found
                }
                reader.Close();
                cmd.Dispose();
                conn.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
    }
