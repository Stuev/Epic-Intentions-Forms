namespace WindowsFormsApplication1
{
    partial class Filter
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
            this.GPA1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GPA2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.School = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Grade2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Grade1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Behavior2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Behavior1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Attend2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Attend1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Race = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Current = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.FilterSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "GPA (4.0 Scale)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "from";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // GPA1
            // 
            this.GPA1.Location = new System.Drawing.Point(164, 57);
            this.GPA1.Name = "GPA1";
            this.GPA1.Size = new System.Drawing.Size(42, 20);
            this.GPA1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "to";
            // 
            // GPA2
            // 
            this.GPA2.Location = new System.Drawing.Point(258, 57);
            this.GPA2.Name = "GPA2";
            this.GPA2.Size = new System.Drawing.Size(42, 20);
            this.GPA2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "School";
            // 
            // School
            // 
            this.School.FormattingEnabled = true;
            this.School.Location = new System.Drawing.Point(154, 96);
            this.School.Name = "School";
            this.School.Size = new System.Drawing.Size(121, 21);
            this.School.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Grade Level";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "from";
            // 
            // Grade2
            // 
            this.Grade2.Location = new System.Drawing.Point(258, 129);
            this.Grade2.Name = "Grade2";
            this.Grade2.Size = new System.Drawing.Size(42, 20);
            this.Grade2.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "to";
            // 
            // Grade1
            // 
            this.Grade1.Location = new System.Drawing.Point(164, 129);
            this.Grade1.Name = "Grade1";
            this.Grade1.Size = new System.Drawing.Size(42, 20);
            this.Grade1.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Gender";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Location = new System.Drawing.Point(154, 224);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 21);
            this.Gender.TabIndex = 16;
            // 
            // Behavior2
            // 
            this.Behavior2.Location = new System.Drawing.Point(258, 159);
            this.Behavior2.Name = "Behavior2";
            this.Behavior2.Size = new System.Drawing.Size(42, 20);
            this.Behavior2.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "to";
            // 
            // Behavior1
            // 
            this.Behavior1.Location = new System.Drawing.Point(164, 159);
            this.Behavior1.Name = "Behavior1";
            this.Behavior1.Size = new System.Drawing.Size(42, 20);
            this.Behavior1.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(124, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "from";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "# Referrals ";
            // 
            // Attend2
            // 
            this.Attend2.Location = new System.Drawing.Point(258, 189);
            this.Attend2.Name = "Attend2";
            this.Attend2.Size = new System.Drawing.Size(42, 20);
            this.Attend2.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(225, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "to";
            // 
            // Attend1
            // 
            this.Attend1.Location = new System.Drawing.Point(164, 189);
            this.Attend1.Name = "Attend1";
            this.Attend1.Size = new System.Drawing.Size(42, 20);
            this.Attend1.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(124, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "from";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Days Missed";
            // 
            // Race
            // 
            this.Race.FormattingEnabled = true;
            this.Race.Location = new System.Drawing.Point(152, 259);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(121, 21);
            this.Race.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(62, 259);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Race";
            // 
            // Current
            // 
            this.Current.FormattingEnabled = true;
            this.Current.Location = new System.Drawing.Point(152, 291);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(121, 21);
            this.Current.TabIndex = 30;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 294);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Current Student";
            // 
            // FilterSubmit
            // 
            this.FilterSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterSubmit.Location = new System.Drawing.Point(107, 338);
            this.FilterSubmit.Name = "FilterSubmit";
            this.FilterSubmit.Size = new System.Drawing.Size(80, 29);
            this.FilterSubmit.TabIndex = 31;
            this.FilterSubmit.Text = "Submit";
            this.FilterSubmit.UseVisualStyleBackColor = true;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 379);
            this.Controls.Add(this.FilterSubmit);
            this.Controls.Add(this.Current);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Race);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Attend2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Attend1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Behavior2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Behavior1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Grade2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Grade1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.School);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GPA2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GPA1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Filter";
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.Filter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GPA1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GPA2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox School;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Grade2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Grade1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.TextBox Behavior2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Behavior1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Attend2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Attend1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox Race;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox Current;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button FilterSubmit;
    }
}