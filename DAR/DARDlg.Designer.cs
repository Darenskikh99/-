namespace DAR
{
    partial class DARDlg
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.описаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_CONS = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_RED = new System.Windows.Forms.ToolStripMenuItem();
            this.директивыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_F = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_IO = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_CALC = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_PRIV = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_SYS = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_INTERNET = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_EXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.описаниеToolStripMenuItem,
            this.ID_RED,
            this.директивыToolStripMenuItem,
            this.ID_CALC,
            this.видToolStripMenuItem,
            this.ID_INTERNET,
            this.ID_EXIT});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // описаниеToolStripMenuItem
            // 
            this.описаниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_CONS,
            this.ID_FILE});
            this.описаниеToolStripMenuItem.Name = "описаниеToolStripMenuItem";
            this.описаниеToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.описаниеToolStripMenuItem.Text = "Описание";
            // 
            // ID_CONS
            // 
            this.ID_CONS.Name = "ID_CONS";
            this.ID_CONS.Size = new System.Drawing.Size(222, 26);
            this.ID_CONS.Text = "Ввод с клавиатуры";
            this.ID_CONS.Click += new System.EventHandler(this.ID_CONS_Click);
            // 
            // ID_FILE
            // 
            this.ID_FILE.Name = "ID_FILE";
            this.ID_FILE.Size = new System.Drawing.Size(222, 26);
            this.ID_FILE.Text = "Ввод из файла";
            this.ID_FILE.Click += new System.EventHandler(this.ID_FILE_Click);
            // 
            // ID_RED
            // 
            this.ID_RED.Name = "ID_RED";
            this.ID_RED.Size = new System.Drawing.Size(227, 26);
            this.ID_RED.Text = "Редактирование";
            this.ID_RED.Click += new System.EventHandler(this.ID_RED_Click);
            // 
            // директивыToolStripMenuItem
            // 
            this.директивыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_F,
            this.ID_IO});
            this.директивыToolStripMenuItem.Name = "директивыToolStripMenuItem";
            this.директивыToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.директивыToolStripMenuItem.Text = "Директивы расчета";
            // 
            // ID_F
            // 
            this.ID_F.Name = "ID_F";
            this.ID_F.Size = new System.Drawing.Size(306, 26);
            this.ID_F.Text = "Вид частотной характеристики";
            this.ID_F.Click += new System.EventHandler(this.ID_F_Click);
            // 
            // ID_IO
            // 
            this.ID_IO.Name = "ID_IO";
            this.ID_IO.Size = new System.Drawing.Size(306, 26);
            this.ID_IO.Text = "Вх/вых узлы";
            this.ID_IO.Click += new System.EventHandler(this.ID_IO_Click);
            // 
            // ID_CALC
            // 
            this.ID_CALC.Name = "ID_CALC";
            this.ID_CALC.Size = new System.Drawing.Size(227, 26);
            this.ID_CALC.Text = "Расчет";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_PRIV,
            this.ID_SYS});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // ID_PRIV
            // 
            this.ID_PRIV.Name = "ID_PRIV";
            this.ID_PRIV.Size = new System.Drawing.Size(247, 26);
            this.ID_PRIV.Text = "Собственный браузер";
            this.ID_PRIV.Click += new System.EventHandler(this.ID_PRIV_Click);
            // 
            // ID_SYS
            // 
            this.ID_SYS.Name = "ID_SYS";
            this.ID_SYS.Size = new System.Drawing.Size(247, 26);
            this.ID_SYS.Text = "Системный браузер";
            this.ID_SYS.Click += new System.EventHandler(this.ID_SYS_Click);
            // 
            // ID_INTERNET
            // 
            this.ID_INTERNET.Name = "ID_INTERNET";
            this.ID_INTERNET.Size = new System.Drawing.Size(227, 26);
            this.ID_INTERNET.Text = "Интернет";
            this.ID_INTERNET.Click += new System.EventHandler(this.ID_INTERNET_Click);
            // 
            // ID_EXIT
            // 
            this.ID_EXIT.Name = "ID_EXIT";
            this.ID_EXIT.Size = new System.Drawing.Size(227, 26);
            this.ID_EXIT.Text = "Выход";
            this.ID_EXIT.Click += new System.EventHandler(this.ID_EXIT_Click);
            // 
            // DARDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DARDlg";
            this.Text = "Моделирование непрерывных систем";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem описаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ID_CONS;
        private System.Windows.Forms.ToolStripMenuItem ID_FILE;
        private System.Windows.Forms.ToolStripMenuItem ID_RED;
        private System.Windows.Forms.ToolStripMenuItem директивыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ID_F;
        private System.Windows.Forms.ToolStripMenuItem ID_IO;
        private System.Windows.Forms.ToolStripMenuItem ID_CALC;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ID_PRIV;
        private System.Windows.Forms.ToolStripMenuItem ID_SYS;
        private System.Windows.Forms.ToolStripMenuItem ID_INTERNET;
        private System.Windows.Forms.ToolStripMenuItem ID_EXIT;
    }
}

