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
    public partial class frmUrunTanimlama : Form
    {
        OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        public frmUrunTanimlama()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtUrunAd.Enabled = true;
            txtUrunAd.Text = "";

            btnYeni.Enabled = false;
            btnKaydet.Enabled = true;
            btnIptal.Enabled = true;
        }
        void Doldur()
        {
            string sql = "Select * From tblUrunler order By UrunAd";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            if (ConnectionState.Open == cnn.State)
                cnn.Close();
            cnn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            dgwUrunler.Rows.Clear();
            int sat = 0;
            while (dr.Read())
            {
                dgwUrunler.Rows.Add(1);
                dgwUrunler.Rows[sat].Cells[0].Value = (sat + 1).ToString();
                dgwUrunler.Rows[sat].Cells[1].Value = dr["UrunAd"].ToString();
                dgwUrunler.Rows[sat].Cells[2].Value = dr["Durum"].ToString() == "False" ? "Aktif" : "Pasif";
                if (dr["Durum"].ToString() == "False")
                    dgwUrunler.Rows[sat].DefaultCellStyle.BackColor = Color.Salmon;
                else
                    dgwUrunler.Rows[sat].DefaultCellStyle.BackColor = Color.GreenYellow;
                dgwUrunler.Rows[sat].Cells[3].Value = dr["pkUrunID"].ToString();
                sat++;
            }
            cnn.Close();
            dgwUrunler.ClearSelection();
        }
        private void frmUrunTanimlama_Load(object sender, EventArgs e)
        {
            Doldur();

            txtUrunAd.Enabled = false;

            btnYeni.Enabled = true;
            btnKaydet.Enabled = false;
            btnIptal.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunAd.Text.Length > 0)
            {
                string sql = "Insert Into tblUrunler(UrunAd) Values('" + txtUrunAd.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, cnn);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                Doldur();

                txtUrunAd.Enabled = false;

                btnYeni.Enabled = true;
                btnKaydet.Enabled = false;
                btnIptal.Enabled = false;
            }
        }

        private void dgwUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==2)
            {
                string sql;
                if (dgwUrunler.Rows[e.RowIndex].Cells[2].Value.ToString() == "Aktif")
                {
                    sql = "Update tblUrunler Set Durum=1 Where pkUrunID=" + int.Parse(dgwUrunler.Rows[e.RowIndex].Cells[3].Value.ToString());
                    dgwUrunler.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.GreenYellow;
                    dgwUrunler.Rows[e.RowIndex].Cells[2].Value = "Pasif";
                }
                else
                {
                    sql = "Update tblUrunler Set Durum=0 Where pkUrunID=" + int.Parse(dgwUrunler.Rows[e.RowIndex].Cells[3].Value.ToString());
                    dgwUrunler.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
                    dgwUrunler.Rows[e.RowIndex].Cells[2].Value = "Aktif";
                }
                OleDbCommand cmd = new OleDbCommand(sql, cnn);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        private void frmUrunTanimlama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtUrunAd.Enabled = false;

            btnYeni.Enabled = true;
            btnKaydet.Enabled = false;
            btnIptal.Enabled = false;
        }
    }
}
