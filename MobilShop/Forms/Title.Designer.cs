
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
            this.userButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.All_button = new System.Windows.Forms.Button();
            this.Phones_button = new System.Windows.Forms.Button();
            this.Comp_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.Comp_button);
            this.panel1.Controls.Add(this.Phones_button);
            this.panel1.Controls.Add(this.All_button);
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 67);
            this.panel1.TabIndex = 0;
            // 
            // userButton
            // 
            this.userButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userButton.Image = global::MobilShop.Properties.Resources.icons8_user_32;
            this.userButton.Location = new System.Drawing.Point(800, 3);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(75, 60);
            this.userButton.TabIndex = 3;
            this.userButton.Text = "UP";
            this.userButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::MobilShop.Properties.Resources.icons8_bag_32;
            this.button2.Location = new System.Drawing.Point(719, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "0";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
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
            this.panel2.Size = new System.Drawing.Size(878, 446);
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
            // 
            // Phones_button
            // 
            this.Phones_button.BackColor = System.Drawing.Color.Transparent;
            this.Phones_button.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phones_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Phones_button.Location = new System.Drawing.Point(292, 5);
            this.Phones_button.Name = "Phones_button";
            this.Phones_button.Size = new System.Drawing.Size(146, 59);
            this.Phones_button.TabIndex = 5;
            this.Phones_button.Text = "Phones";
            this.Phones_button.UseVisualStyleBackColor = false;
            // 
            // Comp_button
            // 
            this.Comp_button.BackColor = System.Drawing.Color.Transparent;
            this.Comp_button.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comp_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Comp_button.Location = new System.Drawing.Point(444, 5);
            this.Comp_button.Name = "Comp_button";
            this.Comp_button.Size = new System.Drawing.Size(146, 59);
            this.Comp_button.TabIndex = 6;
            this.Comp_button.Text = "Comp";
            this.Comp_button.UseVisualStyleBackColor = false;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::MobilShop.Properties.Resources.textures_pikseli_tsvet_ottenki_svet_77390;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Shop";
            this.ShowIcon = false;
            this.Text = "MOBI";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Comp_button;
        private System.Windows.Forms.Button Phones_button;
        private System.Windows.Forms.Button All_button;
    }
}

