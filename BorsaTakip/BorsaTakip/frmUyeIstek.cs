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
    public partial class frmUyeIstek : Form
    {
        OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        public frmUyeIstek()
        {
            InitializeComponent();
        }
        private void frmUyeIstek_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        void Doldur()
        {
            string sql = "Select * From tblUyeler Where UyeTur<>'" + "X" + "' order By Durum Desc,Ad,Soyad";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            if (ConnectionState.Open == cnn.State)
                cnn.Close();
            cnn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            dgwUyeIstekleri.Rows.Clear();
            int sat = 0;
            while (dr.Read())
            {
                dgwUyeIstekleri.Rows.Add(1);
                dgwUyeIstekleri.Rows[sat].Cells[0].Value = (sat + 1).ToString();
                dgwUyeIstekleri.Rows[sat].Cells[1].Value = dr["Ad"].ToString();
                dgwUyeIstekleri.Rows[sat].Cells[2].Value = dr["Soyad"].ToString();
                dgwUyeIstekleri.Rows[sat].Cells[3].Value = dr["TC"].ToString();
                dgwUyeIstekleri.Rows[sat].Cells[4].Value = dr["TelNo"].ToString();
                dgwUyeIstekleri.Rows[sat].Cells[5].Value = dr["Mail"].ToString();
                dgwUyeIstekleri.Rows[sat].Cells[6].Value = dr["Adres"].ToString();
                dgwUyeIstekleri.Rows[sat].Cells[7].Value = dr["UyeTur"].ToString();
                dgwUyeIstekleri.Rows[sat].Cells[8].Value = dr["Durum"].ToString() == "False" ? "Onay" : "İptal";
                if (dr["Durum"].ToString() == "False")
                    dgwUyeIstekleri.Rows[sat].DefaultCellStyle.BackColor = Color.Salmon;
                else
                    dgwUyeIstekleri.Rows[sat].DefaultCellStyle.BackColor = Color.GreenYellow;
                dgwUyeIstekleri.Rows[sat].Cells[9].Value = dr["pkUyeID"].ToString();
                sat++;
            }
            cnn.Close();
            dgwUyeIstekleri.ClearSelection();
        }
        private void dgwUyeIstekleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==8)
            {
                string sql;
                if (dgwUyeIstekleri.Rows[e.RowIndex].Cells[8].Value.ToString() == "Onay")
                {
                    sql = "Update tblUyeler Set Durum=1 Where pkUyeID=" + int.Parse(dgwUyeIstekleri.Rows[e.RowIndex].Cells[9].Value.ToString());
                    dgwUyeIstekleri.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.GreenYellow;
                    dgwUyeIstekleri.Rows[e.RowIndex].Cells[8].Value = "İptal";
                }
                else
                {
                    sql = "Update tblUyeler Set Durum=0 Where pkUyeID=" + int.Parse(dgwUyeIstekleri.Rows[e.RowIndex].Cells[9].Value.ToString());
                    dgwUyeIstekleri.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
                    dgwUyeIstekleri.Rows[e.RowIndex].Cells[8].Value = "Onay";
                }
                OleDbCommand cmd = new OleDbCommand(sql, cnn);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        private void frmUyeIstek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }
    }
}
