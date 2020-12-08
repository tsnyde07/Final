using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Chat
{
    public partial class Received : Form
    {
        String username;
        int messageID;
        public Received(String username, int messageID)
        {
            this.username = username;
            this.messageID = messageID;
            InitializeComponent();
        }

        private void Received_Load(object sender, EventArgs e)
        {
            loadMessage();
            loadFrom();
        }

        private void loadFrom()
        {
            String from;
            String constr = DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            String sel = "select sender from " + username + " WHERE messageID=@messageID";
            cmd.Parameters.AddWithValue("@messageID", messageID);
            cmd.CommandText = sel;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                from = rd.GetString(0);
                tb_from.Text = from;
            }
        }
        private void loadMessage()
        {
            String message;
            String constr = DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            String sel = "select contents from " + username + " WHERE messageID=@messageID";
            cmd.Parameters.AddWithValue("@messageID", messageID);
            cmd.CommandText = sel;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                message = rd.GetString(0);
                tb_message.Text = message;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Boolean CheckForMessageContents()
        {
            if (tb_message.Text.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void bt_reply_Click(object sender, EventArgs e)
        {
            this.Hide();
            Send send = new Send(username);
            send.ShowDialog();
            this.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void bt_deleteContents_Click(object sender, EventArgs e)
        {
            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
            SqlConnection con = new SqlConnection(constr);  // create the database connecting
            SqlCommand cmd = con.CreateCommand();
            try
            {
                String query = "UPDATE " + username + " SET contents = '[REDACTED]', isRead = 1 WHERE messageID=@messageID";
                cmd.Parameters.AddWithValue("@messageID", messageID);
                cmd.CommandText = query;
                con.Open(); // open the Database connection for insertion when done must close the connection to avoid issues
                Int32 returnFlag = (Int32)cmd.ExecuteNonQuery(); // execute the query, the function returns 0 if the insertion unsuccessful
                if (returnFlag > 0)
                    MessageBox.Show("Contents deleted");
                else
                    MessageBox.Show("Something went wrong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            this.Close();
        }
        private void tb_message_TextChanged(object sender, EventArgs e)
        { }
    }
}