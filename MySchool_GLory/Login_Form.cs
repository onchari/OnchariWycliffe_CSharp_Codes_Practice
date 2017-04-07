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

namespace MySchool_GLory
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            textBox_Username.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;

            //login validation
            if (String.IsNullOrEmpty(textBox_password.Text) || String.IsNullOrEmpty(textBox_Username.Text))
            {
                MessageBox.Show("All field should be filled");
                return;
            }

            string connectionString = @"data source=DESKTOP-06IKRA6\ANKO_CHIF;initial catalog=glory_school;integrated security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
          

         
           string sqlqueryCheckUsernameExists = "SELECT username FROM logins WHERE username='"+textBox_Username.Text + "' ";
           SqlCommand sqlCommand = new SqlCommand(sqlqueryCheckUsernameExists, sqlConnection);

           sqlDataReader = sqlCommand.ExecuteReader();
            
            if (sqlDataReader.HasRows)
            {
                sqlDataReader.Close();
                string  sqlquerypasswordMatch = "SELECT password FROM logins where username='" +textBox_Username.Text + "' and password='"+textBox_password.Text+"'";
                sqlCommand = new SqlCommand(sqlquerypasswordMatch, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                   this.Hide();
                    Glory_Dashboard gloryDashboard = new Glory_Dashboard();
                    gloryDashboard.Show();
                }
                sqlDataReader.Close();
            }

            Console.WriteLine("Coming home");
            
            else
            {
                MessageBox.Show("Username (" + textBox_Username.Text + ") does not exists. Kindly register");
            }

            
            sqlConnection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Login Cancellation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
            {
            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}
