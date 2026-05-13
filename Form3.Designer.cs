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
            label1 = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(255, 128, 0);
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderWidth = 1;
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(lblSubtitle);
            roundedPanel1.Controls.Add(lblTitle);
            roundedPanel1.CornerRadius = 20;
            roundedPanel1.Location = new Point(1, 12);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1268, 142);
            roundedPanel1.TabIndex = 14;
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
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(534, 89);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(168, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Cafe By The Valley";
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
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 603);
            Controls.Add(roundedPanel1);
            Name = "Form3";
            Text = "Form3";
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private Label lblSubtitle;
        private Label lblTitle;
        private Label label1;
    }
}