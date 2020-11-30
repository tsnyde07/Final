namespace ProductDy
{
    partial class Update
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductOH = new System.Windows.Forms.TextBox();
            this.txtProductDes = new System.Windows.Forms.TextBox();
            this.txtProductNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(77, 76);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 244);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Products(IDs)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 238);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Update Product Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_click_update);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(492, 176);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(196, 22);
            this.txtProductPrice.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Unit on hands";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Product Number";
            // 
            // txtProductOH
            // 
            this.txtProductOH.Location = new System.Drawing.Point(492, 144);
            this.txtProductOH.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductOH.Name = "txtProductOH";
            this.txtProductOH.Size = new System.Drawing.Size(196, 22);
            this.txtProductOH.TabIndex = 11;
            // 
            // txtProductDes
            // 
            this.txtProductDes.Location = new System.Drawing.Point(492, 112);
            this.txtProductDes.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductDes.Name = "txtProductDes";
            this.txtProductDes.Size = new System.Drawing.Size(196, 22);
            this.txtProductDes.TabIndex = 10;
            // 
            // txtProductNo
            // 
            this.txtProductNo.Location = new System.Drawing.Point(492, 80);
            this.txtProductNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductNo.Name = "txtProductNo";
            this.txtProductNo.Size = new System.Drawing.Size(196, 22);
            this.txtProductNo.TabIndex = 9;
            this.txtProductNo.TextChanged += new System.EventHandler(this.txtProductNo_TextChanged);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductOH);
            this.Controls.Add(this.txtProductDes);
            this.Controls.Add(this.txtProductNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Update";
            this.Text = "update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductOH;
        private System.Windows.Forms.TextBox txtProductDes;
        private System.Windows.Forms.TextBox txtProductNo;
    }
}