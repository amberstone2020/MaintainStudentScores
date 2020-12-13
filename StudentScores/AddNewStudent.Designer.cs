namespace StudentScores
{
    partial class frmAddNewStudent
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
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.labelAllScores = new System.Windows.Forms.Label();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelAllScores2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(324, 26);
            this.txtName.TabIndex = 1;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(19, 69);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(55, 20);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(97, 63);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(167, 26);
            this.txtScore.TabIndex = 3;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(301, 60);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(119, 33);
            this.btnAddScore.TabIndex = 4;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // labelAllScores
            // 
            this.labelAllScores.AutoSize = true;
            this.labelAllScores.Location = new System.Drawing.Point(19, 115);
            this.labelAllScores.Name = "labelAllScores";
            this.labelAllScores.Size = new System.Drawing.Size(67, 20);
            this.labelAllScores.TabIndex = 5;
            this.labelAllScores.Text = "Scores: ";
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(301, 154);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(119, 33);
            this.btnClearScores.TabIndex = 7;
            this.btnClearScores.Text = "Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(149, 211);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(115, 31);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(301, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 31);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelAllScores2
            // 
            this.labelAllScores2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAllScores2.Location = new System.Drawing.Point(97, 105);
            this.labelAllScores2.Name = "labelAllScores2";
            this.labelAllScores2.Size = new System.Drawing.Size(323, 30);
            this.labelAllScores2.TabIndex = 10;
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(454, 254);
            this.ControlBox = false;
            this.Controls.Add(this.labelAllScores2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.labelAllScores);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewStudent";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Label labelAllScores;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelAllScores2;
        public System.Windows.Forms.TextBox txtName;
    }
}