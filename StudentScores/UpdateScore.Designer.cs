namespace StudentScores
{
    partial class frmUpdateScore
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(21, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 34);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(145, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(30, 25);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(55, 20);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score:";
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(145, 25);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(51, 26);
            this.txtUpdate.TabIndex = 3;
            // 
            // UpdateScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 123);
            this.ControlBox = false;
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Score";
            this.Load += new System.EventHandler(this.UpdateScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox txtUpdate;
    }
}