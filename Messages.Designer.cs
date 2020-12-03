
namespace Chat
{
    partial class Messages
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
            this.lb_messages = new System.Windows.Forms.ListBox();
            this.bt_open = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_compose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_messages
            // 
            this.lb_messages.FormattingEnabled = true;
            this.lb_messages.ItemHeight = 16;
            this.lb_messages.Location = new System.Drawing.Point(12, 12);
            this.lb_messages.Name = "lb_messages";
            this.lb_messages.Size = new System.Drawing.Size(350, 388);
            this.lb_messages.TabIndex = 0;
            this.lb_messages.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(400, 15);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(87, 34);
            this.bt_open.TabIndex = 1;
            this.bt_open.Text = "Open";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(400, 105);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(87, 34);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(400, 150);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(87, 34);
            this.bt_exit.TabIndex = 3;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_compose
            // 
            this.bt_compose.Location = new System.Drawing.Point(400, 60);
            this.bt_compose.Name = "bt_compose";
            this.bt_compose.Size = new System.Drawing.Size(87, 34);
            this.bt_compose.TabIndex = 4;
            this.bt_compose.Text = "Compose";
            this.bt_compose.UseVisualStyleBackColor = true;
            this.bt_compose.Click += new System.EventHandler(this.bt_compose_Click);
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 453);
            this.Controls.Add(this.bt_compose);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.lb_messages);
            this.Name = "Messages";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.Messages_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_messages;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_compose;
    }
}