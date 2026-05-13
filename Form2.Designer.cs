namespace messFeedback2
{
    partial class Form2
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
            lblSubtitle = new Label();
            lblTitle = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.RoyalBlue;
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderWidth = 1;
            roundedPanel1.Controls.Add(lblSubtitle);
            roundedPanel1.Controls.Add(lblTitle);
            roundedPanel1.CornerRadius = 20;
            roundedPanel1.Location = new Point(0, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1273, 152);
            roundedPanel1.TabIndex = 14;
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
            lblTitle.Location = new Point(425, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(424, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ADMIN DASHBOARD";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(226, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(783, 379);
            dataGridView1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Breakfast", "Lunch", "Dinner" });
            comboBox1.Location = new Point(256, 169);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "All", "5 Stars", "4 Stars", "3 Stars", "2 Stars", "1 Star" });
            comboBox2.Location = new Point(847, 169);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "All", "Taste", "Hygiene", "Quantity", "Service", "Variety", "Other" });
            comboBox3.Location = new Point(551, 169);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 17;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(109, 621);
            button1.Name = "button1";
            button1.Size = new Size(222, 48);
            button1.TabIndex = 18;
            button1.Text = "Back to Feedback Form";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnBack_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(512, 621);
            button2.Name = "button2";
            button2.Size = new Size(199, 48);
            button2.TabIndex = 19;
            button2.Text = "Refresh Data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnRefresh_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 693);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(roundedPanel1);
            Name = "Form2";
            Text = "Form2";
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private Label lblSubtitle;
        private Label lblTitle;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
        private Button button2;
    }
}