namespace messFeedback2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeFormDesign();
        }

        // Method to set colors and styles when form loads
        private void InitializeFormDesign()
        {
            // Set form properties
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set header panel color (orange)
            if (roundedPanel1 != null)
            {
                roundedPanel1.BackColor = System.Drawing.Color.FromArgb(255, 107, 53);
            }

            // Make Submit button look good
            if (btnSubmit != null)
            {
                btnSubmit.BackColor = System.Drawing.Color.FromArgb(255, 107, 53);
                btnSubmit.ForeColor = System.Drawing.Color.White;
                btnSubmit.FlatStyle = FlatStyle.Flat;
                btnSubmit.FlatAppearance.BorderSize = 0;
                btnSubmit.Cursor = Cursors.Hand;
            }

            // Make Clear button look good
            if (btnClear != null)
            {
                btnClear.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                btnClear.FlatStyle = FlatStyle.Flat;
                btnClear.FlatAppearance.BorderSize = 0;
                btnClear.Cursor = Cursors.Hand;
            }

            // Set dropdown default to empty
            if (cmbRating != null) cmbRating.SelectedIndex = -1;
            if (cmbCategory != null) cmbCategory.SelectedIndex = -1;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            // Step 1: Validate all fields
            if (!ValidateForm())
            {
                return; // Stop here if validation fails
            }

            // Step 2: Get all the values from controls
            string studentName = textBox1.Text.Trim();
            string mealType = GetSelectedMealType();
            string rating = cmbRating.SelectedItem?.ToString() ?? "";
            string category = cmbCategory.SelectedItem?.ToString() ?? "";
            string comments = txtComments.Text.Trim();

            // Step 3: Show success message with all data
            string message = "✅ Feedback Submitted Successfully!\n\n" +
                             "Student: " + studentName + "\n" +
                             "Meal: " + mealType + "\n" +
                             "Rating: " + rating + "\n" +
                             "Category: " + category + "\n" +
                             "Comments: " + comments;

            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Step 4: Clear the form for next entry
            ClearForm();
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter student name");
                return false;
            }

            if (cmbRating.SelectedIndex == -1 || cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Select rating and category");
                return false;
            }

            return true;
        }

        private string GetSelectedMealType()
        {
            if (rbBreakfast.Checked) return "Breakfast";
            if (rbLunch.Checked) return "Lunch";
            if (rbDinner.Checked) return "Dinner";
            return "";
        }
        private void ClearForm()
        {
            textBox1.Clear();
            txtComments.Clear();
            rbBreakfast.Checked = false;
            rbLunch.Checked = false;
            rbDinner.Checked = false;
            cmbRating.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
        }
    }
}
