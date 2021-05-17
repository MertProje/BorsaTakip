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
    public partial class frmUyeListesi : Form
    {
        OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        public frmUyeListesi()
        {
            InitializeComponent();
        }

        private void frmUyeListesi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }
        void Doldur()
        {
            string sql = "Select * From tblUyeler Where UyeTur<>'" + "X" + "' order By Ad,Soyad";
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
                dgwUyeler.Rows[sat].Cells[1].Value = dr["TC"].ToString();
                dgwUyeler.Rows[sat].Cells[2].Value = dr["Ad"].ToString();
                dgwUyeler.Rows[sat].Cells[3].Value = dr["Soyad"].ToString();
                dgwUyeler.Rows[sat].Cells[4].Value = dr["TelNo"].ToString();
                dgwUyeler.Rows[sat].Cells[5].Value = dr["Mail"].ToString();
                dgwUyeler.Rows[sat].Cells[6].Value = dr["Adres"].ToString();
                if (dr["UyeTur"].ToString() == "S")
                    dgwUyeler.Rows[sat].Cells[7].Value = "Satıcı";
                else
                    dgwUyeler.Rows[sat].Cells[7].Value = "Alıcı";                
                if (dr["Durum"].ToString() == "False")
                    dgwUyeler.Rows[sat].DefaultCellStyle.BackColor = Color.Salmon;
                else
                    dgwUyeler.Rows[sat].DefaultCellStyle.BackColor = Color.GreenYellow;
                dgwUyeler.Rows[sat].Cells[8].Value =int.Parse(dr["Hesap"].ToString()).ToString("C0");
                sat++;
            }
            cnn.Close();
            dgwUyeler.ClearSelection();
        }

        private void frmUyeListesi_Load(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
