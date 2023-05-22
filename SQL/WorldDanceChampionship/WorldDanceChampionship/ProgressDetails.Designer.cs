namespace WorldDanceChampionship
{
    partial class ProgressDetails
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 46);
            label1.Name = "label1";
            label1.Size = new Size(62, 27);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(103, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 34);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 101);
            label2.Name = "label2";
            label2.Size = new Size(45, 27);
            label2.TabIndex = 2;
            label2.Text = "Age";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(103, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 34);
            textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(360, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(424, 213);
            dataGridView1.TabIndex = 4;
            // 
            // ProgressDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ProgressDetails";
            Text = "ProgressDetails";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private DataGridView dataGridView1;
    }
}