using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SeyruSefer
{
	class Program
	{
		public static void IslemSec()
		{
			string secilen;
			int seferislemleri = 1;
			int biletsatis = 2;
			int cikis = 3;

			Console.WriteLine("1: Sefer İşlemleri\n2: Bilet Satış İşlemleri\n3: Çıkış");
			Console.Write("Yapmak istediğiniz işlemi seçin (1-3 arası): ");
			secilen = Console.ReadLine();
			if (secilen=="1")
			{
				SeferIslemleri();
			}

			else if (secilen=="2")
			{
				BiletSatisIslemleri();
			}

			else if (secilen=="3")
			{
				Cikis();
			}
		}

		private static void SeferIslemleri()
		{
			int sefer_no;
			int kapasite;
			int bilet_fiyati;
			string plaka;
			string guzergah;
			string tarih;
			string saat;
			string kaptan_adi;
			string dosya_yolu = @"C:\Users\RCenk\Desktop\bilgi.txt"; //İşlem yapılacak dosya yolunu belirttim.
			FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
			//Bir file stream nesnesi oluşturdum. 1.parametre dosya yolunu,
			//2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtiyor,
			//3.parametre dosyaya erişimin veri yazmak için olacağını gösteriyor.
			StreamWriter sw = new StreamWriter(fs); //Yazma işlemi için bir StreamWriter nesnesi oluşturdum.
			Console.WriteLine("\n**************************************************SEFER İŞLEMLERİ**************************************************\n");
			Console.Write(" Herhangi bir işlem alanında Ana Menüye dönmek için '1' Çıkış yapmak için 0'a basın.\n\n");
			Console.Write("* Sefer No Giriniz: ");
			sefer_no = Convert.ToInt16(Console.ReadLine()); //kullanıcıdan bir sayı aldırtıyorum.
			Console.Write("* Güzergah Bilgisini Giriniz: ");
			guzergah = Console.ReadLine();
			Console.Write("* Sefer Tarihi Giriniz (gg/aa/yyyy): ");
			tarih = Console.ReadLine();
			Console.Write("* Sefer Saatini Giriniz (hh:mm): ");
			saat = Console.ReadLine();
			Console.Write("* Yolcu Kapasitesini Giriniz: ");
			kapasite = Convert.ToInt16(Console.ReadLine());
			Console.Write("* Araç Plakasını Giriniz (20 XX 20): ");
			plaka = Console.ReadLine();
			Console.Write("* Kaptanın Adını Giriniz: ");
			kaptan_adi = Console.ReadLine();
			Console.Write("* Bilet Fiyatını Giriniz (TL): ");
			bilet_fiyati = Convert.ToInt16(Console.ReadLine());
			sw.Write(sefer_no + ", ");
			sw.Write(guzergah + ", ");
			sw.Write(tarih + ", ");
			sw.Write(saat + ", ");
			sw.Write(kapasite + ", ");
			sw.Write(plaka + ", ");
			sw.Write(kaptan_adi + ", ");
			sw.WriteLine(bilet_fiyati + ",");
			//Dosyaya ekleyeceğimiz sefer bilgilerini WriteLine() metodu ile yazacağız.
			sw.Flush();
			//Veriyi tampon bölgeden dosyaya aktardım.
			sw.Close();
			fs.Close();
			//İşimiz bitince kullandığımız nesneleri iade ettim.
		}

		private static void BiletSatisIslemleri()
		{

		}

		private static void Cikis()
		{
			Environment.Exit(0);
		} //Programdan çıkış yapar.
		static void Main(string[] args)
		{
			IslemSec();
			Console.ReadKey();
		}
	}
}
