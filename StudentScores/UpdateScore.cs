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
    public partial class frmUpdateScore : Form
    {
        public frmUpdateScore()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(txtUpdate.Text) >= 0 && Int32.Parse(txtUpdate.Text) <= 100)
                {
                    frmUpdateStudentScores.modifyScore.Values.ElementAt(frmStudentScores.selectedEntry)[frmUpdateStudentScores.selectedEntry]
                            = Int32.Parse(txtUpdate.Text);
                    
                }
                else
                {
                    MessageBox.Show("Please enter a score between 0 and 100.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
            catch (Exception)
            {
                txtUpdate.Text = "";
                MessageBox.Show("There are no current scores to update.");
            }
            this.Close();
        }

        private void UpdateScore_Load(object sender, EventArgs e)
        {

        }
    }
}
