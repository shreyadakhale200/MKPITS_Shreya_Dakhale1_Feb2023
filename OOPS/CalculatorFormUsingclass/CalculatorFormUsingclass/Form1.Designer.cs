namespace CalculatorFormUsingclass
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
            One = new Button();
            Two = new Button();
            Three = new Button();
            Add = new Button();
            Equal = new Button();
            Seven = new Button();
            Minus = new Button();
            Multiply = new Button();
            Four = new Button();
            Five = new Button();
            Six = new Button();
            Eight = new Button();
            Nine = new Button();
            Zero = new Button();
            Divide = new Button();
            Modulus = new Button();
            Power = new Button();
            Clear = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(9, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(907, 65);
            textBox1.TabIndex = 0;
            // 
            // One
            // 
            One.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            One.Location = new Point(12, 89);
            One.Name = "One";
            One.Size = new Size(124, 127);
            One.TabIndex = 1;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += One_Click;
            // 
            // Two
            // 
            Two.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Two.Location = new Point(142, 89);
            Two.Name = "Two";
            Two.Size = new Size(124, 127);
            Two.TabIndex = 2;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += Two_Click;
            // 
            // Three
            // 
            Three.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Three.Location = new Point(272, 89);
            Three.Name = "Three";
            Three.Size = new Size(124, 127);
            Three.TabIndex = 3;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += Three_Click;
            // 
            // Add
            // 
            Add.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(142, 355);
            Add.Name = "Add";
            Add.Size = new Size(124, 127);
            Add.TabIndex = 4;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Equal
            // 
            Equal.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Equal.Location = new Point(532, 222);
            Equal.Name = "Equal";
            Equal.Size = new Size(384, 393);
            Equal.TabIndex = 5;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click;
            // 
            // Seven
            // 
            Seven.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Seven.Location = new Point(792, 89);
            Seven.Name = "Seven";
            Seven.Size = new Size(124, 127);
            Seven.TabIndex = 6;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += Seven_Click;
            // 
            // Minus
            // 
            Minus.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Minus.Location = new Point(9, 355);
            Minus.Name = "Minus";
            Minus.Size = new Size(124, 127);
            Minus.TabIndex = 7;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Minus_Click;
            // 
            // Multiply
            // 
            Multiply.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Multiply.Location = new Point(402, 222);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(124, 127);
            Multiply.TabIndex = 8;
            Multiply.Text = "X";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Multiply_Click;
            // 
            // Four
            // 
            Four.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Four.Location = new Point(402, 89);
            Four.Name = "Four";
            Four.Size = new Size(124, 127);
            Four.TabIndex = 9;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += Four_Click;
            // 
            // Five
            // 
            Five.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Five.Location = new Point(532, 89);
            Five.Name = "Five";
            Five.Size = new Size(124, 127);
            Five.TabIndex = 10;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += Five_Click;
            // 
            // Six
            // 
            Six.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Six.Location = new Point(662, 89);
            Six.Name = "Six";
            Six.Size = new Size(124, 127);
            Six.TabIndex = 11;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Six_Click;
            // 
            // Eight
            // 
            Eight.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Eight.Location = new Point(12, 222);
            Eight.Name = "Eight";
            Eight.Size = new Size(124, 127);
            Eight.TabIndex = 12;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += Eight_Click;
            // 
            // Nine
            // 
            Nine.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Nine.Location = new Point(142, 222);
            Nine.Name = "Nine";
            Nine.Size = new Size(124, 127);
            Nine.TabIndex = 13;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += Nine_Click;
            // 
            // Zero
            // 
            Zero.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Zero.Location = new Point(272, 222);
            Zero.Name = "Zero";
            Zero.Size = new Size(124, 127);
            Zero.TabIndex = 14;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // Divide
            // 
            Divide.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Divide.Location = new Point(272, 355);
            Divide.Name = "Divide";
            Divide.Size = new Size(124, 127);
            Divide.TabIndex = 15;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Divide_Click;
            // 
            // Modulus
            // 
            Modulus.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Modulus.Location = new Point(402, 355);
            Modulus.Name = "Modulus";
            Modulus.Size = new Size(124, 127);
            Modulus.TabIndex = 16;
            Modulus.Text = "%";
            Modulus.UseVisualStyleBackColor = true;
            Modulus.Click += Modulus_Click;
            // 
            // Power
            // 
            Power.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Power.Location = new Point(9, 488);
            Power.Name = "Power";
            Power.Size = new Size(124, 127);
            Power.TabIndex = 17;
            Power.Text = "^";
            Power.UseVisualStyleBackColor = true;
            Power.Click += Power_Click;
            // 
            // Clear
            // 
            Clear.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Clear.Location = new Point(142, 488);
            Clear.Name = "Clear";
            Clear.Size = new Size(124, 127);
            Clear.TabIndex = 18;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 701);
            Controls.Add(Clear);
            Controls.Add(Power);
            Controls.Add(Modulus);
            Controls.Add(Divide);
            Controls.Add(Zero);
            Controls.Add(Nine);
            Controls.Add(Eight);
            Controls.Add(Six);
            Controls.Add(Five);
            Controls.Add(Four);
            Controls.Add(Multiply);
            Controls.Add(Minus);
            Controls.Add(Seven);
            Controls.Add(Equal);
            Controls.Add(Add);
            Controls.Add(Three);
            Controls.Add(Two);
            Controls.Add(One);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button One;
        private Button Two;
        private Button Three;
        private Button Add;
        private Button Equal;
        private Button Seven;
        private Button Minus;
        private Button Multiply;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button Eight;
        private Button Nine;
        private Button Zero;
        private Button Divide;
        private Button Modulus;
        private Button Power;
        private Button Clear;
    }
}