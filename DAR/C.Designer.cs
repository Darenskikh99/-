namespace DAR
{
    partial class C
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
            this.IDC_NEXTC_BUTTON = new System.Windows.Forms.Button();
            this.m_nextc = new System.Windows.Forms.TextBox();
            this.m_npc = new System.Windows.Forms.TextBox();
            this.m_nmc = new System.Windows.Forms.TextBox();
            this.m_zc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDC_NEXTC_BUTTON
            // 
            this.IDC_NEXTC_BUTTON.Location = new System.Drawing.Point(176, 224);
            this.IDC_NEXTC_BUTTON.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDC_NEXTC_BUTTON.Name = "IDC_NEXTC_BUTTON";
            this.IDC_NEXTC_BUTTON.Size = new System.Drawing.Size(100, 28);
            this.IDC_NEXTC_BUTTON.TabIndex = 17;
            this.IDC_NEXTC_BUTTON.Text = "Следующий";
            this.IDC_NEXTC_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTC_BUTTON.Click += new System.EventHandler(this.IDC_NEXTC_BUTTON_Click);
            // 
            // m_nextc
            // 
            this.m_nextc.Location = new System.Drawing.Point(247, 38);
            this.m_nextc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_nextc.Name = "m_nextc";
            this.m_nextc.ReadOnly = true;
            this.m_nextc.Size = new System.Drawing.Size(132, 22);
            this.m_nextc.TabIndex = 16;
            this.m_nextc.Text = "1";
            // 
            // m_npc
            // 
            this.m_npc.Location = new System.Drawing.Point(247, 84);
            this.m_npc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_npc.Name = "m_npc";
            this.m_npc.Size = new System.Drawing.Size(132, 22);
            this.m_npc.TabIndex = 15;
            // 
            // m_nmc
            // 
            this.m_nmc.Location = new System.Drawing.Point(247, 129);
            this.m_nmc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_nmc.Name = "m_nmc";
            this.m_nmc.Size = new System.Drawing.Size(132, 22);
            this.m_nmc.TabIndex = 14;
            // 
            // m_zc
            // 
            this.m_zc.Location = new System.Drawing.Point(247, 172);
            this.m_zc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_zc.Name = "m_zc";
            this.m_zc.Size = new System.Drawing.Size(132, 22);
            this.m_zc.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Емкость (Ф)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Узел n-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Узел n+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Конденсатор C";
            // 
            // C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 292);
            this.Controls.Add(this.IDC_NEXTC_BUTTON);
            this.Controls.Add(this.m_nextc);
            this.Controls.Add(this.m_npc);
            this.Controls.Add(this.m_nmc);
            this.Controls.Add(this.m_zc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "C";
            this.Text = "C";
            this.Load += new System.EventHandler(this.C_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDC_NEXTC_BUTTON;
        private System.Windows.Forms.TextBox m_nextc;
        private System.Windows.Forms.TextBox m_npc;
        private System.Windows.Forms.TextBox m_nmc;
        private System.Windows.Forms.TextBox m_zc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}