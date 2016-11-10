namespace WindowsFormsApplication1
{
    partial class View
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
            this.ViewID = new System.Windows.Forms.TextBox();
            this.ViewLastName = new System.Windows.Forms.TextBox();
            this.ViewFirstName = new System.Windows.Forms.TextBox();
            this.ViewSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Student Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Student ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(472, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Student ID OR Last name AND First Name";
            // 
            // ViewID
            // 
            this.ViewID.Location = new System.Drawing.Point(264, 169);
            this.ViewID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ViewID.Name = "ViewID";
            this.ViewID.Size = new System.Drawing.Size(216, 31);
            this.ViewID.TabIndex = 5;
            this.ViewID.TextChanged += new System.EventHandler(this.ViewID_TextChanged);
            // 
            // ViewLastName
            // 
            this.ViewLastName.Location = new System.Drawing.Point(264, 241);
            this.ViewLastName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ViewLastName.Name = "ViewLastName";
            this.ViewLastName.Size = new System.Drawing.Size(216, 31);
            this.ViewLastName.TabIndex = 6;
            // 
            // ViewFirstName
            // 
            this.ViewFirstName.Location = new System.Drawing.Point(264, 308);
            this.ViewFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ViewFirstName.Name = "ViewFirstName";
            this.ViewFirstName.Size = new System.Drawing.Size(216, 31);
            this.ViewFirstName.TabIndex = 7;
            this.ViewFirstName.TextChanged += new System.EventHandler(this.ViewFirstName_TextChanged);
            // 
            // ViewSubmit
            // 
            this.ViewSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSubmit.Location = new System.Drawing.Point(216, 403);
            this.ViewSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ViewSubmit.Name = "ViewSubmit";
            this.ViewSubmit.Size = new System.Drawing.Size(174, 48);
            this.ViewSubmit.TabIndex = 8;
            this.ViewSubmit.Text = "Submit";
            this.ViewSubmit.UseVisualStyleBackColor = true;
            this.ViewSubmit.Click += new System.EventHandler(this.ViewSubmit_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 522);
            this.Controls.Add(this.ViewSubmit);
            this.Controls.Add(this.ViewFirstName);
            this.Controls.Add(this.ViewLastName);
            this.Controls.Add(this.ViewID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ViewID;
        private System.Windows.Forms.TextBox ViewLastName;
        private System.Windows.Forms.TextBox ViewFirstName;
        private System.Windows.Forms.Button ViewSubmit;
    }
}