namespace Product_StoreDatabase
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            label3 = new Label();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label16 = new Label();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            label15 = new Label();
            textBox10 = new TextBox();
            label14 = new Label();
            textBox9 = new TextBox();
            label13 = new Label();
            comboBox2 = new ComboBox();
            label12 = new Label();
            comboBox1 = new ComboBox();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 56);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 137);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 2;
            label2.Text = "Conntact Details";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 134);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 27);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(173, 95);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(71, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Indian";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 95);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 5;
            label3.Text = "Nationality";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(289, 95);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "NRI";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 249);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 48);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 8;
            label4.Text = "CGST";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(85, 45);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(79, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(85, 93);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(79, 27);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 96);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 11;
            label5.Text = "SGST";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(85, 147);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(79, 27);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 147);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 13;
            label6.Text = "IGST";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(289, 45);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(119, 27);
            textBox6.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 48);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 15;
            label7.Text = "Amount";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(289, 95);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(119, 27);
            textBox7.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 102);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 17;
            label8.Text = "Amount";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(289, 146);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(119, 27);
            textBox8.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(209, 153);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 19;
            label9.Text = "Amount";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(39, 281);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(439, 252);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "GST Details";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(textBox12);
            groupBox3.Controls.Add(textBox11);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(484, 34);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(487, 499);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Invoice Details";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(38, 365);
            label16.Name = "label16";
            label16.Size = new Size(90, 20);
            label16.TabIndex = 13;
            label16.Text = "Net Amount";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(181, 362);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(250, 27);
            textBox12.TabIndex = 12;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(181, 296);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(250, 27);
            textBox11.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(38, 299);
            label15.Name = "label15";
            label15.Size = new Size(99, 20);
            label15.TabIndex = 10;
            label15.Text = "Total Amount";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(181, 244);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(152, 27);
            textBox10.TabIndex = 9;
            textBox10.Text = "0";
            textBox10.TextChanged += textBox10_TextChanged;
            textBox10.KeyPress += textBox10_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(38, 247);
            label14.Name = "label14";
            label14.Size = new Size(65, 20);
            label14.TabIndex = 8;
            label14.Text = "Quantity";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(181, 192);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(250, 27);
            textBox9.TabIndex = 7;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(38, 192);
            label13.Name = "label13";
            label13.Size = new Size(41, 20);
            label13.TabIndex = 6;
            label13.Text = "Price";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(181, 141);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(38, 141);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 4;
            label12.Text = "Product";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(181, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 95);
            label11.Name = "label11";
            label11.Size = new Size(124, 20);
            label11.TabIndex = 2;
            label11.Text = "Product Category";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(181, 43);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 48);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 0;
            label10.Text = "Invoice Date";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(328, 557);
            button1.Name = "button1";
            button1.Size = new Size(143, 51);
            button1.TabIndex = 22;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(522, 557);
            button2.Name = "button2";
            button2.Size = new Size(143, 51);
            button2.TabIndex = 23;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 631);
            Controls.Add(button2);
            Controls.Add(button1);
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
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private Label label3;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label16;
        private TextBox textBox12;
        private TextBox textBox11;
        private Label label15;
        private TextBox textBox10;
        private Label label14;
        private TextBox textBox9;
        private Label label13;
        private ComboBox comboBox2;
        private Label label12;
        private ComboBox comboBox1;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private Button button1;
        private Button button2;
    }
}