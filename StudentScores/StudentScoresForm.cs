//Amber Holcomb-Stone
//Code Modified From: https://www.youtube.com/watch?v=5uAQhXhyBek
//https://www.codeproject.com/Questions/499722/addplusitemplusinpluslistboxplusfromplusanotherplu
//https://www.youtube.com/watch?v=XTu-3ZaSGZM
// Dictionary, String Builder, Key Value Pairs, Form Activation, Binding Source, Clearing scores and some other code 
// that I didn't fully understand adapted from: https://github.com/PeterAC
// Text box to Label: https://stackoverflow.com/questions/11480628/displaying-user-input-from-a-textbox-into-a-label
// Clear label: http://www.nullskull.com/q/10096353/clear-text-inside-label.aspx
// Adding score(s) to label: https://stackoverflow.com/questions/20742910/append-string-to-label
// Modal Forms: https://www.youtube.com/watch?v=u1jz2beqjBw
// WinForm Events Lifecycle: https://stackoverflow.com/questions/3070163/order-of-events-form-load-form-shown-and-form-activated-in-windows-forms

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores
{
    public partial class frmStudentScores : Form
    {
        public static Dictionary<string, List<int>> userEntries = new Dictionary<string, List<int>>();
        public static int selectedEntry;
        public frmStudentScores()
        {
            InitializeComponent();

        }
        private void StudentScoresForm_Load(object sender, EventArgs e)
        {
            userEntries.Add("Margot Cotten", new List<int> { 100, 90, 89 });
            userEntries.Add("Sylvia Mavis", new List<int> { 78, 82, 86 });
            userEntries.Add("Brendon Farris", new List<int> { 71, 74, 79 });

            AddToListbox();


        }
        private void AddToListbox()
        {
            foreach (var student in userEntries)
            {
                StringBuilder addOn = new StringBuilder();
                addOn.Append(student.Key.ToString());
                addOn.Append(" - ");
                for (int i = 0; i < student.Value.Count; i++)
                {
                    addOn.Append(student.Value[i]);
                    if (i != student.Value.Count - 1)
                    {
                        addOn.Append(", ");
                    }
                }
                listBoxStudents.Items.Add(addOn);
                listBoxStudents.SetSelected(0, true);
                UpdateValues();
            }
        }

        private void UpdateValues()
        {
            try
            {

                labelScoreTotal2.Text = userEntries.Values.ElementAt(listBoxStudents.SelectedIndex).Sum().ToString();
                labelScoreCount2.Text = userEntries.Values.ElementAt(listBoxStudents.SelectedIndex).Count.ToString();
                labelAverage2.Text = Math.Round(userEntries.Values.ElementAt(listBoxStudents.SelectedIndex).Average()).ToString();
            }
            catch (Exception)
            {
                labelScoreTotal2.Text = "";
                labelScoreCount2.Text = "";
                labelAverage2.Text = "";
            }
        }

        private void listBoxStudents_Click(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form addNew = new frmAddNewStudent();
            addNew.ShowDialog();
            listBoxStudents.Items.Clear();
            AddToListbox();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            userEntries.Remove(userEntries.Keys.ElementAt(listBoxStudents.SelectedIndex));
            listBoxStudents.Items.Clear();
            AddToListbox();
            if (userEntries.Count == 0)
            {
                labelScoreTotal2.Text = "";
                labelScoreCount2.Text = "";
                labelAverage2.Text = "";
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Form UpdateScores = new frmUpdateStudentScores();
            selectedEntry = listBoxStudents.SelectedIndex;

            if (listBoxStudents.Items.Count > 0)
            {
                UpdateScores.ShowDialog();
            }
            listBoxStudents.Items.Clear();
            AddToListbox();
        }

        private void frmStudentScores_Activated(object sender, EventArgs e)
        {
            UpdateValues();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }


}





