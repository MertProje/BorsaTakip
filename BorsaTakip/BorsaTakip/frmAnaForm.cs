using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaTakip
{
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }
        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            frmGiris dlg = new frmGiris();
            DialogResult dr = dlg.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                if (Users.UserRole == "X")
                {
                    mnAdmin.Visible = true;
                    mnIslemler.Visible = true;
                    mnAlıcı.Visible = false;
                    mnSatıcı.Visible = false;
                    
                }
                else if (Users.UserRole == "A")
                {
                    mnAdmin.Visible = false;
                    mnAlıcı.Visible = true;
                    mnSatıcı.Visible = false;
                    mnIslemler.Visible = false;
                }
                else
                {
                    mnAdmin.Visible = false;
                    mnAlıcı.Visible = false;
                    mnSatıcı.Visible = true;
                    mnIslemler.Visible = false;
                }
            }
            else
                this.Close();

        }
        private void üyelikİstekleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnlAnaForm.Controls.Count != 0)
            {
                pnlAnaForm.Controls.RemoveAt(0);
            }
            frmUyeIstek frm = new frmUyeIstek();
            frm.TopLevel = false;
            pnlAnaForm.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }

        private void ürünTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnlAnaForm.Controls.Count != 0)
            {
                pnlAnaForm.Controls.RemoveAt(0);
            }
            frmUrunTanimlama frm = new frmUrunTanimlama();
            frm.TopLevel = false;
            pnlAnaForm.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }

        private void aToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (pnlAnaForm.Controls.Count != 0)
            {
                pnlAnaForm.Controls.RemoveAt(0);
            }
            frmUrunGirisi frm = new frmUrunGirisi();
            frm.TopLevel = false;
            pnlAnaForm.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }

        private void satıcıÜrünOnayıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnlAnaForm.Controls.Count != 0)
            {
                pnlAnaForm.Controls.RemoveAt(0);
            }
            frmUrunGirisOnay frm = new frmUrunGirisOnay();
            frm.TopLevel = false;
            pnlAnaForm.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnlAnaForm.Controls.Count != 0)
            {
                pnlAnaForm.Controls.RemoveAt(0);
            }
            frmParaGirisi frm = new frmParaGirisi();
            frm.TopLevel = false;
            pnlAnaForm.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }

        private void alıcıParaOnayıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnlAnaForm.Controls.Count != 0)
            {
                pnlAnaForm.Controls.RemoveAt(0);
            }
            frmParaGirisOnay frm = new frmParaGirisOnay();
            frm.TopLevel = false;
            pnlAnaForm.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pnlAnaForm.Controls.Count != 0)
            {
                pnlAnaForm.Controls.RemoveAt(0);
            }
            frmAlışveriş frm = new frmAlışveriş();
            frm.TopLevel = false;
            pnlAnaForm.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }

        private void paraGirişleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnlAnaForm.Controls.Count != 0)
            {
                pnlAnaForm.Controls.RemoveAt(0);
            }
            frmUyeListesi frm = new frmUyeListesi();
            frm.TopLevel = false;
            pnlAnaForm.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }

        private void borsaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnlAnaForm.Controls.Count != 0)
            {
                pnlAnaForm.Controls.RemoveAt(0);
            }
            frmBorsaIslemleri frm = new frmBorsaIslemleri();
            frm.TopLevel = false;
            pnlAnaForm.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }
    }
}
