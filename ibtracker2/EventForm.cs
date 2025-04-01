using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ibtracker2
{ 

public partial class EventForm : Form
    {
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txtDate.Text = calendar.static_month + "/" + UserControlDays.static_day + "/" + calendar.static_year;
        }

        private void txtEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEvent.Text) || string.IsNullOrWhiteSpace(txtDate.Text))
            {
                MessageBox.Show("Event Name and Date cannot be empty.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                String sql = "INSERT INTO Events_Table (EventName, EventDate) VALUES (@Event, @Date)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Event", txtEvent.Text);
                    cmd.Parameters.AddWithValue("@Date", txtDate.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Event Saved");
                }
            }
            UpdateCalendar();
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateCalendar()
        {
            
            calendar calendarInstance = new calendar();
            calendarInstance.LoadEvents();
        }
    }
}
