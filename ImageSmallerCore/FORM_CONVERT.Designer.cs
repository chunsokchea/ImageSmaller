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
            progressBar1 = new System.Windows.Forms.ProgressBar();
            listView1 = new System.Windows.Forms.ListView();
            Fname = new System.Windows.Forms.ColumnHeader();
            fType = new System.Windows.Forms.ColumnHeader();
            Fsize = new System.Windows.Forms.ColumnHeader();
            date = new System.Windows.Forms.ColumnHeader();
            trackBar1 = new System.Windows.Forms.TrackBar();
            lblPercent = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            progressBar1.Location = new System.Drawing.Point(12, 380);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(776, 31);
            progressBar1.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { Fname, fType, Fsize, date });
            listView1.Location = new System.Drawing.Point(12, 62);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(776, 310);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Fname
            // 
            Fname.Name = "Fname";
            Fname.Text = "File Name";
            // 
            // fType
            // 
            fType.Name = "fType";
            fType.Text = "File Type";
            // 
            // Fsize
            // 
            Fsize.Name = "Fsize";
            Fsize.Text = "File Size";
            // 
            // date
            // 
            date.Name = "date";
            date.Text = "Created Date";
            // 
            // trackBar1
            // 
            trackBar1.Location = new System.Drawing.Point(64, 21);
            trackBar1.Maximum = 20;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(104, 45);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 12;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new System.Drawing.Point(168, 21);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new System.Drawing.Size(34, 22);
            lblPercent.TabIndex = 3;
            lblPercent.Text = "60%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(14, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 22);
            label2.TabIndex = 3;
            label2.Text = "គុណភាព";
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.FromArgb(24, 69, 138);
            label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label3.Font = new System.Drawing.Font("Khmer OS Muol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(354, 543);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 32);
            label3.TabIndex = 3;
            label3.Text = "បំលែង";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(13, 423);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 22);
            label4.TabIndex = 3;
            label4.Text = "ទីតាងដើមរូបភាព";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label5.ForeColor = System.Drawing.Color.Maroon;
            label5.Location = new System.Drawing.Point(13, 445);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(774, 22);
            label5.TabIndex = 3;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(12, 486);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(63, 22);
            label6.TabIndex = 3;
            label6.Text = "រក្សារទុកនៅ";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label7.ForeColor = System.Drawing.Color.Maroon;
            label7.Location = new System.Drawing.Point(14, 508);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(774, 22);
            label7.TabIndex = 3;
            label7.Click += label7_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTotal.Location = new System.Drawing.Point(12, 414);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(776, 22);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "N/A";
            lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTotal.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(354, 21);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(42, 22);
            label8.TabIndex = 4;
            label8.Text = "label8";
            label8.Visible = false;
            label8.Click += label8_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "រូបដើម", "ផ្ទាល់ខ្លួន" });
            comboBox1.Location = new System.Drawing.Point(521, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(87, 30);
            comboBox1.TabIndex = 5;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(614, 22);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Width ";
            textBox1.Size = new System.Drawing.Size(76, 29);
            textBox1.TabIndex = 6;
            textBox1.Text = "0";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(711, 22);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Height ";
            textBox2.Size = new System.Drawing.Size(76, 29);
            textBox2.TabIndex = 7;
            textBox2.Text = "0";
            textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            textBox2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(692, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(17, 22);
            label1.TabIndex = 8;
            label1.Text = "X";
            label1.Visible = false;
            // 
            // FORM_CONVERT
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 594);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(lblPercent);
            Controls.Add(trackBar1);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "FORM_CONVERT";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Image Smaller";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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