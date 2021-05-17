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
    public partial class frmUrunGirisi : Form
    {
        OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        public frmUrunGirisi()
        {
            InitializeComponent();
        }
        void Doldur()
        {
            string sql = "SELECT * from tblUrunGiris where UyeID=@UyeID";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@UyeID", Users.UyeID);
            cnn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            dgwUrunler.Rows.Clear();
            int sat = 0;
            while (dr.Read())
            {
                dgwUrunler.Rows.Add(1);
                dgwUrunler.Rows[sat].Cells[0].Value = (sat + 1).ToString();
                dgwUrunler.Rows[sat].Cells[1].Value = dr["Urun"].ToString();
                dgwUrunler.Rows[sat].Cells[2].Value = dr["Miktar"].ToString();
                dgwUrunler.Rows[sat].Cells[3].Value = dr["Fiyat"].ToString();
                dgwUrunler.Rows[sat].Cells[4].Value = dr["pkUrunGirisID"].ToString();
                dgwUrunler.Rows[sat].Cells[5].Value = dr["UrunGirisTar"].ToString();
                dgwUrunler.Rows[sat].Cells[6].Value = dr["urunOnayTar"].ToString();
                if (dr["Durum"].ToString() == "False")
                    dgwUrunler.Rows[sat].DefaultCellStyle.BackColor = Color.Salmon;
                else
                    dgwUrunler.Rows[sat].DefaultCellStyle.BackColor = Color.GreenYellow;
                sat++;
            }
            cnn.Close();
            dgwUrunler.ClearSelection();
        }

        private void frmUrunGirisi_Load(object sender, EventArgs e)
        {
            string sql = "Select * From tblUrunler order by UrunAd";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cnn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            cmbUrun.Items.Clear();
            while (dr.Read())
                cmbUrun.Items.Add(dr["UrunAd"].ToString());
            cnn.Close();
            cmbUrun.Text = "Seçiniz";
            
            cmbUrun.Enabled = false;
            txtFiyat.Enabled = false;
            txtMiktar.Enabled = false;

            btnYeni.Enabled = true;
            btnKaydet.Enabled = false;
            btnIptal.Enabled = false;

            Doldur();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            cmbUrun.Enabled = true;
            txtFiyat.Enabled = true;
            txtMiktar.Enabled = true;

            btnYeni.Enabled = false;
            btnKaydet.Enabled = true;
            btnIptal.Enabled = true;

            cmbUrun.Text = "Seçiniz";
            txtMiktar.Text = "";
            txtFiyat.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string sql = "Insert Into tblUrunGiris(Urun,Miktar,Fiyat,UyeID) Values('"+cmbUrun.Text+"','"+txtMiktar.Text+"','"+txtFiyat.Text+"','"+Users.UyeID+"')";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            Doldur();

            cmbUrun.Enabled = false;
            txtFiyat.Enabled = false;
            txtMiktar.Enabled = false;

            btnYeni.Enabled = true;
            btnKaydet.Enabled = false;
            btnIptal.Enabled = false;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            cmbUrun.Enabled = false;
            txtFiyat.Enabled = false;
            txtMiktar.Enabled = false;

            btnYeni.Enabled = true;
            btnKaydet.Enabled = false;
            btnIptal.Enabled = false;
        }
    }
}
