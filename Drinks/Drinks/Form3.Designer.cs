namespace Drinks
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            listBox2 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Блинчики Самокат пшеничные, с маскарпоне и клубникой", "Салат Самокат из свёклы, с черносливом", "Суп Самокат щавелевый с куриной грудкой", "Сэндвич-ролл Самокат с салатом цезарь", "Суп Самокат свекольник", "Блинчики Самокат с кремом и солёной карамелью" });
            listBox2.Location = new Point(64, 233);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(342, 109);
            listBox2.TabIndex = 24;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(736, 12);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 25;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(353, 81);
            label1.Name = "label1";
            label1.Size = new Size(121, 37);
            label1.TabIndex = 26;
            label1.Text = "Бакалея:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(114, 357);
            label2.Name = "label2";
            label2.Size = new Size(600, 21);
            label2.TabIndex = 27;
            label2.Text = "Если вы хотите заказать товар. то вы можете нажать на интересующий вас товар*";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Напиток растительный Самокат фундук", "Напиток растительный Самокат конопляный", "Сок Самокат, манго, прямой отжим", "Квас Самокат, нефильтрованный", "Энергетик Самокат, с соком, маракуйя", "Комбуча Самокат" });
            listBox1.Location = new Point(412, 233);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(351, 109);
            listBox1.TabIndex = 28;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(158, 164);
            label3.Name = "label3";
            label3.Size = new Size(180, 30);
            label3.TabIndex = 29;
            label3.Text = "Продукты, блюда";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(547, 164);
            label4.Name = "label4";
            label4.Size = new Size(94, 30);
            label4.TabIndex = 30;
            label4.Text = "Напитки";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox2);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Каталог";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
    }
}