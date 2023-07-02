namespace FormRegister
{
    partial class PopUpDisplay
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
            labelNameDisplay = new Label();
            labelAgeDisplay = new Label();
            labelMobileNoDisplay = new Label();
            SuspendLayout();
            // 
            // labelNameDisplay
            // 
            labelNameDisplay.AutoSize = true;
            labelNameDisplay.Location = new Point(73, 34);
            labelNameDisplay.Name = "labelNameDisplay";
            labelNameDisplay.Size = new Size(53, 20);
            labelNameDisplay.TabIndex = 0;
            labelNameDisplay.Text = "Name ";
            // 
            // labelAgeDisplay
            // 
            labelAgeDisplay.AutoSize = true;
            labelAgeDisplay.Location = new Point(73, 58);
            labelAgeDisplay.Name = "labelAgeDisplay";
            labelAgeDisplay.Size = new Size(36, 20);
            labelAgeDisplay.TabIndex = 1;
            labelAgeDisplay.Text = "Age";
            // 
            // labelMobileNoDisplay
            // 
            labelMobileNoDisplay.AutoSize = true;
            labelMobileNoDisplay.Location = new Point(73, 83);
            labelMobileNoDisplay.Name = "labelMobileNoDisplay";
            labelMobileNoDisplay.Size = new Size(114, 20);
            labelMobileNoDisplay.TabIndex = 2;
            labelMobileNoDisplay.Text = "Mobile Number";
            // 
            // PopUpDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 189);
            Controls.Add(labelMobileNoDisplay);
            Controls.Add(labelAgeDisplay);
            Controls.Add(labelNameDisplay);
            Name = "PopUpDisplay";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PopUpDisplay";
            Load += PopUpDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNameDisplay;
        private Label labelAgeDisplay;
        private Label labelMobileNoDisplay;
    }
}