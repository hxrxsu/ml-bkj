namespace Drinks
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            button1 = new Button();
            button4 = new Button();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(107, 111);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(279, 23);
            dateTimePicker2.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(107, 182);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(279, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // button3
            // 
            button3.Location = new Point(505, 368);
            button3.Name = "button3";
            button3.Size = new Size(108, 23);
            button3.TabIndex = 17;
            button3.Text = "Удалить запись";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(23, 344);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(465, 94);
            listBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(196, 316);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 22;
            label2.Text = "Cписок заказов:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(736, 12);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 24;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(505, 397);
            button4.Name = "button4";
            button4.Size = new Size(108, 23);
            button4.TabIndex = 25;
            button4.Text = "Отследить заказ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Items.AddRange(new object[] { "Блинчики Самокат пшеничные, с маскарпоне и клубникой", "Салат Самокат из свёклы, с черносливом", "Суп Самокат щавелевый с куриной грудкой", "Сэндвич-ролл Самокат с салатом цезарь", "Суп Самокат свекольник", "Блинчики Самокат с кремом и солёной карамелью" });
            listBox3.Location = new Point(424, 82);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(342, 109);
            listBox3.TabIndex = 26;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Items.AddRange(new object[] { "Напиток растительный Самокат фундук", "Напиток растительный Самокат конопляный", "Сок Самокат, манго, прямой отжим", "Квас Самокат, нефильтрованный", "Энергетик Самокат, с соком, маракуйя", "Комбуча Самокат" });
            listBox4.Location = new Point(424, 224);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(351, 109);
            listBox4.TabIndex = 29;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(559, 193);
            label4.Name = "label4";
            label4.Size = new Size(94, 30);
            label4.TabIndex = 31;
            label4.Text = "Напитки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(513, 49);
            label3.Name = "label3";
            label3.Size = new Size(180, 30);
            label3.TabIndex = 32;
            label3.Text = "Продукты, блюда";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(listBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Заказ ";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private ListBox listBox1;
        private Label label2;
        private Button button1;
        private Button button4;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label4;
        private Label label3;
    }
}