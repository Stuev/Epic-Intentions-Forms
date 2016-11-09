namespace WindowsFormsApplication1
{
    partial class DeleteCum
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
            this.DeleteCumSubmit = new System.Windows.Forms.Button();
            this.DeleteCumDate = new System.Windows.Forms.TextBox();
            this.DeleteCumGrade = new System.Windows.Forms.TextBox();
            this.DeleteCumID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "(out of 4)";
            // 
            // DeleteCumSubmit
            // 
            this.DeleteCumSubmit.Location = new System.Drawing.Point(125, 228);
            this.DeleteCumSubmit.Name = "DeleteCumSubmit";
            this.DeleteCumSubmit.Size = new System.Drawing.Size(123, 40);
            this.DeleteCumSubmit.TabIndex = 22;
            this.DeleteCumSubmit.Text = "Delete Grade";
            this.DeleteCumSubmit.UseVisualStyleBackColor = true;
            // 
            // DeleteCumDate
            // 
            this.DeleteCumDate.Location = new System.Drawing.Point(177, 171);
            this.DeleteCumDate.Name = "DeleteCumDate";
            this.DeleteCumDate.Size = new System.Drawing.Size(99, 20);
            this.DeleteCumDate.TabIndex = 21;
            // 
            // DeleteCumGrade
            // 
            this.DeleteCumGrade.Location = new System.Drawing.Point(177, 130);
            this.DeleteCumGrade.Name = "DeleteCumGrade";
            this.DeleteCumGrade.Size = new System.Drawing.Size(99, 20);
            this.DeleteCumGrade.TabIndex = 20;
            // 
            // DeleteCumID
            // 
            this.DeleteCumID.Location = new System.Drawing.Point(177, 89);
            this.DeleteCumID.Name = "DeleteCumID";
            this.DeleteCumID.Size = new System.Drawing.Size(99, 20);
            this.DeleteCumID.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "yyyy-mm-dd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grade Entry Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cumulative GPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Delete Cumulative GPA ";
            // 
            // DeleteCum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 359);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteCumSubmit);
            this.Controls.Add(this.DeleteCumDate);
            this.Controls.Add(this.DeleteCumGrade);
            this.Controls.Add(this.DeleteCumID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCum";
            this.Text = "DeleteCum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteCumSubmit;
        private System.Windows.Forms.TextBox DeleteCumDate;
        private System.Windows.Forms.TextBox DeleteCumGrade;
        private System.Windows.Forms.TextBox DeleteCumID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}