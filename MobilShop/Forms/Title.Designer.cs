
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.All_button = new System.Windows.Forms.Button();
            this.Apple_button = new System.Windows.Forms.Button();
            this.Sumsung_button = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.Bay_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.Sumsung_button);
            this.panel1.Controls.Add(this.Apple_button);
            this.panel1.Controls.Add(this.All_button);
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Controls.Add(this.Bay_button);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 67);
            this.panel1.TabIndex = 0;
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
            this.panel2.Size = new System.Drawing.Size(878, 550);
            this.panel2.TabIndex = 1;
            // 
            // All_button
            // 
            this.All_button.BackColor = System.Drawing.Color.Transparent;
            this.All_button.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.All_button.Location = new System.Drawing.Point(140, 5);
            this.All_button.Name = "All_button";
            this.All_button.Size = new System.Drawing.Size(146, 59);
            this.All_button.TabIndex = 4;
            this.All_button.Text = "ALL";
            this.All_button.UseVisualStyleBackColor = false;
            this.All_button.Click += new System.EventHandler(this.All_button_Click);
            // 
            // Apple_button
            // 
            this.Apple_button.BackColor = System.Drawing.Color.Transparent;
            this.Apple_button.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apple_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Apple_button.Location = new System.Drawing.Point(292, 5);
            this.Apple_button.Name = "Apple_button";
            this.Apple_button.Size = new System.Drawing.Size(146, 59);
            this.Apple_button.TabIndex = 5;
            this.Apple_button.Text = "Apple";
            this.Apple_button.UseVisualStyleBackColor = false;
            this.Apple_button.Click += new System.EventHandler(this.Apple_button_Click);
            // 
            // Sumsung_button
            // 
            this.Sumsung_button.BackColor = System.Drawing.Color.Transparent;
            this.Sumsung_button.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sumsung_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Sumsung_button.Location = new System.Drawing.Point(444, 5);
            this.Sumsung_button.Name = "Sumsung_button";
            this.Sumsung_button.Size = new System.Drawing.Size(166, 59);
            this.Sumsung_button.TabIndex = 6;
            this.Sumsung_button.Text = "Sumsung";
            this.Sumsung_button.UseVisualStyleBackColor = false;
            this.Sumsung_button.Click += new System.EventHandler(this.Sumsung_button_Click);
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::MobilShop.Properties.Resources.icons8_search2_32;
            this.button1.Location = new System.Drawing.Point(638, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MobilShop.Properties.Resources.Снимок_экрана_2022_05_04_124223;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Shop";
            this.ShowIcon = false;
            this.Text = "MOBI";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button Bay_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Sumsung_button;
        private System.Windows.Forms.Button Apple_button;
        private System.Windows.Forms.Button All_button;
    }
}

