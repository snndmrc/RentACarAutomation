namespace Arac_Kiralama_Otomasyonu
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.tbK_adi = new System.Windows.Forms.TextBox();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.lblK_adi = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbK_adi
            // 
            this.tbK_adi.BackColor = System.Drawing.Color.White;
            this.tbK_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbK_adi.ForeColor = System.Drawing.Color.Black;
            this.tbK_adi.Location = new System.Drawing.Point(412, 158);
            this.tbK_adi.Margin = new System.Windows.Forms.Padding(2);
            this.tbK_adi.Name = "tbK_adi";
            this.tbK_adi.Size = new System.Drawing.Size(146, 26);
            this.tbK_adi.TabIndex = 0;
            // 
            // tbParola
            // 
            this.tbParola.BackColor = System.Drawing.Color.White;
            this.tbParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbParola.ForeColor = System.Drawing.Color.Black;
            this.tbParola.Location = new System.Drawing.Point(412, 196);
            this.tbParola.Margin = new System.Windows.Forms.Padding(2);
            this.tbParola.Name = "tbParola";
            this.tbParola.PasswordChar = '*';
            this.tbParola.Size = new System.Drawing.Size(146, 26);
            this.tbParola.TabIndex = 1;
            this.tbParola.TextChanged += new System.EventHandler(this.tbParola_TextChanged);
            // 
            // lblK_adi
            // 
            this.lblK_adi.AutoSize = true;
            this.lblK_adi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblK_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblK_adi.ForeColor = System.Drawing.Color.Black;
            this.lblK_adi.Location = new System.Drawing.Point(297, 164);
            this.lblK_adi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblK_adi.Name = "lblK_adi";
            this.lblK_adi.Size = new System.Drawing.Size(111, 20);
            this.lblK_adi.TabIndex = 2;
            this.lblK_adi.Text = "Kullanıcı Adı ";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParola.ForeColor = System.Drawing.Color.Black;
            this.lblParola.Location = new System.Drawing.Point(297, 196);
            this.lblParola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(65, 20);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parola ";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(354, 271);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(154, 35);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(412, 227);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Şifre Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 150);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rent A Car\r\nAutomation\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblK_adi);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.tbK_adi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "giris";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbK_adi;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.Label lblK_adi;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
    }
}

