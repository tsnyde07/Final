
namespace Chat
{
    partial class Send
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_send = new System.Windows.Forms.Button();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.lb_to = new System.Windows.Forms.Label();
            this.usernames_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(199, 522);
            this.bt_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 62);
            this.bt_close.TabIndex = 11;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(119, 522);
            this.bt_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(75, 62);
            this.bt_send.TabIndex = 9;
            this.bt_send.Text = "Send";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // tb_message
            // 
            this.tb_message.BackColor = System.Drawing.Color.White;
            this.tb_message.Location = new System.Drawing.Point(31, 213);
            this.tb_message.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(341, 303);
            this.tb_message.TabIndex = 8;
            this.tb_message.TextChanged += new System.EventHandler(this.tb_message_TextChanged);
            // 
            // lb_to
            // 
            this.lb_to.AutoSize = true;
            this.lb_to.Location = new System.Drawing.Point(61, 41);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(29, 17);
            this.lb_to.TabIndex = 7;
            this.lb_to.Text = "To:";
            // 
            // usernames_listbox
            // 
            this.usernames_listbox.FormattingEnabled = true;
            this.usernames_listbox.ItemHeight = 16;
            this.usernames_listbox.Location = new System.Drawing.Point(119, 62);
            this.usernames_listbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernames_listbox.Name = "usernames_listbox";
            this.usernames_listbox.Size = new System.Drawing.Size(159, 116);
            this.usernames_listbox.TabIndex = 12;
            this.usernames_listbox.SelectedIndexChanged += new System.EventHandler(this.usernames_listbox_SelectedIndexChanged);
            // 
            // Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 644);
            this.Controls.Add(this.usernames_listbox);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.lb_to);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Send";
            this.Text = "Send";
            this.Load += new System.EventHandler(this.Send_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Label lb_to;
        private System.Windows.Forms.ListBox usernames_listbox;
    }
}
