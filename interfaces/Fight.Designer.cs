namespace interfaces
{
    partial class Fight
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
            button1 = new Button();
            label1 = new Label();
            labelEnemyHealth = new Label();
            label3 = new Label();
            label4 = new Label();
            labelPlayerHealth = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(179, 314);
            button1.Name = "button1";
            button1.Size = new Size(157, 36);
            button1.TabIndex = 0;
            button1.Text = "Выбрать оружие";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 89);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // labelEnemyHealth
            // 
            labelEnemyHealth.AutoSize = true;
            labelEnemyHealth.Location = new Point(530, 47);
            labelEnemyHealth.Name = "labelEnemyHealth";
            labelEnemyHealth.Size = new Size(119, 20);
            labelEnemyHealth.TabIndex = 2;
            labelEnemyHealth.Text = "Здоровье врага";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 140);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 196);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // labelPlayerHealth
            // 
            labelPlayerHealth.AutoSize = true;
            labelPlayerHealth.Location = new Point(92, 47);
            labelPlayerHealth.Name = "labelPlayerHealth";
            labelPlayerHealth.Size = new Size(128, 20);
            labelPlayerHealth.TabIndex = 5;
            labelPlayerHealth.Text = "Здоровье игрока";
            labelPlayerHealth.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Location = new Point(403, 314);
            button2.Name = "button2";
            button2.Size = new Size(157, 36);
            button2.TabIndex = 6;
            button2.Text = "В бой";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Fight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(labelPlayerHealth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelEnemyHealth);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Fight";
            Text = "Fight";
            Load += Fight_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label labelEnemyHealth;
        private Label label3;
        private Label label4;
        private Label labelPlayerHealth;
        private Button button2;
    }
}