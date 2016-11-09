namespace WindowsFormsApplication1
{
    partial class DeleteUncum
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteUnCumID = new System.Windows.Forms.TextBox();
            this.DeleteUnCumClass = new System.Windows.Forms.TextBox();
            this.DeleteUnCumGrade = new System.Windows.Forms.TextBox();
            this.DeleteUnCumDate = new System.Windows.Forms.TextBox();
            this.DeleteUnCumSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Uncumulative Grades ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade Entry Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "yyyy-mm-dd";
            // 
            // DeleteUnCumID
            // 
            this.DeleteUnCumID.Location = new System.Drawing.Point(169, 74);
            this.DeleteUnCumID.Name = "DeleteUnCumID";
            this.DeleteUnCumID.Size = new System.Drawing.Size(99, 20);
            this.DeleteUnCumID.TabIndex = 6;
            // 
            // DeleteUnCumClass
            // 
            this.DeleteUnCumClass.Location = new System.Drawing.Point(169, 111);
            this.DeleteUnCumClass.Name = "DeleteUnCumClass";
            this.DeleteUnCumClass.Size = new System.Drawing.Size(99, 20);
            this.DeleteUnCumClass.TabIndex = 7;
            // 
            // DeleteUnCumGrade
            // 
            this.DeleteUnCumGrade.Location = new System.Drawing.Point(169, 150);
            this.DeleteUnCumGrade.Name = "DeleteUnCumGrade";
            this.DeleteUnCumGrade.Size = new System.Drawing.Size(99, 20);
            this.DeleteUnCumGrade.TabIndex = 8;
            // 
            // DeleteUnCumDate
            // 
            this.DeleteUnCumDate.Location = new System.Drawing.Point(169, 191);
            this.DeleteUnCumDate.Name = "DeleteUnCumDate";
            this.DeleteUnCumDate.Size = new System.Drawing.Size(99, 20);
            this.DeleteUnCumDate.TabIndex = 9;
            // 
            // DeleteUnCumSubmit
            // 
            this.DeleteUnCumSubmit.Location = new System.Drawing.Point(117, 248);
            this.DeleteUnCumSubmit.Name = "DeleteUnCumSubmit";
            this.DeleteUnCumSubmit.Size = new System.Drawing.Size(123, 40);
            this.DeleteUnCumSubmit.TabIndex = 10;
            this.DeleteUnCumSubmit.Text = "Delete Grade";
            this.DeleteUnCumSubmit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "(out of 100)";
            // 
            // DeleteUncum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 330);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteUnCumSubmit);
            this.Controls.Add(this.DeleteUnCumDate);
            this.Controls.Add(this.DeleteUnCumGrade);
            this.Controls.Add(this.DeleteUnCumClass);
            this.Controls.Add(this.DeleteUnCumID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteUncum";
            this.Text = "DeleteUncum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DeleteUnCumID;
        private System.Windows.Forms.TextBox DeleteUnCumClass;
        private System.Windows.Forms.TextBox DeleteUnCumGrade;
        private System.Windows.Forms.TextBox DeleteUnCumDate;
        private System.Windows.Forms.Button DeleteUnCumSubmit;
        private System.Windows.Forms.Label label7;
    }
}