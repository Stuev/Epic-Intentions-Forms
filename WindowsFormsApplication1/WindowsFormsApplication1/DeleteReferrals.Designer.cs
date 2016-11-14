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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteReferralID = new System.Windows.Forms.ComboBox();
            this.DeleteReferralType = new System.Windows.Forms.ComboBox();
            this.DeleteReferralDate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Referral Type";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DeleteRefSubmit
            // 
            this.DeleteRefSubmit.Location = new System.Drawing.Point(304, 429);
            this.DeleteRefSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteRefSubmit.Name = "DeleteRefSubmit";
            this.DeleteRefSubmit.Size = new System.Drawing.Size(246, 77);
            this.DeleteRefSubmit.TabIndex = 32;
            this.DeleteRefSubmit.Text = "Delete Referral";
            this.DeleteRefSubmit.UseVisualStyleBackColor = true;
            this.DeleteRefSubmit.Click += new System.EventHandler(this.DeleteRefSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "yyyy-mm-dd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Referral Entry Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Delete Behavior Referral ";
            // 
            // DeleteReferralID
            // 
            this.DeleteReferralID.FormattingEnabled = true;
            this.DeleteReferralID.Location = new System.Drawing.Point(410, 167);
            this.DeleteReferralID.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteReferralID.Name = "DeleteReferralID";
            this.DeleteReferralID.Size = new System.Drawing.Size(238, 33);
            this.DeleteReferralID.TabIndex = 45;
            this.DeleteReferralID.SelectedIndexChanged += new System.EventHandler(this.DeleteReferralID_SelectedIndexChanged);
            // 
            // DeleteReferralType
            // 
            this.DeleteReferralType.FormattingEnabled = true;
            this.DeleteReferralType.Location = new System.Drawing.Point(410, 246);
            this.DeleteReferralType.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteReferralType.Name = "DeleteReferralType";
            this.DeleteReferralType.Size = new System.Drawing.Size(238, 33);
            this.DeleteReferralType.TabIndex = 46;
            // 
            // DeleteReferralDate
            // 
            this.DeleteReferralDate.FormattingEnabled = true;
            this.DeleteReferralDate.Location = new System.Drawing.Point(410, 322);
            this.DeleteReferralDate.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteReferralDate.Name = "DeleteReferralDate";
            this.DeleteReferralDate.Size = new System.Drawing.Size(238, 33);
            this.DeleteReferralDate.TabIndex = 47;
            // 
            // DeleteReferrals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 690);
            this.Controls.Add(this.DeleteReferralDate);
            this.Controls.Add(this.DeleteReferralType);
            this.Controls.Add(this.DeleteReferralID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteRefSubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DeleteReferrals";
            this.Text = "DeleteReferrals";
            this.Load += new System.EventHandler(this.DeleteReferrals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteRefSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DeleteReferralID;
        private System.Windows.Forms.ComboBox DeleteReferralType;
        private System.Windows.Forms.ComboBox DeleteReferralDate;
    }
}