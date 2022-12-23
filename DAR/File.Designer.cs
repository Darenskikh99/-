namespace DAR
{
    partial class FILE
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
            this.m_file = new System.Windows.Forms.TextBox();
            this.IDC_FILEOK_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя файла";
            // 
            // m_file
            // 
            this.m_file.Location = new System.Drawing.Point(99, 110);
            this.m_file.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_file.Name = "m_file";
            this.m_file.Size = new System.Drawing.Size(232, 22);
            this.m_file.TabIndex = 1;
            // 
            // IDC_FILEOK_BUTTON
            // 
            this.IDC_FILEOK_BUTTON.Location = new System.Drawing.Point(232, 191);
            this.IDC_FILEOK_BUTTON.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_FILEOK_BUTTON.Name = "IDC_FILEOK_BUTTON";
            this.IDC_FILEOK_BUTTON.Size = new System.Drawing.Size(100, 28);
            this.IDC_FILEOK_BUTTON.TabIndex = 2;
            this.IDC_FILEOK_BUTTON.Text = "OK";
            this.IDC_FILEOK_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_FILEOK_BUTTON.Click += new System.EventHandler(this.IDC_FILEOK_BUTTON_Click);
            // 
            // FILE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 266);
            this.Controls.Add(this.IDC_FILEOK_BUTTON);
            this.Controls.Add(this.m_file);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FILE";
            this.Text = "FILE";
            this.Load += new System.EventHandler(this.FILE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_file;
        private System.Windows.Forms.Button IDC_FILEOK_BUTTON;
    }
}