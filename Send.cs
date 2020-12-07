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

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            
            //Should add contents to the database then close
            MessageBox.Show("If implemented, message would be sent!");
            this.Close();
        }

        private void tb_to_TextChanged(object sender, EventArgs e)
        {
            //should check database for username
        }
    }
}
