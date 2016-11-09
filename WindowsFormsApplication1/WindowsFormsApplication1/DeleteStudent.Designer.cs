namespace WindowsFormsApplication1
{
    partial class DeleteStudent
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
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteStudentSubmit = new System.Windows.Forms.Button();
            this.DeleteStudentLast = new System.Windows.Forms.TextBox();
            this.DeleteStudentFirst = new System.Windows.Forms.TextBox();
            this.DeleteStudentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "First Name";
            // 
            // DeleteStudentSubmit
            // 
            this.DeleteStudentSubmit.Location = new System.Drawing.Point(121, 216);
            this.DeleteStudentSubmit.Name = "DeleteStudentSubmit";
            this.DeleteStudentSubmit.Size = new System.Drawing.Size(123, 40);
            this.DeleteStudentSubmit.TabIndex = 42;
            this.DeleteStudentSubmit.Text = "Delete Student";
            this.DeleteStudentSubmit.UseVisualStyleBackColor = true;
            // 
            // DeleteStudentLast
            // 
            this.DeleteStudentLast.Location = new System.Drawing.Point(173, 145);
            this.DeleteStudentLast.Name = "DeleteStudentLast";
            this.DeleteStudentLast.Size = new System.Drawing.Size(99, 20);
            this.DeleteStudentLast.TabIndex = 41;
            // 
            // DeleteStudentFirst
            // 
            this.DeleteStudentFirst.Location = new System.Drawing.Point(173, 104);
            this.DeleteStudentFirst.Name = "DeleteStudentFirst";
            this.DeleteStudentFirst.Size = new System.Drawing.Size(99, 20);
            this.DeleteStudentFirst.TabIndex = 40;
            // 
            // DeleteStudentID
            // 
            this.DeleteStudentID.Location = new System.Drawing.Point(173, 63);
            this.DeleteStudentID.Name = "DeleteStudentID";
            this.DeleteStudentID.Size = new System.Drawing.Size(99, 20);
            this.DeleteStudentID.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Delete Student ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 14);
            this.label3.TabIndex = 44;
            this.label3.Text = "Warning: This will delete the student from the entire database";
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteStudentSubmit);
            this.Controls.Add(this.DeleteStudentLast);
            this.Controls.Add(this.DeleteStudentFirst);
            this.Controls.Add(this.DeleteStudentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteStudent";
            this.Text = "DeleteStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteStudentSubmit;
        private System.Windows.Forms.TextBox DeleteStudentLast;
        private System.Windows.Forms.TextBox DeleteStudentFirst;
        private System.Windows.Forms.TextBox DeleteStudentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}