using System;
using System.Windows.Forms;
using System.Data.SqlClient;

/*
 * This will be used to create a new user
 * Contents in the name, username, and password will be stored to a database
 * Once in the database (after you hit submit) the form should close and you should be on the original form to sign in
 */


namespace Chat
{
    public partial class New_User : Form
    {
        public New_User()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //There should be a database for user credentials and one for each user to hold message records
            string username = tb_username.Text;
            string password = tb_password.Text;

            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
            SqlConnection con = new SqlConnection(constr);  // create the database connecting
            SqlCommand cmd = con.CreateCommand(); // Need to execute the query
            try
            {
                string query = "SELECT * FROM user_details WHERE usernames = '" + username + "'";
                cmd.CommandText = query;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                {
                    con.Close();
                    query = "insert into user_details values('" + username + "','" + password + "')";
                    cmd.CommandText = query;
                    con.Open();
                    Int32 returnFlag = (Int32)cmd.ExecuteNonQuery(); // execute the query, the function returns 0 if the insertion unsuccessful
                    if (returnFlag > 0)
                    {
                        con.Close();
                        MessageBox.Show("New User Created");
                        query = "CREATE TABLE [" + username + "] (ID int NOT NULL, sender varchar(50) NOT NULL, timestamp date NOT NULL, contents varchar(MAX) NOT NULL, isRead bit NOT NULL, PRIMARY KEY (ID));";
                        cmd.CommandText = query;
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    else
                        MessageBox.Show("Something went wrong");
                    cmd.Dispose();
                    con.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username already exists");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                cmd.Dispose();
                con.Close();
            }
            tb_username.Text = "";
            tb_password.Text = "";
        }

        private void New_User_Load(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
