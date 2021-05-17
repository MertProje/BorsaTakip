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
    public partial class frmAlışveriş : Form
    {
        OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        OleDbConnection cnn1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        public frmAlışveriş()
        {
            InitializeComponent();
        }

        private void frmAlışveriş_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }
        void Doldur()
        {
            //SELECT * FROM tblBorsa where format(Tarih,"dd/mm/yyyy") ="04.05.2021"
            string sql = "Select * From tblBorsa Inner Join tblUrunler ON tblBorsa.Urun = tblUrunler.pkUrunID Where Format(Tarih,'dd/mm/yyyy')='" + DateTime.Now.ToString("dd.MM.yyyy")+"' And Alıcı=" + Users.UyeID;
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cnn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();

            dgwAlımYap.Rows.Clear();
            int s = 0;
            while (dr.Read())
            {
                dgwAlımYap.Rows.Add(1);
                dgwAlımYap.Rows[s].Cells[0].Value = (s + 1).ToString();
                dgwAlımYap.Rows[s].Cells[1].Value = dr["UrunAd"].ToString();
                dgwAlımYap.Rows[s].Cells[2].Value = dr["Miktar"].ToString() + " Kg";
                dgwAlımYap.Rows[s].Cells[3].Value = dr["Fiyat"].ToString() + " TL"; 
                dgwAlımYap.Rows[s].Cells[4].Value = int.Parse(dr["Miktar"].ToString())*int.Parse(dr["Fiyat"].ToString())+" TL";
                dgwAlımYap.Rows[s].Cells[5].Value = dr["Tarih"].ToString();
                s++;
            }
            cnn.Close();
        }
        List<int> listUrunID = new List<int>();
        private void frmAlışveriş_Load(object sender, EventArgs e)
        {
            string sql = "Select * From tblUrunler order by UrunAd";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cnn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            cmbUrun.Items.Clear();
            listUrunID.Clear();
            while (dr.Read())
            {
                cmbUrun.Items.Add(dr["UrunAd"].ToString());
                listUrunID.Add(int.Parse(dr["pkUrunID"].ToString()));
            }
            cmbUrun.Text = "Seçiniz";
            cnn.Close();

            cmbUrun.Enabled = false;
            txtMiktar.Enabled = false;

            btnYeni.Enabled = true;
            btnKaydet.Enabled = false;
            btnIptal.Enabled = false;

            dgwAlımYap.Rows.Clear();
            Doldur();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbUrun.Text != "Seçiniz" && txtMiktar.Text != "")
            {
                int TalepMiktar = int.Parse(txtMiktar.Text);
                #region Ürün Kontrolü
                string sql = "Select Sum(Miktar) As Miktar From tblUrunGiris Where Urun='" + cmbUrun.Text + "'";
                OleDbCommand cmd = new OleDbCommand(sql, cnn);
                cnn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if ( TalepMiktar > int.Parse(dr["Miktar"].ToString()))
                {
                    MessageBox.Show("Maalesef Talep Edilen Miktar Mevcut Değil.", "Borsa Takip Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cnn.Close();
                    return;
                }
                cnn.Close();
                #endregion
                #region AlışVeriş Tutarı Hesaplama
                sql = "Select * From tblUrunGiris Where Urun='"+cmbUrun.Text+"' and Miktar>0 order By pkUrunGirisID";
                cmd = new OleDbCommand(sql, cnn);
                cnn.Open();
                dr = cmd.ExecuteReader();
                int Tutar = 0;
                while (dr.Read())
                {
                    
                    if (TalepMiktar <= int.Parse(dr["Miktar"].ToString()))
                    {
                        Tutar += int.Parse(dr["Fiyat"].ToString()) * TalepMiktar;
                        break;
                    }
                    else
                    {
                        Tutar=Tutar+ int.Parse(dr["Fiyat"].ToString()) * int.Parse(dr["Miktar"].ToString());
                        TalepMiktar-= int.Parse(dr["Miktar"].ToString());
                    }
                }
                cnn.Close();
                #endregion
                #region Bakiye Kontrolü
                sql = "Select Hesap From tblUyeler Where pkUyeID="+Users.UyeID;
                cmd = new OleDbCommand(sql, cnn);
                cnn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (int.Parse(dr["Hesap"].ToString()) < Tutar)
                {
                    MessageBox.Show("Maalesef Bakiye Yetersiz.", "Borsa Takip Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cnn.Close();
                    return;
                }
                cnn.Close();
                #endregion
                #region Alışveriş Yap
                sql = "Select * From tblUrunGiris Where Urun='" + cmbUrun.Text + "' and Miktar>0 order By pkUrunGirisID";
                cmd = new OleDbCommand(sql, cnn);
                cnn.Open();
                dr = cmd.ExecuteReader();
                Tutar = 0;
                while (dr.Read())
                {
                    if (TalepMiktar <= int.Parse(dr["Miktar"].ToString()))
                    {
                        Tutar += int.Parse(dr["Fiyat"].ToString()) * TalepMiktar;                        
                        KayıtUpdate(int.Parse(dr["pkUrunGirisID"].ToString()),int.Parse(dr["UyeID"].ToString()), TalepMiktar, int.Parse(dr["Fiyat"].ToString()));
                        break;
                    }
                    else
                    {
                        Tutar = Tutar + int.Parse(dr["Fiyat"].ToString()) * int.Parse(dr["Miktar"].ToString());
                        KayıtUpdate(int.Parse(dr["pkUrunGirisID"].ToString()),int.Parse(dr["UyeID"].ToString()), int.Parse(dr["Miktar"].ToString()), int.Parse(dr["Fiyat"].ToString()));
                        TalepMiktar -= int.Parse(dr["Miktar"].ToString());
                    }
                }
                cnn.Close();
                #endregion
                cmbUrun.Enabled = false;
                txtMiktar.Enabled = false;

                btnYeni.Enabled = true;
                btnKaydet.Enabled = false;
                btnIptal.Enabled = false;
            }
            else
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz.", "Borsa Takip YAzılımı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        void KayıtUpdate(int UrunID,int Satıcı,int Miktar,int Fiyat)
        {
            int Tutar = Miktar * Fiyat;
            #region Borsa İşlemleri Kayıt
            string sql = "Insert Into tblBorsa(Alıcı,Satıcı,Urun,Miktar,Fiyat) Values(@Alıcı,@Satıcı,@Urun,@Miktar,@Fiyat)";
            OleDbCommand cmd = new OleDbCommand(sql, cnn1);
            cnn1.Open();
            cmd.Parameters.AddWithValue("@Alıcı", Users.UyeID);
            cmd.Parameters.AddWithValue("@Satıcı", Satıcı);
            cmd.Parameters.AddWithValue("@Urun", listUrunID[cmbUrun.SelectedIndex]);
            cmd.Parameters.AddWithValue("@Miktar", Miktar);
            cmd.Parameters.AddWithValue("@Fiyat", Fiyat);
            cmd.ExecuteNonQuery();
            cnn1.Close();
            #endregion
            #region Alıcı Update Yap
            sql = "Update tblUyeler Set Hesap=Hesap-'"+Tutar+"' Where pkUyeID="+Users.UyeID;
            cmd = new OleDbCommand(sql, cnn1);
            cnn1.Open();
            cmd.ExecuteNonQuery();
            cnn1.Close();
            #endregion
            #region Satıcı Update yap
            sql = "Update tblUyeler Set Hesap=Hesap+'" + Tutar + "' Where pkUyeID=" + Satıcı;
            cmd = new OleDbCommand(sql, cnn1);
            cnn1.Open();
            cmd.ExecuteNonQuery();
            cnn1.Close();
            #endregion
            #region Urun Miktar Update
            sql = "Update tblUrunGiris set Miktar=Miktar-'"+Miktar+"' Where pkUrunGirisID="+UrunID;
            cmd = new OleDbCommand(sql, cnn1);
            cnn1.Open();
            cmd.ExecuteNonQuery();
            cnn1.Close();
            #endregion
            #region Grid Yaz
            dgwAlımYap.Rows.Add(1);
            int sat = dgwAlımYap.Rows.Count-1;
            dgwAlımYap.Rows[sat].Cells[0].Value = (sat + 1).ToString();
            dgwAlımYap.Rows[sat].Cells[1].Value = cmbUrun.Text;
            dgwAlımYap.Rows[sat].Cells[2].Value = Miktar.ToString()+ " Kg";
            dgwAlımYap.Rows[sat].Cells[3].Value = Fiyat.ToString() + " TL";
            dgwAlımYap.Rows[sat].Cells[4].Value = (Miktar * Fiyat).ToString() + " TL";
            dgwAlımYap.Rows[sat].Cells[5].Value = DateTime.Now.ToString();
            #endregion
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            cmbUrun.Enabled = true;
            txtMiktar.Enabled = true;

            btnYeni.Enabled = false;
            btnKaydet.Enabled = true;
            btnIptal.Enabled = true;

            cmbUrun.Text = "Seçiniz";
            txtMiktar.Text = "";


        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            cmbUrun.Enabled = false;
            txtMiktar.Enabled = false;

            btnYeni.Enabled = true;
            btnKaydet.Enabled = false;
            btnIptal.Enabled = false;
        }
    }
}
