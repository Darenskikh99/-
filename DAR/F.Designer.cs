namespace DAR
{
    partial class F
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
            this.IDC_F = new System.Windows.Forms.RadioButton();
            this.IDC_DF = new System.Windows.Forms.RadioButton();
            this.IDC_KF = new System.Windows.Forms.RadioButton();
            this.IDC_T1 = new System.Windows.Forms.TextBox();
            this.IDC_T2 = new System.Windows.Forms.TextBox();
            this.IDC_T3 = new System.Windows.Forms.TextBox();
            this.IDC_F1 = new System.Windows.Forms.TextBox();
            this.IDC_F2 = new System.Windows.Forms.TextBox();
            this.IDC_F3 = new System.Windows.Forms.TextBox();
            this.IDC_FOK_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDC_F
            // 
            this.IDC_F.AutoSize = true;
            this.IDC_F.Checked = true;
            this.IDC_F.Location = new System.Drawing.Point(51, 47);
            this.IDC_F.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_F.Name = "IDC_F";
            this.IDC_F.Size = new System.Drawing.Size(236, 20);
            this.IDC_F.TabIndex = 0;
            this.IDC_F.TabStop = true;
            this.IDC_F.Text = "Единственная частотная точка";
            this.IDC_F.UseVisualStyleBackColor = true;
            this.IDC_F.CheckedChanged += new System.EventHandler(this.IDC_F_CheckedChanged);
            // 
            // IDC_DF
            // 
            this.IDC_DF.AutoSize = true;
            this.IDC_DF.Location = new System.Drawing.Point(51, 101);
            this.IDC_DF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_DF.Name = "IDC_DF";
            this.IDC_DF.Size = new System.Drawing.Size(268, 20);
            this.IDC_DF.TabIndex = 1;
            this.IDC_DF.Text = "Линейный закон изменения частоты";
            this.IDC_DF.UseVisualStyleBackColor = true;
            this.IDC_DF.CheckedChanged += new System.EventHandler(this.IDC_DF_CheckedChanged);
            // 
            // IDC_KF
            // 
            this.IDC_KF.AutoSize = true;
            this.IDC_KF.Location = new System.Drawing.Point(51, 160);
            this.IDC_KF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_KF.Name = "IDC_KF";
            this.IDC_KF.Size = new System.Drawing.Size(323, 20);
            this.IDC_KF.TabIndex = 2;
            this.IDC_KF.Text = "Логарифмический закон изменения частоты";
            this.IDC_KF.UseVisualStyleBackColor = true;
            this.IDC_KF.CheckedChanged += new System.EventHandler(this.IDC_KF_CheckedChanged);
            // 
            // IDC_T1
            // 
            this.IDC_T1.Location = new System.Drawing.Point(51, 228);
            this.IDC_T1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_T1.Name = "IDC_T1";
            this.IDC_T1.ReadOnly = true;
            this.IDC_T1.Size = new System.Drawing.Size(305, 22);
            this.IDC_T1.TabIndex = 3;
            this.IDC_T1.Text = "Значение частоты (кгц)";
            // 
            // IDC_T2
            // 
            this.IDC_T2.Location = new System.Drawing.Point(51, 278);
            this.IDC_T2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_T2.Name = "IDC_T2";
            this.IDC_T2.ReadOnly = true;
            this.IDC_T2.Size = new System.Drawing.Size(305, 22);
            this.IDC_T2.TabIndex = 4;
            // 
            // IDC_T3
            // 
            this.IDC_T3.Location = new System.Drawing.Point(51, 330);
            this.IDC_T3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_T3.Name = "IDC_T3";
            this.IDC_T3.ReadOnly = true;
            this.IDC_T3.Size = new System.Drawing.Size(305, 22);
            this.IDC_T3.TabIndex = 5;
            // 
            // IDC_F1
            // 
            this.IDC_F1.Location = new System.Drawing.Point(384, 228);
            this.IDC_F1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_F1.Name = "IDC_F1";
            this.IDC_F1.Size = new System.Drawing.Size(95, 22);
            this.IDC_F1.TabIndex = 6;
            this.IDC_F1.Text = "0";
            // 
            // IDC_F2
            // 
            this.IDC_F2.Location = new System.Drawing.Point(384, 278);
            this.IDC_F2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_F2.Name = "IDC_F2";
            this.IDC_F2.Size = new System.Drawing.Size(95, 22);
            this.IDC_F2.TabIndex = 7;
            this.IDC_F2.Text = "0";
            // 
            // IDC_F3
            // 
            this.IDC_F3.Location = new System.Drawing.Point(384, 330);
            this.IDC_F3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_F3.Name = "IDC_F3";
            this.IDC_F3.Size = new System.Drawing.Size(95, 22);
            this.IDC_F3.TabIndex = 8;
            this.IDC_F3.Text = "0";
            // 
            // IDC_FOK_BUTTON
            // 
            this.IDC_FOK_BUTTON.Location = new System.Drawing.Point(231, 385);
            this.IDC_FOK_BUTTON.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_FOK_BUTTON.Name = "IDC_FOK_BUTTON";
            this.IDC_FOK_BUTTON.Size = new System.Drawing.Size(100, 28);
            this.IDC_FOK_BUTTON.TabIndex = 9;
            this.IDC_FOK_BUTTON.Text = "OK";
            this.IDC_FOK_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_FOK_BUTTON.Click += new System.EventHandler(this.IDC_FOK_BUTTON_Click);
            // 
            // F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 443);
            this.Controls.Add(this.IDC_FOK_BUTTON);
            this.Controls.Add(this.IDC_F3);
            this.Controls.Add(this.IDC_F2);
            this.Controls.Add(this.IDC_F1);
            this.Controls.Add(this.IDC_T3);
            this.Controls.Add(this.IDC_T2);
            this.Controls.Add(this.IDC_T1);
            this.Controls.Add(this.IDC_KF);
            this.Controls.Add(this.IDC_DF);
            this.Controls.Add(this.IDC_F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F";
            this.Text = "Вид частотной характеристики";
            this.Load += new System.EventHandler(this.F_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton IDC_F;
        private System.Windows.Forms.RadioButton IDC_DF;
        private System.Windows.Forms.RadioButton IDC_KF;
        private System.Windows.Forms.TextBox IDC_T1;
        private System.Windows.Forms.TextBox IDC_T2;
        private System.Windows.Forms.TextBox IDC_T3;
        private System.Windows.Forms.TextBox IDC_F1;
        private System.Windows.Forms.TextBox IDC_F2;
        private System.Windows.Forms.TextBox IDC_F3;
        private System.Windows.Forms.Button IDC_FOK_BUTTON;
    }
}