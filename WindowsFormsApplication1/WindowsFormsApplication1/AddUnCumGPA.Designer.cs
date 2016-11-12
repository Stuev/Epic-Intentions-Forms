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
            this.label4 = new System.Windows.Forms.Label();
            this.classNameDrop = new System.Windows.Forms.ComboBox();
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
            this.label2.Location = new System.Drawing.Point(108, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grade (out of 100)";
            // 
            // ID_AddUnCummGPA
            // 
            this.ID_AddUnCummGPA.Location = new System.Drawing.Point(217, 94);
            this.ID_AddUnCummGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ID_AddUnCummGPA.Name = "ID_AddUnCummGPA";
            this.ID_AddUnCummGPA.Size = new System.Drawing.Size(104, 22);
            this.ID_AddUnCummGPA.TabIndex = 3;
            // 
            // Grade_AddUnCummGPA
            // 
            this.Grade_AddUnCummGPA.Location = new System.Drawing.Point(217, 166);
            this.Grade_AddUnCummGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Grade_AddUnCummGPA.Name = "Grade_AddUnCummGPA";
            this.Grade_AddUnCummGPA.Size = new System.Drawing.Size(104, 22);
            this.Grade_AddUnCummGPA.TabIndex = 4;
            // 
            // Submit_AddUnCummGPA
            // 
            this.Submit_AddUnCummGPA.Location = new System.Drawing.Point(143, 262);
            this.Submit_AddUnCummGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Submit_AddUnCummGPA.Name = "Submit_AddUnCummGPA";
            this.Submit_AddUnCummGPA.Size = new System.Drawing.Size(139, 44);
            this.Submit_AddUnCummGPA.TabIndex = 5;
            this.Submit_AddUnCummGPA.Text = "Add Grade to Database";
            this.Submit_AddUnCummGPA.UseVisualStyleBackColor = true;
            this.Submit_AddUnCummGPA.Click += new System.EventHandler(this.Submit_AddUnCummGPA_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Class Name";
            // 
            // classNameDrop
            // 
            this.classNameDrop.FormattingEnabled = true;
            this.classNameDrop.Location = new System.Drawing.Point(217, 128);
            this.classNameDrop.Margin = new System.Windows.Forms.Padding(4);
            this.classNameDrop.Name = "classNameDrop";
            this.classNameDrop.Size = new System.Drawing.Size(104, 24);
            this.classNameDrop.TabIndex = 13;
            this.classNameDrop.SelectedIndexChanged += new System.EventHandler(this.classNameDrop_SelectedIndexChanged);
            // 
            // AddUnCumGPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 374);
            this.Controls.Add(this.classNameDrop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Submit_AddUnCummGPA);
            this.Controls.Add(this.Grade_AddUnCummGPA);
            this.Controls.Add(this.ID_AddUnCummGPA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddUnCumGPA";
            this.Text = "AddUnCummGPA";
            this.Load += new System.EventHandler(this.AddUnCumGPA_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox classNameDrop;
    }
}