namespace BorsaTakip
{
    partial class frmUyeOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUyeOl));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullanıcıAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.rbSatıcı = new System.Windows.Forms.RadioButton();
            this.rbAlıcı = new System.Windows.Forms.RadioButton();
            this.pnlAlanlar = new System.Windows.Forms.Panel();
            this.lblHataAd = new System.Windows.Forms.Label();
            this.lblHataSoyad = new System.Windows.Forms.Label();
            this.lblHataTC = new System.Windows.Forms.Label();
            this.lblHataTelNo = new System.Windows.Forms.Label();
            this.lblHataMail = new System.Windows.Forms.Label();
            this.lblHataAdres = new System.Windows.Forms.Label();
            this.lblHataKullanıcıAd = new System.Windows.Forms.Label();
            this.lblHataSifre = new System.Windows.Forms.Label();
            this.lblHataSifreTekrar = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.MaskedTextBox();
            this.pnlAlanlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtKullanıcıAd
            // 
            this.txtKullanıcıAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullanıcıAd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAd.Location = new System.Drawing.Point(22, 283);
            this.txtKullanıcıAd.MaxLength = 25;
            this.txtKullanıcıAd.Name = "txtKullanıcıAd";
            this.txtKullanıcıAd.Size = new System.Drawing.Size(175, 23);
            this.txtKullanıcıAd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adı";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.Window;
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(22, 9);
            this.txtAd.MaxLength = 25;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(175, 23);
            this.txtAd.TabIndex = 1;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfGirisi);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyadı";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(22, 38);
            this.txtSoyad.MaxLength = 25;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(175, 23);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfGirisi);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "TC Kimlik No";
            // 
            // txtTC
            // 
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.Location = new System.Drawing.Point(22, 67);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(175, 23);
            this.txtTC.TabIndex = 3;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RakamGirisi);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(22, 312);
            this.txtSifre.MaxLength = 10;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(175, 23);
            this.txtSifre.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Şifre (Tekrar) ";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifreTekrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreTekrar.Location = new System.Drawing.Point(22, 341);
            this.txtSifreTekrar.MaxLength = 10;
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '*';
            this.txtSifreTekrar.Size = new System.Drawing.Size(175, 23);
            this.txtSifreTekrar.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(30, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(22, 154);
            this.txtAdres.MaxLength = 255;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(272, 63);
            this.txtAdres.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(30, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(22, 125);
            this.txtMail.MaxLength = 30;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(175, 23);
            this.txtMail.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(30, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefon No";
            // 
            // btnİptal
            // 
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİptal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.Image = ((System.Drawing.Image)(resources.GetObject("btnİptal.Image")));
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnİptal.Location = new System.Drawing.Point(290, 394);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(72, 56);
            this.btnİptal.TabIndex = 32;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.Location = new System.Drawing.Point(212, 394);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(72, 56);
            this.btnKaydet.TabIndex = 31;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeni.Location = new System.Drawing.Point(134, 394);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(72, 56);
            this.btnYeni.TabIndex = 30;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeni.UseCompatibleTextRendering = true;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(30, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Üye Türü";
            // 
            // rbSatıcı
            // 
            this.rbSatıcı.AutoSize = true;
            this.rbSatıcı.Checked = true;
            this.rbSatıcı.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSatıcı.Location = new System.Drawing.Point(22, 223);
            this.rbSatıcı.Name = "rbSatıcı";
            this.rbSatıcı.Size = new System.Drawing.Size(60, 21);
            this.rbSatıcı.TabIndex = 7;
            this.rbSatıcı.TabStop = true;
            this.rbSatıcı.Text = "Satıcı";
            this.rbSatıcı.UseVisualStyleBackColor = true;
            // 
            // rbAlıcı
            // 
            this.rbAlıcı.AutoSize = true;
            this.rbAlıcı.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAlıcı.Location = new System.Drawing.Point(137, 223);
            this.rbAlıcı.Name = "rbAlıcı";
            this.rbAlıcı.Size = new System.Drawing.Size(52, 21);
            this.rbAlıcı.TabIndex = 8;
            this.rbAlıcı.Text = "Alıcı";
            this.rbAlıcı.UseVisualStyleBackColor = true;
            // 
            // pnlAlanlar
            // 
            this.pnlAlanlar.Controls.Add(this.txtTelNo);
            this.pnlAlanlar.Controls.Add(this.lblHataSifreTekrar);
            this.pnlAlanlar.Controls.Add(this.lblHataSifre);
            this.pnlAlanlar.Controls.Add(this.lblHataKullanıcıAd);
            this.pnlAlanlar.Controls.Add(this.lblHataAdres);
            this.pnlAlanlar.Controls.Add(this.lblHataMail);
            this.pnlAlanlar.Controls.Add(this.lblHataTelNo);
            this.pnlAlanlar.Controls.Add(this.lblHataTC);
            this.pnlAlanlar.Controls.Add(this.lblHataSoyad);
            this.pnlAlanlar.Controls.Add(this.lblHataAd);
            this.pnlAlanlar.Controls.Add(this.txtAd);
            this.pnlAlanlar.Controls.Add(this.rbAlıcı);
            this.pnlAlanlar.Controls.Add(this.txtKullanıcıAd);
            this.pnlAlanlar.Controls.Add(this.rbSatıcı);
            this.pnlAlanlar.Controls.Add(this.txtSoyad);
            this.pnlAlanlar.Controls.Add(this.txtTC);
            this.pnlAlanlar.Controls.Add(this.txtSifre);
            this.pnlAlanlar.Controls.Add(this.txtSifreTekrar);
            this.pnlAlanlar.Controls.Add(this.txtMail);
            this.pnlAlanlar.Controls.Add(this.txtAdres);
            this.pnlAlanlar.Location = new System.Drawing.Point(112, 3);
            this.pnlAlanlar.Name = "pnlAlanlar";
            this.pnlAlanlar.Size = new System.Drawing.Size(348, 385);
            this.pnlAlanlar.TabIndex = 36;
            // 
            // lblHataAd
            // 
            this.lblHataAd.AutoSize = true;
            this.lblHataAd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHataAd.ForeColor = System.Drawing.Color.Red;
            this.lblHataAd.Location = new System.Drawing.Point(203, 12);
            this.lblHataAd.Name = "lblHataAd";
            this.lblHataAd.Size = new System.Drawing.Size(50, 13);
            this.lblHataAd.TabIndex = 36;
            this.lblHataAd.Text = "* Zorunlu";
            // 
            // lblHataSoyad
            // 
            this.lblHataSoyad.AutoSize = true;
            this.lblHataSoyad.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHataSoyad.ForeColor = System.Drawing.Color.Red;
            this.lblHataSoyad.Location = new System.Drawing.Point(203, 43);
            this.lblHataSoyad.Name = "lblHataSoyad";
            this.lblHataSoyad.Size = new System.Drawing.Size(50, 13);
            this.lblHataSoyad.TabIndex = 37;
            this.lblHataSoyad.Text = "* Zorunlu";
            // 
            // lblHataTC
            // 
            this.lblHataTC.AutoSize = true;
            this.lblHataTC.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHataTC.ForeColor = System.Drawing.Color.Red;
            this.lblHataTC.Location = new System.Drawing.Point(203, 72);
            this.lblHataTC.Name = "lblHataTC";
            this.lblHataTC.Size = new System.Drawing.Size(50, 13);
            this.lblHataTC.TabIndex = 38;
            this.lblHataTC.Text = "* Zorunlu";
            // 
            // lblHataTelNo
            // 
            this.lblHataTelNo.AutoSize = true;
            this.lblHataTelNo.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHataTelNo.ForeColor = System.Drawing.Color.Red;
            this.lblHataTelNo.Location = new System.Drawing.Point(203, 101);
            this.lblHataTelNo.Name = "lblHataTelNo";
            this.lblHataTelNo.Size = new System.Drawing.Size(50, 13);
            this.lblHataTelNo.TabIndex = 39;
            this.lblHataTelNo.Text = "* Zorunlu";
            // 
            // lblHataMail
            // 
            this.lblHataMail.AutoSize = true;
            this.lblHataMail.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHataMail.ForeColor = System.Drawing.Color.Red;
            this.lblHataMail.Location = new System.Drawing.Point(203, 130);
            this.lblHataMail.Name = "lblHataMail";
            this.lblHataMail.Size = new System.Drawing.Size(50, 13);
            this.lblHataMail.TabIndex = 40;
            this.lblHataMail.Text = "* Zorunlu";
            // 
            // lblHataAdres
            // 
            this.lblHataAdres.AutoSize = true;
            this.lblHataAdres.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHataAdres.ForeColor = System.Drawing.Color.Red;
            this.lblHataAdres.Location = new System.Drawing.Point(295, 160);
            this.lblHataAdres.Name = "lblHataAdres";
            this.lblHataAdres.Size = new System.Drawing.Size(50, 13);
            this.lblHataAdres.TabIndex = 41;
            this.lblHataAdres.Text = "* Zorunlu";
            // 
            // lblHataKullanıcıAd
            // 
            this.lblHataKullanıcıAd.AutoSize = true;
            this.lblHataKullanıcıAd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHataKullanıcıAd.ForeColor = System.Drawing.Color.Red;
            this.lblHataKullanıcıAd.Location = new System.Drawing.Point(203, 288);
            this.lblHataKullanıcıAd.Name = "lblHataKullanıcıAd";
            this.lblHataKullanıcıAd.Size = new System.Drawing.Size(50, 13);
            this.lblHataKullanıcıAd.TabIndex = 42;
            this.lblHataKullanıcıAd.Text = "* Zorunlu";
            // 
            // lblHataSifre
            // 
            this.lblHataSifre.AutoSize = true;
            this.lblHataSifre.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHataSifre.ForeColor = System.Drawing.Color.Red;
            this.lblHataSifre.Location = new System.Drawing.Point(203, 317);
            this.lblHataSifre.Name = "lblHataSifre";
            this.lblHataSifre.Size = new System.Drawing.Size(50, 13);
            this.lblHataSifre.TabIndex = 43;
            this.lblHataSifre.Text = "* Zorunlu";
            // 
            // lblHataSifreTekrar
            // 
            this.lblHataSifreTekrar.AutoSize = true;
            this.lblHataSifreTekrar.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHataSifreTekrar.ForeColor = System.Drawing.Color.Red;
            this.lblHataSifreTekrar.Location = new System.Drawing.Point(203, 346);
            this.lblHataSifreTekrar.Name = "lblHataSifreTekrar";
            this.lblHataSifreTekrar.Size = new System.Drawing.Size(102, 13);
            this.lblHataSifreTekrar.TabIndex = 44;
            this.lblHataSifreTekrar.Text = "* Şifreler Uyuşmuyor";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelNo.Location = new System.Drawing.Point(22, 95);
            this.txtTelNo.Mask = "(000) 000 00 00";
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(175, 23);
            this.txtTelNo.TabIndex = 4;
            this.txtTelNo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RakamGirisi);
            // 
            // frmUyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 458);
            this.Controls.Add(this.pnlAlanlar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUyeOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Borsa Takip Yazılımı";
            this.Load += new System.EventHandler(this.frmUyeOl_Load);
            this.pnlAlanlar.ResumeLayout(false);
            this.pnlAlanlar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullanıcıAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbSatıcı;
        private System.Windows.Forms.RadioButton rbAlıcı;
        private System.Windows.Forms.Panel pnlAlanlar;
        private System.Windows.Forms.Label lblHataSifre;
        private System.Windows.Forms.Label lblHataKullanıcıAd;
        private System.Windows.Forms.Label lblHataAdres;
        private System.Windows.Forms.Label lblHataMail;
        private System.Windows.Forms.Label lblHataTelNo;
        private System.Windows.Forms.Label lblHataTC;
        private System.Windows.Forms.Label lblHataSoyad;
        private System.Windows.Forms.Label lblHataAd;
        private System.Windows.Forms.Label lblHataSifreTekrar;
        private System.Windows.Forms.MaskedTextBox txtTelNo;
    }
}