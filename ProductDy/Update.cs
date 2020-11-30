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
namespace ProductDy
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        private void Update_Load(object sender, EventArgs e)
        {
            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
            SqlConnection con = new SqlConnection(constr);  // create the database connecting
            SqlCommand cmd = con.CreateCommand();
            try
            {
                String sel = "select * from Product";
                cmd.CommandText = sel;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
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

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            String selectedID = listBox1.GetItemText(listBox1.SelectedItem);
            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
            SqlConnection con = new SqlConnection(constr);  // create the database connecting
            SqlCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                String sel = "select * from Product where Product_Number = Cast(@selectedID as NCHAR)";
                cmd.Parameters.Add("@selectedID", SqlDbType.NChar).Value = selectedID;
                cmd.CommandText = sel;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtProductNo.Text = reader.GetValue(0).ToString();
                    txtProductDes.Text = reader.GetValue(1).ToString();
                    txtProductOH.Text = reader.GetValue(2).ToString();
                    txtProductPrice.Text = reader.GetValue(3).ToString();
                }
                reader.Close();
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
        private void bt_click_update(object sender, EventArgs e)
        {
            string productNo = txtProductNo.Text;
            string description = txtProductDes.Text;
            int NOHands = int.Parse(txtProductOH.Text);
            decimal price = decimal.Parse(txtProductPrice.Text);

            String constr = DatabaseConnect.connectionString;  // See DatabaseConnect Class in Form1.cs file- bottom
            SqlConnection con = new SqlConnection(constr);  // create the database connecting
            SqlCommand cmd = con.CreateCommand(); // Need to execute the query
            try
            {
                //form the SQL insert query using the given data
                string query = "UPDATE Product SET Product_Number = @productNO, Description = @description, Units_On_Hand = @NOhands, Price = @price Where Product_Number = '" + listBox1.GetItemText(listBox1.SelectedItem) + "'";
                cmd.Parameters.Add("@productNO", SqlDbType.NChar).Value = productNo;
                cmd.Parameters.Add("@description", SqlDbType.NChar).Value = description;
                cmd.Parameters.Add("@NOhands", SqlDbType.NChar).Value = NOHands;
                cmd.Parameters.Add("@price", SqlDbType.NChar).Value = price;
                cmd.CommandText = query;
                con.Open(); // open the Database connection for insertion when done must close the connection to avoid issues
                Int32 returnFlag = (Int32)cmd.ExecuteNonQuery(); // execute the query, the function returns 0 if the insertion unsuccessful
                if (returnFlag > 0)
                    MessageBox.Show("Updated Successfully");
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
        private void txtProductNo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}