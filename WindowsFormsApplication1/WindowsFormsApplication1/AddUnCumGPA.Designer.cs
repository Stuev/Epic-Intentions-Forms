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
            this.GPA_AddUnCummGPA = new System.Windows.Forms.TextBox();
            this.Submit_AddUnCummGPA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Uncumulative Progress Report Grades (Unofficial)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "GPA";
            // 
            // ID_AddUnCummGPA
            // 
            this.ID_AddUnCummGPA.Location = new System.Drawing.Point(217, 101);
            this.ID_AddUnCummGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ID_AddUnCummGPA.Name = "ID_AddUnCummGPA";
            this.ID_AddUnCummGPA.Size = new System.Drawing.Size(104, 22);
            this.ID_AddUnCummGPA.TabIndex = 3;
            // 
            // GPA_AddUnCummGPA
            // 
            this.GPA_AddUnCummGPA.Location = new System.Drawing.Point(217, 155);
            this.GPA_AddUnCummGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GPA_AddUnCummGPA.Name = "GPA_AddUnCummGPA";
            this.GPA_AddUnCummGPA.Size = new System.Drawing.Size(104, 22);
            this.GPA_AddUnCummGPA.TabIndex = 4;
            // 
            // Submit_AddUnCummGPA
            // 
            this.Submit_AddUnCummGPA.Location = new System.Drawing.Point(144, 209);
            this.Submit_AddUnCummGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Submit_AddUnCummGPA.Name = "Submit_AddUnCummGPA";
            this.Submit_AddUnCummGPA.Size = new System.Drawing.Size(139, 44);
            this.Submit_AddUnCummGPA.TabIndex = 5;
            this.Submit_AddUnCummGPA.Text = "Add GPA to Database";
            this.Submit_AddUnCummGPA.UseVisualStyleBackColor = true;
            this.Submit_AddUnCummGPA.Click += new System.EventHandler(this.Submit_AddUnCummGPA_Click);
            // 
            // AddUnCumGPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 374);
            this.Controls.Add(this.Submit_AddUnCummGPA);
            this.Controls.Add(this.GPA_AddUnCummGPA);
            this.Controls.Add(this.ID_AddUnCummGPA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox GPA_AddUnCummGPA;
        private System.Windows.Forms.Button Submit_AddUnCummGPA;
    }
}