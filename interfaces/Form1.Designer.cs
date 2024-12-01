namespace interfaces
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label_health = new Label();
            label_name = new Label();
            Lis_Items = new ListBox();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 400);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Магазин";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(169, 400);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Сражаться";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(565, 21);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Здоровье";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(565, 70);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 4;
            label2.Text = "Имя";
            // 
            // label_health
            // 
            label_health.Location = new Point(0, 0);
            label_health.Name = "label_health";
            label_health.Size = new Size(100, 23);
            label_health.TabIndex = 7;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(565, 120);
            label_name.Name = "label_name";
            label_name.Size = new Size(70, 20);
            label_name.TabIndex = 6;
            label_name.Text = "Кошелёк";
            // 
            // Lis_Items
            // 
            Lis_Items.FormattingEnabled = true;
            Lis_Items.Location = new Point(75, 93);
            Lis_Items.Name = "Lis_Items";
            Lis_Items.Size = new Size(269, 104);
            Lis_Items.TabIndex = 8;
            Lis_Items.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 23);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 9;
            label3.Text = "Инвантарь";
            // 
            // button3
            // 
            button3.Location = new Point(283, 223);
            button3.Name = "button3";
            button3.Size = new Size(217, 29);
            button3.TabIndex = 10;
            button3.Text = "Обновить оружие";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(Lis_Items);
            Controls.Add(label_name);
            Controls.Add(label_health);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label_health;
        private Label label_name;
        private Label label3;
        public ListBox Lis_Items;
        private Button button3;
    }
}
