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
    public partial class frmUpdateStudentScores : Form
    {
        public static Dictionary<string, List<int>> modifyScore;
        BindingSource bind = new BindingSource();
        public static int selectedEntry;
        public frmUpdateStudentScores()
        {
            InitializeComponent();
        }

        private void frmUpdateStudentScores_Activated(object sender, EventArgs e)
        {
            labelName2.Text = modifyScore.Keys.ElementAt(frmStudentScores.selectedEntry);
            bind.DataSource = modifyScore.Values.ElementAt(frmStudentScores.selectedEntry);
            listBoxScores.DataSource = bind;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form addScore = new frmAddScore();
            addScore.ShowDialog();
            bind.ResetBindings(false);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            frmStudentScores.userEntries = modifyScore;
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedEntry = listBoxScores.SelectedIndex;
            Form updateScore = new frmUpdateScore();
            updateScore.ShowDialog();
            bind.ResetBindings(false);

        }
        private void btnClearScores_Click(object sender, EventArgs e)
        {
            modifyScore.Values.ElementAt(frmStudentScores.selectedEntry).RemoveRange(
                 0, modifyScore.Values.ElementAt(frmStudentScores.selectedEntry).Count);
            bind.ResetBindings(false);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
             modifyScore.Values.ElementAt(frmStudentScores.selectedEntry).RemoveAt(listBoxScores.SelectedIndex);
             bind.ResetBindings(false);
        }

        private void UpdateStudentScores_Load(object sender, EventArgs e)
        {
            modifyScore = frmStudentScores.userEntries.ToDictionary(p => p.Key, p => p.Value.ToList());

           
        }
    }
}
