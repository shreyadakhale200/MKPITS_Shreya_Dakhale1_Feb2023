namespace Calculator
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
            textBox1 = new TextBox();
            one = new Button();
            Two = new Button();
            Three = new Button();
            Four = new Button();
            Five = new Button();
            Six = new Button();
            Seven = new Button();
            Eight = new Button();
            Nine = new Button();
            Add = new Button();
            Equal = new Button();
            Subtract = new Button();
            Clear = new Button();
            Multiply = new Button();
            Divide = new Button();
            Zero = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(-3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1120, 61);
            textBox1.TabIndex = 0;
            // 
            // one
            // 
            one.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            one.Location = new Point(12, 69);
            one.Name = "one";
            one.Size = new Size(94, 115);
            one.TabIndex = 1;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // Two
            // 
            Two.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Two.Location = new Point(112, 69);
            Two.Name = "Two";
            Two.Size = new Size(94, 115);
            Two.TabIndex = 2;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += Two_Click;
            // 
            // Three
            // 
            Three.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Three.Location = new Point(212, 69);
            Three.Name = "Three";
            Three.Size = new Size(94, 115);
            Three.TabIndex = 3;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += Three_Click_1;
            // 
            // Four
            // 
            Four.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Four.Location = new Point(312, 69);
            Four.Name = "Four";
            Four.Size = new Size(94, 115);
            Four.TabIndex = 4;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += Four_Click;
            // 
            // Five
            // 
            Five.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Five.Location = new Point(412, 69);
            Five.Name = "Five";
            Five.Size = new Size(94, 115);
            Five.TabIndex = 5;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += Five_Click;
            // 
            // Six
            // 
            Six.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Six.Location = new Point(12, 190);
            Six.Name = "Six";
            Six.Size = new Size(94, 115);
            Six.TabIndex = 6;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Six_Click;
            // 
            // Seven
            // 
            Seven.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Seven.Location = new Point(112, 190);
            Seven.Name = "Seven";
            Seven.Size = new Size(94, 115);
            Seven.TabIndex = 7;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += Seven_Click;
            // 
            // Eight
            // 
            Eight.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Eight.Location = new Point(212, 190);
            Eight.Name = "Eight";
            Eight.Size = new Size(94, 115);
            Eight.TabIndex = 8;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += Eight_Click;
            // 
            // Nine
            // 
            Nine.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Nine.Location = new Point(312, 190);
            Nine.Name = "Nine";
            Nine.Size = new Size(94, 115);
            Nine.TabIndex = 9;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += Nine_Click;
            // 
            // Add
            // 
            Add.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(412, 190);
            Add.Name = "Add";
            Add.Size = new Size(94, 115);
            Add.TabIndex = 10;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click_1;
            // 
            // Equal
            // 
            Equal.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Equal.Location = new Point(512, 69);
            Equal.Name = "Equal";
            Equal.Size = new Size(535, 402);
            Equal.TabIndex = 11;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click;
            // 
            // Subtract
            // 
            Subtract.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Subtract.Location = new Point(112, 311);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(94, 119);
            Subtract.TabIndex = 12;
            Subtract.Text = "-";
            Subtract.UseVisualStyleBackColor = true;
            Subtract.Click += Subtract_Click;
            // 
            // Clear
            // 
            Clear.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Clear.Location = new Point(12, 311);
            Clear.Name = "Clear";
            Clear.Size = new Size(94, 119);
            Clear.TabIndex = 13;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Multiply
            // 
            Multiply.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Multiply.Location = new Point(312, 311);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(94, 115);
            Multiply.TabIndex = 14;
            Multiply.Text = "X";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Multiply_Click;
            // 
            // Divide
            // 
            Divide.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Divide.Location = new Point(212, 311);
            Divide.Name = "Divide";
            Divide.Size = new Size(94, 119);
            Divide.TabIndex = 15;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Divide_Click;
            // 
            // Zero
            // 
            Zero.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Zero.Location = new Point(412, 311);
            Zero.Name = "Zero";
            Zero.Size = new Size(94, 115);
            Zero.TabIndex = 16;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 653);
            Controls.Add(Zero);
            Controls.Add(Divide);
            Controls.Add(Multiply);
            Controls.Add(Clear);
            Controls.Add(Subtract);
            Controls.Add(Equal);
            Controls.Add(Add);
            Controls.Add(Nine);
            Controls.Add(Eight);
            Controls.Add(Seven);
            Controls.Add(Six);
            Controls.Add(Five);
            Controls.Add(Four);
            Controls.Add(Three);
            Controls.Add(Two);
            Controls.Add(one);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button one;
        private Button Two;
        private Button Three;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Add;
        private Button Equal;
        private Button Subtract;
        private Button Clear;
        private Button Multiply;
        private Button Divide;
        private Button Zero;
    }
}