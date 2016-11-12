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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteCumID = new System.Windows.Forms.ComboBox();
            this.DeleteCumGPA = new System.Windows.Forms.ComboBox();
            this.DeleteCumDate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "(out of 4)";
            // 
            // DeleteCumSubmit
            // 
            this.DeleteCumSubmit.Location = new System.Drawing.Point(250, 438);
            this.DeleteCumSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteCumSubmit.Name = "DeleteCumSubmit";
            this.DeleteCumSubmit.Size = new System.Drawing.Size(246, 77);
            this.DeleteCumSubmit.TabIndex = 22;
            this.DeleteCumSubmit.Text = "Delete Grade";
            this.DeleteCumSubmit.UseVisualStyleBackColor = true;
            this.DeleteCumSubmit.Click += new System.EventHandler(this.DeleteCumSubmit_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "yyyy-mm-dd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grade Entry Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cumulative GPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Delete Cumulative GPA ";
            // 
            // DeleteCumID
            // 
            this.DeleteCumID.FormattingEnabled = true;
            this.DeleteCumID.Location = new System.Drawing.Point(354, 185);
            this.DeleteCumID.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteCumID.Name = "DeleteCumID";
            this.DeleteCumID.Size = new System.Drawing.Size(238, 33);
            this.DeleteCumID.TabIndex = 43;
            this.DeleteCumID.SelectedIndexChanged += new System.EventHandler(this.UnCumClass_SelectedIndexChanged);
            // 
            // DeleteCumGPA
            // 
            this.DeleteCumGPA.FormattingEnabled = true;
            this.DeleteCumGPA.Location = new System.Drawing.Point(354, 250);
            this.DeleteCumGPA.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteCumGPA.Name = "DeleteCumGPA";
            this.DeleteCumGPA.Size = new System.Drawing.Size(238, 33);
            this.DeleteCumGPA.TabIndex = 44;
            // 
            // DeleteCumDate
            // 
            this.DeleteCumDate.FormattingEnabled = true;
            this.DeleteCumDate.Location = new System.Drawing.Point(354, 329);
            this.DeleteCumDate.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteCumDate.Name = "DeleteCumDate";
            this.DeleteCumDate.Size = new System.Drawing.Size(238, 33);
            this.DeleteCumDate.TabIndex = 45;
            // 
            // DeleteCum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 690);
            this.Controls.Add(this.DeleteCumDate);
            this.Controls.Add(this.DeleteCumGPA);
            this.Controls.Add(this.DeleteCumID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteCumSubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DeleteCum";
            this.Text = "DeleteCum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteCumSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DeleteCumID;
        private System.Windows.Forms.ComboBox DeleteCumGPA;
        private System.Windows.Forms.ComboBox DeleteCumDate;
    }
}