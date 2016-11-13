namespace WindowsFormsApplication1
{
    partial class AddNewSchool
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
            this.label6 = new System.Windows.Forms.Label();
            this.AddSchoolNewSchool = new System.Windows.Forms.TextBox();
            this.AddSchool_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Add New School to Database (if not in Database)";
            // 
            // AddSchoolNewSchool
            // 
            this.AddSchoolNewSchool.Location = new System.Drawing.Point(106, 109);
            this.AddSchoolNewSchool.Margin = new System.Windows.Forms.Padding(4);
            this.AddSchoolNewSchool.Name = "AddSchoolNewSchool";
            this.AddSchoolNewSchool.Size = new System.Drawing.Size(201, 22);
            this.AddSchoolNewSchool.TabIndex = 15;
            // 
            // AddSchool_Button
            // 
            this.AddSchool_Button.Location = new System.Drawing.Point(127, 207);
            this.AddSchool_Button.Margin = new System.Windows.Forms.Padding(4);
            this.AddSchool_Button.Name = "AddSchool_Button";
            this.AddSchool_Button.Size = new System.Drawing.Size(153, 37);
            this.AddSchool_Button.TabIndex = 14;
            this.AddSchool_Button.Text = "Add New School";
            this.AddSchool_Button.UseVisualStyleBackColor = true;
            this.AddSchool_Button.Click += new System.EventHandler(this.AddSchool_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Confirm the spelling of new school name.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add School To Database";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddNewSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 352);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddSchoolNewSchool);
            this.Controls.Add(this.AddSchool_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddNewSchool";
            this.Text = "Add New School";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddSchoolNewSchool;
        private System.Windows.Forms.Button AddSchool_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}