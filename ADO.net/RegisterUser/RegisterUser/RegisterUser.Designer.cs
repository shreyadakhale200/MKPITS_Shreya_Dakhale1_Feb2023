namespace RegisterUser
{
    partial class RegisterUser
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
            groupBox1Register = new GroupBox();
            button1Delete = new Button();
            button1Unedit = new Button();
            button2Edit = new Button();
            textBox1Rollno = new TextBox();
            label1Rollno = new Label();
            button1Update = new Button();
            button1Submit = new Button();
            label1Password = new Label();
            textBox2password = new TextBox();
            textBox1username = new TextBox();
            label1Username = new Label();
            label1status = new Label();
            groupBox1Register.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1Register
            // 
            groupBox1Register.Controls.Add(label1status);
            groupBox1Register.Controls.Add(button1Delete);
            groupBox1Register.Controls.Add(button1Unedit);
            groupBox1Register.Controls.Add(button2Edit);
            groupBox1Register.Controls.Add(textBox1Rollno);
            groupBox1Register.Controls.Add(label1Rollno);
            groupBox1Register.Controls.Add(button1Update);
            groupBox1Register.Controls.Add(button1Submit);
            groupBox1Register.Controls.Add(label1Password);
            groupBox1Register.Controls.Add(textBox2password);
            groupBox1Register.Controls.Add(textBox1username);
            groupBox1Register.Controls.Add(label1Username);
            groupBox1Register.Location = new Point(12, 12);
            groupBox1Register.Name = "groupBox1Register";
            groupBox1Register.Size = new Size(491, 184);
            groupBox1Register.TabIndex = 1;
            groupBox1Register.TabStop = false;
            groupBox1Register.Text = "Register Please";
            // 
            // button1Delete
            // 
            button1Delete.Enabled = false;
            button1Delete.Location = new Point(294, 121);
            button1Delete.Name = "button1Delete";
            button1Delete.Size = new Size(94, 29);
            button1Delete.TabIndex = 9;
            button1Delete.Text = "Delete";
            button1Delete.UseVisualStyleBackColor = true;
            button1Delete.Click += button1Delete_Click;
            // 
            // button1Unedit
            // 
            button1Unedit.Location = new Point(389, 121);
            button1Unedit.Name = "button1Unedit";
            button1Unedit.Size = new Size(94, 29);
            button1Unedit.TabIndex = 2;
            button1Unedit.Text = "UnEdit";
            button1Unedit.UseVisualStyleBackColor = true;
            button1Unedit.Visible = false;
            button1Unedit.Click += button1Unedit_Click;
            // 
            // button2Edit
            // 
            button2Edit.Location = new Point(199, 121);
            button2Edit.Name = "button2Edit";
            button2Edit.Size = new Size(94, 29);
            button2Edit.TabIndex = 8;
            button2Edit.Text = "Edit";
            button2Edit.UseVisualStyleBackColor = true;
            button2Edit.Click += button2Edit_Click;
            // 
            // textBox1Rollno
            // 
            textBox1Rollno.Enabled = false;
            textBox1Rollno.Location = new Point(228, 38);
            textBox1Rollno.MaxLength = 50;
            textBox1Rollno.Name = "textBox1Rollno";
            textBox1Rollno.Size = new Size(149, 27);
            textBox1Rollno.TabIndex = 7;
            textBox1Rollno.TextChanged += textBox1Rollno_TextChanged;
            textBox1Rollno.KeyPress += textBox1Rollno_KeyPress;
            // 
            // label1Rollno
            // 
            label1Rollno.AutoSize = true;
            label1Rollno.Location = new Point(133, 41);
            label1Rollno.Name = "label1Rollno";
            label1Rollno.Size = new Size(59, 20);
            label1Rollno.TabIndex = 6;
            label1Rollno.Text = "Roll No";
            // 
            // button1Update
            // 
            button1Update.Enabled = false;
            button1Update.Location = new Point(104, 121);
            button1Update.Name = "button1Update";
            button1Update.Size = new Size(94, 29);
            button1Update.TabIndex = 5;
            button1Update.Text = "Update";
            button1Update.UseVisualStyleBackColor = true;
            button1Update.Click += button1Update_Click;
            // 
            // button1Submit
            // 
            button1Submit.Location = new Point(8, 121);
            button1Submit.Name = "button1Submit";
            button1Submit.Size = new Size(94, 29);
            button1Submit.TabIndex = 4;
            button1Submit.Text = "Insert";
            button1Submit.UseVisualStyleBackColor = true;
            button1Submit.Click += button1Submit_Click;
            // 
            // label1Password
            // 
            label1Password.AutoSize = true;
            label1Password.Location = new Point(122, 92);
            label1Password.Name = "label1Password";
            label1Password.Size = new Size(70, 20);
            label1Password.TabIndex = 3;
            label1Password.Text = "Password";
            // 
            // textBox2password
            // 
            textBox2password.AcceptsTab = true;
            textBox2password.AutoCompleteMode = AutoCompleteMode.Append;
            textBox2password.Location = new Point(228, 89);
            textBox2password.Name = "textBox2password";
            textBox2password.PasswordChar = '*';
            textBox2password.Size = new Size(149, 27);
            textBox2password.TabIndex = 2;
            // 
            // textBox1username
            // 
            textBox1username.Location = new Point(228, 62);
            textBox1username.Name = "textBox1username";
            textBox1username.Size = new Size(149, 27);
            textBox1username.TabIndex = 1;
            textBox1username.TextChanged += textBox1username_TextChanged;
            textBox1username.KeyPress += textBox1username_KeyPress;
            textBox1username.Leave += textBox1username_Leave;
            // 
            // label1Username
            // 
            label1Username.AutoSize = true;
            label1Username.Location = new Point(117, 65);
            label1Username.Name = "label1Username";
            label1Username.Size = new Size(75, 20);
            label1Username.TabIndex = 0;
            label1Username.Text = "Username";
            // 
            // label1status
            // 
            label1status.AutoSize = true;
            label1status.Location = new Point(228, 153);
            label1status.Name = "label1status";
            label1status.Size = new Size(49, 20);
            label1status.TabIndex = 10;
            label1status.Text = "Result";
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 208);
            Controls.Add(groupBox1Register);
            Name = "RegisterUser";
            Text = "RegisterUser";
            Load += RegisterUser_Load;
            groupBox1Register.ResumeLayout(false);
            groupBox1Register.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1Register;
        private Button button1Submit;
        private Label label1Password;
        private TextBox textBox2password;
        private TextBox textBox1username;
        private Label label1Username;
        private Button button1Update;
        private TextBox textBox1Rollno;
        private Label label1Rollno;
        private Button button2Edit;
        private Button button1Unedit;
        private Button button1Delete;
        private Label label1status;
    }
}