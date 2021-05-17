using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaTakip
{
    public partial class frmUrunGirisOnay : Form
    {
        public frmUrunGirisOnay()
        {
            InitializeComponent();
        }
        OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        private void frmUrunGirisOnay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }
        void Doldur()
        {
            string sql = "Select * From tblUrunGiris Inner Join tblUyeler ON tblUrunGiris.UyeID = tblUyeler.pkUyeID Where tblUrunGiris.Durum=0 order by UrunGirisTar";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cnn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            dgwUrunler.Rows.Clear();
            int sat = 0;
            while (dr.Read())
            {
                dgwUrunler.Rows.Add(1);
                dgwUrunler.Rows[sat].Cells[0].Value = (sat + 1).ToString();
                dgwUrunler.Rows[sat].Cells[1].Value = dr["Ad"].ToString();
                dgwUrunler.Rows[sat].Cells[2].Value = dr["Soyad"].ToString();
                dgwUrunler.Rows[sat].Cells[3].Value = dr["TC"].ToString();
                dgwUrunler.Rows[sat].Cells[4].Value = dr["Urun"].ToString();
                dgwUrunler.Rows[sat].Cells[5].Value = dr["Miktar"].ToString();
                dgwUrunler.Rows[sat].Cells[6].Value = dr["Fiyat"].ToString();
                dgwUrunler.Rows[sat].Cells[7].Value = dr["pkUrunGirisID"].ToString();
                dgwUrunler.Rows[sat].Cells[8].Value = dr["UrunGirisTar"].ToString();
                dgwUrunler.Rows[sat].Cells[9].Value = dr["UrunOnayTar"].ToString();
                dgwUrunler.Rows[sat].Cells[10].Value = "Onay";
                sat++;
            }
            cnn.Close();
            dgwUrunler.ClearSelection();
        }
        private void frmUrunGirisOnay_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void dgwUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==10)
            {
                string sql = "Update tblUrunGiris Set Durum=1,UrunOnayTar='"+DateTime.Now.ToString()+"' Where pkUrunGirisID="+int.Parse(dgwUrunler.Rows[e.RowIndex].Cells[7].Value.ToString());
                OleDbCommand cmd = new OleDbCommand(sql, cnn);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                Doldur();
            }
        }
    }
}
