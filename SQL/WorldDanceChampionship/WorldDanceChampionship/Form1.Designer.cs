namespace WorldDanceChampionship
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
            button5 = new Button();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label6 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(769, 234);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "World Dance Championship";
            // 
            // button5
            // 
            button5.Location = new Point(634, 46);
            button5.Name = "button5";
            button5.Size = new Size(129, 60);
            button5.TabIndex = 10;
            button5.Text = "SEARCH";
            button5.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(391, 183);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(222, 32);
            comboBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 186);
            label5.Name = "label5";
            label5.Size = new Size(49, 24);
            label5.TabIndex = 8;
            label5.Text = "City :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "India", "USA", "France", "Australia", "Italy" });
            comboBox1.Location = new Point(391, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 32);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 148);
            label4.Name = "label4";
            label4.Size = new Size(78, 24);
            label4.TabIndex = 6;
            label4.Text = "Country :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(391, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 30);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 115);
            label3.Name = "label3";
            label3.Size = new Size(93, 24);
            label3.TabIndex = 4;
            label3.Text = "Enter Age :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(391, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 30);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 82);
            label2.Name = "label2";
            label2.Size = new Size(101, 24);
            label2.TabIndex = 2;
            label2.Text = "Last Name :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(391, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 49);
            label1.Name = "label1";
            label1.Size = new Size(101, 24);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(30, 23);
            button1.Name = "button1";
            button1.Size = new Size(142, 55);
            button1.TabIndex = 1;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(341, 398);
            label6.Name = "label6";
            label6.Size = new Size(62, 24);
            label6.TabIndex = 2;
            label6.Text = "Status ";
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(219, 23);
            button2.Name = "button2";
            button2.Size = new Size(142, 55);
            button2.TabIndex = 3;
            button2.Text = "RESET FORM";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(13, 266);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 112);
            panel1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(605, 24);
            button4.Name = "button4";
            button4.Size = new Size(142, 55);
            button4.TabIndex = 5;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(416, 23);
            button3.Name = "button3";
            button3.Size = new Size(142, 55);
            button3.TabIndex = 4;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(792, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(706, 511);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1501, 553);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Button button1;
        private Label label6;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
    }
}