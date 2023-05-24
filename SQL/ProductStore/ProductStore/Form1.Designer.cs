namespace ProductStore
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
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            textBox9 = new TextBox();
            label13 = new Label();
            comboBox2 = new ComboBox();
            label12 = new Label();
            textBox8 = new TextBox();
            label11 = new Label();
            groupBox2 = new GroupBox();
            textBox13 = new TextBox();
            label17 = new Label();
            textBox12 = new TextBox();
            label16 = new Label();
            textBox11 = new TextBox();
            label15 = new Label();
            groupBox3 = new GroupBox();
            textBox7 = new TextBox();
            label18 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(90, 53);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(197, 51);
            textBox1.MaxLength = 500;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 29);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 137);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 2;
            label2.Text = "Contact Detail";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(197, 131);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 28);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(95, 56);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 4;
            label3.Text = "Invoice Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(219, 49);
            dateTimePicker1.MinDate = new DateTime(2023, 5, 18, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 29);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2023, 5, 18, 15, 32, 32, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(81, 95);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 6;
            label4.Text = "Nationality";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(195, 93);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 25);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Indian";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(328, 93);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 25);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "NRI";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(127, 153);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 9;
            label5.Text = "Product";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(219, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 30);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(123, 268);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 11;
            label6.Text = "Quantity";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(216, 263);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 31);
            textBox3.TabIndex = 12;
            textBox3.Text = "0";
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 56);
            label7.Name = "label7";
            label7.Size = new Size(51, 21);
            label7.TabIndex = 13;
            label7.Text = "CGST";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(85, 52);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(148, 28);
            textBox4.TabIndex = 14;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 107);
            label8.Name = "label8";
            label8.Size = new Size(50, 21);
            label8.TabIndex = 15;
            label8.Text = "SGST";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(85, 107);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(147, 28);
            textBox5.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(19, 155);
            label9.Name = "label9";
            label9.Size = new Size(47, 21);
            label9.TabIndex = 17;
            label9.Text = "IGST";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(85, 151);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(147, 28);
            textBox6.TabIndex = 18;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(453, 557);
            button1.Name = "button1";
            button1.Size = new Size(105, 53);
            button1.TabIndex = 21;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(636, 557);
            button2.Name = "button2";
            button2.Size = new Size(105, 53);
            button2.TabIndex = 22;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(11, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 195);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Details";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(216, 205);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(303, 31);
            textBox9.TabIndex = 28;
            textBox9.Text = "0";
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(152, 208);
            label13.Name = "label13";
            label13.Size = new Size(49, 21);
            label13.TabIndex = 27;
            label13.Text = "Price";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(219, 95);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(300, 31);
            comboBox2.TabIndex = 26;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(58, 99);
            label12.Name = "label12";
            label12.Size = new Size(144, 21);
            label12.TabIndex = 25;
            label12.Text = "Product Category";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(215, 358);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(300, 31);
            textBox8.TabIndex = 24;
            textBox8.Text = "0";
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(95, 369);
            label11.Name = "label11";
            label11.Size = new Size(103, 21);
            label11.TabIndex = 23;
            label11.Text = "Net Amount";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox13);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(textBox12);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(textBox11);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(11, 215);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(550, 239);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "GST Details";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(369, 152);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(162, 31);
            textBox13.TabIndex = 24;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(273, 155);
            label17.Name = "label17";
            label17.Size = new Size(79, 23);
            label17.TabIndex = 23;
            label17.Text = "Amount";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(369, 101);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(162, 31);
            textBox12.TabIndex = 22;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(273, 105);
            label16.Name = "label16";
            label16.Size = new Size(79, 23);
            label16.TabIndex = 21;
            label16.Text = "Amount";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(369, 51);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(162, 31);
            textBox11.TabIndex = 20;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(273, 53);
            label15.Name = "label15";
            label15.Size = new Size(79, 23);
            label15.TabIndex = 19;
            label15.Text = "Amount";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(580, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(601, 445);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product Details";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(216, 315);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(297, 31);
            textBox7.TabIndex = 30;
            textBox7.Text = "0";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(72, 318);
            label18.Name = "label18";
            label18.Size = new Size(126, 23);
            label18.TabIndex = 29;
            label18.Text = "Total Amount";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(528, 9);
            label10.Name = "label10";
            label10.Size = new Size(180, 33);
            label10.TabIndex = 33;
            label10.Text = "Product Store";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(15, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1197, 468);
            panel1.TabIndex = 35;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 633);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label11;
        private TextBox textBox9;
        private Label label13;
        private ComboBox comboBox2;
        private Label label12;
        private TextBox textBox8;
        private GroupBox groupBox2;
        private TextBox textBox12;
        private Label label16;
        private TextBox textBox11;
        private Label label15;
        private TextBox textBox13;
        private Label label17;
        private GroupBox groupBox3;
        private Label label10;
        private Panel panel1;
        private TextBox textBox7;
        private Label label18;
    }
}