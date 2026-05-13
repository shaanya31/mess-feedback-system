namespace messFeedback2
{
    partial class Form3
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
            roundedPanel1 = new RoundedPanel();
            label3 = new Label();
            label1 = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            button3 = new Button();
            roundedPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(255, 128, 0);
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderWidth = 1;
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(lblTitle);
            roundedPanel1.CornerRadius = 20;
            roundedPanel1.Location = new Point(1, 12);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1268, 142);
            roundedPanel1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(553, 89);
            label3.Name = "label3";
            label3.Size = new Size(168, 28);
            label3.TabIndex = 3;
            label3.Text = "Cafe By The Valley";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 35);
            label1.Name = "label1";
            label1.Size = new Size(78, 54);
            label1.TabIndex = 2;
            label1.Text = "🍽️";
            label1.Click += label1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(284, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(667, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Mess Feedback System - Welcome";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(128, 128, 255);
            lblSubtitle.Location = new Point(557, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(158, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Average Rating";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 167);
            label2.Name = "label2";
            label2.Size = new Size(398, 28);
            label2.TabIndex = 3;
            label2.Text = "Welcome! Please select an option below:";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(204, 217);
            button1.Name = "button1";
            button1.Size = new Size(443, 100);
            button1.TabIndex = 15;
            button1.Text = "Submit Feedback";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(653, 217);
            button2.Name = "button2";
            button2.Size = new Size(447, 100);
            button2.TabIndex = 16;
            button2.Text = "Admin Dashboard";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblSubtitle);
            panel1.Location = new Point(31, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 172);
            panel1.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(897, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 28);
            label5.TabIndex = 5;
            label5.Text = "This Week";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(159, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 4;
            label4.Text = "Total Feedbacks";
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(554, 545);
            button3.Name = "button3";
            button3.Size = new Size(150, 35);
            button3.TabIndex = 19;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 603);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(roundedPanel1);
            Cursor = Cursors.Hand;
            Name = "Form3";
            Text = "Form3";
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private Label lblSubtitle;
        private Label lblTitle;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button3;
    }
}