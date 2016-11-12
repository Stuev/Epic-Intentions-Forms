namespace WindowsFormsApplication1
{
    partial class AddSchool_ID
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
            this.label4 = new System.Windows.Forms.Label();
            this.AddSchool_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.stID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddSchool_StartDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddSchoolNewSchool = new System.Windows.Forms.TextBox();
            this.AddSchoolExistingSchool = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Attending School";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm the spelling of new school name.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select Existing School Student Transferred to";
            // 
            // AddSchool_Button
            // 
            this.AddSchool_Button.Location = new System.Drawing.Point(249, 288);
            this.AddSchool_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddSchool_Button.Name = "AddSchool_Button";
            this.AddSchool_Button.Size = new System.Drawing.Size(153, 37);
            this.AddSchool_Button.TabIndex = 5;
            this.AddSchool_Button.Text = "Add New School";
            this.AddSchool_Button.UseVisualStyleBackColor = true;
            this.AddSchool_Button.Click += new System.EventHandler(this.AddSchool_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student ID";
            // 
            // stID
            // 
            this.stID.Location = new System.Drawing.Point(336, 79);
            this.stID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stID.Name = "stID";
            this.stID.Size = new System.Drawing.Size(201, 22);
            this.stID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Start Date of Transfer School";
            // 
            // AddSchool_StartDate
            // 
            this.AddSchool_StartDate.Location = new System.Drawing.Point(336, 119);
            this.AddSchool_StartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddSchool_StartDate.Name = "AddSchool_StartDate";
            this.AddSchool_StartDate.Size = new System.Drawing.Size(201, 22);
            this.AddSchool_StartDate.TabIndex = 8;
            this.AddSchool_StartDate.Text = "MM/DD/YYYY";
            this.AddSchool_StartDate.TextChanged += new System.EventHandler(this.AddSchool_StartDate_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Add New School to Database (if not in Database)";
            // 
            // AddSchoolNewSchool
            // 
            this.AddSchoolNewSchool.Location = new System.Drawing.Point(336, 199);
            this.AddSchoolNewSchool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddSchoolNewSchool.Name = "AddSchoolNewSchool";
            this.AddSchoolNewSchool.Size = new System.Drawing.Size(201, 22);
            this.AddSchoolNewSchool.TabIndex = 10;
            this.AddSchoolNewSchool.TextChanged += new System.EventHandler(this.AddSchoolNewSchool_TextChanged);
            // 
            // AddSchoolExistingSchool
            // 
            this.AddSchoolExistingSchool.FormattingEnabled = true;
            this.AddSchoolExistingSchool.Location = new System.Drawing.Point(336, 159);
            this.AddSchoolExistingSchool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddSchoolExistingSchool.Name = "AddSchoolExistingSchool";
            this.AddSchoolExistingSchool.Size = new System.Drawing.Size(201, 24);
            this.AddSchoolExistingSchool.TabIndex = 12;
            this.AddSchoolExistingSchool.Text = "No School Selected";
            this.AddSchoolExistingSchool.SelectedIndexChanged += new System.EventHandler(this.AddSchoolExistingSchool_SelectedIndexChanged);
            // 
            // AddSchool_ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 420);
            this.Controls.Add(this.AddSchoolExistingSchool);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddSchoolNewSchool);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddSchool_StartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stID);
            this.Controls.Add(this.AddSchool_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddSchool_ID";
            this.Text = "AddSchool";
            this.Load += new System.EventHandler(this.AddSchool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddSchool_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddSchool_StartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddSchoolNewSchool;
        private System.Windows.Forms.ComboBox AddSchoolExistingSchool;
    }
}