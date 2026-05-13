using System;
using System.Data;
using System.Windows.Forms;

namespace messFeedback2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadSampleData(); // For now, show sample data
        }

        // Setup DataGridView columns
        private void SetupDataGridView()
        {
            // Clear any existing columns
            dataGridView1.Columns.Clear();

            // Add columns
            dataGridView1.Columns.Add("StudentName", "Student Name");
            dataGridView1.Columns.Add("MealType", "Meal Type");
            dataGridView1.Columns.Add("Rating", "Rating");
            dataGridView1.Columns.Add("Category", "Category");
            dataGridView1.Columns.Add("Comments", "Comments");
            dataGridView1.Columns.Add("DateTime", "Date & Time");

            // Set column widths
            dataGridView1.Columns["StudentName"].Width = 120;
            dataGridView1.Columns["MealType"].Width = 80;
            dataGridView1.Columns["Rating"].Width = 80;
            dataGridView1.Columns["Category"].Width = 100;
            dataGridView1.Columns["Comments"].Width = 200;
            dataGridView1.Columns["DateTime"].Width = 140;
        }

        // Load sample data (temporary - until database is ready)
        private void LoadSampleData()
        {
            dataGridView1.Rows.Clear();

            // Sample row 1
            dataGridView1.Rows.Add("Rahul Sharma", "Breakfast", "5 - Excellent",
                                  "Taste", "Food was amazing!",
                                  DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"));

            // Sample row 2
            dataGridView1.Rows.Add("Priya Patel", "Lunch", "3 - Average",
                                  "Quantity", "Need more quantity",
                                  DateTime.Now.AddHours(-2).ToString("dd/MM/yyyy hh:mm tt"));

            // Sample row 3
            dataGridView1.Rows.Add("Amit Kumar", "Dinner", "2 - Below Average",
                                  "Hygiene", "Found hair in food",
                                  DateTime.Now.AddHours(-5).ToString("dd/MM/yyyy hh:mm tt"));
        }

        // Back button - close this form and show feedback form
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 feedbackForm = new Form1();
            feedbackForm.Show(); // Show feedback form
            this.Close(); // Close admin form
        }

        // Refresh button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSampleData(); // Reload data
            MessageBox.Show("Data refreshed!", "Success");
        }
    }
}