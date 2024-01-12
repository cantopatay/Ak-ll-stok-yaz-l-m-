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
    public partial class FrmMusteriListesi : Form
    {   
        public static string musterikodu;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T63P1D5\\SQLEXPRESS;Initial Catalog=URETIM;Integrated Security=True");
        void arama()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT MUSTERI_KODU, MUSTERI_ADI,IL,ILCE FROM TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU LIKE '%"+txtMusterıKodu.Text+"%' AND MUSTERI_ADI LIKE '%"+txtMusterıAdı.Text+"%' AND IL LIKE '%"+txtIl.Text+"%' AND ILCE LIKE '%"+txtIlce.Text+"%' ", conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
        }
        public FrmMusteriListesi()
        {
            InitializeComponent();
        }

        private void FrmMusteriListesi_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;// listedeki sütunlarda değişiklik yapılmasını engeller
            arama();
        }

        private void txtMusterıKodu_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtMusterıAdı_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtIl_EditValueChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtIlce_EditValueChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (musterikodu == "musterikayit")
            {
                musterikodu = x["MUSTERI_KODU"].ToString(); //musterikoduna sadece secilen sütundaki MUSTERI_KODU bilgisini ata
                this.Hide(); //müşterilistesi formunu kapat
                FrmMusteriKayitlari frm = new FrmMusteriKayitlari(); //ve yeni bir müşteri kayıtları formunu aç
                frm.Activate();
            }
            else
            {

            }
        }

        private void FrmMusteriListesi_FormClosed(object sender, FormClosedEventArgs e)// eğer müşteri listesinde sütun seçilmeden direk form kapatılırsa
        {
            musterikodu = "";
        }
    }
}
