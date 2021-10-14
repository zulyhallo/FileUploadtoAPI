
namespace FileUploadtoAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Upload = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(500, 144);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(75, 23);
            this.Upload.TabIndex = 0;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(35, 111);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(66, 15);
            this.FileName.TabIndex = 1;
            this.FileName.Text = "File Name :";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(107, 103);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(468, 23);
            this.txtFileName.TabIndex = 2;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(593, 103);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(30, 23);
            this.Browse.TabIndex = 3;
            this.Browse.Text = "...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Upload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button Browse;
    }
}

