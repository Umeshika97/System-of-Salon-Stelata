namespace WindowsFormsApplication4
{
    partial class Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcusno = new System.Windows.Forms.TextBox();
            this.txtadate = new System.Windows.Forms.TextBox();
            this.txtatime = new System.Windows.Forms.TextBox();
            this.rbbd = new System.Windows.Forms.RadioButton();
            this.rbft = new System.Windows.Forms.RadioButton();
            this.rbbt = new System.Windows.Forms.RadioButton();
            this.rbhd = new System.Windows.Forms.RadioButton();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.cmbq = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer No.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Appointment Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Appointment Time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Do you pay Appointment Charges";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Service Type ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtcusno
            // 
            this.txtcusno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusno.Location = new System.Drawing.Point(164, 17);
            this.txtcusno.Name = "txtcusno";
            this.txtcusno.Size = new System.Drawing.Size(123, 26);
            this.txtcusno.TabIndex = 5;
            // 
            // txtadate
            // 
            this.txtadate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadate.Location = new System.Drawing.Point(164, 70);
            this.txtadate.Name = "txtadate";
            this.txtadate.Size = new System.Drawing.Size(123, 26);
            this.txtadate.TabIndex = 6;
            // 
            // txtatime
            // 
            this.txtatime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtatime.Location = new System.Drawing.Point(164, 117);
            this.txtatime.Name = "txtatime";
            this.txtatime.Size = new System.Drawing.Size(123, 26);
            this.txtatime.TabIndex = 7;
            // 
            // rbbd
            // 
            this.rbbd.AutoSize = true;
            this.rbbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbbd.Location = new System.Drawing.Point(247, 224);
            this.rbbd.Name = "rbbd";
            this.rbbd.Size = new System.Drawing.Size(133, 20);
            this.rbbd.TabIndex = 10;
            this.rbbd.TabStop = true;
            this.rbbd.Text = "Bridal Dressing";
            this.rbbd.UseVisualStyleBackColor = true;
            // 
            // rbft
            // 
            this.rbft.AutoSize = true;
            this.rbft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbft.Location = new System.Drawing.Point(247, 270);
            this.rbft.Name = "rbft";
            this.rbft.Size = new System.Drawing.Size(145, 20);
            this.rbft.TabIndex = 11;
            this.rbft.TabStop = true;
            this.rbft.Text = "Facial threatment";
            this.rbft.UseVisualStyleBackColor = true;
            // 
            // rbbt
            // 
            this.rbbt.AutoSize = true;
            this.rbbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbbt.Location = new System.Drawing.Point(247, 323);
            this.rbbt.Name = "rbbt";
            this.rbbt.Size = new System.Drawing.Size(138, 20);
            this.rbbt.TabIndex = 12;
            this.rbbt.TabStop = true;
            this.rbbt.Text = "Body threatment";
            this.rbbt.UseVisualStyleBackColor = true;
            // 
            // rbhd
            // 
            this.rbhd.AutoSize = true;
            this.rbhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbhd.Location = new System.Drawing.Point(247, 373);
            this.rbhd.Name = "rbhd";
            this.rbhd.Size = new System.Drawing.Size(151, 20);
            this.rbhd.TabIndex = 13;
            this.rbhd.TabStop = true;
            this.rbhd.Text = "Hair and Dressing";
            this.rbhd.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(61, 429);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(110, 45);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(243, 429);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(110, 45);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(418, 429);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(110, 45);
            this.btnback.TabIndex = 16;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cmbq
            // 
            this.cmbq.FormattingEnabled = true;
            this.cmbq.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbq.Location = new System.Drawing.Point(397, 56);
            this.cmbq.Name = "cmbq";
            this.cmbq.Size = new System.Drawing.Size(130, 21);
            this.cmbq.TabIndex = 17;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(620, 535);
            this.Controls.Add(this.cmbq);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.rbhd);
            this.Controls.Add(this.rbbt);
            this.Controls.Add(this.rbft);
            this.Controls.Add(this.rbbd);
            this.Controls.Add(this.txtatime);
            this.Controls.Add(this.txtadate);
            this.Controls.Add(this.txtcusno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Service";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcusno;
        private System.Windows.Forms.TextBox txtadate;
        private System.Windows.Forms.TextBox txtatime;
        private System.Windows.Forms.RadioButton rbbd;
        private System.Windows.Forms.RadioButton rbft;
        private System.Windows.Forms.RadioButton rbbt;
        private System.Windows.Forms.RadioButton rbhd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox cmbq;
    }
}