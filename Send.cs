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

namespace Chat
{
    public partial class Send : Form
    {
        public Send()
        {
            InitializeComponent();
        }

        private void Send_Load(object sender, EventArgs e)
        {
            String constr = DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(constr);

            String sel = "select usernames from user_details";
            SqlDataAdapter Da = new SqlDataAdapter(sel, con);
            DataSet ds = new DataSet();

            Da.Fill(ds, "QueryResult_user_details");
            usernames_listbox.DataSource = ds.Tables["QueryResult_user_details"];
            usernames_listbox.DisplayMember = "usernames";

            con.Close();
        }

        public Boolean checkForMessageContents()
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

        private void bt_send_Click(object sender, EventArgs e)
        {
            
            Boolean checkForMessage = checkForMessageContents();
            if(checkForMessage == true)
            {
                string message = tb_message.Text;
                string recipient = usernames_listbox.SelectedItem.ToString();
                String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
                SqlConnection con = new SqlConnection(constr);  // create the database connecting
                SqlCommand cmd = con.CreateCommand(); // Need to execute the query
                try
                {
                    //form the SQL insert query using the given data
                    string query = "insert into user_message_details values('" + recipient + "','" + message + ")";
                    cmd.CommandText = query;
                    con.Open(); // open the Database connection for insertion when done must close the connection to avoid issues
                    Int32 returnFlag = (Int32)cmd.ExecuteNonQuery(); // execute the query, the function returns 0 if the insertion unsuccessful
                    if (returnFlag > 0)
                        MessageBox.Show("Message Sent");
                    else
                        MessageBox.Show("Message Failed to Send");


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
            }
            else
            {
                MessageBox.Show("Please enter a message before sending");
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_message_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
