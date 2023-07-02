namespace RegistrationForm
{
    partial class RegisterForm
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
            RegistergroupBox = new GroupBox();
            Savebutton = new Button();
            Resetbutton = new Button();
            MobilenotextBox = new TextBox();
            Mobilenolabel = new Label();
            AgetextBox = new TextBox();
            Agelabel = new Label();
            NametextBox = new TextBox();
            Namelabel = new Label();
            RegistergroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RegistergroupBox
            // 
            RegistergroupBox.Controls.Add(Savebutton);
            RegistergroupBox.Controls.Add(Resetbutton);
            RegistergroupBox.Controls.Add(MobilenotextBox);
            RegistergroupBox.Controls.Add(Mobilenolabel);
            RegistergroupBox.Controls.Add(AgetextBox);
            RegistergroupBox.Controls.Add(Agelabel);
            RegistergroupBox.Controls.Add(NametextBox);
            RegistergroupBox.Controls.Add(Namelabel);
            RegistergroupBox.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            RegistergroupBox.Location = new Point(51, 32);
            RegistergroupBox.Name = "RegistergroupBox";
            RegistergroupBox.Size = new Size(370, 186);
            RegistergroupBox.TabIndex = 0;
            RegistergroupBox.TabStop = false;
            RegistergroupBox.Text = "Register ";
            // 
            // Savebutton
            // 
            Savebutton.Enabled = false;
            Savebutton.Location = new Point(259, 151);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(94, 29);
            Savebutton.TabIndex = 13;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = true;
            Savebutton.Click += Savebutton_Click;
            // 
            // Resetbutton
            // 
            Resetbutton.Location = new Point(154, 151);
            Resetbutton.Name = "Resetbutton";
            Resetbutton.Size = new Size(94, 29);
            Resetbutton.TabIndex = 12;
            Resetbutton.Text = "Reset";
            Resetbutton.UseVisualStyleBackColor = true;
            // 
            // MobilenotextBox
            // 
            MobilenotextBox.Location = new Point(154, 96);
            MobilenotextBox.MaxLength = 10;
            MobilenotextBox.Name = "MobilenotextBox";
            MobilenotextBox.Size = new Size(199, 27);
            MobilenotextBox.TabIndex = 11;
            MobilenotextBox.KeyPress += MobilenotextBox_KeyPress;
            // 
            // Mobilenolabel
            // 
            Mobilenolabel.AutoSize = true;
            Mobilenolabel.Location = new Point(26, 99);
            Mobilenolabel.Name = "Mobilenolabel";
            Mobilenolabel.Size = new Size(109, 22);
            Mobilenolabel.TabIndex = 10;
            Mobilenolabel.Text = "Mobile Number";
            // 
            // AgetextBox
            // 
            AgetextBox.Location = new Point(154, 68);
            AgetextBox.MaxLength = 3;
            AgetextBox.Name = "AgetextBox";
            AgetextBox.Size = new Size(199, 27);
            AgetextBox.TabIndex = 9;
            AgetextBox.SizeChanged += AgetextBox_SizeChanged;
            AgetextBox.TextChanged += AgetextBox_TextChanged;
            // 
            // Agelabel
            // 
            Agelabel.AutoSize = true;
            Agelabel.Location = new Point(26, 71);
            Agelabel.Name = "Agelabel";
            Agelabel.Size = new Size(35, 22);
            Agelabel.TabIndex = 8;
            Agelabel.Text = "Age";
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(154, 39);
            NametextBox.MaxLength = 50;
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(199, 27);
            NametextBox.TabIndex = 7;
            NametextBox.TextChanged += NametextBox_TextChanged;
            // 
            // Namelabel
            // 
            Namelabel.AutoSize = true;
            Namelabel.Location = new Point(26, 42);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(49, 22);
            Namelabel.TabIndex = 6;
            Namelabel.Text = "Name";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 260);
            Controls.Add(RegistergroupBox);
            Name = "RegisterForm";
            Text = "Register";
            RegistergroupBox.ResumeLayout(false);
            RegistergroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RegistergroupBox;
        private TextBox MobilenotextBox;
        private Label Mobilenolabel;
        private TextBox AgetextBox;
        private Label Agelabel;
        private TextBox NametextBox;
        private Label Namelabel;
        private Button Savebutton;
        private Button Resetbutton;
    }
}