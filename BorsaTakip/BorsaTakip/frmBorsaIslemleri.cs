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
    public partial class frmBorsaIslemleri : Form
    {
        OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        public frmBorsaIslemleri()
        {
            InitializeComponent();
        }

        private void frmBorsaIslemleri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }
        void Doldur()
        {
            string sql = @"SELECT tblUyeler.Ad As AlıcıAd, tblUyeler.Soyad As AlıcıSoyad,  (Select tblUyeler.Ad From tblUyeler Where tblUyeler.pkUyeID = tblBorsa.Satıcı) AS SatıcıAd,(Select tblUyeler.Soyad From tblUyeler Where tblUyeler.pkUyeID = tblBorsa.Satıcı) AS SatıcıSoyad, tblUrunler.UrunAd, tblBorsa.Miktar, tblBorsa.Fiyat, tblBorsa.Tarih
FROM(tblUyeler INNER JOIN tblBorsa ON tblUyeler.pkUyeID = tblBorsa.Alıcı) INNER JOIN tblUrunler ON tblBorsa.Urun = tblUrunler.pkUrunID ORDER BY tblBorsa.Tarih";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            if (ConnectionState.Open == cnn.State)
                cnn.Close();
            cnn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            dgwUyeler.Rows.Clear();
            int sat = 0;
            while (dr.Read())
            {
                dgwUyeler.Rows.Add(1);
                dgwUyeler.Rows[sat].Cells[0].Value = (sat + 1).ToString();
                dgwUyeler.Rows[sat].Cells[1].Value = dr["Tarih"].ToString();
                dgwUyeler.Rows[sat].Cells[4].Value = dr["AlıcıAd"].ToString();
                dgwUyeler.Rows[sat].Cells[5].Value = dr["AlıcıSoyad"].ToString();
                dgwUyeler.Rows[sat].Cells[2].Value = dr["SatıcıAd"].ToString();
                dgwUyeler.Rows[sat].Cells[3].Value = dr["SatıcıSoyad"].ToString();
                dgwUyeler.Rows[sat].Cells[6].Value = dr["UrunAd"].ToString();
                dgwUyeler.Rows[sat].Cells[7].Value = dr["Miktar"].ToString();
                dgwUyeler.Rows[sat].Cells[8].Value = int.Parse(dr["Fiyat"].ToString()).ToString("C0");
                sat++;
            }
            cnn.Close();
            dgwUyeler.ClearSelection();
        }

        private void frmBorsaIslemleri_Load(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
