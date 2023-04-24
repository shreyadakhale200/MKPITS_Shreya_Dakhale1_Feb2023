namespace WinFormsAppLoginPage
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "India", "USA", "UK" });
            comboBox1.Location = new Point(167, 20);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 22);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 1;
            label1.Text = "Country :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 65);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 2;
            label2.Text = "City :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(167, 65);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(457, 373);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(141, 43);
            button1.TabIndex = 4;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 16);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 5;
            label3.Text = "Database :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 110);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 6;
            label4.Text = "Courses :";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "", "Java", "Dotnet", "C++", "C", "Python" });
            listBox1.Location = new Point(167, 110);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(133, 94);
            listBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(167, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(56, 223);
            label5.Name = "label5";
            label5.Size = new Size(51, 17);
            label5.TabIndex = 9;
            label5.Text = "DOB :";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(167, 274);
            maskedTextBox1.Mask = "(99) 000-000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(202, 23);
            maskedTextBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(9, 274);
            label6.Name = "label6";
            label6.Size = new Size(125, 17);
            label6.TabIndex = 11;
            label6.Text = "Phone Number :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(369, 16);
            label7.Name = "label7";
            label7.Size = new Size(148, 24);
            label7.TabIndex = 12;
            label7.Text = "Enquiry Form";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(312, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 312);
            panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(738, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 129);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 427);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Button button1;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private MaskedTextBox maskedTextBox1;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}