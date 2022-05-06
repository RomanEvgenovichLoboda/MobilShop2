
namespace MobilShop
{
    partial class Shop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.Sumsung_button = new System.Windows.Forms.Button();
            this.Apple_button = new System.Windows.Forms.Button();
            this.All_button = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.Bay_button = new System.Windows.Forms.Button();
            this.find_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.price_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.search_textBox);
            this.panel1.Controls.Add(this.Sumsung_button);
            this.panel1.Controls.Add(this.Apple_button);
            this.panel1.Controls.Add(this.All_button);
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Controls.Add(this.Bay_button);
            this.panel1.Controls.Add(this.find_button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 67);
            this.panel1.TabIndex = 0;
            // 
            // search_textBox
            // 
            this.search_textBox.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textBox.Location = new System.Drawing.Point(479, 20);
            this.search_textBox.Multiline = true;
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(167, 32);
            this.search_textBox.TabIndex = 7;
            // 
            // Sumsung_button
            // 
            this.Sumsung_button.BackColor = System.Drawing.Color.Transparent;
            this.Sumsung_button.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sumsung_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Sumsung_button.Location = new System.Drawing.Point(313, 4);
            this.Sumsung_button.Name = "Sumsung_button";
            this.Sumsung_button.Size = new System.Drawing.Size(149, 59);
            this.Sumsung_button.TabIndex = 6;
            this.Sumsung_button.Text = "Sumsung";
            this.Sumsung_button.UseVisualStyleBackColor = false;
            this.Sumsung_button.Click += new System.EventHandler(this.Sumsung_button_Click);
            // 
            // Apple_button
            // 
            this.Apple_button.BackColor = System.Drawing.Color.Transparent;
            this.Apple_button.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apple_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Apple_button.Location = new System.Drawing.Point(205, 3);
            this.Apple_button.Name = "Apple_button";
            this.Apple_button.Size = new System.Drawing.Size(102, 59);
            this.Apple_button.TabIndex = 5;
            this.Apple_button.Text = "Apple";
            this.Apple_button.UseVisualStyleBackColor = false;
            this.Apple_button.Click += new System.EventHandler(this.Apple_button_Click);
            // 
            // All_button
            // 
            this.All_button.BackColor = System.Drawing.Color.Transparent;
            this.All_button.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.All_button.Location = new System.Drawing.Point(117, 4);
            this.All_button.Name = "All_button";
            this.All_button.Size = new System.Drawing.Size(82, 59);
            this.All_button.TabIndex = 4;
            this.All_button.Text = "ALL";
            this.All_button.UseVisualStyleBackColor = false;
            this.All_button.Click += new System.EventHandler(this.All_button_Click);
            // 
            // userButton
            // 
            this.userButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userButton.Image = global::MobilShop.Properties.Resources.icons8_user_32;
            this.userButton.Location = new System.Drawing.Point(800, 3);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(75, 60);
            this.userButton.TabIndex = 3;
            this.userButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // Bay_button
            // 
            this.Bay_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bay_button.Image = global::MobilShop.Properties.Resources.icons8_bag_32;
            this.Bay_button.Location = new System.Drawing.Point(719, 3);
            this.Bay_button.Name = "Bay_button";
            this.Bay_button.Size = new System.Drawing.Size(75, 61);
            this.Bay_button.TabIndex = 2;
            this.Bay_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bay_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Bay_button.UseVisualStyleBackColor = true;
            this.Bay_button.Click += new System.EventHandler(this.Bay_button_Click);
            // 
            // find_button
            // 
            this.find_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.find_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.find_button.Image = global::MobilShop.Properties.Resources.icons8_search2_32;
            this.find_button.Location = new System.Drawing.Point(652, 11);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(45, 48);
            this.find_button.TabIndex = 1;
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MobilShop.Properties.Resources.Снимок_экрана_2022_05_04_124223;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(12, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 520);
            this.panel2.TabIndex = 1;
            // 
            // price_label
            // 
            this.price_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.price_label.AutoSize = true;
            this.price_label.BackColor = System.Drawing.Color.Transparent;
            this.price_label.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.Crimson;
            this.price_label.Location = new System.Drawing.Point(746, 608);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(26, 30);
            this.price_label.TabIndex = 2;
            this.price_label.Text = "0";
            this.price_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(864, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "₴";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Shop";
            this.ShowIcon = false;
            this.Text = "MOBILshop";
            this.Load += new System.EventHandler(this.userButton_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button Bay_button;
        private System.Windows.Forms.Button find_button;
        public System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Sumsung_button;
        private System.Windows.Forms.Button Apple_button;
        private System.Windows.Forms.Button All_button;
        public System.Windows.Forms.Label price_label;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox search_textBox;
    }
}

