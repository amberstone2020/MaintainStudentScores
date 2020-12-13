namespace StudentScores
{
    partial class frmUpdateStudentScores
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
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelScores = new System.Windows.Forms.Label();
            this.listBoxScores = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelName2
            // 
            this.labelName2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelName2.Location = new System.Drawing.Point(103, 24);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(292, 30);
            this.labelName2.TabIndex = 1;
            // 
            // labelScores
            // 
            this.labelScores.AutoSize = true;
            this.labelScores.Location = new System.Drawing.Point(27, 82);
            this.labelScores.Name = "labelScores";
            this.labelScores.Size = new System.Drawing.Size(63, 20);
            this.labelScores.TabIndex = 2;
            this.labelScores.Text = "Scores:";
            // 
            // listBoxScores
            // 
            this.listBoxScores.FormattingEnabled = true;
            this.listBoxScores.ItemHeight = 20;
            this.listBoxScores.Location = new System.Drawing.Point(103, 82);
            this.listBoxScores.Name = "listBoxScores";
            this.listBoxScores.Size = new System.Drawing.Size(159, 184);
            this.listBoxScores.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(281, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(281, 131);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 34);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(281, 182);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 32);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(281, 233);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(114, 32);
            this.btnClearScores.TabIndex = 7;
            this.btnClearScores.Text = "Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(151, 302);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(111, 33);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(281, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 33);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
           
            // 
            // UpdateStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 347);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxScores);
            this.Controls.Add(this.labelScores);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.labelName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateStudentScores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Student Scores";
            this.Activated += new System.EventHandler(this.frmUpdateStudentScores_Activated);
            this.Load += new System.EventHandler(this.UpdateStudentScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelScores;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listBoxScores;
    }
}