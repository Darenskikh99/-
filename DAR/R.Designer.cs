namespace DAR
{
    partial class R
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
            this.IDC_NEXTR_BUTTON = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.m_nextr = new System.Windows.Forms.Label();
            this.m_npr = new System.Windows.Forms.Label();
            this.m_nmr = new System.Windows.Forms.Label();
            this.m_zr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDC_NEXTR_BUTTON
            // 
            this.IDC_NEXTR_BUTTON.Location = new System.Drawing.Point(167, 127);
            this.IDC_NEXTR_BUTTON.Name = "IDC_NEXTR_BUTTON";
            this.IDC_NEXTR_BUTTON.Size = new System.Drawing.Size(100, 23);
            this.IDC_NEXTR_BUTTON.TabIndex = 0;
            this.IDC_NEXTR_BUTTON.Text = "Следующий";
            this.IDC_NEXTR_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTR_BUTTON.Click += new System.EventHandler(this.IDC_NEXTR_BUTTON_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(167, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(167, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "0";
            // 
            // m_nextr
            // 
            this.m_nextr.AutoSize = true;
            this.m_nextr.Location = new System.Drawing.Point(12, 15);
            this.m_nextr.Name = "m_nextr";
            this.m_nextr.Size = new System.Drawing.Size(83, 16);
            this.m_nextr.TabIndex = 5;
            this.m_nextr.Text = "Резистор R";
            // 
            // m_npr
            // 
            this.m_npr.AutoSize = true;
            this.m_npr.Location = new System.Drawing.Point(12, 43);
            this.m_npr.Name = "m_npr";
            this.m_npr.Size = new System.Drawing.Size(57, 16);
            this.m_npr.TabIndex = 6;
            this.m_npr.Text = "Узел n+";
            // 
            // m_nmr
            // 
            this.m_nmr.AutoSize = true;
            this.m_nmr.Location = new System.Drawing.Point(12, 71);
            this.m_nmr.Name = "m_nmr";
            this.m_nmr.Size = new System.Drawing.Size(54, 16);
            this.m_nmr.TabIndex = 7;
            this.m_nmr.Text = "Узел n-";
            this.m_nmr.Click += new System.EventHandler(this.label3_Click);
            // 
            // m_zr
            // 
            this.m_zr.AutoSize = true;
            this.m_zr.Location = new System.Drawing.Point(12, 99);
            this.m_zr.Name = "m_zr";
            this.m_zr.Size = new System.Drawing.Size(149, 16);
            this.m_zr.TabIndex = 8;
            this.m_zr.Text = "Сопротивление (КОм)";
            // 
            // R
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 162);
            this.Controls.Add(this.m_zr);
            this.Controls.Add(this.m_nmr);
            this.Controls.Add(this.m_npr);
            this.Controls.Add(this.m_nextr);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IDC_NEXTR_BUTTON);
            this.Name = "R";
            this.Text = "R";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDC_NEXTR_BUTTON;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label m_nextr;
        private System.Windows.Forms.Label m_npr;
        private System.Windows.Forms.Label m_nmr;
        private System.Windows.Forms.Label m_zr;
    }
}