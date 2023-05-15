namespace BooksDetails
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
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(89, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Scholastic Books";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(298, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 30);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 128);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 4;
            label3.Text = "Quantity :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(298, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 30);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 91);
            label2.Name = "label2";
            label2.Size = new Size(56, 24);
            label2.TabIndex = 2;
            label2.Text = "Price :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 55);
            label1.Name = "label1";
            label1.Size = new Size(171, 24);
            label1.TabIndex = 0;
            label1.Text = "Enter your Fav Book :";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(326, 278);
            button1.Name = "button1";
            button1.Size = new Size(146, 66);
            button1.TabIndex = 1;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(326, 373);
            label4.Name = "label4";
            label4.Size = new Size(66, 24);
            label4.TabIndex = 2;
            label4.Text = "Result :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
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
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label4;
    }
}