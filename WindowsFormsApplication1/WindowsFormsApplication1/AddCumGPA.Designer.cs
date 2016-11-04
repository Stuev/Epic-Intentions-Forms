namespace WindowsFormsApplication1
{
    partial class AddCumGPA
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
            this.Submit_AddCumGPA = new System.Windows.Forms.Button();
            this.GPA_AddCumGPA = new System.Windows.Forms.TextBox();
            this.ID_AddCumGPA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit_AddCumGPA
            // 
            this.Submit_AddCumGPA.Location = new System.Drawing.Point(113, 199);
            this.Submit_AddCumGPA.Name = "Submit_AddCumGPA";
            this.Submit_AddCumGPA.Size = new System.Drawing.Size(104, 36);
            this.Submit_AddCumGPA.TabIndex = 11;
            this.Submit_AddCumGPA.Text = "Add GPA to Database";
            this.Submit_AddCumGPA.UseVisualStyleBackColor = true;
            // 
            // GPA_AddCumGPA
            // 
            this.GPA_AddCumGPA.Location = new System.Drawing.Point(133, 145);
            this.GPA_AddCumGPA.Name = "GPA_AddCumGPA";
            this.GPA_AddCumGPA.Size = new System.Drawing.Size(79, 20);
            this.GPA_AddCumGPA.TabIndex = 10;
            // 
            // ID_AddCumGPA
            // 
            this.ID_AddCumGPA.Location = new System.Drawing.Point(133, 105);
            this.ID_AddCumGPA.Name = "ID_AddCumGPA";
            this.ID_AddCumGPA.Size = new System.Drawing.Size(79, 20);
            this.ID_AddCumGPA.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "GPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Cumulative Semester Progress Report Grades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "(Official Grades)";
            // 
            // AddCumGPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 330);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Submit_AddCumGPA);
            this.Controls.Add(this.GPA_AddCumGPA);
            this.Controls.Add(this.ID_AddCumGPA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCumGPA";
            this.Text = "AddCumGPA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_AddCumGPA;
        private System.Windows.Forms.TextBox GPA_AddCumGPA;
        private System.Windows.Forms.TextBox ID_AddCumGPA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}