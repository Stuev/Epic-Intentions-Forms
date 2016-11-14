namespace WindowsFormsApplication1
{
    partial class Main
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
            this.ViewStudent = new System.Windows.Forms.Button();
            this.FilterStudent = new System.Windows.Forms.Button();
            this.EditStudent = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ImportData = new System.Windows.Forms.Button();
            this.ViewAll = new System.Windows.Forms.Button();
            this.PastStudents = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.EditSchool = new System.Windows.Forms.Button();
            this.EditAdminPW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Option";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewStudent
            // 
            this.ViewStudent.Location = new System.Drawing.Point(25, 109);
            this.ViewStudent.Margin = new System.Windows.Forms.Padding(4);
            this.ViewStudent.Name = "ViewStudent";
            this.ViewStudent.Size = new System.Drawing.Size(155, 53);
            this.ViewStudent.TabIndex = 3;
            this.ViewStudent.Text = "View Student Profile ";
            this.ViewStudent.UseVisualStyleBackColor = true;
            this.ViewStudent.Click += new System.EventHandler(this.ViewStudent_Click);
            // 
            // FilterStudent
            // 
            this.FilterStudent.Location = new System.Drawing.Point(25, 167);
            this.FilterStudent.Margin = new System.Windows.Forms.Padding(4);
            this.FilterStudent.Name = "FilterStudent";
            this.FilterStudent.Size = new System.Drawing.Size(155, 53);
            this.FilterStudent.TabIndex = 5;
            this.FilterStudent.Text = "Filter Data";
            this.FilterStudent.UseVisualStyleBackColor = true;
            this.FilterStudent.Click += new System.EventHandler(this.FilterStudent_Click);
            // 
            // EditStudent
            // 
            this.EditStudent.Location = new System.Drawing.Point(25, 225);
            this.EditStudent.Margin = new System.Windows.Forms.Padding(4);
            this.EditStudent.Name = "EditStudent";
            this.EditStudent.Size = new System.Drawing.Size(155, 51);
            this.EditStudent.TabIndex = 7;
            this.EditStudent.Text = "Edit Student";
            this.EditStudent.UseVisualStyleBackColor = true;
            this.EditStudent.Click += new System.EventHandler(this.EditStudent_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(219, 109);
            this.AddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(155, 51);
            this.AddStudent.TabIndex = 4;
            this.AddStudent.Text = "Add New Student";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(219, 167);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 53);
            this.button5.TabIndex = 6;
            this.button5.Text = "Add Info to Existing Student";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ImportData
            // 
            this.ImportData.Location = new System.Drawing.Point(219, 225);
            this.ImportData.Margin = new System.Windows.Forms.Padding(4);
            this.ImportData.Name = "ImportData";
            this.ImportData.Size = new System.Drawing.Size(155, 51);
            this.ImportData.TabIndex = 8;
            this.ImportData.Text = "Import School Data to Insert Multiple Students";
            this.ImportData.UseVisualStyleBackColor = true;
            this.ImportData.Click += new System.EventHandler(this.ImportData_Click);
            // 
            // ViewAll
            // 
            this.ViewAll.Location = new System.Drawing.Point(25, 47);
            this.ViewAll.Margin = new System.Windows.Forms.Padding(4);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(155, 57);
            this.ViewAll.TabIndex = 1;
            this.ViewAll.Text = "View All Students";
            this.ViewAll.UseVisualStyleBackColor = true;
            this.ViewAll.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // PastStudents
            // 
            this.PastStudents.Location = new System.Drawing.Point(219, 47);
            this.PastStudents.Margin = new System.Windows.Forms.Padding(4);
            this.PastStudents.Name = "PastStudents";
            this.PastStudents.Size = new System.Drawing.Size(155, 57);
            this.PastStudents.TabIndex = 2;
            this.PastStudents.Text = "Update Past Student Status";
            this.PastStudents.UseVisualStyleBackColor = true;
            this.PastStudents.Click += new System.EventHandler(this.PastStudents_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(219, 284);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(155, 51);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Admin Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // EditSchool
            // 
            this.EditSchool.Location = new System.Drawing.Point(25, 284);
            this.EditSchool.Margin = new System.Windows.Forms.Padding(4);
            this.EditSchool.Name = "EditSchool";
            this.EditSchool.Size = new System.Drawing.Size(155, 51);
            this.EditSchool.TabIndex = 9;
            this.EditSchool.Text = "Edit School Name";
            this.EditSchool.UseVisualStyleBackColor = true;
            this.EditSchool.Click += new System.EventHandler(this.EditSchool_Click);
            // 
            // EditAdminPW
            // 
            this.EditAdminPW.Location = new System.Drawing.Point(122, 343);
            this.EditAdminPW.Margin = new System.Windows.Forms.Padding(4);
            this.EditAdminPW.Name = "EditAdminPW";
            this.EditAdminPW.Size = new System.Drawing.Size(155, 51);
            this.EditAdminPW.TabIndex = 11;
            this.EditAdminPW.Text = "Edit Admin Password";
            this.EditAdminPW.UseVisualStyleBackColor = true;
            this.EditAdminPW.Click += new System.EventHandler(this.EditAdminPW_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 417);
            this.Controls.Add(this.EditAdminPW);
            this.Controls.Add(this.EditSchool);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.PastStudents);
            this.Controls.Add(this.ViewAll);
            this.Controls.Add(this.ImportData);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.EditStudent);
            this.Controls.Add(this.FilterStudent);
            this.Controls.Add(this.ViewStudent);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewStudent;
        private System.Windows.Forms.Button FilterStudent;
        private System.Windows.Forms.Button EditStudent;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ImportData;
        private System.Windows.Forms.Button ViewAll;
        private System.Windows.Forms.Button PastStudents;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button EditSchool;
        private System.Windows.Forms.Button EditAdminPW;
    }
}