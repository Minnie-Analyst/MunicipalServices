using MunicipalServicesApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MunicipalServices
{
    public partial class ReportIssueForm : Form
    {
        private List<Issue> issues = new List<Issue>();
        public ReportIssueForm()
        {
            InitializeComponent();
           

            cmbCategory.Items.Add("Roads");
            cmbCategory.Items.Add("Water");
            cmbCategory.Items.Add("Electricity");
            cmbCategory.Items.Add("Sanitation");
            cmbCategory.Items.Add("Waste Management");
            cmbCategory.Items.Add("Street Lighting");
            cmbCategory.Items.Add("Other");
        }
        

        private void ReportIssueForm_Load(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|Document Files|*.pdf;*.doc;*.docx|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblFile.Text = openFileDialog.FileName;
                UpdateProgress();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the location of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLocation.Focus();
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an issue category.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCategory.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rTBdescription.Text))
            {
                MessageBox.Show("Please provide a description of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                rTBdescription.Focus();
                return;
            }
            Issue newIssue = new Issue
            {
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rTBdescription.Text.Trim(),
                AttachmentPath = lblFile.Text,
                DateReported = DateTime.Now
            };

            issues.Add(newIssue);

            MessageBox.Show("Your issue has been submitted successfully!",
                "Report Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void UpdateProgress()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                progress += 25;
            }

            if (cmbCategory.SelectedIndex != -1)
            {
                progress += 25;
            }

            if (!string.IsNullOrWhiteSpace(rTBdescription.Text))
            {
                progress += 25;
            }

            if (lblFile.Text != "No file selected")
            {
                progress += 25;
            }

            progressBar.Value = progress;

            if (progress == 0)
            {
                lblEngagement.Text = "Let's get started!";
            }
            else if (progress == 25)
            {
                lblEngagement.Text = "Great start! Please select a category.";
            }
            else if (progress == 50)
            {
                lblEngagement.Text = "Good progress! Tell us more about the issue.";
            }
            else if (progress == 75)
            {
                lblEngagement.Text = "Almost there! You can attach a photo or document.";
            }
            else if (progress == 100)
            {
                lblEngagement.Text = "You're ready to submit your report!";
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void rTBdescription_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }
    }
}
