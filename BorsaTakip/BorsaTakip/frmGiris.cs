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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string sql = "Select * From tblUyeler Where KullaniciAd='"+txtKullanıcıAd.Text+"' And Sifre='"+txtSifre.Text+"'";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cnn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if(!bool.Parse(dr["Durum"].ToString()))
                {
                    MessageBox.Show("Üyelik Durumunuz Tamamlanmadı.", "Borsa Takip Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cnn.Close();
                }
                else
                {
                    Users.Ad = dr["Ad"].ToString();
                    Users.Soyad = dr["Soyad"].ToString();
                    Users.UserName = dr["KullaniciAd"].ToString();
                    Users.UserRole = dr["UyeTur"].ToString();
                    Users.UyeID = int.Parse(dr["pkUyeID"].ToString());
                    cnn.Close();

                    if (chHatirla.Checked)
                    {
                        Properties.Settings.Default["UserName"] = txtKullanıcıAd.Text;
                        Properties.Settings.Default["PassWord"] = txtSifre.Text;
                    }
                    else
                    {
                        Properties.Settings.Default["UserName"] = "";
                        Properties.Settings.Default["PassWord"] = "";
                    }
                    Properties.Settings.Default.Save();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Borsa Takip Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cnn.Close();
            }

        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            txtKullanıcıAd.Text = Properties.Settings.Default["UserName"].ToString();
            txtSifre.Text = Properties.Settings.Default["PassWord"].ToString();
            if (txtKullanıcıAd.Text.Length > 0)
                chHatirla.Checked = true;
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            frmUyeOl frm = new frmUyeOl();
            frm.ShowDialog();
        }
    }
}
