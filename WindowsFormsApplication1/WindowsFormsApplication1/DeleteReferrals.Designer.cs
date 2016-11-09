namespace WindowsFormsApplication1
{
    partial class DeleteReferrals
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
            this.DeleteRefSubmit = new System.Windows.Forms.Button();
            this.DeleteRefDate = new System.Windows.Forms.TextBox();
            this.DeleteRefType = new System.Windows.Forms.TextBox();
            this.DeleteRefID = new System.Windows.Forms.TextBox();
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
            this.label7.Location = new System.Drawing.Point(103, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Referral Type";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DeleteRefSubmit
            // 
            this.DeleteRefSubmit.Location = new System.Drawing.Point(152, 223);
            this.DeleteRefSubmit.Name = "DeleteRefSubmit";
            this.DeleteRefSubmit.Size = new System.Drawing.Size(123, 40);
            this.DeleteRefSubmit.TabIndex = 32;
            this.DeleteRefSubmit.Text = "Delete Referral";
            this.DeleteRefSubmit.UseVisualStyleBackColor = true;
            // 
            // DeleteRefDate
            // 
            this.DeleteRefDate.Location = new System.Drawing.Point(204, 166);
            this.DeleteRefDate.Name = "DeleteRefDate";
            this.DeleteRefDate.Size = new System.Drawing.Size(99, 20);
            this.DeleteRefDate.TabIndex = 31;
            // 
            // DeleteRefType
            // 
            this.DeleteRefType.Location = new System.Drawing.Point(204, 125);
            this.DeleteRefType.Name = "DeleteRefType";
            this.DeleteRefType.Size = new System.Drawing.Size(99, 20);
            this.DeleteRefType.TabIndex = 30;
            // 
            // DeleteRefID
            // 
            this.DeleteRefID.Location = new System.Drawing.Point(204, 84);
            this.DeleteRefID.Name = "DeleteRefID";
            this.DeleteRefID.Size = new System.Drawing.Size(99, 20);
            this.DeleteRefID.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "yyyy-mm-dd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Referral Entry Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Delete Behavior Referral ";
            // 
            // DeleteReferrals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 359);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteRefSubmit);
            this.Controls.Add(this.DeleteRefDate);
            this.Controls.Add(this.DeleteRefType);
            this.Controls.Add(this.DeleteRefID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteReferrals";
            this.Text = "DeleteReferrals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteRefSubmit;
        private System.Windows.Forms.TextBox DeleteRefDate;
        private System.Windows.Forms.TextBox DeleteRefType;
        private System.Windows.Forms.TextBox DeleteRefID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}