namespace InstituteCourseRegistration
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
            groupBox1 = new GroupBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox3 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Details";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(138, 364);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 30);
            comboBox3.TabIndex = 9;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(138, 311);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 30);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(138, 260);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 30);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 28);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 367);
            label5.Name = "label5";
            label5.Size = new Size(34, 22);
            label5.TabIndex = 5;
            label5.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 314);
            label4.Name = "label4";
            label4.Size = new Size(42, 22);
            label4.TabIndex = 4;
            label4.Text = "State";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 263);
            label3.Name = "label3";
            label3.Size = new Size(51, 22);
            label3.TabIndex = 3;
            label3.Text = "Nation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 227);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 2;
            label2.Text = "Full Name";
            label2.Click += label2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton5);
            groupBox4.Controls.Add(radioButton3);
            groupBox4.Controls.Add(radioButton4);
            groupBox4.Location = new Point(33, 115);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(411, 84);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Gender";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(297, 30);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(66, 26);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "Other";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(49, 33);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(63, 26);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Male";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(165, 33);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(80, 26);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Female";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(33, 41);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(411, 84);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Select Category";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(165, 36);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(125, 26);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "IT Professional";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(49, 36);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(79, 26);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Student";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(544, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(446, 431);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fees Details";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(164, 199);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(183, 28);
            dateTimePicker1.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(164, 145);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 28);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(164, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 28);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 48);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 28);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 204);
            label9.Name = "label9";
            label9.Size = new Size(101, 22);
            label9.TabIndex = 3;
            label9.Text = "Payment Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 148);
            label8.Name = "label8";
            label8.Size = new Size(62, 22);
            label8.TabIndex = 2;
            label8.Text = "Balance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 97);
            label7.Name = "label7";
            label7.Size = new Size(93, 22);
            label7.TabIndex = 1;
            label7.Text = "Paid Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 51);
            label6.Name = "label6";
            label6.Size = new Size(95, 22);
            label6.TabIndex = 0;
            label6.Text = "Total Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(400, 33);
            label1.Name = "label1";
            label1.Size = new Size(276, 33);
            label1.TabIndex = 2;
            label1.Text = "Course Registration Form";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(379, 541);
            button1.Name = "button1";
            button1.Size = new Size(115, 41);
            button1.TabIndex = 3;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(585, 541);
            button2.Name = "button2";
            button2.Size = new Size(115, 41);
            button2.TabIndex = 4;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 594);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox4;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button1;
        private Button button2;
        private RadioButton radioButton5;
    }
}