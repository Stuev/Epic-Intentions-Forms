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
            this.AddSchoolToDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Option ";
            // 
            // AddUncumGPA
            // 
            this.AddUncumGPA.Location = new System.Drawing.Point(108, 92);
            this.AddUncumGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddUncumGPA.Name = "AddUncumGPA";
            this.AddUncumGPA.Size = new System.Drawing.Size(272, 44);
            this.AddUncumGPA.TabIndex = 1;
            this.AddUncumGPA.Text = "Add UnCumulative Grades from Student Reports";
            this.AddUncumGPA.UseVisualStyleBackColor = true;
            this.AddUncumGPA.Click += new System.EventHandler(this.AddUncumGPA_Click);
            // 
            // AddCumGPA
            // 
            this.AddCumGPA.Location = new System.Drawing.Point(108, 155);
            this.AddCumGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCumGPA.Name = "AddCumGPA";
            this.AddCumGPA.Size = new System.Drawing.Size(272, 47);
            this.AddCumGPA.TabIndex = 2;
            this.AddCumGPA.Text = "Add Official School Cumulative GPA from Semester Progress Report";
            this.AddCumGPA.UseVisualStyleBackColor = true;
            this.AddCumGPA.Click += new System.EventHandler(this.AddCumGPA_Click);
            // 
            // AddSchool
            // 
            this.AddSchool.Location = new System.Drawing.Point(108, 225);
            this.AddSchool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddSchool.Name = "AddSchool";
            this.AddSchool.Size = new System.Drawing.Size(272, 44);
            this.AddSchool.TabIndex = 3;
            this.AddSchool.Text = "Change Attending School for Existing Student";
            this.AddSchool.UseVisualStyleBackColor = true;
            this.AddSchool.Click += new System.EventHandler(this.AddSchool_Click);
            // 
            // AddReferral
            // 
            this.AddReferral.Location = new System.Drawing.Point(108, 287);
            this.AddReferral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddReferral.Name = "AddReferral";
            this.AddReferral.Size = new System.Drawing.Size(272, 42);
            this.AddReferral.TabIndex = 4;
            this.AddReferral.Text = "Add Referrals";
            this.AddReferral.UseVisualStyleBackColor = true;
            this.AddReferral.Click += new System.EventHandler(this.AddReferral_Click);
            // 
            // AddSchoolToDatabase
            // 
            this.AddSchoolToDatabase.Location = new System.Drawing.Point(108, 346);
            this.AddSchoolToDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.AddSchoolToDatabase.Name = "AddSchoolToDatabase";
            this.AddSchoolToDatabase.Size = new System.Drawing.Size(272, 42);
            this.AddSchoolToDatabase.TabIndex = 5;
            this.AddSchoolToDatabase.Text = "Add New School to Database";
            this.AddSchoolToDatabase.UseVisualStyleBackColor = true;
            this.AddSchoolToDatabase.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 426);
            this.Controls.Add(this.AddSchoolToDatabase);
            this.Controls.Add(this.AddReferral);
            this.Controls.Add(this.AddSchool);
            this.Controls.Add(this.AddCumGPA);
            this.Controls.Add(this.AddUncumGPA);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button AddSchoolToDatabase;
    }
}