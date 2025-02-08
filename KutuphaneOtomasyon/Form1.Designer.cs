namespace KutuphaneOtomasyon
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
			this.txt_sifre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_girisyap = new System.Windows.Forms.Button();
			this.btn_temizle = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(47, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(113, 96);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(216, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kullanıcı Adı:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txt_kullaniciadi
			// 
			this.txt_kullaniciadi.Location = new System.Drawing.Point(313, 41);
			this.txt_kullaniciadi.Name = "txt_kullaniciadi";
			this.txt_kullaniciadi.Size = new System.Drawing.Size(156, 22);
			this.txt_kullaniciadi.TabIndex = 2;
			// 
			// txt_sifre
			// 
			this.txt_sifre.Location = new System.Drawing.Point(313, 85);
			this.txt_sifre.Name = "txt_sifre";
			this.txt_sifre.Size = new System.Drawing.Size(156, 22);
			this.txt_sifre.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(216, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Şifre";
			// 
			// btn_girisyap
			// 
			this.btn_girisyap.Location = new System.Drawing.Point(313, 132);
			this.btn_girisyap.Name = "btn_girisyap";
			this.btn_girisyap.Size = new System.Drawing.Size(77, 29);
			this.btn_girisyap.TabIndex = 5;
			this.btn_girisyap.Text = "Giriş Yap";
			this.btn_girisyap.UseVisualStyleBackColor = true;
			this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
			// 
			// btn_temizle
			// 
			this.btn_temizle.Location = new System.Drawing.Point(396, 132);
			this.btn_temizle.Name = "btn_temizle";
			this.btn_temizle.Size = new System.Drawing.Size(73, 29);
			this.btn_temizle.TabIndex = 6;
			this.btn_temizle.Text = "Temizle";
			this.btn_temizle.UseVisualStyleBackColor = true;
			this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 209);
			this.Controls.Add(this.btn_temizle);
			this.Controls.Add(this.btn_girisyap);
			this.Controls.Add(this.txt_sifre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_kullaniciadi);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_kullaniciadi;
		private System.Windows.Forms.TextBox txt_sifre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_girisyap;
		private System.Windows.Forms.Button btn_temizle;
	}
}

