using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ProductDy
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        private void Delete_Load(object sender, EventArgs e)
        {
            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
            SqlConnection con = new SqlConnection(constr);  // create the database connecting
            SqlCommand cmd = con.CreateCommand(); // Need to execute the query
            try  // if there is a problem in connection, it will  catch the exception
            {
                String sel = "select * from Product";  // Create the SQL query to be executed
                cmd.CommandText = sel;
                con.Open(); // open the connection, will throw exception if cannot connect to the server
                SqlDataReader reader = cmd.ExecuteReader(); // 
                DataTable dt = new DataTable();
                dt.Load(reader); // load the data in the Data table through the reader
                // Now bind the data table with the controls I have
                listBox1.DataSource = dt;
                listBox1.DisplayMember = "Product_number";
                listBox1.Controls.Add(listBox1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            finally
            {
                cmd.Dispose(); // clean ups, all the related the memory allocations
                con.Close();
            }
        }
        private void bt_Click_delete(object sender, EventArgs e)
        {
            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
            SqlConnection con = new SqlConnection(constr);  // create the database connecting
            SqlCommand cmd = con.CreateCommand(); // Need to execute the query
            try  // if there is a problem in connection, it will catch the exception
            {
                String queryForDelete = "DELETE FROM Product WHERE Product_number='" + listBox1.GetItemText(listBox1.SelectedItem) + "'";
                cmd.CommandText = queryForDelete;
                con.Open();
                Int32 returnFlag = (Int32)cmd.ExecuteNonQuery();
                if (returnFlag > 0)
                    MessageBox.Show("Deleted Successfully");
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
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}