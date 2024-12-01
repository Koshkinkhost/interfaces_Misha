namespace interfaces
{
    partial class shop
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
            WeaponsList = new ListBox();
            button1 = new Button();
            label_money = new Label();
            SuspendLayout();
            // 
            // WeaponsList
            // 
            WeaponsList.FormattingEnabled = true;
            WeaponsList.Location = new Point(12, 12);
            WeaponsList.Name = "WeaponsList";
            WeaponsList.Size = new Size(380, 84);
            WeaponsList.TabIndex = 0;
            WeaponsList.SelectedIndexChanged += WeaponsList_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(25, 223);
            button1.Name = "button1";
            button1.Size = new Size(119, 34);
            button1.TabIndex = 1;
            button1.Text = "Купить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_money
            // 
            label_money.AutoSize = true;
            label_money.Location = new Point(470, 21);
            label_money.Name = "label_money";
            label_money.Size = new Size(50, 20);
            label_money.TabIndex = 2;
            label_money.Text = "label1";
            // 
            // shop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(580, 291);
            Controls.Add(label_money);
            Controls.Add(button1);
            Controls.Add(WeaponsList);
            Name = "shop";
            Text = "shop";
            Load += shop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox WeaponsList;
        private Button button1;
        private Label label_money;
    }
}