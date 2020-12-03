using System;
using System.Windows.Forms;

namespace Chat
{
    public partial class Received : Form
    {
        public Received()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_reply_Click(object sender, EventArgs e)
        {
            //Should pass the sender of the selected message in received
            this.Hide();
            Send send = new Send();
            send.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_deleteContents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If implemented, the contents of the message would be deleted a record saying that a message was received saved");
            this.Close();
        }
    }
}
