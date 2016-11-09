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
            this.label5 = new System.Windows.Forms.Label();
            this.PastReason = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Status of Current Student to Past Student";
            // 
            // PastStudentFirstName
            // 
            this.PastStudentFirstName.Location = new System.Drawing.Point(185, 122);
            this.PastStudentFirstName.Name = "PastStudentFirstName";
            this.PastStudentFirstName.Size = new System.Drawing.Size(110, 20);
            this.PastStudentFirstName.TabIndex = 13;
            // 
            // PastStudentLastName
            // 
            this.PastStudentLastName.Location = new System.Drawing.Point(185, 87);
            this.PastStudentLastName.Name = "PastStudentLastName";
            this.PastStudentLastName.Size = new System.Drawing.Size(110, 20);
            this.PastStudentLastName.TabIndex = 12;
            // 
            // PastStudentID
            // 
            this.PastStudentID.Location = new System.Drawing.Point(185, 42);
            this.PastStudentID.Name = "PastStudentID";
            this.PastStudentID.Size = new System.Drawing.Size(110, 20);
            this.PastStudentID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Student ID";
            // 
            // PastStudentSubmit
            // 
            this.PastStudentSubmit.Location = new System.Drawing.Point(133, 250);
            this.PastStudentSubmit.Name = "PastStudentSubmit";
            this.PastStudentSubmit.Size = new System.Drawing.Size(104, 43);
            this.PastStudentSubmit.TabIndex = 14;
            this.PastStudentSubmit.Text = "Change Status to Past";
            this.PastStudentSubmit.UseVisualStyleBackColor = true;
            this.PastStudentSubmit.Click += new System.EventHandler(this.PastStudentSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter Reason for Leaving";
            // 
            // PastReason
            // 
            this.PastReason.Location = new System.Drawing.Point(185, 210);
            this.PastReason.Name = "PastReason";
            this.PastReason.Size = new System.Drawing.Size(197, 20);
            this.PastReason.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "OR";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "AND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(370, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Change Status of Past Student to Current Student";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 28;
            this.button1.Text = "Change Status to Current";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PastStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PastReason);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PastReason;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}