namespace WindowsFormsApplication1
{
    partial class AddInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddUncumGPA = new System.Windows.Forms.Button();
            this.AddCumGPA = new System.Windows.Forms.Button();
            this.AddSchool = new System.Windows.Forms.Button();
            this.AddReferral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Option ";
            // 
            // AddUncumGPA
            // 
            this.AddUncumGPA.Location = new System.Drawing.Point(81, 75);
            this.AddUncumGPA.Name = "AddUncumGPA";
            this.AddUncumGPA.Size = new System.Drawing.Size(204, 36);
            this.AddUncumGPA.TabIndex = 1;
            this.AddUncumGPA.Text = "Add UnCumulative GPA from Student Reports";
            this.AddUncumGPA.UseVisualStyleBackColor = true;
            // 
            // AddCumGPA
            // 
            this.AddCumGPA.Location = new System.Drawing.Point(81, 126);
            this.AddCumGPA.Name = "AddCumGPA";
            this.AddCumGPA.Size = new System.Drawing.Size(204, 38);
            this.AddCumGPA.TabIndex = 2;
            this.AddCumGPA.Text = "Add Official School Cumulative GPA from Semester Progress Report";
            this.AddCumGPA.UseVisualStyleBackColor = true;
            // 
            // AddSchool
            // 
            this.AddSchool.Location = new System.Drawing.Point(81, 183);
            this.AddSchool.Name = "AddSchool";
            this.AddSchool.Size = new System.Drawing.Size(204, 36);
            this.AddSchool.TabIndex = 3;
            this.AddSchool.Text = "Add School";
            this.AddSchool.UseVisualStyleBackColor = true;
            this.AddSchool.Click += new System.EventHandler(this.AddSchool_Click);
            // 
            // AddReferral
            // 
            this.AddReferral.Location = new System.Drawing.Point(81, 241);
            this.AddReferral.Name = "AddReferral";
            this.AddReferral.Size = new System.Drawing.Size(204, 34);
            this.AddReferral.TabIndex = 4;
            this.AddReferral.Text = "Add Referrals";
            this.AddReferral.UseVisualStyleBackColor = true;
            // 
            // AddInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 346);
            this.Controls.Add(this.AddReferral);
            this.Controls.Add(this.AddSchool);
            this.Controls.Add(this.AddCumGPA);
            this.Controls.Add(this.AddUncumGPA);
            this.Controls.Add(this.label1);
            this.Name = "AddInfo";
            this.Text = "AddInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddUncumGPA;
        private System.Windows.Forms.Button AddCumGPA;
        private System.Windows.Forms.Button AddSchool;
        private System.Windows.Forms.Button AddReferral;
    }
}