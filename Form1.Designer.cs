namespace messFeedback2
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
            lblSubtitle = new Label();
            lblTitle = new Label();
            lblStudentName = new Label();
            textBox1 = new TextBox();
            lblMealType = new Label();
            rbBreakfast = new RadioButton();
            rbLunch = new RadioButton();
            rbDinner = new RadioButton();
            lblRating = new Label();
            cmbRating = new ComboBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblComments = new Label();
            txtComments = new TextBox();
            roundedPanel1 = new RoundedPanel();
            btnSubmit = new Button();
            btnClear = new Button();
            button1 = new Button();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
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
            lblTitle.Location = new Point(478, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(308, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Mess Feedback";
            lblTitle.Click += label1_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(104, 186);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(134, 25);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(279, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 31);
            textBox1.TabIndex = 2;
            // 
            // lblMealType
            // 
            lblMealType.AutoSize = true;
            lblMealType.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMealType.Location = new Point(113, 271);
            lblMealType.Name = "lblMealType";
            lblMealType.Size = new Size(100, 25);
            lblMealType.TabIndex = 3;
            lblMealType.Text = "Meal Type";
            // 
            // rbBreakfast
            // 
            rbBreakfast.AutoSize = true;
            rbBreakfast.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbBreakfast.Location = new Point(154, 319);
            rbBreakfast.Name = "rbBreakfast";
            rbBreakfast.Size = new Size(100, 27);
            rbBreakfast.TabIndex = 4;
            rbBreakfast.TabStop = true;
            rbBreakfast.Text = "Breakfast";
            rbBreakfast.UseVisualStyleBackColor = true;
            // 
            // rbLunch
            // 
            rbLunch.AutoSize = true;
            rbLunch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbLunch.Location = new Point(488, 319);
            rbLunch.Name = "rbLunch";
            rbLunch.Size = new Size(77, 27);
            rbLunch.TabIndex = 5;
            rbLunch.TabStop = true;
            rbLunch.Text = "Lunch";
            rbLunch.UseVisualStyleBackColor = true;
            // 
            // rbDinner
            // 
            rbDinner.AutoSize = true;
            rbDinner.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbDinner.Location = new Point(780, 317);
            rbDinner.Name = "rbDinner";
            rbDinner.Size = new Size(85, 29);
            rbDinner.TabIndex = 6;
            rbDinner.TabStop = true;
            rbDinner.Text = "Dinner";
            rbDinner.UseVisualStyleBackColor = true;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRating.Location = new Point(104, 393);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(187, 25);
            lblRating.TabIndex = 7;
            lblRating.Text = "Rate Your Meal (1-5)";
            lblRating.Click += label1_Click_1;
            // 
            // cmbRating
            // 
            cmbRating.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRating.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRating.FormattingEnabled = true;
            cmbRating.Items.AddRange(new object[] { "1 - Poor", "   ", "2 - Below Average", "     ", "3 - Average", "     ", "4 - Good", "     ", "5 - Excellent" });
            cmbRating.Location = new Point(367, 390);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(151, 33);
            cmbRating.TabIndex = 8;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(104, 473);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(182, 25);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Complaint Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Taste", "   ", "Hygiene", "   ", "Quantity", "   ", "Service", "   ", "Variety", "   ", "Other" });
            cmbCategory.Location = new Point(367, 470);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 33);
            cmbCategory.TabIndex = 10;
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComments.Location = new Point(113, 562);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(228, 75);
            lblComments.TabIndex = 11;
            lblComments.Text = "Comments / Suggestions:\n\n\n";
            // 
            // txtComments
            // 
            txtComments.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComments.Location = new Point(367, 562);
            txtComments.Multiline = true;
            txtComments.Name = "txtComments";
            txtComments.ScrollBars = ScrollBars.Vertical;
            txtComments.Size = new Size(620, 100);
            txtComments.TabIndex = 12;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(255, 128, 0);
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderWidth = 1;
            roundedPanel1.Controls.Add(lblSubtitle);
            roundedPanel1.Controls.Add(lblTitle);
            roundedPanel1.CornerRadius = 20;
            roundedPanel1.Location = new Point(-1, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1242, 142);
            roundedPanel1.TabIndex = 13;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(104, 692);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(255, 47);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(488, 692);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(253, 47);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(860, 692);
            button1.Name = "button1";
            button1.Size = new Size(253, 47);
            button1.TabIndex = 16;
            button1.Text = "Go to Admin Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 751);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(roundedPanel1);
            Controls.Add(txtComments);
            Controls.Add(lblComments);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(cmbRating);
            Controls.Add(lblRating);
            Controls.Add(rbDinner);
            Controls.Add(rbLunch);
            Controls.Add(rbBreakfast);
            Controls.Add(lblMealType);
            Controls.Add(textBox1);
            Controls.Add(lblStudentName);
            Name = "Form1";
            Text = "Form1";
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblStudentName;
        private TextBox textBox1;
        private Label lblMealType;
        private RadioButton rbBreakfast;
        private RadioButton rbLunch;
        private RadioButton rbDinner;
        private Label lblRating;
        private ComboBox cmbRating;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblComments;
        private TextBox txtComments;
        private RoundedPanel roundedPanel1;
        private Button btnSubmit;
        private Button btnClear;
        private Button button1;
    }
}
