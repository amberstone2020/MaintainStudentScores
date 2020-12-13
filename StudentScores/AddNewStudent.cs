using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores
{
    public partial class frmAddNewStudent : Form
    {
        Dictionary<string, List<int>> newStudent = new Dictionary<string, List<int>>();
        List<int> scores = new List<int>();
        public frmAddNewStudent()
        {
            InitializeComponent();

        }
        private void frmAddNewStudent_Activated(object sender, EventArgs e)
        {
            txtName.Focus();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                frmStudentScores.userEntries.Add(txtName.Text, scores);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a name");
                txtName.Focus();
            }
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(txtScore.Text) >= 0 && Int32.Parse(txtScore.Text) <= 100)
                {
                    scores.Add(Int32.Parse(txtScore.Text));
                }
                else
                {
                    MessageBox.Show("Please enter a valid score between 0 and 100.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number");
            }
            labelAllScores2.Text = String.Join(", ", scores);
            txtScore.Text = "";
            txtScore.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            scores.Clear();
            labelAllScores2.Text = "";
            txtScore.Text = "";
            txtScore.Focus();
        }

    }
}
