namespace WindowsFormsApplication1
{
    partial class EditSchool
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
            this.label5 = new System.Windows.Forms.Label();
            this.UploadFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.School = new System.Windows.Forms.ComboBox();
            this.NewSchool = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "*Please confirm that the school name is correct*";
            // 
            // UploadFile
            // 
            this.UploadFile.Location = new System.Drawing.Point(148, 276);
            this.UploadFile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UploadFile.Name = "UploadFile";
            this.UploadFile.Size = new System.Drawing.Size(172, 38);
            this.UploadFile.TabIndex = 15;
            this.UploadFile.Text = "Complete Edit";
            this.UploadFile.UseVisualStyleBackColor = true;
            this.UploadFile.Click += new System.EventHandler(this.UploadFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Please make the necessary changes for an existing school";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Edit School Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Select School";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Updated School Name";
            // 
            // School
            // 
            this.School.FormattingEnabled = true;
            this.School.Location = new System.Drawing.Point(232, 146);
            this.School.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.School.Name = "School";
            this.School.Size = new System.Drawing.Size(153, 24);
            this.School.TabIndex = 19;
            // 
            // NewSchool
            // 
            this.NewSchool.Location = new System.Drawing.Point(232, 188);
            this.NewSchool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewSchool.Name = "NewSchool";
            this.NewSchool.Size = new System.Drawing.Size(163, 22);
            this.NewSchool.TabIndex = 20;
            this.NewSchool.TextChanged += new System.EventHandler(this.NewSchool_TextChanged);
            // 
            // EditSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 460);
            this.Controls.Add(this.NewSchool);
            this.Controls.Add(this.School);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UploadFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditSchool";
            this.Text = "EditSchool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UploadFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox School;
        private System.Windows.Forms.TextBox NewSchool;
    }
}