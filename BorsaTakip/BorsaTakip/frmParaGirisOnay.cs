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
    public partial class frmParaGirisOnay : Form
    {
        public frmParaGirisOnay()
        {
            InitializeComponent();
        }
        OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        private void frmParaGirisOnay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }
        void Doldur()
        {
            string sql = "Select * From tblParaGiris Inner Join tblUyeler ON tblParaGiris.UyeID = tblUyeler.pkUyeID Where tblParaGiris.Durum=0 order by tblParaGiris.ParaGirisTar";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cnn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            dgwParaGirisOnay.Rows.Clear();
            int sat = 0;
            while (dr.Read())
            {
                dgwParaGirisOnay.Rows.Add(1);
                dgwParaGirisOnay.Rows[sat].Cells[0].Value = (sat + 1).ToString();
                dgwParaGirisOnay.Rows[sat].Cells[1].Value = dr["Ad"].ToString();
                dgwParaGirisOnay.Rows[sat].Cells[2].Value = dr["Soyad"].ToString();
                dgwParaGirisOnay.Rows[sat].Cells[3].Value = dr["TC"].ToString();
                dgwParaGirisOnay.Rows[sat].Cells[4].Value = dr["TelNo"].ToString();
                dgwParaGirisOnay.Rows[sat].Cells[5].Value = dr["Hesap"].ToString();
                dgwParaGirisOnay.Rows[sat].Cells[6].Value = dr["Para"].ToString();
                dgwParaGirisOnay.Rows[sat].Cells[7].Value = dr["pkParaGirisID"].ToString();
                dgwParaGirisOnay.Rows[sat].Cells[8].Value = dr["ParaGirisTar"].ToString();
                dgwParaGirisOnay.Rows[sat].Cells[9].Value = dr["ParaOnayTar"].ToString();
                dgwParaGirisOnay.Rows[sat].Cells[10].Value = "Onay";
                dgwParaGirisOnay.Rows[sat].Cells[11].Value = dr["UyeID"].ToString();
                sat++;
            }
            cnn.Close();
            dgwParaGirisOnay.ClearSelection();
        }
        private void frmParaGirisOnay_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void dgwParaGirisOnay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                string sql = "Update tblParaGiris Set Durum=1,ParaOnayTar='" + DateTime.Now.ToString() + "' Where pkParaGirisID=" + int.Parse(dgwParaGirisOnay.Rows[e.RowIndex].Cells[7].Value.ToString());
                OleDbCommand cmd = new OleDbCommand(sql, cnn);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                sql="Update tblUyeler Set Hesap=Hesap+'"+ int.Parse(dgwParaGirisOnay.Rows[e.RowIndex].Cells[6].Value.ToString()) + "' Where pkUyeID=" + int.Parse(dgwParaGirisOnay.Rows[e.RowIndex].Cells[11].Value.ToString());
                cmd = new OleDbCommand(sql, cnn);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                Doldur();
            }
        }
    }
}
