namespace DAR
{
    partial class INT
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
            this.IDC_COMBO = new System.Windows.Forms.ComboBox();
            this.IDC_INP = new System.Windows.Forms.Button();
            this.IDC_BACK = new System.Windows.Forms.Button();
            this.IDC_FORWARD = new System.Windows.Forms.Button();
            this.IDC_STOP = new System.Windows.Forms.Button();
            this.IDC_EXPLORER = new System.Windows.Forms.WebBrowser();
            this.IDC_EXIT = new System.Windows.Forms.Button();
            this.IDC_PROGRESS = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес";
            // 
            // IDC_COMBO
            // 
            this.IDC_COMBO.FormattingEnabled = true;
            this.IDC_COMBO.Items.AddRange(new object[] {
            "http://localhost/MF/beg.html",
            "http://127.0.0.1/MF/Int3d.htm",
            "http://127.0.0.1/MF/ParamComp.html",
            "http://yandex.ru",
            "http://mail.ru"});
            this.IDC_COMBO.Location = new System.Drawing.Point(124, 38);
            this.IDC_COMBO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_COMBO.Name = "IDC_COMBO";
            this.IDC_COMBO.Size = new System.Drawing.Size(259, 24);
            this.IDC_COMBO.TabIndex = 1;
            this.IDC_COMBO.Text = "http://localhost/MF/beg.html";
            // 
            // IDC_INP
            // 
            this.IDC_INP.Location = new System.Drawing.Point(425, 36);
            this.IDC_INP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_INP.Name = "IDC_INP";
            this.IDC_INP.Size = new System.Drawing.Size(100, 28);
            this.IDC_INP.TabIndex = 2;
            this.IDC_INP.Text = "Ввод";
            this.IDC_INP.UseVisualStyleBackColor = true;
            this.IDC_INP.Click += new System.EventHandler(this.IDC_INP_Click);
            // 
            // IDC_BACK
            // 
            this.IDC_BACK.Location = new System.Drawing.Point(551, 36);
            this.IDC_BACK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_BACK.Name = "IDC_BACK";
            this.IDC_BACK.Size = new System.Drawing.Size(100, 28);
            this.IDC_BACK.TabIndex = 3;
            this.IDC_BACK.Text = "Назад";
            this.IDC_BACK.UseVisualStyleBackColor = true;
            this.IDC_BACK.Click += new System.EventHandler(this.IDC_BACK_Click);
            // 
            // IDC_FORWARD
            // 
            this.IDC_FORWARD.Location = new System.Drawing.Point(672, 36);
            this.IDC_FORWARD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_FORWARD.Name = "IDC_FORWARD";
            this.IDC_FORWARD.Size = new System.Drawing.Size(100, 28);
            this.IDC_FORWARD.TabIndex = 4;
            this.IDC_FORWARD.Text = "Вперед";
            this.IDC_FORWARD.UseVisualStyleBackColor = true;
            this.IDC_FORWARD.Click += new System.EventHandler(this.IDC_FORWARD_Click);
            // 
            // IDC_STOP
            // 
            this.IDC_STOP.Location = new System.Drawing.Point(792, 36);
            this.IDC_STOP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_STOP.Name = "IDC_STOP";
            this.IDC_STOP.Size = new System.Drawing.Size(100, 28);
            this.IDC_STOP.TabIndex = 5;
            this.IDC_STOP.Text = "Стоп";
            this.IDC_STOP.UseVisualStyleBackColor = true;
            this.IDC_STOP.Click += new System.EventHandler(this.IDC_STOP_Click);
            // 
            // IDC_EXPLORER
            // 
            this.IDC_EXPLORER.Location = new System.Drawing.Point(39, 96);
            this.IDC_EXPLORER.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_EXPLORER.MinimumSize = new System.Drawing.Size(27, 25);
            this.IDC_EXPLORER.Name = "IDC_EXPLORER";
            this.IDC_EXPLORER.Size = new System.Drawing.Size(853, 448);
            this.IDC_EXPLORER.TabIndex = 6;
            this.IDC_EXPLORER.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.IDC_EXPLORER_Navigated);
            this.IDC_EXPLORER.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.IDC_EXPLORER_Navigating);
            this.IDC_EXPLORER.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.IDC_EXPLORER_ProgressChanged);
            // 
            // IDC_EXIT
            // 
            this.IDC_EXIT.Location = new System.Drawing.Point(573, 588);
            this.IDC_EXIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_EXIT.Name = "IDC_EXIT";
            this.IDC_EXIT.Size = new System.Drawing.Size(100, 28);
            this.IDC_EXIT.TabIndex = 8;
            this.IDC_EXIT.Text = "Закрыть";
            this.IDC_EXIT.UseVisualStyleBackColor = true;
            this.IDC_EXIT.Click += new System.EventHandler(this.IDC_EXIT_Click);
            // 
            // IDC_PROGRESS
            // 
            this.IDC_PROGRESS.Location = new System.Drawing.Point(221, 587);
            this.IDC_PROGRESS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_PROGRESS.Name = "IDC_PROGRESS";
            this.IDC_PROGRESS.Size = new System.Drawing.Size(304, 28);
            this.IDC_PROGRESS.TabIndex = 9;
            // 
            // INT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 665);
            this.Controls.Add(this.IDC_PROGRESS);
            this.Controls.Add(this.IDC_EXIT);
            this.Controls.Add(this.IDC_EXPLORER);
            this.Controls.Add(this.IDC_STOP);
            this.Controls.Add(this.IDC_FORWARD);
            this.Controls.Add(this.IDC_BACK);
            this.Controls.Add(this.IDC_INP);
            this.Controls.Add(this.IDC_COMBO);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "INT";
            this.Text = "Интернет";
            this.Load += new System.EventHandler(this.INT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IDC_COMBO;
        private System.Windows.Forms.Button IDC_INP;
        private System.Windows.Forms.Button IDC_BACK;
        private System.Windows.Forms.Button IDC_FORWARD;
        private System.Windows.Forms.Button IDC_STOP;
        private System.Windows.Forms.WebBrowser IDC_EXPLORER;
        private System.Windows.Forms.Button IDC_EXIT;
        private System.Windows.Forms.ProgressBar IDC_PROGRESS;
    }
}