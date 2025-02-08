using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon
{
	public class Kitap
	{
		public int kitapid {  get; set; }
		public string kitapIsim { get; set; }
		public string kitapYazar { get; set; }	
		public string kitapDili { get; set; }
		public string yayinEvi { get; set; }
		public string tur {  get; set; }
		public int adet { get; set; }
		public int sayfasayisi { get; set; }
		public int basimyil {  get; set; }


        public Kitap()
        {
            
        }

        public Kitap(int kitapid,string kitapIsim,string kitapYazar,string kitapDili,string yayinEvi,string tur,int adet,int sayfasayisi,int basimyil )
        { 
            this.kitapid = kitapid;
			this.kitapIsim = kitapIsim;
			this.kitapYazar = kitapYazar;
			this.kitapDili = kitapDili;
			this.yayinEvi = yayinEvi;
			this.tur = tur;
			this.adet = adet;
			this.sayfasayisi = sayfasayisi;
			this.basimyil = basimyil;	

        }

		public int getkitapId()
		{
			return this.kitapid;
		}
		public string getkitapIsim()
		{
			return this.kitapIsim;
		}
		public string getkitapYazar()
		{
			return this.kitapYazar ;
		}

		public string getkitapDili()
		{
			return this.kitapDili;
		}
		public string getyayinevi()
		{
			return this.yayinEvi;
		}
		public string gettur()
		{
			return this.tur;	
		}
		public int getkitapdet()
		{
			return this.adet;
		}
		public int getsayfasayisi()
		{
			return this.sayfasayisi;
		}
		public int getbasimyil()
		{
			return this.basimyil;
		}
    }
}
