using System;
using System.Data.SqlClient;
using System.Windows.Forms;

/*
 * This will be the initial form
 * After users exist in the database, you can sign in
 * It will check the username and password for matching entries
 * If they match, open the messages form
 */

namespace Chat
{
    public partial class chatSignIn : Form
    {
        public chatSignIn()
        {
            InitializeComponent();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_newUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_User new_user = new New_User();
            new_user.ShowDialog();
            this.Show();
        }

        private void chatSignIn_Load(object sender, EventArgs e)
        {
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (login())
            {
                //first check if the username and password match a database entry then execute the following
                this.Hide();
                Messages messages = new Messages();
                messages.ShowDialog();
            }
        }
        private bool login()
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            String constr = DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = con.CreateCommand();
            try
            {
                string query = "SELECT * FROM user_details WHERE usernames = '" + username + "' AND passwords = '" + password + "'";
                cmd.CommandText = query;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                    return false;
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
            return false;
        }
    }
      

    public class DatabaseConnect
    {
        public static String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dylan\\Documents\\GitHub\\Final\\user_details.mdf;Integrated Security=True";
        DatabaseConnect() { }
        // Connection string for database server
        //String constr = "Server=SBF2D1Z2;Database=PRODUCTDB;Integrated Security=True;";
    }
}
