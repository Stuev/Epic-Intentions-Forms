namespace WindowsFormsApplication1
{
    partial class AddReferral
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddReferral_ID = new System.Windows.Forms.TextBox();
            this.AddReferral_Date = new System.Windows.Forms.TextBox();
            this.AddReferral_Category = new System.Windows.Forms.ComboBox();
            this.RefDesc = new System.Windows.Forms.TextBox();
            this.RefDescBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Referral";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Referral Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Incident Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Brief Description";
            // 
            // AddReferral_ID
            // 
            this.AddReferral_ID.Location = new System.Drawing.Point(192, 74);
            this.AddReferral_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddReferral_ID.Name = "AddReferral_ID";
            this.AddReferral_ID.Size = new System.Drawing.Size(116, 22);
            this.AddReferral_ID.TabIndex = 7;
            // 
            // AddReferral_Date
            // 
            this.AddReferral_Date.Location = new System.Drawing.Point(192, 116);
            this.AddReferral_Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddReferral_Date.Name = "AddReferral_Date";
            this.AddReferral_Date.Size = new System.Drawing.Size(116, 22);
            this.AddReferral_Date.TabIndex = 8;
            // 
            // AddReferral_Category
            // 
            this.AddReferral_Category.FormattingEnabled = true;
            this.AddReferral_Category.Location = new System.Drawing.Point(192, 158);
            this.AddReferral_Category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddReferral_Category.Name = "AddReferral_Category";
            this.AddReferral_Category.Size = new System.Drawing.Size(116, 24);
            this.AddReferral_Category.TabIndex = 9;
            this.AddReferral_Category.SelectedIndexChanged += new System.EventHandler(this.AddReferral_Category_SelectedIndexChanged);
            // 
            // RefDesc
            // 
            this.RefDesc.Location = new System.Drawing.Point(192, 196);
            this.RefDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RefDesc.Name = "RefDesc";
            this.RefDesc.Size = new System.Drawing.Size(240, 22);
            this.RefDesc.TabIndex = 10;
            // 
            // RefDescBox
            // 
            this.RefDescBox.Location = new System.Drawing.Point(109, 240);
            this.RefDescBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RefDescBox.Name = "RefDescBox";
            this.RefDescBox.Size = new System.Drawing.Size(187, 30);
            this.RefDescBox.TabIndex = 11;
            this.RefDescBox.Text = "Add Referral to Database";
            this.RefDescBox.UseVisualStyleBackColor = true;
            this.RefDescBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddReferral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 321);
            this.Controls.Add(this.RefDescBox);
            this.Controls.Add(this.RefDesc);
            this.Controls.Add(this.AddReferral_Category);
            this.Controls.Add(this.AddReferral_Date);
            this.Controls.Add(this.AddReferral_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddReferral";
            this.Text = "AddReferral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddReferral_ID;
        private System.Windows.Forms.TextBox AddReferral_Date;
        private System.Windows.Forms.ComboBox AddReferral_Category;
        private System.Windows.Forms.TextBox RefDesc;
        private System.Windows.Forms.Button RefDescBox;
    }
}