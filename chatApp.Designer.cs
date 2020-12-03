
namespace Chat
{
    partial class chatSignIn
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_newUser = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(150, 25);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 22);
            this.tb_username.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(150, 60);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 22);
            this.tb_password.TabIndex = 1;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(60, 25);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(73, 17);
            this.lb_username.TabIndex = 2;
            this.lb_username.Text = "Username";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(60, 65);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(69, 17);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "Password";
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(30, 100);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 45);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_newUser
            // 
            this.bt_newUser.Location = new System.Drawing.Point(130, 100);
            this.bt_newUser.Name = "bt_newUser";
            this.bt_newUser.Size = new System.Drawing.Size(75, 45);
            this.bt_newUser.TabIndex = 5;
            this.bt_newUser.Text = "New User";
            this.bt_newUser.UseVisualStyleBackColor = true;
            this.bt_newUser.Click += new System.EventHandler(this.bt_newUser_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(230, 100);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 45);
            this.bt_exit.TabIndex = 6;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // chatSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 178);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_newUser);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Name = "chatSignIn";
            this.Text = "Chat- Sign in";
            this.Load += new System.EventHandler(this.chatSignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_newUser;
        private System.Windows.Forms.Button bt_exit;
    }
}

