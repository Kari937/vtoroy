namespace Project
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenProd = new System.Windows.Forms.Button();
            this.buttonOpenGoods = new System.Windows.Forms.Button();
            this.buttonOpenDeals = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(2, 27);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(276, 108);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.Color.Khaki;
            this.buttonOpenClients.Location = new System.Drawing.Point(2, 164);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(275, 50);
            this.buttonOpenClients.TabIndex = 1;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenProd
            // 
            this.buttonOpenProd.BackColor = System.Drawing.Color.Khaki;
            this.buttonOpenProd.Location = new System.Drawing.Point(2, 242);
            this.buttonOpenProd.Name = "buttonOpenProd";
            this.buttonOpenProd.Size = new System.Drawing.Size(275, 50);
            this.buttonOpenProd.TabIndex = 2;
            this.buttonOpenProd.Text = "Продавцы";
            this.buttonOpenProd.UseVisualStyleBackColor = false;
            this.buttonOpenProd.Click += new System.EventHandler(this.buttonOpenProd_Click);
            // 
            // buttonOpenGoods
            // 
            this.buttonOpenGoods.BackColor = System.Drawing.Color.Khaki;
            this.buttonOpenGoods.Location = new System.Drawing.Point(2, 318);
            this.buttonOpenGoods.Name = "buttonOpenGoods";
            this.buttonOpenGoods.Size = new System.Drawing.Size(275, 50);
            this.buttonOpenGoods.TabIndex = 3;
            this.buttonOpenGoods.Text = "Товары";
            this.buttonOpenGoods.UseVisualStyleBackColor = false;
            this.buttonOpenGoods.Click += new System.EventHandler(this.buttonOpenGoods_Click);
            // 
            // buttonOpenDeals
            // 
            this.buttonOpenDeals.BackColor = System.Drawing.Color.Khaki;
            this.buttonOpenDeals.Location = new System.Drawing.Point(2, 399);
            this.buttonOpenDeals.Name = "buttonOpenDeals";
            this.buttonOpenDeals.Size = new System.Drawing.Size(275, 50);
            this.buttonOpenDeals.TabIndex = 4;
            this.buttonOpenDeals.Text = "Сделки";
            this.buttonOpenDeals.UseVisualStyleBackColor = false;
            this.buttonOpenDeals.Click += new System.EventHandler(this.buttonOpenDeals_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(-1, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(35, 13);
            this.labelHello.TabIndex = 5;
            this.labelHello.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(279, 561);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOpenDeals);
            this.Controls.Add(this.buttonOpenGoods);
            this.Controls.Add(this.buttonOpenProd);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.Logo);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Связной";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenProd;
        private System.Windows.Forms.Button buttonOpenGoods;
        private System.Windows.Forms.Button buttonOpenDeals;
        private System.Windows.Forms.Label labelHello;
    }
}

