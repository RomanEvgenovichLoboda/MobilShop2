
namespace MobilShop
{
    partial class ProductControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_label = new System.Windows.Forms.Label();
            this.company_label = new System.Windows.Forms.Label();
            this.flash_label = new System.Windows.Forms.Label();
            this.ssd_label = new System.Windows.Forms.Label();
            this.processor_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.ForeColor = System.Drawing.Color.Gold;
            this.name_label.Location = new System.Drawing.Point(163, 27);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(46, 17);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "label1";
            // 
            // company_label
            // 
            this.company_label.AutoSize = true;
            this.company_label.ForeColor = System.Drawing.Color.Gold;
            this.company_label.Location = new System.Drawing.Point(163, 62);
            this.company_label.Name = "company_label";
            this.company_label.Size = new System.Drawing.Size(46, 17);
            this.company_label.TabIndex = 1;
            this.company_label.Text = "label2";
            // 
            // flash_label
            // 
            this.flash_label.AutoSize = true;
            this.flash_label.ForeColor = System.Drawing.Color.Gold;
            this.flash_label.Location = new System.Drawing.Point(163, 104);
            this.flash_label.Name = "flash_label";
            this.flash_label.Size = new System.Drawing.Size(46, 17);
            this.flash_label.TabIndex = 2;
            this.flash_label.Text = "label3";
            // 
            // ssd_label
            // 
            this.ssd_label.AutoSize = true;
            this.ssd_label.ForeColor = System.Drawing.Color.Gold;
            this.ssd_label.Location = new System.Drawing.Point(163, 133);
            this.ssd_label.Name = "ssd_label";
            this.ssd_label.Size = new System.Drawing.Size(46, 17);
            this.ssd_label.TabIndex = 3;
            this.ssd_label.Text = "label4";
            // 
            // processor_label
            // 
            this.processor_label.AutoSize = true;
            this.processor_label.ForeColor = System.Drawing.SystemColors.Control;
            this.processor_label.Location = new System.Drawing.Point(163, 165);
            this.processor_label.Name = "processor_label";
            this.processor_label.Size = new System.Drawing.Size(46, 17);
            this.processor_label.TabIndex = 4;
            this.processor_label.Text = "label5";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_label.ForeColor = System.Drawing.Color.GreenYellow;
            this.price_label.Location = new System.Drawing.Point(10, 209);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(70, 25);
            this.price_label.TabIndex = 5;
            this.price_label.Text = "label6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(15, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(214, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::MobilShop.Properties.Resources.textures_pikseli_tsvet_ottenki_svet_77390;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.processor_label);
            this.Controls.Add(this.ssd_label);
            this.Controls.Add(this.flash_label);
            this.Controls.Add(this.company_label);
            this.Controls.Add(this.name_label);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(273, 268);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label company_label;
        private System.Windows.Forms.Label flash_label;
        private System.Windows.Forms.Label ssd_label;
        private System.Windows.Forms.Label processor_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
