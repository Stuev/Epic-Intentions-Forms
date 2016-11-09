namespace WindowsFormsApplication1
{
    partial class AddUnCumGPA
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_AddUnCummGPA = new System.Windows.Forms.TextBox();
            this.Grade_AddUnCummGPA = new System.Windows.Forms.TextBox();
            this.Submit_AddUnCummGPA = new System.Windows.Forms.Button();
            this.Class_AddUnCummGPA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GradeLevel_AddUnCummGPA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Uncumulative Progress Report Grades (Unofficial)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grade (out of 100)";
            // 
            // ID_AddUnCummGPA
            // 
            this.ID_AddUnCummGPA.Location = new System.Drawing.Point(163, 76);
            this.ID_AddUnCummGPA.Name = "ID_AddUnCummGPA";
            this.ID_AddUnCummGPA.Size = new System.Drawing.Size(79, 20);
            this.ID_AddUnCummGPA.TabIndex = 3;
            // 
            // Grade_AddUnCummGPA
            // 
            this.Grade_AddUnCummGPA.Location = new System.Drawing.Point(163, 161);
            this.Grade_AddUnCummGPA.Name = "Grade_AddUnCummGPA";
            this.Grade_AddUnCummGPA.Size = new System.Drawing.Size(79, 20);
            this.Grade_AddUnCummGPA.TabIndex = 4;
            // 
            // Submit_AddUnCummGPA
            // 
            this.Submit_AddUnCummGPA.Location = new System.Drawing.Point(107, 213);
            this.Submit_AddUnCummGPA.Name = "Submit_AddUnCummGPA";
            this.Submit_AddUnCummGPA.Size = new System.Drawing.Size(104, 36);
            this.Submit_AddUnCummGPA.TabIndex = 5;
            this.Submit_AddUnCummGPA.Text = "Add Grade to Database";
            this.Submit_AddUnCummGPA.UseVisualStyleBackColor = true;
            this.Submit_AddUnCummGPA.Click += new System.EventHandler(this.Submit_AddUnCummGPA_Click);
            // 
            // Class_AddUnCummGPA
            // 
            this.Class_AddUnCummGPA.Location = new System.Drawing.Point(163, 133);
            this.Class_AddUnCummGPA.Name = "Class_AddUnCummGPA";
            this.Class_AddUnCummGPA.Size = new System.Drawing.Size(79, 20);
            this.Class_AddUnCummGPA.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Class Name";
            // 
            // GradeLevel_AddUnCummGPA
            // 
            this.GradeLevel_AddUnCummGPA.Location = new System.Drawing.Point(163, 104);
            this.GradeLevel_AddUnCummGPA.Name = "GradeLevel_AddUnCummGPA";
            this.GradeLevel_AddUnCummGPA.Size = new System.Drawing.Size(79, 20);
            this.GradeLevel_AddUnCummGPA.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current Grade Level";
            // 
            // AddUnCumGPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 304);
            this.Controls.Add(this.GradeLevel_AddUnCummGPA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Class_AddUnCummGPA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Submit_AddUnCummGPA);
            this.Controls.Add(this.Grade_AddUnCummGPA);
            this.Controls.Add(this.ID_AddUnCummGPA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUnCumGPA";
            this.Text = "AddUnCummGPA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID_AddUnCummGPA;
        private System.Windows.Forms.TextBox Grade_AddUnCummGPA;
        private System.Windows.Forms.Button Submit_AddUnCummGPA;
        private System.Windows.Forms.TextBox Class_AddUnCummGPA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GradeLevel_AddUnCummGPA;
        private System.Windows.Forms.Label label5;
    }
}