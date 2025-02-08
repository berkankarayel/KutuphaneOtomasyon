using KutuphaneOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
	public partial class Form1 : Form
	{
		private List<Kisi>kisilerim =new List<Kisi>();
		private List<Kitap> kitaplarim =new List<Kitap>();

		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btn_girisyap_Click(object sender, EventArgs e)
		{
			string kullaniciadi, sifre = "";
			kullaniciadi  = txt_kullaniciadi.Text;
			sifre= txt_sifre.Text;


			bool kontrol = false;
			foreach (Kisi kisi in kisilerim)
			{
				if(kullaniciadi.ToLower()==kisi.getKullaniciAdi() && sifre.ToLower()==kisi.getSifre() && kisi.getYetki() == "admin")
				{
					// admin sayfasına yönlendir.
					AdminSayfasi adminSayfasi =new AdminSayfasi (kisilerim,kitaplarim);
					adminSayfasi.Show();
					this.Hide();
					kontrol = true;
					break;
				}else if(kullaniciadi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "üye")
				{
					UyeSayfası uyeSayfası = new UyeSayfası();
					uyeSayfası.Show();
					this.Hide();
					kontrol = true;
					break;
				}
				
				
			}
			if (!kontrol)
			{
				MessageBox.Show("hatalı Giriş","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void btn_temizle_Click(object sender, EventArgs e)
		{
			txt_kullaniciadi.Text=string.Empty;
			txt_sifre.Text=string.Empty;
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			kisilerim.Add(new Kisi(1,"berkan","Karayel",DateTime.Now,"berkan","1","admin"));
			kisilerim.Add(new Kisi(2, "YAKUP", "REÇBER", DateTime.Now, "yakup", "2", "üye"));
			kisilerim.Add(new Kisi(3, "İrfancan", "Kahveci", DateTime.Now, "berkan", "3", "üye"));
			kisilerim.Add(new Kisi(1, "Sezer", "Uçmaz", DateTime.Now, "sezer", "4", "üye")); ;


			kitaplarim.Add(new Kitap(1, "içimizdeki Şeytan", "Sebehattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 100, 250, 2016));
			kitaplarim.Add(new Kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "Roman", 350, 760, 2015));
			kitaplarim.Add(new Kitap(3, "Uçurtma Avcisi", "Khaled Hasseini", "İngilizce", "Everest Yayıncılık", "Roman", 5000, 198, 1999));
			kitaplarim.Add(new Kitap(4, "Küçük Prens", "Khaled Hasseini", "İngilizce", "Everest Yayıncılık", "Roman", 5000, 198, 1999));
			kitaplarim.Add(new Kitap(5, "Kürk Mantolu Madonna", "Sebahattin Ali", "İngilizce", "Everest Yayıncılık", "Roman", 5000, 198, 1999));


		}
	}
}
