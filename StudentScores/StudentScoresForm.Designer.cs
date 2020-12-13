namespace StudentScores
{
    partial class frmStudentScores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStudents = new System.Windows.Forms.Label();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelScoreTotal = new System.Windows.Forms.Label();
            this.labelScoreCount = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelScoreTotal2 = new System.Windows.Forms.Label();
            this.labelScoreCount2 = new System.Windows.Forms.Label();
            this.labelAverage2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Location = new System.Drawing.Point(23, 18);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(78, 20);
            this.labelStudents.TabIndex = 0;
            this.labelStudents.Text = "Students:";
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 20;
            this.listBoxStudents.Location = new System.Drawing.Point(27, 50);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(356, 144);
            this.listBoxStudents.TabIndex = 1;
            this.listBoxStudents.Click += new System.EventHandler(this.listBoxStudents_Click);

            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(400, 50);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(116, 33);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(400, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update...";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(400, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(400, 289);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelScoreTotal
            // 
            this.labelScoreTotal.Location = new System.Drawing.Point(201, 216);
            this.labelScoreTotal.Name = "labelScoreTotal";
            this.labelScoreTotal.Size = new System.Drawing.Size(100, 23);
            this.labelScoreTotal.TabIndex = 6;
            this.labelScoreTotal.Text = "Score Total:";
            // 
            // labelScoreCount
            // 
            this.labelScoreCount.AutoSize = true;
            this.labelScoreCount.Location = new System.Drawing.Point(189, 253);
            this.labelScoreCount.Name = "labelScoreCount";
            this.labelScoreCount.Size = new System.Drawing.Size(110, 20);
            this.labelScoreCount.TabIndex = 8;
            this.labelScoreCount.Text = " Score Count: ";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(223, 289);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(72, 20);
            this.labelAverage.TabIndex = 10;
            this.labelAverage.Text = "Average:";
            // 
            // labelScoreTotal2
            // 
            this.labelScoreTotal2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelScoreTotal2.Location = new System.Drawing.Point(311, 216);
            this.labelScoreTotal2.Name = "labelScoreTotal2";
            this.labelScoreTotal2.Size = new System.Drawing.Size(72, 23);
            this.labelScoreTotal2.TabIndex = 12;
            // 
            // labelScoreCount2
            // 
            this.labelScoreCount2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelScoreCount2.Location = new System.Drawing.Point(311, 253);
            this.labelScoreCount2.Name = "labelScoreCount2";
            this.labelScoreCount2.Size = new System.Drawing.Size(72, 23);
            this.labelScoreCount2.TabIndex = 13;
            // 
            // labelAverage2
            // 
            this.labelAverage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverage2.Location = new System.Drawing.Point(311, 289);
            this.labelAverage2.Name = "labelAverage2";
            this.labelAverage2.Size = new System.Drawing.Size(72, 20);
            this.labelAverage2.TabIndex = 14;
            // 
            // StudentScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 339);
            this.Controls.Add(this.labelAverage2);
            this.Controls.Add(this.labelScoreCount2);
            this.Controls.Add(this.labelScoreTotal2);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelScoreCount);
            this.Controls.Add(this.labelScoreTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.labelStudents);
            this.Name = "StudentScoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Scores";
            this.Activated += new System.EventHandler(this.frmStudentScores_Activated);
            this.Load += new System.EventHandler(this.StudentScoresForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelScoreTotal;
        private System.Windows.Forms.Label labelScoreCount;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelScoreTotal2;
        private System.Windows.Forms.Label labelScoreCount2;
        private System.Windows.Forms.Label labelAverage2;
        public System.Windows.Forms.ListBox listBoxStudents;
    }
}

