using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ibtracker2
{
    public partial class LoginPage : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\swast\source\repos\ibtracker2\ibtracker2\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;

        public LoginPage()
        {
            InitializeComponent();


        }

        private void Enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Uname.Text))
                {
                    Uname.Text = "Please enter username";
                    return;
                }

                string loginCommand = "Select count(*) From User_Table Where Uname = @Username and Password = @Password";
                cmd = new SqlCommand(loginCommand, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Username", Uname.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Text);
                conn.Open();

                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    MessageBox.Show("Login Successful, You will be redirected to the homepage shortly");
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed, Please Enter Right Username and Password Again");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void Uname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
