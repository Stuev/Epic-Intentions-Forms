namespace WindowsFormsApplication1
{
    partial class PastStudent
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
            this.PastStudentFirstName = new System.Windows.Forms.TextBox();
            this.PastStudentLastName = new System.Windows.Forms.TextBox();
            this.PastStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PastStudentSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Status of Current Student to Past Student";
            // 
            // PastStudentFirstName
            // 
            this.PastStudentFirstName.Location = new System.Drawing.Point(185, 162);
            this.PastStudentFirstName.Name = "PastStudentFirstName";
            this.PastStudentFirstName.Size = new System.Drawing.Size(110, 20);
            this.PastStudentFirstName.TabIndex = 13;
            // 
            // PastStudentLastName
            // 
            this.PastStudentLastName.Location = new System.Drawing.Point(185, 127);
            this.PastStudentLastName.Name = "PastStudentLastName";
            this.PastStudentLastName.Size = new System.Drawing.Size(110, 20);
            this.PastStudentLastName.TabIndex = 12;
            // 
            // PastStudentID
            // 
            this.PastStudentID.Location = new System.Drawing.Point(185, 90);
            this.PastStudentID.Name = "PastStudentID";
            this.PastStudentID.Size = new System.Drawing.Size(110, 20);
            this.PastStudentID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Student ID";
            // 
            // PastStudentSubmit
            // 
            this.PastStudentSubmit.Location = new System.Drawing.Point(144, 211);
            this.PastStudentSubmit.Name = "PastStudentSubmit";
            this.PastStudentSubmit.Size = new System.Drawing.Size(104, 28);
            this.PastStudentSubmit.TabIndex = 14;
            this.PastStudentSubmit.Text = "Change Status";
            this.PastStudentSubmit.UseVisualStyleBackColor = true;
            // 
            // PastStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 275);
            this.Controls.Add(this.PastStudentSubmit);
            this.Controls.Add(this.PastStudentFirstName);
            this.Controls.Add(this.PastStudentLastName);
            this.Controls.Add(this.PastStudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PastStudent";
            this.Text = "PastStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PastStudentFirstName;
        private System.Windows.Forms.TextBox PastStudentLastName;
        private System.Windows.Forms.TextBox PastStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PastStudentSubmit;
    }
}