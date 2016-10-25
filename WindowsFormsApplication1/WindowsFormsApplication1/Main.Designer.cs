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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Option";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewStudent
            // 
            this.ViewStudent.Location = new System.Drawing.Point(121, 66);
            this.ViewStudent.Margin = new System.Windows.Forms.Padding(4);
            this.ViewStudent.Name = "ViewStudent";
            this.ViewStudent.Size = new System.Drawing.Size(155, 28);
            this.ViewStudent.TabIndex = 1;
            this.ViewStudent.Text = "View Student Profile ";
            this.ViewStudent.UseVisualStyleBackColor = true;
            // 
            // FilterStudent
            // 
            this.FilterStudent.Location = new System.Drawing.Point(121, 114);
            this.FilterStudent.Margin = new System.Windows.Forms.Padding(4);
            this.FilterStudent.Name = "FilterStudent";
            this.FilterStudent.Size = new System.Drawing.Size(155, 28);
            this.FilterStudent.TabIndex = 2;
            this.FilterStudent.Text = "Filter Data";
            this.FilterStudent.UseVisualStyleBackColor = true;
            this.FilterStudent.Click += new System.EventHandler(this.FilterStudent_Click);
            // 
            // EditStudent
            // 
            this.EditStudent.Location = new System.Drawing.Point(121, 162);
            this.EditStudent.Margin = new System.Windows.Forms.Padding(4);
            this.EditStudent.Name = "EditStudent";
            this.EditStudent.Size = new System.Drawing.Size(155, 28);
            this.EditStudent.TabIndex = 3;
            this.EditStudent.Text = "Edit Student";
            this.EditStudent.UseVisualStyleBackColor = true;
            this.EditStudent.Click += new System.EventHandler(this.EditStudent_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(121, 210);
            this.AddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(155, 28);
            this.AddStudent.TabIndex = 4;
            this.AddStudent.Text = "Add New Student";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(121, 260);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 28);
            this.button5.TabIndex = 5;
            this.button5.Text = "Add Info??";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ImportData
            // 
            this.ImportData.Location = new System.Drawing.Point(121, 310);
            this.ImportData.Margin = new System.Windows.Forms.Padding(4);
            this.ImportData.Name = "ImportData";
            this.ImportData.Size = new System.Drawing.Size(155, 43);
            this.ImportData.TabIndex = 6;
            this.ImportData.Text = "Import School Data to Insert Multiple Students";
            this.ImportData.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 374);
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
    }
}