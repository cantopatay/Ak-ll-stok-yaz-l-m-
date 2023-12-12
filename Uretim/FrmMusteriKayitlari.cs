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
    public partial class FrmMusteriKayitlari : Form
    {
        SqlConnection adres = new SqlConnection("Data Source=DESKTOP-T63P1D5\\SQLEXPRESS;Initial Catalog=URETIM;Integrated Security=True");

        public FrmMusteriKayitlari()
        {
            InitializeComponent();
        }
        string x1 = "0";
        void musterikontrol()
        {
            adres.Open();
            SqlCommand sorgu1 = new SqlCommand("select COUNT(*) from TBL_MUSTERIKAYITLARI where MUSTERI_KODU='"+txtMusteriKodu.Text+"'", adres);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x1 = dr[0].ToString();

            }
            adres.Close();
        }
        void musteribilgisicekme()
        {
            adres.Open();
            SqlCommand sorgu1 = new SqlCommand("select * from TBL_MUSTERIKAYITLARI where MUSTERI_KODU='" + txtMusteriKodu.Text + "'", adres);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtMusteriAdi.Text = dr[1].ToString();
                txtAdres.Text= dr[2].ToString();
                cbxIl.Text= dr[3].ToString();
                cbxIlce.Text= dr[4].ToString();
                txtTelefon.Text= dr[5].ToString();
                txtEPosta.Text= dr[6].ToString();
                string x = dr[7].ToString();
                if (x == "A")
                {
                    rbtnAlici.Checked = true;
                }
                else
                {
                    rbtnSatici.Checked = true;
                }

            }
            adres.Close();
           illisteleme();
            ilcelisteleme();
        }
        void illisteleme()
        {
            cbxIl.Properties.Items.Clear();
            adres.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT ISIM FROM TBL_IL", adres);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                cbxIl.Properties.Items.Add(dr[0]);
            }
            adres.Close();
        }
        void ilcelisteleme()
        {
            cbxIlce.Properties.Items.Clear();
            adres.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT ISIM FROM TBL_ILCE WHERE IL_ID='"+ (cbxIl.SelectedIndex+1) + "'", adres);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                cbxIlce.Properties.Items.Add(dr[0]);


            }
            adres.Close();
        }
        private void FrmMusteriKayitlari_Load(object sender, EventArgs e)
        {
            illisteleme();
        }

        private void txtMusteriKodu_Leave(object sender, EventArgs e)
        {
            if (txtMusteriKodu.Text == "")
            {
                txtMusteriKodu.Focus();
            }
            else
            {
                musterikontrol();//müşteriyi kontrol et 
                if (Convert.ToInt16(x1) == 1) //eğer varsa
                {
                    musteribilgisicekme();   //bilgi çek
                }
                else //yoksa
                {
                    temizle();
                    illisteleme(); //müşteriye yeni kayıt yaparken iller direk listelensin ki seçebilelim
                }
            }
            
        }
        void temizle()
        {
            txtAdres.Text = "";
            txtEPosta.Text = "";
            txtMusteriAdi.Text = "";
            txtTelefon.Text = "";
            cbxIl.Properties.Items.Clear();
            cbxIl.Text = "";
            cbxIlce.Properties.Items.Clear();
            cbxIlce.Text = "";
            rbtnAlici.Checked = false;
            rbtnSatici.Checked = false;


        }

       

        private void sbtnKaydet_Click(object sender, EventArgs e) //Kaydet butonuna Tıklanınca 
        {
            musterikontrol();
            if (Convert.ToInt16(x1) == 1) //Eğer varsa Güncelle
            {
                if (rbtnAlici.Checked == true) //Eğer alıcıysa
                {
                    //Alıcı güncelleme
                    adres.Open();
                    SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_MUSTERIKAYITLARI SET MUSTERI_ADI='"+txtMusteriAdi.Text+"',ADRES='"+txtAdres.Text+"',IL='"+cbxIl.Text+"',ILCE='"+cbxIlce.Text+"',TELEFON='"+txtTelefon.Text+"',E_POSTA='"+txtEPosta.Text+"',TIP='A' WHERE MUSTERI_KODU='"+txtMusteriKodu.Text+"'", adres);
                    sorgu1.ExecuteNonQuery();
                    adres.Close();
                    temizle();
                    txtMusteriKodu.Text = "";
                   
                }
                else //Eğer satıcıysa
                {
                    //Satıcı güncelleme
                    adres.Open();
                    SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_MUSTERIKAYITLARI SET MUSTERI_ADI='" + txtMusteriAdi.Text + "',ADRES='" + txtAdres.Text + "',IL='" + cbxIl.Text + "',ILCE='" + cbxIlce.Text + "',TELEFON='" + txtTelefon.Text + "',E_POSTA='" + txtEPosta.Text + "',TIP='S' WHERE MUSTERI_KODU='" + txtMusteriKodu.Text + "'", adres);
                    sorgu1.ExecuteNonQuery();
                    adres.Close();
                    temizle();
                    txtMusteriKodu.Text = "";
                   
                }
                
            }
            else //Yoksa Ekle
            {
                if (rbtnAlici.Checked == true) //Eğer alıcıysa
                {
                    //Alıcı ekleme
                    adres.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_MUSTERIKAYITLARI (MUSTERI_KODU, MUSTERI_ADI, ADRES, IL, ILCE, TELEFON, E_POSTA, TIP) VALUES('"+txtMusteriKodu.Text+"','"+txtMusteriAdi.Text+"','"+txtAdres.Text +"','"+cbxIl.Text+"','"+cbxIlce.Text+"','"+txtTelefon.Text+"','"+txtEPosta.Text+"','A')", adres);
                    sorgu1.ExecuteNonQuery();
                    adres.Close();
                    temizle();
                    txtMusteriKodu.Text = "";
                    
                }
                else //Eğer satıcıysa
                {
                    //Satıcı ekleme
                    adres.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_MUSTERIKAYITLARI (MUSTERI_KODU, MUSTERI_ADI, ADRES, IL, ILCE, TELEFON, E_POSTA, TIP) VALUES('" + txtMusteriKodu.Text + "','" + txtMusteriAdi.Text + "','" + txtAdres.Text + "','" + cbxIl.Text + "','" + cbxIlce.Text + "','" + txtTelefon.Text + "','" + txtEPosta.Text + "','S')", adres);
                    sorgu1.ExecuteNonQuery();
                    adres.Close();
                    temizle();
                    txtMusteriKodu.Text = "";
                    
                }
            }
        }

        private void sbtnSil_Click(object sender, EventArgs e)// Sil Tuşuna Basıldığında
        {
            adres.Open();
            SqlCommand sorgu1 = new SqlCommand("DELETE TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU='"+txtMusteriKodu.Text+"'", adres);
            sorgu1.ExecuteNonQuery();
            adres.Close();
            temizle();
            txtMusteriKodu.Text = "";
            
        }

        private void cbxIl_Leave(object sender, EventArgs e)
        {
            ilcelisteleme();
            cbxIlce.Text = "";
        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FrmMusteriListesi.musterikodu = "musterikayit"; //Eğer Müşteri kayıtlarından müşteri listesine ulaşırsak musterikodunu buna göre yazmamız gerekir çünkü ilerde siparişlerden de müşteri listesine ulaşabiliriz
            FrmMusteriListesi frm = new FrmMusteriListesi();
            frm.Show();
        }

        private void FrmMusteriKayitlari_Activated(object sender, EventArgs e)
        {
            if (FrmMusteriListesi.musterikodu == "")
            {
               // temizle();
                //txtMusteriKodu.Text = "";
            }
            else
            {
                txtMusteriKodu.Text = FrmMusteriListesi.musterikodu;
                musteribilgisicekme();
            }
        }

        private void FrmMusteriKayitlari_FormClosed(object sender, FormClosedEventArgs e)//müşteri kayıtları formu kapatıldığı zaman 
        {
            FrmMusteriListesi.musterikodu = ""; //hafızasından bu bilgiyi silsin
        }
    }
}
