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
   
    public partial class FrmStokGrupKodlari : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T63P1D5\\SQLEXPRESS;Initial Catalog=URETIM;Integrated Security=True");

        string x1 = "0";
        void grupkodukontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select Count(*) from TBL_GRUPKOD where GRUP_KODU='" + txtGrupKodu.Text + "'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x1 = dr[0].ToString();
            }

            conn.Close();
        }
        void grupbilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select GRUP_ADI from TBL_GRUPKOD where GRUP_KODU='" + txtGrupKodu.Text + "'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtGrupAdi.Text = dr[0].ToString();
            }

            conn.Close();
        }
        void grupkodulisteleme() {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_GRUPKOD", conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
        }
        public FrmStokGrupKodlari()
        {
            InitializeComponent();
        }

        

        private void FrmStokGrupKodlari_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false; //Tabloda değiştirme özelliğini kaldırdım
            grupkodulisteleme();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            DataRow satir = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtGrupKodu.Text = satir["GRUP_KODU"].ToString();
            txtGrupAdi.Text = satir["GRUP_ADI"].ToString();
        }

        private void txtGrupKodu_Leave(object sender, EventArgs e)
        {
            grupkodukontrol();
            if (Convert.ToInt16(x1) == 1)
            {
                grupbilgisicekme();
            }
            else {
                txtGrupAdi.Text = "";
            }
        }
    }
}
