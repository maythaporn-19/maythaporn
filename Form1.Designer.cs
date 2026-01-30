namespace maythaporn
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            textBox7 = new TextBox();
            label10 = new Label();
            textBox8 = new TextBox();
            label11 = new Label();
            textBox9 = new TextBox();
            label12 = new Label();
            textBox10 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "ยี่ห้อสินค้า :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Acer", "Asus", "Dell", "HP", "Lenovo", "MSI", "Apple", "อื่นๆ", "" });
            comboBox1.Location = new Point(21, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(190, 227, 186);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(12, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 399);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "บันทึกข้อมูลคอมพิวเตอร์ที่ส่งซ่อม";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 243);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "เช่น เปิดไม่ติด";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 213);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 4;
            label4.Text = "อาการเสีย :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 177);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "เช่น Aspire 5";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 146);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 4;
            label3.Text = "รุ่น :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Notebook", "PC", "All-in-One", "MacBook", "Mac" });
            comboBox2.Location = new Point(21, 110);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 83);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 4;
            label2.Text = "ประเภทสินค้า :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 283);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "เบอร์โทรลูกค้า :";
            label5.Click += label5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(22, 314);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(65, 364);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 4;
            button1.Text = "เพิ่มข้อมูลสินค้า";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 229, 236);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(862, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 494);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "ข้อมูลสำหรับพิมพ์ใบเสร็จ";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 28);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 5;
            label6.Text = "รหัสสินค้า :";
            label6.Click += label6_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(29, 46);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "เช่น RC-0001";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 83);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 5;
            label7.Text = "ยี่ห้อสินค้า :";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(29, 101);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 5;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 137);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 5;
            label8.Text = "ประเภทสินค้า :";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(29, 164);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 200);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 5;
            label9.Text = "รุ่น :";
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(29, 218);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 251);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 5;
            label10.Text = "อาการเสีย :";
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(30, 275);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 314);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 5;
            label11.Text = "เบอร์โทรลูกค้า :";
            label11.Click += label11_Click;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(30, 341);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 372);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 5;
            label12.Text = "ราคาค่าซ่อม (บาท) :";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(30, 399);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "เช่น 1500";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.Location = new Point(10, 455);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "คิดเงิน";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(119, 455);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "ลบรายการสินค้า";
            button3.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Window;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(222, 49);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(634, 441);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "รายการคอมพิวเตอร์ที่รับซ่อม";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(588, 352);
            dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 238, 250);
            ClientSize = new Size(1091, 508);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label2;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Button button1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox8;
        private Label label10;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox6;
        private Label label8;
        private Label label11;
        private TextBox textBox9;
        private Label label12;
        private Button button3;
        private TextBox textBox10;
        private Button button2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
    }
}
