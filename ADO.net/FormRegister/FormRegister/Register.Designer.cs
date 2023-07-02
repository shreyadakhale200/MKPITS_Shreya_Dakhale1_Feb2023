namespace FormRegister
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxRegister = new GroupBox();
            labelMobileno = new Label();
            buttonSubmit = new Button();
            textBoxMobileNo = new TextBox();
            textBoxAge = new TextBox();
            labelAge = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            buttonReset = new Button();
            groupBoxRegister.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRegister
            // 
            groupBoxRegister.Controls.Add(buttonReset);
            groupBoxRegister.Controls.Add(labelMobileno);
            groupBoxRegister.Controls.Add(buttonSubmit);
            groupBoxRegister.Controls.Add(textBoxMobileNo);
            groupBoxRegister.Controls.Add(textBoxAge);
            groupBoxRegister.Controls.Add(labelAge);
            groupBoxRegister.Controls.Add(textBoxName);
            groupBoxRegister.Controls.Add(labelName);
            groupBoxRegister.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxRegister.Location = new Point(12, 12);
            groupBoxRegister.Name = "groupBoxRegister";
            groupBoxRegister.Size = new Size(343, 222);
            groupBoxRegister.TabIndex = 0;
            groupBoxRegister.TabStop = false;
            groupBoxRegister.Text = "Register Here";
            groupBoxRegister.Enter += groupBoxRegister_Enter;
            // 
            // labelMobileno
            // 
            labelMobileno.AutoSize = true;
            labelMobileno.ForeColor = Color.FromArgb(192, 0, 0);
            labelMobileno.Location = new Point(51, 115);
            labelMobileno.Name = "labelMobileno";
            labelMobileno.Size = new Size(81, 19);
            labelMobileno.TabIndex = 5;
            labelMobileno.Text = "Mobile No";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(208, 173);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(94, 29);
            buttonSubmit.TabIndex = 7;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // textBoxMobileNo
            // 
            textBoxMobileNo.Location = new Point(142, 107);
            textBoxMobileNo.MaxLength = 10;
            textBoxMobileNo.Name = "textBoxMobileNo";
            textBoxMobileNo.Size = new Size(160, 27);
            textBoxMobileNo.TabIndex = 6;
            textBoxMobileNo.KeyPress += textBox1_KeyPress;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(142, 80);
            textBoxAge.MaxLength = 3;
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(160, 27);
            textBoxAge.TabIndex = 4;
            textBoxAge.TextChanged += textBoxAge_TextChanged;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(51, 83);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(38, 19);
            labelAge.TabIndex = 3;
            labelAge.Text = "Age";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(142, 53);
            textBoxName.MaxLength = 500;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(160, 27);
            textBoxName.TabIndex = 2;
            textBoxName.Leave += textBoxName_Leave;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.ForeColor = Color.FromArgb(192, 0, 0);
            labelName.Location = new Point(51, 56);
            labelName.Name = "labelName";
            labelName.Size = new Size(51, 19);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            labelName.Click += labelName_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(114, 173);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 246);
            Controls.Add(groupBoxRegister);
            Name = "Register";
            Text = "Register";
            groupBoxRegister.ResumeLayout(false);
            groupBoxRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxRegister;
        private TextBox textBoxName;
        private Label labelName;
        private Button buttonSubmit;
        private TextBox textBoxMobileNo;
        private TextBox textBoxAge;
        private Label labelAge;
        private Label labelMobileno;
        private Button buttonReset;
    }
}