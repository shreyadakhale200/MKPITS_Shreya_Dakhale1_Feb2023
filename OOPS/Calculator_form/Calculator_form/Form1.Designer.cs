namespace Calculator_form
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
            Add = new Button();
            Equal = new Button();
            Three = new Button();
            Four = new Button();
            Five = new Button();
            Six = new Button();
            Seven = new Button();
            Eight = new Button();
            Nine = new Button();
            Zero = new Button();
            Subtract = new Button();
            Clear = new Button();
            Multiply = new Button();
            Divide = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(31, 26);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(633, 93);
            textBox1.TabIndex = 0;
            // 
            // one
            // 
            one.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            one.Location = new Point(31, 128);
            one.Margin = new Padding(3, 2, 3, 2);
            one.Name = "one";
            one.Size = new Size(101, 110);
            one.TabIndex = 1;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // Two
            // 
            Two.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Two.Location = new Point(140, 128);
            Two.Margin = new Padding(3, 2, 3, 2);
            Two.Name = "Two";
            Two.Size = new Size(100, 110);
            Two.TabIndex = 2;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += Two_Click;
            // 
            // Add
            // 
            Add.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(31, 471);
            Add.Margin = new Padding(3, 2, 3, 2);
            Add.Name = "Add";
            Add.Size = new Size(100, 108);
            Add.TabIndex = 3;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Equal
            // 
            Equal.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Equal.Location = new Point(352, 243);
            Equal.Margin = new Padding(3, 2, 3, 2);
            Equal.Name = "Equal";
            Equal.Size = new Size(312, 336);
            Equal.TabIndex = 4;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click;
            // 
            // Three
            // 
            Three.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Three.Location = new Point(246, 128);
            Three.Name = "Three";
            Three.Size = new Size(100, 110);
            Three.TabIndex = 5;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += Three_Click;
            // 
            // Four
            // 
            Four.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Four.Location = new Point(352, 128);
            Four.Name = "Four";
            Four.Size = new Size(100, 110);
            Four.TabIndex = 6;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += Four_Click;
            // 
            // Five
            // 
            Five.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Five.Location = new Point(458, 128);
            Five.Name = "Five";
            Five.Size = new Size(97, 110);
            Five.TabIndex = 7;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += Five_Click;
            // 
            // Six
            // 
            Six.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Six.Location = new Point(561, 128);
            Six.Name = "Six";
            Six.Size = new Size(103, 110);
            Six.TabIndex = 8;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Six_Click;
            // 
            // Seven
            // 
            Seven.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Seven.Location = new Point(31, 243);
            Seven.Margin = new Padding(3, 2, 3, 2);
            Seven.Name = "Seven";
            Seven.Size = new Size(100, 108);
            Seven.TabIndex = 9;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += Seven_Click;
            // 
            // Eight
            // 
            Eight.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Eight.Location = new Point(138, 243);
            Eight.Margin = new Padding(3, 2, 3, 2);
            Eight.Name = "Eight";
            Eight.Size = new Size(102, 108);
            Eight.TabIndex = 10;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += Eight_Click;
            // 
            // Nine
            // 
            Nine.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Nine.Location = new Point(246, 241);
            Nine.Margin = new Padding(3, 2, 3, 2);
            Nine.Name = "Nine";
            Nine.Size = new Size(100, 110);
            Nine.TabIndex = 11;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += Nine_Click;
            // 
            // Zero
            // 
            Zero.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Zero.Location = new Point(140, 355);
            Zero.Margin = new Padding(3, 2, 3, 2);
            Zero.Name = "Zero";
            Zero.Size = new Size(100, 110);
            Zero.TabIndex = 12;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // Subtract
            // 
            Subtract.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Subtract.Location = new Point(141, 471);
            Subtract.Margin = new Padding(3, 2, 3, 2);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(99, 108);
            Subtract.TabIndex = 13;
            Subtract.Text = "-";
            Subtract.UseVisualStyleBackColor = true;
            Subtract.Click += Subtract_Click;
            // 
            // Clear
            // 
            Clear.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Clear.Location = new Point(31, 356);
            Clear.Name = "Clear";
            Clear.Size = new Size(100, 109);
            Clear.TabIndex = 14;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Multiply
            // 
            Multiply.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Multiply.Location = new Point(246, 471);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(100, 108);
            Multiply.TabIndex = 15;
            Multiply.Text = "X";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Multiply_Click;
            // 
            // Divide
            // 
            Divide.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Divide.Location = new Point(246, 356);
            Divide.Name = "Divide";
            Divide.Size = new Size(100, 109);
            Divide.TabIndex = 16;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Divide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 632);
            Controls.Add(Divide);
            Controls.Add(Multiply);
            Controls.Add(Clear);
            Controls.Add(Subtract);
            Controls.Add(Zero);
            Controls.Add(Nine);
            Controls.Add(Eight);
            Controls.Add(Seven);
            Controls.Add(Six);
            Controls.Add(Five);
            Controls.Add(Four);
            Controls.Add(Three);
            Controls.Add(Equal);
            Controls.Add(Add);
            Controls.Add(Two);
            Controls.Add(one);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button one;
        private Button Two;
        private Button Add;
        private Button Equal;
        private Button Three;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Zero;
        private Button Subtract;
        private Button Clear;
        private Button Multiply;
        private Button Divide;
    }
}