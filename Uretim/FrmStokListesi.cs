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
    public partial class FrmStokListesi : Form
    {
        
        public static string stokkodu;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T63P1D5\\SQLEXPRESS;Initial Catalog=URETIM;Integrated Security=True");
        public FrmStokListesi()
        {
            InitializeComponent();
        }
        void arama() //Stok listesini arama ve GridView de tablo şeklinde  gösterme işlemi
        {
            conn.Open();
            DataTable dt = new DataTable(); //DataTable, bellekte tablo şeklinde veri saklamak için kullanılır.
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_STOKKAYITLARI WHERE STOK_KODU LIKE '%" + txtStokKodu.Text + "%' AND STOK_ADI LIKE '%" + txtStokAdi.Text + "%' AND GRUP_KODU LIKE '%" + txtGrupKodu.Text + "%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);  //bu sorguda textlere yazdığımız terimleri içinde barındıran verileri gösterir yani filtreleme işlemi
            da.Fill(dt); // dt'yi da ile doldur
            gridControl1.DataSource = dt; // datatabledeki tablo şeklinde tutulan verileri gridControl1.DataSource'ye atayıp tablo seklinde gösterme işlemi yani bellekteki tabloyu gösterme
            conn.Close();
        }
        private void FrmStokListesi_Load(object sender, EventArgs e) //form açılırken yapılmasını istediğimiz fonksiyon
        {
            gridView1.OptionsBehavior.Editable = false; // tablo listelenirken içerisinde oynama yapılmasını engelleme
            arama(); //tablo açılırken bütün listenin görünmesi için 
        }

        private void txtStokKodu_TextChanged(object sender, EventArgs e) //text her değiştiğinde çalışan fonksiyon
        {
            arama();
        }

        private void txtStokAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        
        private void txtGrupKodu_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

     
        private void gridView1_DoubleClick(object sender, EventArgs e) //GridViewde satıra çift tıklama anında çalışacak fonksiyon 
        {
            DataRow satir = gridView1.GetDataRow(gridView1.FocusedRowHandle); // en son fokuslanan satırı al
            if (stokkodu == "kayit") //Eğer stok listesine stok kayıtlarından ulaşıldıysa 
            {
                stokkodu = satir["STOK_KODU"].ToString(); //satırdaki stok kodunu stokkoduna ata
                this.Hide(); //ve stok listesi formunu kapat
                FrmStokKayitlari frm = new FrmStokKayitlari();
                frm.Activate(); //stok kayıtları formunu aktif et
            }
            else
            {

            }
        }

        private void FrmStokListesi_FormClosed(object sender, FormClosedEventArgs e) //eğer stok listesi manuel olarak kapatılırsa 
        {
            stokkodu = ""; //stok kodunu sıfırla
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
