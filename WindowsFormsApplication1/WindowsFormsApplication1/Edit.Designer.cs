namespace WindowsFormsApplication1
{
    partial class Edit
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
            this.EditFirstName = new System.Windows.Forms.TextBox();
            this.EditLastName = new System.Windows.Forms.TextBox();
            this.EditID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Student Detail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditFirstName
            // 
            this.EditFirstName.Location = new System.Drawing.Point(163, 222);
            this.EditFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditFirstName.Name = "EditFirstName";
            this.EditFirstName.Size = new System.Drawing.Size(145, 22);
            this.EditFirstName.TabIndex = 14;
            // 
            // EditLastName
            // 
            this.EditLastName.Location = new System.Drawing.Point(163, 178);
            this.EditLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditLastName.Name = "EditLastName";
            this.EditLastName.Size = new System.Drawing.Size(145, 22);
            this.EditLastName.TabIndex = 13;
            // 
            // EditID
            // 
            this.EditID.Location = new System.Drawing.Point(163, 133);
            this.EditID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditID.Name = "EditID";
            this.EditID.Size = new System.Drawing.Size(145, 22);
            this.EditID.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter Student ID OR Last name AND First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Student ID";
            // 
            // EditSubmit
            // 
            this.EditSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSubmit.Location = new System.Drawing.Point(97, 292);
            this.EditSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditSubmit.Name = "EditSubmit";
            this.EditSubmit.Size = new System.Drawing.Size(200, 32);
            this.EditSubmit.TabIndex = 17;
            this.EditSubmit.Text = "Find Student Info";
            this.EditSubmit.UseVisualStyleBackColor = true;
            this.EditSubmit.Click += new System.EventHandler(this.EditSubmit_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 370);
            this.Controls.Add(this.EditSubmit);
            this.Controls.Add(this.EditFirstName);
            this.Controls.Add(this.EditLastName);
            this.Controls.Add(this.EditID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditFirstName;
        private System.Windows.Forms.TextBox EditLastName;
        private System.Windows.Forms.TextBox EditID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditSubmit;
    }
}