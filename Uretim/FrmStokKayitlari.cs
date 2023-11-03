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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmStokListesi frm = new FrmStokListesi();
            frm.Show();
        }

        private void sbtnGrupKodListesi_Click(object sender, EventArgs e)
        {
            FrmStokGrupKodlari frm = new FrmStokGrupKodlari();
            frm.Show();
        }

        private void FrmStokKayitlari_Load(object sender, EventArgs e)
        {

        }

        private void txtStokAdi_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtStokKodu_Leave(object sender, EventArgs e)
        {
            if (txtStokKodu.Text=="") {
                txtStokKodu.Focus();//eger stok kodu texti boşsa diğer textlere geçilmesin yalnızca doluysa geçilsin
            }
            else
            {
                stokkartikontrol();
                if (Convert.ToUInt16(x1) == 1)
                {
                    stokbilgisicekme();
                }
                else { };
            }
            
        }
    }
}
