namespace BorsaTakip
{
    partial class frmAnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.üyelikİstekleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satıcıÜrünOnayıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alıcıParaOnayıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAlıcı = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSatıcı = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnIslemler = new System.Windows.Forms.ToolStripMenuItem();
            this.borsaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAnaForm = new System.Windows.Forms.Panel();
            this.paraGirişleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 425);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(900, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAdmin,
            this.mnAlıcı,
            this.mnSatıcı,
            this.mnIslemler});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnAdmin
            // 
            this.mnAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyelikİstekleriToolStripMenuItem,
            this.satıcıÜrünOnayıToolStripMenuItem,
            this.alıcıParaOnayıToolStripMenuItem,
            this.ürünTanımlamaToolStripMenuItem});
            this.mnAdmin.Name = "mnAdmin";
            this.mnAdmin.Size = new System.Drawing.Size(58, 21);
            this.mnAdmin.Text = "Admin";
            // 
            // üyelikİstekleriToolStripMenuItem
            // 
            this.üyelikİstekleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("üyelikİstekleriToolStripMenuItem.Image")));
            this.üyelikİstekleriToolStripMenuItem.Name = "üyelikİstekleriToolStripMenuItem";
            this.üyelikİstekleriToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.üyelikİstekleriToolStripMenuItem.Text = "Üyelik İstekleri";
            this.üyelikİstekleriToolStripMenuItem.Click += new System.EventHandler(this.üyelikİstekleriToolStripMenuItem_Click);
            // 
            // satıcıÜrünOnayıToolStripMenuItem
            // 
            this.satıcıÜrünOnayıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("satıcıÜrünOnayıToolStripMenuItem.Image")));
            this.satıcıÜrünOnayıToolStripMenuItem.Name = "satıcıÜrünOnayıToolStripMenuItem";
            this.satıcıÜrünOnayıToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.satıcıÜrünOnayıToolStripMenuItem.Text = "Satıcı Ürün Onayı";
            this.satıcıÜrünOnayıToolStripMenuItem.Click += new System.EventHandler(this.satıcıÜrünOnayıToolStripMenuItem_Click);
            // 
            // alıcıParaOnayıToolStripMenuItem
            // 
            this.alıcıParaOnayıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alıcıParaOnayıToolStripMenuItem.Image")));
            this.alıcıParaOnayıToolStripMenuItem.Name = "alıcıParaOnayıToolStripMenuItem";
            this.alıcıParaOnayıToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.alıcıParaOnayıToolStripMenuItem.Text = "Alıcı Para Onayı";
            this.alıcıParaOnayıToolStripMenuItem.Click += new System.EventHandler(this.alıcıParaOnayıToolStripMenuItem_Click);
            // 
            // ürünTanımlamaToolStripMenuItem
            // 
            this.ürünTanımlamaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ürünTanımlamaToolStripMenuItem.Image")));
            this.ürünTanımlamaToolStripMenuItem.Name = "ürünTanımlamaToolStripMenuItem";
            this.ürünTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ürünTanımlamaToolStripMenuItem.Text = "Ürün Tanımlama";
            this.ürünTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.ürünTanımlamaToolStripMenuItem_Click);
            // 
            // mnAlıcı
            // 
            this.mnAlıcı.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.aToolStripMenuItem1});
            this.mnAlıcı.Name = "mnAlıcı";
            this.mnAlıcı.Size = new System.Drawing.Size(46, 21);
            this.mnAlıcı.Text = "Alıcı";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aToolStripMenuItem.Image")));
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aToolStripMenuItem.Text = "Para Yükleme";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aToolStripMenuItem1.Image")));
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.aToolStripMenuItem1.Text = "Alım Yap";
            this.aToolStripMenuItem1.Click += new System.EventHandler(this.aToolStripMenuItem1_Click);
            // 
            // mnSatıcı
            // 
            this.mnSatıcı.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem2});
            this.mnSatıcı.Name = "mnSatıcı";
            this.mnSatıcı.Size = new System.Drawing.Size(54, 21);
            this.mnSatıcı.Text = "Satıcı";
            // 
            // aToolStripMenuItem2
            // 
            this.aToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("aToolStripMenuItem2.Image")));
            this.aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            this.aToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.aToolStripMenuItem2.Text = "Ürün Girişi";
            this.aToolStripMenuItem2.Click += new System.EventHandler(this.aToolStripMenuItem2_Click);
            // 
            // mnIslemler
            // 
            this.mnIslemler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraGirişleriToolStripMenuItem,
            this.borsaİşlemleriToolStripMenuItem});
            this.mnIslemler.Name = "mnIslemler";
            this.mnIslemler.Size = new System.Drawing.Size(103, 21);
            this.mnIslemler.Text = "İşlemler Listesi";
            // 
            // borsaİşlemleriToolStripMenuItem
            // 
            this.borsaİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borsaİşlemleriToolStripMenuItem.Image")));
            this.borsaİşlemleriToolStripMenuItem.Name = "borsaİşlemleriToolStripMenuItem";
            this.borsaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.borsaİşlemleriToolStripMenuItem.Text = "Borsa İşlemleri";
            this.borsaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.borsaİşlemleriToolStripMenuItem_Click);
            // 
            // pnlAnaForm
            // 
            this.pnlAnaForm.BackColor = System.Drawing.Color.White;
            this.pnlAnaForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAnaForm.BackgroundImage")));
            this.pnlAnaForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAnaForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnaForm.Location = new System.Drawing.Point(0, 25);
            this.pnlAnaForm.Name = "pnlAnaForm";
            this.pnlAnaForm.Size = new System.Drawing.Size(900, 400);
            this.pnlAnaForm.TabIndex = 5;
            // 
            // paraGirişleriToolStripMenuItem
            // 
            this.paraGirişleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paraGirişleriToolStripMenuItem.Image")));
            this.paraGirişleriToolStripMenuItem.Name = "paraGirişleriToolStripMenuItem";
            this.paraGirişleriToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.paraGirişleriToolStripMenuItem.Text = "Üye Listesi";
            this.paraGirişleriToolStripMenuItem.Click += new System.EventHandler(this.paraGirişleriToolStripMenuItem_Click);
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 447);
            this.Controls.Add(this.pnlAnaForm);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Borsa Takip Yazılımı";
            this.Load += new System.EventHandler(this.frmAnaForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnAdmin;
        private System.Windows.Forms.ToolStripMenuItem üyelikİstekleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satıcıÜrünOnayıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alıcıParaOnayıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnAlıcı;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnSatıcı;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem2;
        private System.Windows.Forms.Panel pnlAnaForm;
        private System.Windows.Forms.ToolStripMenuItem mnIslemler;
        private System.Windows.Forms.ToolStripMenuItem borsaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraGirişleriToolStripMenuItem;
    }
}



