namespace Drinks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            авторToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { авторToolStripMenuItem, выйтиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // авторToolStripMenuItem
            // 
            авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            авторToolStripMenuItem.Size = new Size(52, 20);
            авторToolStripMenuItem.Text = "Автор";
            авторToolStripMenuItem.Click += авторToolStripMenuItem_Click;
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(54, 20);
            выйтиToolStripMenuItem.Text = "Выйти";
            выйтиToolStripMenuItem.Click += выйтиToolStripMenuItem_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.ForeColor = Color.FromArgb(255, 128, 128);
            button4.Location = new Point(358, 380);
            button4.Name = "button4";
            button4.Size = new Size(136, 38);
            button4.TabIndex = 5;
            button4.Text = "Отчет";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(358, 336);
            button1.Name = "button1";
            button1.Size = new Size(136, 38);
            button1.TabIndex = 6;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.ForeColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(12, 380);
            button2.Name = "button2";
            button2.Size = new Size(136, 38);
            button2.TabIndex = 7;
            button2.Text = "Сотрудники";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.ForeColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(358, 237);
            button3.Name = "button3";
            button3.Size = new Size(136, 38);
            button3.TabIndex = 8;
            button3.Text = "Каталог товаров";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Самокат";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private Button button4;
        private ToolStripMenuItem авторToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}