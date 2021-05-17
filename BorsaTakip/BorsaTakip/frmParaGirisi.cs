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
    public partial class frmParaGirisi : Form
    {
        public frmParaGirisi()
        {
            InitializeComponent();
        }
        OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        private void frmParaGirisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }

        private void frmParaGirisi_Load(object sender, EventArgs e)
        {
            string sql = "Select * From tblUyeler Where pkUyeID="+Users.UyeID;
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cnn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                txtDevirBakiye.Text = dr["Hesap"].ToString();
            cnn.Close();
            txtPara.Enabled = false;

            btnYeni.Enabled = true;
            btnKaydet.Enabled = false;
            btnIptal.Enabled = false;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtPara.Enabled = true;

            btnYeni.Enabled = false;
            btnKaydet.Enabled = true;
            btnIptal.Enabled = true;

            txtPara.Text = "";
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtPara.Enabled = false;

            btnYeni.Enabled = true;
            btnKaydet.Enabled = false;
            btnIptal.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string sql = "Insert Into tblParaGiris(UyeID,Para) Values(@UyeID,@Para)";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@UyeID", Users.UyeID);
            cmd.Parameters.AddWithValue("@Para", txtPara.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();


            txtPara.Enabled = false;

            btnYeni.Enabled = true;
            btnKaydet.Enabled = false;
            btnIptal.Enabled = false;
        }
    }
}
