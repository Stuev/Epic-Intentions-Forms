namespace WindowsFormsApplication1
{
    partial class EditPart2
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
            this.ImportFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UploadFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit Student Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please make the necessary changes on the Excel file that";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "popped up. Then, save the same file to import below.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Uploaded file MUST be the Excel File that popped up";
            // 
            // ImportFile
            // 
            this.ImportFile.Location = new System.Drawing.Point(122, 137);
            this.ImportFile.Name = "ImportFile";
            this.ImportFile.Size = new System.Drawing.Size(86, 25);
            this.ImportFile.TabIndex = 5;
            this.ImportFile.Text = "Import File";
            this.ImportFile.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 6;
            // 
            // UploadFile
            // 
            this.UploadFile.Location = new System.Drawing.Point(122, 241);
            this.UploadFile.Name = "UploadFile";
            this.UploadFile.Size = new System.Drawing.Size(86, 25);
            this.UploadFile.TabIndex = 7;
            this.UploadFile.Text = "Complete Edit";
            this.UploadFile.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "*Please confirm the correct file is imported*";
            // 
            // EditPart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 337);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UploadFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ImportFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditPart2";
            this.Text = "EditPart2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ImportFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button UploadFile;
        private System.Windows.Forms.Label label5;
    }
}