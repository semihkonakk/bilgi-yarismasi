namespace bilgi_yarısması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dogru = new System.Windows.Forms.TextBox();
            this.puan = new System.Windows.Forms.TextBox();
            this.yanlıs = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(199, 144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(541, 166);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "SORU :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(108, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "PUAN:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 55);
            this.button3.TabIndex = 8;
            this.button3.Text = "B";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(699, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 55);
            this.button4.TabIndex = 9;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "DOĞRU CEVAP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(30, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "YANLIŞ CEVAP:";
            // 
            // dogru
            // 
            this.dogru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dogru.Location = new System.Drawing.Point(199, 424);
            this.dogru.Name = "dogru";
            this.dogru.Size = new System.Drawing.Size(64, 27);
            this.dogru.TabIndex = 12;
            this.dogru.Text = "0";
            this.dogru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // puan
            // 
            this.puan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.puan.Location = new System.Drawing.Point(199, 531);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(64, 27);
            this.puan.TabIndex = 14;
            this.puan.Text = "0";
            this.puan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yanlıs
            // 
            this.yanlıs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yanlıs.Location = new System.Drawing.Point(199, 474);
            this.yanlıs.Name = "yanlıs";
            this.yanlıs.Size = new System.Drawing.Size(64, 27);
            this.yanlıs.TabIndex = 15;
            this.yanlıs.Text = "0";
            this.yanlıs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yanlıs.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(363, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 76);
            this.button5.TabIndex = 16;
            this.button5.Text = "BAŞLA";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(586, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 28);
            this.label6.TabIndex = 18;
            this.label6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 590);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.yanlıs);
            this.Controls.Add(this.puan);
            this.Controls.Add(this.dogru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;
        private Label label5;
        private TextBox dogru;
        private TextBox puan;
        private TextBox yanlıs;
        private Button button5;
        private Label label6;
    }
}