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
    public partial class FrmSiparisListesi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T63P1D5\\SQLEXPRESS;Initial Catalog=URETIM;Integrated Security=True");
        public FrmSiparisListesi()
        {
            InitializeComponent();
        }

        private void FrmSiparisListesi_Load(object sender, EventArgs e)
        {

        }
    }
}
