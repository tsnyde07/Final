using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Chat
{
    public partial class Received : Form
    {
        String username;
        public Received(String username)
        {
            this.username = username;
            InitializeComponent();
        }

/*        private void Recveived_Load(object sender, EventArgs e)
        {
            String constr = DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(constr);

            String sel = "Select username from user_details";
            SqlDataAdapter Da = new SqlDataAdapter(sel, con);
            DataSet ds =new DataSet()

            Da.Fill(ds, "QueryResult_user_details");
            tb_from.Datasource = ds.Tables["QueryResult_user_details"];
            tb_from.Datasource = new DataSet();


            con.Close();
            
        }
*/
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

            //Should pass the sender of the selected message in received
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
            tb_message.Text = "";

            MessageBox.Show("If implemented, the contents of the message would be deleted a record saying that a message was received saved");
            this.Close();
        }

        private void tb_message_TextChanged(object sender, EventArgs e)
        {
            // inserts both the username and message into the textbox
            string username = tb_from.Text;
            string message = tb_message.Text;
            string constr = DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = con.CreateCommand();
            try
            {   
                // Pulls the username from the database and shows it in the From textbox
                // String query = = "Pull from user_details values('" username "'")"; 


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}