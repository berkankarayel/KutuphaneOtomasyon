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
	public partial class AdminSayfasi : Form
	{
		List<Kisi>kisilerim;
		List<Kitap> kitaplarim;
		public AdminSayfasi(List<Kisi> kisilerim, List<Kitap> kitaplarim)
		{
			InitializeComponent();
			this.kisilerim = kisilerim;
			this.kitaplarim = kitaplarim;
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void groupBox_uyeismleri_Enter(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void AdminSayfasi_Load(object sender, EventArgs e)
		{
			foreach(Kisi kisi in kisilerim)
			{
				dataGridView1.Rows.Add(kisi.getId(),kisi.getIsim(),kisi.getSoyIsim(),kisi.getOlusturmaTarih(),kisi.getKullaniciAdi(),kisi.getSifre(),kisi.getYetki());
			}

			foreach(Kitap kitap in kitaplarim)
			{
				dataGridView2.Rows.Add(kitap.getkitapId(), kitap.getkitapIsim(), kitap.getkitapYazar(), kitap.getkitapDili(), kitap.getyayinevi(),kitap.gettur(), kitap.getkitapdet(), kitap.getsayfasayisi(), kitap.getbasimyil());
			}
		}

		private void btn_ekle_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text),txt_isim.Text,txt_soyisim.Text,maskedTextBox1.Text,txt_kullaniciadi.Text,txt_sifre.Text,txt_yetki.Text);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btn_sil_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
		}

		public void textleriDoldur()
		{
			txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			txt_kullaniciadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
		}

		private void btn_guncelle_Click(object sender, EventArgs e)
		{
			
			string id = txt_id.Text;
			string isim = txt_isim.Text;
			string soyisim = txt_soyisim.Text;
			string tarih = maskedTextBox1.Text;
			string kullaniciadi = txt_kullaniciadi.Text;
			string sifre = txt_sifre.Text;
			string yetki = txt_yetki.Text;
			

			dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
			dataGridView1.Rows.Add(id, isim, soyisim, tarih, kullaniciadi, sifre, yetki);
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textleriDoldur();

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_kitapekle_Click(object sender, EventArgs e)
		{
			dataGridView2.Rows.Add(txt_kitapid.Text,txt_kitapisim.Text,txt_kitapyazar.Text,txt_dil.Text,txt_yayinevi.Text,txt_tur.Text,txt_adet.Text,txt_sayfasayisi.Text,txt_basimyili.Text);
		}

		private void btn_kitapsil_Click(object sender, EventArgs e)
		{
			dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
		}

		private void btn_kitapgüncelle_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// 1. Seçili satır var mı kontrol edelim
			if (dataGridView2.CurrentRow == null) return;

			// 2. En az kaç hücre olmalı, onu kontrol edelim
			if (dataGridView2.CurrentRow.Cells.Count < 9) return;

			// 3. Null değer kontrolü
			for (int i = 0; i < 9; i++)
			{
				if (dataGridView2.CurrentRow.Cells[i].Value == null)
				{
					return; // Null değer varsa işlemi iptal et
				}
			}

			// Artık hata vermeyecek, çünkü yukarıdaki kontrollerden geçildi
			txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
			txt_kitapisim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
			txt_kitapyazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
			txt_dil.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
			txt_yayinevi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
			txt_tur.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
			txt_adet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
			txt_sayfasayisi.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
			txt_basimyili.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();

		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
