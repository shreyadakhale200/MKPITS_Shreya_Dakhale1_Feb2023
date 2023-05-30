namespace AsusStores
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
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox4 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox16 = new TextBox();
            textBox15 = new TextBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            groupBox5 = new GroupBox();
            textBox18 = new TextBox();
            label18 = new Label();
            textBox17 = new TextBox();
            label17 = new Label();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox6 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(24, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(363, 148);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(18, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 219);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Category";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(463, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(371, 219);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product Details";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 39);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(140, 30);
            textBox3.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(159, 174);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(140, 30);
            textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(159, 127);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(140, 30);
            textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(159, 84);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(140, 30);
            textBox4.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 177);
            label6.Name = "label6";
            label6.Size = new Size(46, 24);
            label6.TabIndex = 3;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 130);
            label5.Name = "label5";
            label5.Size = new Size(113, 24);
            label5.TabIndex = 2;
            label5.Text = "Total Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 87);
            label4.Name = "label4";
            label4.Size = new Size(142, 24);
            label4.TabIndex = 1;
            label4.Text = "Available Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 42);
            label3.Name = "label3";
            label3.Size = new Size(116, 24);
            label3.TabIndex = 0;
            label3.Text = "Product Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox12);
            groupBox3.Controls.Add(textBox11);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(463, 237);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(371, 255);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Invoice Details";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(239, 216);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(95, 30);
            textBox12.TabIndex = 14;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(159, 216);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(66, 30);
            textBox11.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(159, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(175, 30);
            dateTimePicker1.TabIndex = 12;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(239, 169);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(95, 30);
            textBox10.TabIndex = 11;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(159, 169);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(66, 30);
            textBox9.TabIndex = 10;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(159, 123);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(175, 30);
            textBox8.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(159, 73);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(175, 30);
            textBox7.TabIndex = 8;
            textBox7.TextChanged += textBox7_TextChanged;
            textBox7.KeyPress += textBox7_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(100, 219);
            label11.Name = "label11";
            label11.Size = new Size(55, 24);
            label11.TabIndex = 5;
            label11.Text = "SGST";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(99, 177);
            label10.Name = "label10";
            label10.Size = new Size(56, 24);
            label10.TabIndex = 4;
            label10.Text = "CGST";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(65, 130);
            label9.Name = "label9";
            label9.Size = new Size(87, 24);
            label9.TabIndex = 3;
            label9.Text = "Total Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 84);
            label8.Name = "label8";
            label8.Size = new Size(142, 24);
            label8.TabIndex = 2;
            label8.Text = "Quantity Required";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 34);
            label7.Name = "label7";
            label7.Size = new Size(102, 24);
            label7.TabIndex = 1;
            label7.Text = "Invoice Date";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton5);
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Controls.Add(textBox16);
            groupBox4.Controls.Add(textBox15);
            groupBox4.Controls.Add(textBox14);
            groupBox4.Controls.Add(textBox13);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(21, 237);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(413, 255);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Customer Details";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(332, 119);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(72, 28);
            radioButton5.TabIndex = 16;
            radioButton5.TabStop = true;
            radioButton5.Text = "Other";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(240, 119);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 28);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(167, 121);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 28);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(179, 213);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(175, 30);
            textBox16.TabIndex = 13;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(179, 166);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(175, 30);
            textBox15.TabIndex = 12;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(179, 70);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(175, 30);
            textBox14.TabIndex = 11;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(179, 28);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(175, 30);
            textBox13.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(45, 216);
            label16.Name = "label16";
            label16.Size = new Size(105, 24);
            label16.TabIndex = 4;
            label16.Text = "Paid Amount";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(83, 169);
            label15.Name = "label15";
            label15.Size = new Size(58, 24);
            label15.TabIndex = 3;
            label15.Text = "Mobile";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(82, 123);
            label14.Name = "label14";
            label14.Size = new Size(64, 24);
            label14.TabIndex = 2;
            label14.Text = "Gender";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(60, 73);
            label13.Name = "label13";
            label13.Size = new Size(91, 24);
            label13.TabIndex = 1;
            label13.Text = "Last Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(59, 31);
            label12.Name = "label12";
            label12.Size = new Size(91, 24);
            label12.TabIndex = 0;
            label12.Text = "First Name";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox18);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(textBox17);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(radioButton4);
            groupBox5.Controls.Add(radioButton3);
            groupBox5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(463, 498);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(371, 170);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Payment Gateways";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(170, 122);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(175, 30);
            textBox18.TabIndex = 5;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(36, 125);
            label18.Name = "label18";
            label18.Size = new Size(120, 24);
            label18.TabIndex = 4;
            label18.Text = "Sold Person ID";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(170, 79);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(175, 30);
            textBox17.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(51, 82);
            label17.Name = "label17";
            label17.Size = new Size(99, 24);
            label17.TabIndex = 2;
            label17.Text = "Net Amount";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(202, 33);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(62, 28);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "EMI";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(63, 33);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(69, 28);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Cash";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dataGridView1);
            groupBox6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(21, 498);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(417, 172);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Summary";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(405, 133);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(171, 688);
            button1.Name = "button1";
            button1.Size = new Size(278, 54);
            button1.TabIndex = 11;
            button1.Text = "SHOW DETAILS";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(463, 688);
            button2.Name = "button2";
            button2.Size = new Size(236, 54);
            button2.TabIndex = 12;
            button2.Text = "SAVE";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 754);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private TextBox textBox12;
        private TextBox textBox11;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox4;
        private Label label12;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox16;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private GroupBox groupBox5;
        private TextBox textBox18;
        private Label label18;
        private TextBox textBox17;
        private Label label17;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private GroupBox groupBox6;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private RadioButton radioButton5;
    }
}