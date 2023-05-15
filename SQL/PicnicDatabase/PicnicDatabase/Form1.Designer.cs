namespace PicnicDatabase
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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Highland Park";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(306, 198);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(208, 32);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Koradi Road", "Civil Lines" });
            comboBox1.Location = new Point(306, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 32);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(203, 201);
            label5.Name = "label5";
            label5.Size = new Size(97, 24);
            label5.TabIndex = 8;
            label5.Text = "Drop Point :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 163);
            label4.Name = "label4";
            label4.Size = new Size(115, 24);
            label4.TabIndex = 6;
            label4.Text = "Pick-up Point :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(306, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 30);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 127);
            label3.Name = "label3";
            label3.Size = new Size(143, 24);
            label3.TabIndex = 4;
            label3.Text = "Parent's Number :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(306, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 30);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 88);
            label2.Name = "label2";
            label2.Size = new Size(101, 24);
            label2.TabIndex = 2;
            label2.Text = "Last Name :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 52);
            label1.Name = "label1";
            label1.Size = new Size(101, 24);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(352, 296);
            button1.Name = "button1";
            button1.Size = new Size(128, 57);
            button1.TabIndex = 1;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(352, 400);
            label6.Name = "label6";
            label6.Size = new Size(66, 24);
            label6.TabIndex = 2;
            label6.Text = "Result :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
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
        private Label label1;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}