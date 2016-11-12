namespace WindowsFormsApplication1
{
    partial class AddNewStudent
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
            this.AddCurrent = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.AddAttend = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.AddBehavior = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.AddGender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AddGrade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddGPA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddStudentSubmit = new System.Windows.Forms.Button();
            this.CumGradeAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.raceBox = new System.Windows.Forms.TextBox();
            this.addSchool = new System.Windows.Forms.ComboBox();
            this.addStudentID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addLastName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.addFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddCurrent
            // 
            this.AddCurrent.FormattingEnabled = true;
            this.AddCurrent.Location = new System.Drawing.Point(220, 441);
            this.AddCurrent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCurrent.Name = "AddCurrent";
            this.AddCurrent.Size = new System.Drawing.Size(121, 24);
            this.AddCurrent.TabIndex = 60;
            this.AddCurrent.SelectedIndexChanged += new System.EventHandler(this.AddCurrent_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(99, 444);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 17);
            this.label19.TabIndex = 59;
            this.label19.Text = "Current Student";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(156, 401);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 17);
            this.label18.TabIndex = 57;
            this.label18.Text = "Race";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // AddAttend
            // 
            this.AddAttend.Location = new System.Drawing.Point(220, 315);
            this.AddAttend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddAttend.Name = "AddAttend";
            this.AddAttend.Size = new System.Drawing.Size(55, 22);
            this.AddAttend.TabIndex = 54;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(104, 319);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 17);
            this.label17.TabIndex = 52;
            this.label17.Text = "# Days Missed";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // AddBehavior
            // 
            this.AddBehavior.Location = new System.Drawing.Point(220, 278);
            this.AddBehavior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddBehavior.Name = "AddBehavior";
            this.AddBehavior.Size = new System.Drawing.Size(55, 22);
            this.AddBehavior.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(127, 282);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 17);
            this.label14.TabIndex = 47;
            this.label14.Text = "# Referrals";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // AddGender
            // 
            this.AddGender.FormattingEnabled = true;
            this.AddGender.Location = new System.Drawing.Point(220, 358);
            this.AddGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddGender.Name = "AddGender";
            this.AddGender.Size = new System.Drawing.Size(119, 24);
            this.AddGender.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(144, 362);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Gender";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // AddGrade
            // 
            this.AddGrade.Location = new System.Drawing.Point(220, 241);
            this.AddGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddGrade.Name = "AddGrade";
            this.AddGrade.Size = new System.Drawing.Size(55, 22);
            this.AddGrade.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Grade";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "School";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AddGPA
            // 
            this.AddGPA.Location = new System.Drawing.Point(220, 133);
            this.AddGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddGPA.Name = "AddGPA";
            this.AddGPA.Size = new System.Drawing.Size(55, 22);
            this.AddGPA.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "GPA (4.0 Scale)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, -12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Add New Student to Database";
            // 
            // AddStudentSubmit
            // 
            this.AddStudentSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentSubmit.Location = new System.Drawing.Point(161, 476);
            this.AddStudentSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddStudentSubmit.Name = "AddStudentSubmit";
            this.AddStudentSubmit.Size = new System.Drawing.Size(93, 33);
            this.AddStudentSubmit.TabIndex = 62;
            this.AddStudentSubmit.Text = "Submit";
            this.AddStudentSubmit.UseVisualStyleBackColor = true;
            this.AddStudentSubmit.Click += new System.EventHandler(this.AddStudentSubmit_Click_1);
            // 
            // CumGradeAdd
            // 
            this.CumGradeAdd.Location = new System.Drawing.Point(220, 166);
            this.CumGradeAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CumGradeAdd.Name = "CumGradeAdd";
            this.CumGradeAdd.Size = new System.Drawing.Size(55, 22);
            this.CumGradeAdd.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Cum. Grade (100 pt scale)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(245, 17);
            this.label9.TabIndex = 65;
            this.label9.Text = "Note: GPA is preferred. Do not insert ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 153);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "both GPA and Cum. Grade for one student";
            // 
            // raceBox
            // 
            this.raceBox.Location = new System.Drawing.Point(220, 401);
            this.raceBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(132, 22);
            this.raceBox.TabIndex = 68;
            // 
            // addSchool
            // 
            this.addSchool.FormattingEnabled = true;
            this.addSchool.Location = new System.Drawing.Point(220, 201);
            this.addSchool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addSchool.Name = "addSchool";
            this.addSchool.Size = new System.Drawing.Size(160, 24);
            this.addSchool.TabIndex = 69;
            this.addSchool.SelectedIndexChanged += new System.EventHandler(this.addSchool_SelectedIndexChanged);
            // 
            // addStudentID
            // 
            this.addStudentID.Location = new System.Drawing.Point(220, 101);
            this.addStudentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addStudentID.Name = "addStudentID";
            this.addStudentID.Size = new System.Drawing.Size(72, 22);
            this.addStudentID.TabIndex = 70;
            this.addStudentID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(123, 101);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 71;
            this.label12.Text = "Student ID";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(123, 70);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 72;
            this.label13.Text = "Last Name";
            // 
            // addLastName
            // 
            this.addLastName.Location = new System.Drawing.Point(220, 66);
            this.addLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addLastName.Name = "addLastName";
            this.addLastName.Size = new System.Drawing.Size(132, 22);
            this.addLastName.TabIndex = 73;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(127, 37);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 74;
            this.label15.Text = "First Name";
            // 
            // addFirstName
            // 
            this.addFirstName.Location = new System.Drawing.Point(220, 33);
            this.addFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addFirstName.Name = "addFirstName";
            this.addFirstName.Size = new System.Drawing.Size(121, 22);
            this.addFirstName.TabIndex = 75;
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 519);
            this.Controls.Add(this.addFirstName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.addLastName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.addStudentID);
            this.Controls.Add(this.addSchool);
            this.Controls.Add(this.raceBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CumGradeAdd);
            this.Controls.Add(this.AddStudentSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCurrent);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.AddAttend);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.AddBehavior);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.AddGender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AddGrade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddGPA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNewStudent";
            this.Text = "AddNewStudent";
            this.Load += new System.EventHandler(this.AddNewStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AddCurrent;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox AddAttend;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox AddBehavior;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox AddGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AddGrade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddGPA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddStudentSubmit;
        private System.Windows.Forms.TextBox CumGradeAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox raceBox;
        private System.Windows.Forms.ComboBox addSchool;
        private System.Windows.Forms.TextBox addStudentID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox addLastName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox addFirstName;
    }
}