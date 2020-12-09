using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//Displays messages of signed in user

namespace Chat
{
    public partial class Messages : Form
    {
        int messageID;
        String username;
        public Messages(String username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void lb_messages_SelectedIndexChanged(object sender, EventArgs e)
        {
            getMessageID();
        }
        public void Messages_Load(object sender, EventArgs e)
        {
            String constr = DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(constr);
            String sel = "select sender,timestamp from " + username + " WHERE isRead = 0";
            SqlDataAdapter Da = new SqlDataAdapter(sel, con);
            DataSet ds = new DataSet();
            Da.Fill(ds, "QueryResult_user_details");
            lb_messages.DataSource = ds.Tables["QueryResult_user_details"];
            lb_messages.DisplayMember = "timestamp";

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bt_delete_Click(object sender, EventArgs e)
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
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                Messages_Load(null, EventArgs.Empty);
            }
        }
        private void getMessageID()
        {
            String constr = DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = con.CreateCommand();

            String timestamp = lb_messages.GetItemText(lb_messages.SelectedItem);
            String sel = "SELECT messageID FROM " + username + " WHERE timestamp=@timestamp";
            cmd.CommandText = sel;
            cmd.Parameters.AddWithValue("@timestamp", timestamp);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                messageID = rd.GetInt32(0);
            }
        }
        private void bt_open_Click(object sender, EventArgs e)
        {
            this.Hide();
            Received received = new Received(username, messageID);
            received.ShowDialog();
            this.Show();
   
        }
        private void bt_compose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Send send = new Send(username);
            send.ShowDialog();
            this.Show();
        }

        private void logout_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            chatSignIn chat = new chatSignIn();
            chat.ShowDialog();
            this.Show();
        }

        private void refresh_bt_Click(object sender, EventArgs e)
        {
            Messages_Load(null, EventArgs.Empty);
        }
    }
}
