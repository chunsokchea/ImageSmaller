namespace ImageSmallerCore
{
    partial class FORM_CONVERT
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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.listView1 = new System.Windows.Forms.ListView();
			this.Fname = new System.Windows.Forms.ColumnHeader();
			this.fType = new System.Windows.Forms.ColumnHeader();
			this.Fsize = new System.Windows.Forms.ColumnHeader();
			this.date = new System.Windows.Forms.ColumnHeader();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.lblPercent = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(12, 380);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(776, 31);
			this.progressBar1.TabIndex = 0;
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Fname,
            this.fType,
            this.Fsize,
            this.date});
			this.listView1.Location = new System.Drawing.Point(12, 62);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(776, 310);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// Fname
			// 
			this.Fname.Name = "Fname";
			this.Fname.Text = "File Name";
			// 
			// fType
			// 
			this.fType.Name = "fType";
			this.fType.Text = "File Type";
			// 
			// Fsize
			// 
			this.Fsize.Name = "Fsize";
			this.Fsize.Text = "File Size";
			// 
			// date
			// 
			this.date.Name = "date";
			this.date.Text = "Created Date";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(64, 21);
			this.trackBar1.Maximum = 20;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(104, 45);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.Value = 12;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// lblPercent
			// 
			this.lblPercent.AutoSize = true;
			this.lblPercent.Location = new System.Drawing.Point(168, 21);
			this.lblPercent.Name = "lblPercent";
			this.lblPercent.Size = new System.Drawing.Size(34, 22);
			this.lblPercent.TabIndex = 3;
			this.lblPercent.Text = "60%";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Khmer OS Koulen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(14, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 22);
			this.label2.TabIndex = 3;
			this.label2.Text = "គុណភាព";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(138)))));
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Khmer OS Muol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(354, 543);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 32);
			this.label3.TabIndex = 3;
			this.label3.Text = "បំលែង";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Khmer OS Koulen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(13, 423);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "ទីតាងដើមរូបភាព";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.ForeColor = System.Drawing.Color.Maroon;
			this.label5.Location = new System.Drawing.Point(13, 445);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(774, 22);
			this.label5.TabIndex = 3;
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Khmer OS Koulen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(12, 486);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 22);
			this.label6.TabIndex = 3;
			this.label6.Text = "រក្សារទុកនៅ";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.ForeColor = System.Drawing.Color.Maroon;
			this.label7.Location = new System.Drawing.Point(14, 508);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(774, 22);
			this.label7.TabIndex = 3;
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// lblTotal
			// 
			this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblTotal.Font = new System.Drawing.Font("Khmer OS Koulen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTotal.Location = new System.Drawing.Point(12, 414);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(776, 22);
			this.lblTotal.TabIndex = 3;
			this.lblTotal.Text = "N/A";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTotal.Click += new System.EventHandler(this.label1_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(354, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 22);
			this.label8.TabIndex = 4;
			this.label8.Text = "label8";
			this.label8.Visible = false;
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "រូបដើម",
            "ផ្ទាល់ខ្លួន"});
			this.comboBox1.Location = new System.Drawing.Point(521, 21);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(87, 30);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.Visible = false;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(614, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.PlaceholderText = "Width ";
			this.textBox1.Size = new System.Drawing.Size(76, 29);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "0";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox1.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(711, 22);
			this.textBox2.Name = "textBox2";
			this.textBox2.PlaceholderText = "Height ";
			this.textBox2.Size = new System.Drawing.Size(76, 29);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "0";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox2.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(692, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 22);
			this.label1.TabIndex = 8;
			this.label1.Text = "X";
			// 
			// FORM_CONVERT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 594);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblPercent);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "FORM_CONVERT";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Image Smaller";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ColumnHeader Fname;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader fType;
        private System.Windows.Forms.ColumnHeader Fsize;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}