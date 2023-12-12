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
    public partial class FrmStokKayitlari : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T63P1D5\\SQLEXPRESS;Initial Catalog=URETIM;Integrated Security=True");
        public FrmStokKayitlari()
        {
            InitializeComponent();
        }
        string x1 = "0";
        void stokkartikontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT (*) FROM TBL_STOKKAYITLARI WHERE STOK_KODU='"+ txtStokKodu.Text+"'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x1=dr[0].ToString();
            }
            
            conn.Close();
        }
         string x2 = "0";
        void grupkodukontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select Count(*) from TBL_GRUPKOD where GRUP_KODU='"+ txtGrupKodu.Text+"'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x2 = dr[0].ToString();
            }

            conn.Close();
        }
        void temizle()
        {
            txtStokAdi.Text = "";
            txtFiyat.Text = "";
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
            txtKDVOrani.Text = "";
        }
        void stokbilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_STOKKAYITLARI WHERE STOK_KODU='"+txtStokKodu.Text+"'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtStokAdi.Text = dr[1].ToString();
                txtGrupKodu.Text = dr[2].ToString();
                txtFiyat.Text = dr[3].ToString();
                txtKDVOrani.Text = dr[4].ToString();
            }
            
            conn.Close();
        }
        void grupbilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select GRUP_ADI from TBL_GRUPKOD where GRUP_KODU='"+txtGrupKodu.Text+"'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtGrupAdi.Text = dr[0].ToString();
            }

            conn.Close();
        }
        

        private void sbtnGrupKodListesi_Click(object sender, EventArgs e)
        {
            
            FrmStokGrupKodlari frm = new FrmStokGrupKodlari();
            frm.Show();
        }
        
        private void FrmStokKayitlari_Load(object sender, EventArgs e)
        {
            txtFiyat.Text = "0,00";
            txtKDVOrani.Text = "0,00";
        }

       

        private void txtStokKodu_Leave(object sender, EventArgs e)
        {
            if (txtStokKodu.Text=="") {
                txtStokKodu.Focus();//eger stok kodu texti boşsa diğer textlere geçilmesin yalnızca doluysa geçilsin
            }
            else
            {
                FrmStokListesi.stokkodu = txtStokKodu.Text;
                stokkartikontrol();
                if (Convert.ToUInt16(x1) == 1)
                {
                    stokbilgisicekme();
                    grupbilgisicekme();
                }
                else
                {
                    temizle();
                    txtFiyat.Text = "0,00";
                    txtKDVOrani.Text = "0,00";

                };
            }
            
        }

        private void FrmStokKayitlari_Activated(object sender, EventArgs e)
        {
            if (FrmStokListesi.stokkodu == "")
            {
                temizle();
                txtStokKodu.Text = "";
            }
            else //çift tıklayarak gelindiyse 
            {
                txtStokKodu.Text = FrmStokListesi.stokkodu;
                stokbilgisicekme();
                grupbilgisicekme();
            }
            
        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {   
            FrmStokListesi.stokkodu = "kayit";
            FrmStokListesi frm = new FrmStokListesi();
            frm.Show();
        }

        private void txtGrupKodu_Leave(object sender, EventArgs e)
        {
            grupkodukontrol(); //grup kodu var mı yokmu test et
            if(Convert.ToInt16(x2)==1) //eger varsa 
            {
                grupbilgisicekme(); //grupkodu.Texte gelen veriyi ata
            }
            else // yoksa 
            {
                txtGrupKodu.Focus();
            }
        }

        private void FrmStokKayitlari_FormClosed(object sender, FormClosedEventArgs e) //stok kayıtları ekranı manuel olarak kapatıldığında 
        {
            FrmStokListesi.stokkodu = ""; //eski kayıt verileri temizlensin
        }

        private void sbtnKaydet_Click(object sender, EventArgs e)
        {   
            
            stokkartikontrol();
            if (Convert.ToInt16(x1) == 1)
            {
                //güncelleme
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_STOKKAYITLARI SET STOK_ADI='"+txtStokAdi.Text+"',GRUPKODU='"+txtGrupKodu.Text+"',FIYAT='"+txtFiyat.Text.Replace(',','.')+"',KDV_ORANI='"+txtKDVOrani.Text.Replace(',', '.') + "' WHERE STOK_KODU='"+txtStokKodu.Text+"'", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();
                txtStokKodu.Text = "";
                
            }
            else
            {
                //YENİ KAYIT EKLEME
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_STOKKAYITLARI (STOK_KODU,STOK_ADI,GRUP_KODU,FIYAT,KDV_ORANI) VALUES('"+txtStokKodu.Text+"','"+txtStokAdi.Text+"','"+txtGrupKodu.Text+"','"+txtFiyat.Text.Replace(',', '.') + "','"+txtKDVOrani.Text.Replace(',', '.') + "')", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();
                txtStokKodu.Text = "";
                
            }
        }

        private void sbtnSil_Click(object sender, EventArgs e)
        {
            stokkartikontrol();
            if (Convert.ToInt16(x1) == 1)
            {
                //sil
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("DELETE TBL_STOKKAYITLARI WHERE STOK_KODU='"+ txtStokKodu.Text+"'", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();
                txtStokKodu.Text = "";
                
            }
            else
            {
                //zaten yok
                MessageBox.Show("Bçyle bir stok kodu bulunamamaktadır.");
            }
        }
    }
}
