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
            this.Submit_AddCumGPA.Location = new System.Drawing.Point(151, 245);
            this.Submit_AddCumGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Submit_AddCumGPA.Name = "Submit_AddCumGPA";
            this.Submit_AddCumGPA.Size = new System.Drawing.Size(139, 44);
            this.Submit_AddCumGPA.TabIndex = 11;
            this.Submit_AddCumGPA.Text = "Add GPA to Database";
            this.Submit_AddCumGPA.UseVisualStyleBackColor = true;
            this.Submit_AddCumGPA.Click += new System.EventHandler(this.Submit_AddCumGPA_Click);
            // 
            // GPA_AddCumGPA
            // 
            this.GPA_AddCumGPA.Location = new System.Drawing.Point(177, 178);
            this.GPA_AddCumGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GPA_AddCumGPA.Name = "GPA_AddCumGPA";
            this.GPA_AddCumGPA.Size = new System.Drawing.Size(104, 22);
            this.GPA_AddCumGPA.TabIndex = 10;
            // 
            // ID_AddCumGPA
            // 
            this.ID_AddCumGPA.Location = new System.Drawing.Point(177, 129);
            this.ID_AddCumGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ID_AddCumGPA.Name = "ID_AddCumGPA";
            this.ID_AddCumGPA.Size = new System.Drawing.Size(104, 22);
            this.ID_AddCumGPA.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "GPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Cumulative Semester Progress Report Grades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "(Official Grades)";
            // 
            // AddCumGPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 406);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Submit_AddCumGPA);
            this.Controls.Add(this.GPA_AddCumGPA);
            this.Controls.Add(this.ID_AddCumGPA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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