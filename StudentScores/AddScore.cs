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
    public partial class frmAddScore : Form
    {
        
        public frmAddScore()
        {
            InitializeComponent();
            
        }

        private void btnAddScore_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(txtScore.Text) >= 0 && Int32.Parse(txtScore.Text) <= 100)
                {
                    frmUpdateStudentScores.modifyScore.Values.ElementAt(frmStudentScores.selectedEntry).Add(Int32.Parse(txtScore.Text));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a valid score between 0 and 100.", "Invalid score");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number", "Invalid Entry");
            }
        }
    }
}
