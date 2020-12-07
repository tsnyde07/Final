using System;
using System.Windows.Forms;

//Displays messages of signed in user

namespace Chat
{
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Messages_Load(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            //Should delete the selected entry's contents but maintain record message was sent
            MessageBox.Show("If implemented, selected message would be deleted but a record that a message was received is kept");
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            //Should launch the received form and display this message's records
            //Best way would be to pass the selected item from the list box?
            this.Hide();
            Received received = new Received();
            received.ShowDialog();
            this.Show();
        }

        private void bt_compose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Send send = new Send();
            send.ShowDialog();
            this.Show();
        }
    }
}
