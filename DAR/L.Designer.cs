namespace DAR
{
    partial class L
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
            this.IDC_NEXTL_BUTTON = new System.Windows.Forms.Button();
            this.m_nextl = new System.Windows.Forms.TextBox();
            this.m_npl = new System.Windows.Forms.TextBox();
            this.m_nml = new System.Windows.Forms.TextBox();
            this.m_zl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDC_NEXTL_BUTTON
            // 
            this.IDC_NEXTL_BUTTON.Location = new System.Drawing.Point(176, 224);
            this.IDC_NEXTL_BUTTON.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_NEXTL_BUTTON.Name = "IDC_NEXTL_BUTTON";
            this.IDC_NEXTL_BUTTON.Size = new System.Drawing.Size(100, 28);
            this.IDC_NEXTL_BUTTON.TabIndex = 26;
            this.IDC_NEXTL_BUTTON.Text = "Следующий";
            this.IDC_NEXTL_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTL_BUTTON.Click += new System.EventHandler(this.IDC_NEXTL_BUTTON_Click);
            // 
            // m_nextl
            // 
            this.m_nextl.Location = new System.Drawing.Point(247, 38);
            this.m_nextl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_nextl.Name = "m_nextl";
            this.m_nextl.ReadOnly = true;
            this.m_nextl.Size = new System.Drawing.Size(132, 22);
            this.m_nextl.TabIndex = 25;
            this.m_nextl.Text = "1";
            // 
            // m_npl
            // 
            this.m_npl.Location = new System.Drawing.Point(247, 84);
            this.m_npl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_npl.Name = "m_npl";
            this.m_npl.Size = new System.Drawing.Size(132, 22);
            this.m_npl.TabIndex = 24;
            // 
            // m_nml
            // 
            this.m_nml.Location = new System.Drawing.Point(247, 129);
            this.m_nml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_nml.Name = "m_nml";
            this.m_nml.Size = new System.Drawing.Size(132, 22);
            this.m_nml.TabIndex = 23;
            // 
            // m_zl
            // 
            this.m_zl.Location = new System.Drawing.Point(247, 172);
            this.m_zl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_zl.Name = "m_zl";
            this.m_zl.Size = new System.Drawing.Size(132, 22);
            this.m_zl.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Индуктивность (Гн)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Узел n-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Узел n+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Катушка индуктивности L";
            // 
            // L
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 292);
            this.Controls.Add(this.IDC_NEXTL_BUTTON);
            this.Controls.Add(this.m_nextl);
            this.Controls.Add(this.m_npl);
            this.Controls.Add(this.m_nml);
            this.Controls.Add(this.m_zl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "L";
            this.Text = "L";
            this.Load += new System.EventHandler(this.L_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDC_NEXTL_BUTTON;
        private System.Windows.Forms.TextBox m_nextl;
        private System.Windows.Forms.TextBox m_npl;
        private System.Windows.Forms.TextBox m_nml;
        private System.Windows.Forms.TextBox m_zl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}