using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace BorsaTakip
{
    public partial class frmUyeOl : Form
    {
        OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        public frmUyeOl()
        {
            InitializeComponent();
        }
        void Aktif(bool aa)
        {
            btnYeni.Enabled =! aa;
            btnKaydet.Enabled = aa;
            btnİptal.Enabled = aa;

            pnlAlanlar.Enabled = aa;
        }
        private void frmUyeOl_Load(object sender, EventArgs e)
        {
            Aktif(false);
            HataGizle();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Aktif(true);
            txtAd.Text = "";
            txtAdres.Text = "";
            txtKullanıcıAd.Text = "";
            txtMail.Text = "";
            txtSifre.Text = "";
            txtSifreTekrar.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            txtTelNo.Text = "";

            HataGizle();
        }
        void HataGizle()
        {
            lblHataAd.Visible = false;
            lblHataAdres.Visible = false;
            lblHataKullanıcıAd.Visible = false;
            lblHataMail.Visible = false;
            lblHataSifre.Visible = false;
            lblHataSifreTekrar.Visible = false;
            lblHataSoyad.Visible = false;
            lblHataTC.Visible = false;
            lblHataTelNo.Visible = false;
        }
        private bool EmailKontrol(string email)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return (new Regex(strRegex)).IsMatch(email);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            char Bayrak = 'T';
            HataGizle();

            if (txtAd.Text == "") { lblHataAd.Visible = true; Bayrak = 'F'; }
            if (txtSoyad.Text == "") { lblHataSoyad.Visible = true; Bayrak = 'F'; }
            if (txtTC.Text.Length<11) { lblHataTC.Visible = true; Bayrak = 'F'; }
            if (txtTelNo.Text.Length != 10) { lblHataTelNo.Visible = true; Bayrak = 'F'; }
            if (txtMail.Text == "" || EmailKontrol(txtMail.Text)==false) { lblHataMail.Visible = true; Bayrak = 'F'; }
            if (txtAdres.Text == "") { lblHataAdres.Visible = true; Bayrak = 'F'; }
            if (txtKullanıcıAd.Text == "") { lblHataKullanıcıAd.Visible = true; Bayrak = 'F'; }
            if (txtSifre.Text == "") { lblHataSifre.Visible = true; Bayrak = 'F'; }
            if (txtSifre.Text != txtSifreTekrar.Text) { lblHataSifreTekrar.Visible = true; Bayrak = 'F'; }

            if(Bayrak=='T')
            {
                string sql = "Insert Into tblUyeler(Ad,Soyad,TC,TelNo,Mail,Adres,UyeTur,KullaniciAd,Sifre) Values(@Ad,@Soyad,@TC,@TelNo,@Mail,@Adres,@UyeTur,@KullaniciAd,@Sifre)";
                OleDbCommand cmd = new OleDbCommand(sql, cnn);
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@TC", txtTC.Text);
                cmd.Parameters.AddWithValue("@TelNo", txtTelNo.Text);
                cmd.Parameters.AddWithValue("@Mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);
                cmd.Parameters.AddWithValue("@UyeTur", rbAlıcı.Checked?'A':'S');
                cmd.Parameters.AddWithValue("@KullaniciAd", txtKullanıcıAd.Text);
                cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Kaydınız Başarı ile Alındı.\nSistem Yöneticisi Tarafından Üyeliğiniz Onaylandıktan Sonra Sisteme Giriş Yapabilirsniz.", "Borsa Takip Yazılımı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Aktif(false);
            }
        }

        void HarfGirisi(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
&& !char.IsSeparator(e.KeyChar);
        }
        void RakamGirisi(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            Aktif(false);            
        }
    }
}
