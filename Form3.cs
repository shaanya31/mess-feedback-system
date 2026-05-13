using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace messFeedback2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            StyleForm(); // Apply colors and styling
        }

        // Method to make form look beautiful
        private void StyleForm()
        {
            // Set form background to white
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Style the header panel (if you named it panel1)
            // Check your panel name in Properties window!
            try
            {
                // Try to find the header panel by name
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Panel && ctrl.Name.Contains("panel"))
                    {
                        ctrl.BackColor = Color.FromArgb(255, 107, 53); // Orange color
                        break;
                    }
                }

                // Style all labels in header to white text
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Panel)
                    {
                        foreach (Control innerCtrl in ctrl.Controls)
                        {
                            if (innerCtrl is Label)
                            {
                                innerCtrl.ForeColor = Color.White;
                                innerCtrl.BackColor = Color.Transparent;
                            }
                        }
                    }
                }

                // Style button1 (Student Feedback button) - Orange
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Name == "button1")
                    {
                        ctrl.BackColor = Color.FromArgb(255, 107, 53);
                        ctrl.ForeColor = Color.White;
                        ((Button)ctrl).FlatStyle = FlatStyle.Flat;
                        ((Button)ctrl).FlatAppearance.BorderSize = 0;
                        ctrl.Cursor = Cursors.Hand;
                    }
                }

                // Style button2 (Admin Dashboard button) - Blue
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Name == "button2")
                    {
                        ctrl.BackColor = Color.FromArgb(46, 58, 140);
                        ctrl.ForeColor = Color.White;
                        ((Button)ctrl).FlatStyle = FlatStyle.Flat;
                        ((Button)ctrl).FlatAppearance.BorderSize = 0;
                        ctrl.Cursor = Cursors.Hand;
                    }
                }

                // Style button3 (Exit button) - Gray
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Name == "button3")
                    {
                        ctrl.BackColor = Color.FromArgb(220, 220, 220);
                        ctrl.ForeColor = Color.Black;
                        ((Button)ctrl).FlatStyle = FlatStyle.Flat;
                        ((Button)ctrl).FlatAppearance.BorderSize = 0;
                        ctrl.Cursor = Cursors.Hand;
                    }
                }
            }
            catch
            {
                // If styling fails, it's okay - form will still work
            }
        }

        // label1_Click - Not needed, can leave empty
        private void label1_Click(object sender, EventArgs e)
        {
            // Label click - usually not used
        }

        // button1_Click - Student Feedback Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the student feedback form (Form1)
                Form1 feedbackForm = new Form1();
                feedbackForm.Show();

                // Hide this welcome form
                this.Hide();

                // When Form1 closes, show this form again
                feedbackForm.FormClosed += (s, args) => this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening feedback form: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // button2_Click - Admin Dashboard Button
        private void button2_Click(object sender, EventArgs e)
        {
            // Show message that admin dashboard is coming soon
            MessageBox.Show(
                "🎯 Admin Dashboard\n\n" +
                "This feature will show:\n" +
                "✅ All submitted feedbacks\n" +
                "✅ Filter by meal type\n" +
                "✅ Filter by category\n" +
                "✅ Statistics and analytics\n\n" +
                "Currently under development!",
                "Admin Dashboard",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // TODO: When you create admin form (Form2 or frmAdminDashboard), 
            // uncomment these lines:
            /*
            try
            {
                Form2 adminForm = new Form2(); // Change Form2 to your admin form name
                adminForm.Show();
                this.Hide();
                adminForm.FormClosed += (s, args) => this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            */
        }

        // button3_Click - Exit Button
        private void button3_Click(object sender, EventArgs e)
        {
            // Ask user if they really want to exit
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the Mess Feedback System?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // If user clicks Yes, close the entire application
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Close everything
            }
        }

        // Form Load event - runs when form first opens
        private void Form3_Load(object sender, EventArgs e)
        {
            // Set the title bar text with current date
            this.Text = "Mess Feedback System - " + DateTime.Now.ToString("dd MMM yyyy");

            // You can add more initialization code here
            // For example: Load statistics, check database connection, etc.
        }
    }
}