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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteStudentID = new System.Windows.Forms.ComboBox();
            this.DeleteStudentFname = new System.Windows.Forms.ComboBox();
            this.DeleteStudentLname = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "First Name";
            // 
            // DeleteStudentSubmit
            // 
            this.DeleteStudentSubmit.Location = new System.Drawing.Point(242, 415);
            this.DeleteStudentSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DeleteStudentSubmit.Name = "DeleteStudentSubmit";
            this.DeleteStudentSubmit.Size = new System.Drawing.Size(246, 77);
            this.DeleteStudentSubmit.TabIndex = 42;
            this.DeleteStudentSubmit.Text = "Delete Student";
            this.DeleteStudentSubmit.UseVisualStyleBackColor = true;
            this.DeleteStudentSubmit.Click += new System.EventHandler(this.DeleteStudentSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Delete Student ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(659, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "Warning: This will delete the student from the entire database";
            // 
            // DeleteStudentID
            // 
            this.DeleteStudentID.FormattingEnabled = true;
            this.DeleteStudentID.Location = new System.Drawing.Point(346, 127);
            this.DeleteStudentID.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteStudentID.Name = "DeleteStudentID";
            this.DeleteStudentID.Size = new System.Drawing.Size(238, 33);
            this.DeleteStudentID.TabIndex = 46;
            // 
            // DeleteStudentFname
            // 
            this.DeleteStudentFname.FormattingEnabled = true;
            this.DeleteStudentFname.Location = new System.Drawing.Point(346, 205);
            this.DeleteStudentFname.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteStudentFname.Name = "DeleteStudentFname";
            this.DeleteStudentFname.Size = new System.Drawing.Size(238, 33);
            this.DeleteStudentFname.TabIndex = 47;
            // 
            // DeleteStudentLname
            // 
            this.DeleteStudentLname.FormattingEnabled = true;
            this.DeleteStudentLname.Location = new System.Drawing.Point(346, 284);
            this.DeleteStudentLname.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteStudentLname.Name = "DeleteStudentLname";
            this.DeleteStudentLname.Size = new System.Drawing.Size(238, 33);
            this.DeleteStudentLname.TabIndex = 48;
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 565);
            this.Controls.Add(this.DeleteStudentLname);
            this.Controls.Add(this.DeleteStudentFname);
            this.Controls.Add(this.DeleteStudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteStudentSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DeleteStudent";
            this.Text = "DeleteStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteStudentSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DeleteStudentID;
        private System.Windows.Forms.ComboBox DeleteStudentFname;
        private System.Windows.Forms.ComboBox DeleteStudentLname;
    }
}