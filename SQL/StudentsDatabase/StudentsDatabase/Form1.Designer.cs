namespace StudentsDatabase
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
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label5 = new Label();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(90, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(628, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Details";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(281, 180);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 28);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 183);
            label4.Name = "label4";
            label4.Size = new Size(44, 22);
            label4.TabIndex = 6;
            label4.Text = "Age :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(281, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 28);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 135);
            label3.Name = "label3";
            label3.Size = new Size(71, 22);
            label3.TabIndex = 4;
            label3.Text = "Address :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 92);
            label2.Name = "label2";
            label2.Size = new Size(65, 22);
            label2.TabIndex = 2;
            label2.Text = "Course :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 28);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 48);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(403, 274);
            button1.Name = "button1";
            button1.Size = new Size(144, 55);
            button1.TabIndex = 1;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(90, 352);
            label5.Name = "label5";
            label5.Size = new Size(58, 22);
            label5.TabIndex = 2;
            label5.Text = "Result :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DotNet", "Java" });
            comboBox1.Location = new Point(281, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 30);
            comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label5;
        private ComboBox comboBox1;
    }
}