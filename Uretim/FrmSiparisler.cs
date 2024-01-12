using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Uretim
{
    public partial class FrmSiparisler : Form
    {
        string sipkalem = "";
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T63P1D5\\SQLEXPRESS;Initial Catalog=URETIM;Integrated Security=True");
        public FrmSiparisler()
        {
            InitializeComponent();
        }

       string x1 = "0";
        void sipariskontrol() //böyle bir sipariş var mı yok mu bilgisini bu fonksiyonla alıyoruz
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_SIPARISLER WHERE SIPARIS_NO='"+txtSiparisNumarasi.Text+"'", conn); //siparişler tablosundaki sipariş no primary key bu yüzden tek satır dönecek
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read()) // datareader satır satır okuma yapıyor 
            {
                x1 = dr1[0].ToString();
            }
            conn.Close();
        }
        void siparisbilgisicekme1()
        /*bu fonksiyon Sipariş bilgisi çekme işlemidir. Genel Bilgiler GroupBox'ın içindeki bilgiler bu fonksiyon ile gelir 
          Bir siparişin içinde birden fazla ürün olabilir. bu ürünleri listelemek için siparisbilgisicekme2() fonksiyonunda GridControl kullanıldı*/
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_SIPARISLER WHERE SIPARIS_NO='"+ txtSiparisNumarasi.Text+"'", conn); 
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {   
                //dr[0] içinde siparis_no tutuluyor bu yüzden eklenmedi
                txtMusteriKodu.Text = dr1[1].ToString();
                txtSiparisTarihi.Text=dr1[2].ToString();
                txtTeslimTarihi.Text=dr1[3].ToString();
                txtToplamTutar.Text=dr1[4].ToString();
            }
            conn.Close();
        }
        void siparisbilgisicekme2() /* siparişkalemleri tablosundaki siparişe ait ürün bilgilerini gridView içinde listeleme işlemi*/
        {
            conn.Open();
            DataTable dt = new DataTable(); //DataTable, bellekte tablo şeklinde veri saklamak için kullanılır.
            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_KODU, STOK_ADI, MIKTAR,FIYAT,KDV,SIPKALEM_ID FROM TBL_SIPARISKALEMLERI WHERE SIPARIS_NO='" + txtSiparisNumarasi.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);// dt'yi da ile doldur
            gridControl1.DataSource = dt; // datatabledeki tablo şeklinde tutulan verileri gridControl1.DataSource'ye atayıp tablo seklinde gösterme işlemi yani bellekteki tabloyu gösterme

            conn.Close();
        }

        string x2 = "0";
        void musterikontrol() //müşteri var mı yok mu?
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU='" + txtMusteriKodu.Text + "'", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x2 = dr1[0].ToString();
            }
            conn.Close();
        }
        void musterbilgisicekme() //müşteri koduna ait müşteri bilgilerini Detaylı Müşteri Bilgisi GroupBoxına gösterme işlemi 
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT MUSTERI_ADI, IL,ILCE FROM TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU='"+txtMusteriKodu.Text+"'", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtMusteriAdi.Text = dr1[0].ToString();
                txtIl.Text=dr1[1].ToString();
                txtIlce.Text=dr1[2].ToString();
            }
            conn.Close();
        }
        string x3 = "0";
        void stokkontrol() /* GridView içinde listelenen siparişe ait ürüne tıkladığımızda o ürünün stokta olup olmadığının kontrol edilmesi işlemi ürün var mı yok mu?*/
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_STOKKAYITLARI WHERE STOK_KODU='" + txtStokKodu.Text + "' ", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x3 = dr1[0].ToString();
            }
            conn.Close();
        }
        void stokbilgisicekme() //sipariş içerik bilgileri groupbox'ındaki listelenen ürünlere tıklanması durumunda stok bilgilerinin çekilmesi işlemi  
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_ADI,FIYAT,KDV_ORANI FROM TBL_STOKKAYITLARI WHERE STOK_KODU='" + txtStokKodu.Text + "' ", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtStokAdi.Text = dr1[0].ToString();
                txtFiyat.Text=dr1[1].ToString();
               txtKDV.Text=dr1[2].ToString();
                
            }
            conn.Close();
        }
        void geneltoplamhesaplama() //bir siparişe ait ürünlerin toplam fiyatını bulabileceğimiz fonksiyon 
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT SUM((MIKTAR*FIYAT)+(MIKTAR*FIYAT*KDV/100)) WHERE TBL_SIPARISKALEMLERI GROUP BY "+txtSiparisNumarasi.Text+"",conn);
            //bu sorguda sipariş kalemleri tablosundaki ürün fiyatı ile miktarı çarpıp ardından ürün fiyatı ile kdvsini de çarpıp eklediğimizde çıkan sonucu sipariş numarasına göre gruplayıp topladığımızda siparişe ait toplam tutarı elde ediyoruz
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtToplamTutar.Text = dr1[0].ToString();
            }
            conn.Close();
        }
        void temizle1() //sipariş kalemlerine(ürünlere) ait bilgilerin temizlenmesi
        {
            txtStokKodu.Text = "";
            txtStokAdi.Text= "";
            txtUrunAciklamasi.Text = "";
            txtFiyat.Text = "";
            txtKDV.Text = "";
            txtMiktar.Text = "";
        }
        void temizle2()// ekranda görülen bütün textlerin temizlenmesi
        {   
            txtSiparisTarihi.Text = "";
            txtTeslimTarihi.Text = "";
            txtMusteriKodu.Text = "";
            txtMusteriAdi.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtToplamTutar.Text = "";
            temizle1();
        }
        string x6 = "0";
        void sipgenelisemrikontrol()
        {
            conn.Open();
            /*Sipariş yeni geldiyse ÜD(ÜRETİM DURUMU): K ,İş Emri verildiyse ÜD :A, İş Emri tamamlandıysa ÜD: B , eğer ürün sevk edilmişse ÜD: S olacak  */
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_SIPARISKALEMLERI WHERE SIPARIS_NO='"+txtSiparisNumarasi.Text+"'AND (URETIMDURUMU='A' OR URETIMDURUMU='B' OR URETIMDURUMU='S') ",conn);
            //Üretim durumuna göre siparişi silme işlemi gerçekleştirilir eğer siparişin içindeki ürünlerin üretim durumu K ise silinebilir eğer siparişin içinde bir tane bile yukarıdaki durumlardan varsa silme işlemi yapılamaz silme işlemi yapabilmek için x6=0 olmalı 
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            { 
                x6 = dr1[0].ToString();
            }
            conn.Close();
        }
        string x5 = "0";
        void sipkalemisemrikontrol()
        {
            conn.Open();
            /*siparişin içinden ürün silmek için üretim durumuna baktıktan sonra silşme işlemi gerçekleştirilir ürünün üretim durumunubu sorguyla x5 değerine atıyoruz
              çünkü ileride üretim durumuna göre siparişin içinden silinip silinemeyeceğine karar vericez */
            SqlCommand sorgu1 = new SqlCommand("SELECT URETIMDURUMU FROM TBL_SIPARISKALEMLERI WHERE SIPKALEM_ID='"+sipkalem+" ", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x5 = dr1[0].ToString();
            }
            conn.Close();
        }
        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FrmSiparisListesi frm = new FrmSiparisListesi();
            frm.Show();
        }

        private void txtSiparisNumarasi_Leave(object sender, EventArgs e) //sipariş numarasına bişey yazıp text kutucuğundan ayrıldığımız taktirde çalışacak fonksiyonlar

        {
            sipariskontrol();// önce sipariş kontrolü
            if (Convert.ToInt16(x1)== 1) //eğer girdiğimiz sipariş numarasına ait sipariş varsa;
            {
                siparisbilgisicekme1(); //Girdiğimiz sipariş numarasına ait bilgileri getir
                siparisbilgisicekme2(); // siparişin içindeki ürünleri yani sipariş kalemlerini listele  
                musterbilgisicekme();  // müşteri koduna ait müşteri bilgilerini Detaylı Müşteri Bilgisi GroupBox'ında göster
                txtMusteriKodu.Enabled = false; //sipariş numarasını kontrol etmeden musteri koduna bişey yazılamasın 
            }
            else //eğer girdiğimiz sipariş numarasına ait sipariş yoksa;
            {
               if(txtSiparisNumarasi.Text == "") //sipariş numarası boşsa 
                {
                    txtSiparisNumarasi.Focus(); //sipariş numarasına fokusla yani ilk başta siparişnumarası textine yazı yazılabilsin 
                }
                else //sipariş numarası texti doluysa 
                {
                    siparisbilgisicekme2(); // olmayan bir siparis numarası yazdığımızda ve tab yaptığımızda gridViewin içi de boş olsun diye
                    temizle2(); //herşeyi temizle
                    txtMusteriKodu.Enabled = true; // eğer yazdığımız sipariş no ya ait bilgiler yoksa müşteri kodu ile arama yapalım
                }
            }
        }

        private void FrmSiparisler_Load(object sender, EventArgs e) // siparişler form ekranı açılırken çalışmasını istediğimiz şeyler 
        {
            gridView1.OptionsBehavior.Editable = false; //dridview içinde listelenen ürünlere arayüzden edit işlemi yapılamasın 
            txtKDV.Enabled = false; //ilgili kutulara bişey yazılamasın
            txtFiyat.Enabled = false;
            txtUrunAciklamasi.Enabled = false;
            txtMiktar.Enabled = false;
        }

        private void txtMusteriKodu_Leave(object sender, EventArgs e) //müşteri kodu textine bişey yazıp ayrıldığımızda çalışacak fonksiyonlar
        {
            musterikontrol(); //müşteri var mı yok mu ?
            if (Convert.ToInt16(x2) == 1) //varsa
            {
                musterbilgisicekme(); //müşteri koduna ait müşteri bilgilerini Detaylı Müşteri Bilgisi GroupBox'ında göster
            }
            else //yoksa
            {
                txtMusteriKodu.Focus(); //müşteri koduna odakla yani bidaha yaz
            }
        }

        private void txtStokKodu_Leave(object sender, EventArgs e)//stok kodu textine bişey yazıp ayrıldığımızda çalışacak fonksiyonlar
        {
            stokkontrol(); //stok var mı yok mu
            if (Convert.ToInt16(x3) == 1) //varsa
            {
                stokbilgisicekme(); //stok bilgisi çek 
                txtStokAdi.Enabled = true; //ilgili kutulara bişey yazma yetkisi aktif edildi düzenleme işlemi yapılabilecek
                txtKDV.Enabled = true;
                txtFiyat.Enabled = true;
                txtUrunAciklamasi.Enabled = true;
                txtMiktar.Enabled = true;
                txtMiktar.Text = "0,00";

            }
            else
            {
                txtStokKodu.Focus();
            }
        }

        private void sbtnKaydet_Click(object sender, EventArgs e)
        {
            if (sipkalem == "")
            {
                //YENİ BİR KAYIT DEMEK İNSERT İŞLEMİ YAPILACAK
                conn.Open();
                //SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_SIPARISKALEMLERI (SIPARIS_NO,STOK_KODU,STOK_ADI,MIKTAR,URUN_ACIKLAMASI,FIYAT,KDV,URETIMDURUMU) VALUES ('"+txtSiparisNumarasi.Text+"','"+txtStokKodu.Text+"','"+txtStokAdi.Text+"','"+txtMiktar.Text.Replace(',','.')+"','"+txtUrunAciklamasi.Text+"','"+txtFiyat.Text.Replace(',', '.') + "','"+txtKDV.Text.Replace(',', '.') + "','K') ", conn);
               // sorgu1.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                //ESKİ KAYDI GÜNCELLEMEK DEMEK
                conn.Open();
               // SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISKALEMLERI SET MIKTAR='"+txtMiktar.Text+"',URUN_ACIKLAMASI='"+txtUrunAciklamasi.Text+"',FIYAT='"+ txtFiyat.Text.Replace(',', '.') + "',KDV='"+ txtKDV.Text.Replace(',', '.') + "'WHERE SIPKALEM_ID='"+sipkalem+"'", conn);
                //sorgu1.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e) //GridViewde satıra çift tıklama anında çalışacak fonksiyon 
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle); // en son fokuslanan satırı al
            //sütuna ait verileri ilgili textlere ata;
            txtStokKodu.Text = x["STOK_KODU"].ToString(); 
            txtStokAdi.Text = x["STOK_ADI"].ToString();
            txtFiyat.Text= x["FIYAT"].ToString();
            txtMiktar.Text = x["MIKTAR"].ToString();
            txtKDV.Text = x["KDV"].ToString();
            //txtUrunAciklamasi.Text = x["URUN_ACIKLAMASI"].ToString();
            sipkalem = x["SIPKALEM_ID"].ToString();
            
            txtStokKodu.Enabled = false;//stok koduna ait text edit yapılamasın çünkü güncelleme için 
            txtMiktar.Enabled = true; // stok koduna ait bilgiler burdan düzenlenebilsin
            txtFiyat.Enabled = true;
            txtKDV.Enabled = true;
            txtUrunAciklamasi.Enabled = true;
        }
    }
}
