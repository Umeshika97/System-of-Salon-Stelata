namespace WindowsFormsApplication4
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnstaff = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnservice = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstaff
            // 
            this.btnstaff.BackColor = System.Drawing.Color.White;
            this.btnstaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstaff.BackgroundImage")));
            this.btnstaff.Location = new System.Drawing.Point(40, 21);
            this.btnstaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(205, 186);
            this.btnstaff.TabIndex = 0;
            this.btnstaff.UseVisualStyleBackColor = false;
            this.btnstaff.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncustomer.BackgroundImage")));
            this.btncustomer.Location = new System.Drawing.Point(374, 21);
            this.btncustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(200, 186);
            this.btncustomer.TabIndex = 1;
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnservice
            // 
            this.btnservice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnservice.BackgroundImage")));
            this.btnservice.Location = new System.Drawing.Point(40, 304);
            this.btnservice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnservice.Name = "btnservice";
            this.btnservice.Size = new System.Drawing.Size(205, 183);
            this.btnservice.TabIndex = 2;
            this.btnservice.UseVisualStyleBackColor = true;
            this.btnservice.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.BackColor = System.Drawing.Color.White;
            this.btnproduct.Image = ((System.Drawing.Image)(resources.GetObject("btnproduct.Image")));
            this.btnproduct.Location = new System.Drawing.Point(374, 304);
            this.btnproduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(200, 183);
            this.btnproduct.TabIndex = 3;
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Staff Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Detail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Service Detail";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product Detail";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Black;
            this.btnexit.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(456, 571);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(118, 43);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(621, 624);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.btnservice);
            this.Controls.Add(this.btncustomer);
            this.Controls.Add(this.btnstaff);
            this.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstaff;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnservice;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnexit;
    }
}