﻿using System;
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
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T63P1D5\\SQLEXPRESS;Initial Catalog=URETIM;Integrated Security=True");
        public FrmStokListesi()
        {
            InitializeComponent();
        }
        void arama()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_STOKKAYITLARI WHERE STOK_KODU LIKE '%" + txtStokKodu.Text + "%' AND STOK_ADI LIKE '%" + txtStokAdi.Text + "%' AND GRUP_KODU LIKE '%" + txtGrupKodu.Text + "%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
        }
        private void FrmStokListesi_Load(object sender, EventArgs e)
        {
            arama();
        }

        private void txtStokKodu_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtStokAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtGrupKodu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGrupKodu_TextChanged(object sender, EventArgs e)
        {
            arama();
        }
    }
}