namespace HospitalMs
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            btnBilgiGuncelle = new Button();
            cmbCinsiyet = new ComboBox();
            txtSifre = new TextBox();
            lblCinsiyet = new Label();
            mskTelefon = new MaskedTextBox();
            mskTC = new MaskedTextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            lblSifre = new Label();
            lblTelefon = new Label();
            lblSoyad = new Label();
            lblTC = new Label();
            lblAd = new Label();
            lblBaslik = new Label();
            SuspendLayout();
            // 
            // btnBilgiGuncelle
            // 
            btnBilgiGuncelle.BackColor = Color.FromArgb(31, 78, 121);
            btnBilgiGuncelle.Cursor = Cursors.Hand;
            btnBilgiGuncelle.FlatAppearance.BorderSize = 0;
            btnBilgiGuncelle.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            btnBilgiGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            btnBilgiGuncelle.FlatStyle = FlatStyle.Flat;
            btnBilgiGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBilgiGuncelle.ForeColor = Color.White;
            btnBilgiGuncelle.Location = new Point(56, 543);
            btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            btnBilgiGuncelle.Size = new Size(330, 50);
            btnBilgiGuncelle.TabIndex = 27;
            btnBilgiGuncelle.Text = "GÜNCELLE";
            btnBilgiGuncelle.UseVisualStyleBackColor = false;
            btnBilgiGuncelle.Click += btnBilgiGuncelle_Click;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.BackColor = Color.White;
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FlatStyle = FlatStyle.Flat;
            cmbCinsiyet.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmbCinsiyet.Location = new Point(56, 468);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(330, 33);
            cmbCinsiyet.TabIndex = 5;
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(56, 398);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(330, 30);
            txtSifre.TabIndex = 4;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCinsiyet.ForeColor = Color.FromArgb(13, 59, 102);
            lblCinsiyet.Location = new Point(56, 443);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(78, 23);
            lblCinsiyet.TabIndex = 24;
            lblCinsiyet.Text = "Cinsiyet:";
            // 
            // mskTelefon
            // 
            mskTelefon.BorderStyle = BorderStyle.FixedSingle;
            mskTelefon.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mskTelefon.Location = new Point(56, 328);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(330, 31);
            mskTelefon.TabIndex = 3;
            // 
            // mskTC
            // 
            mskTC.BorderStyle = BorderStyle.FixedSingle;
            mskTC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mskTC.Location = new Point(56, 258);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.PromptChar = ' ';
            mskTC.Size = new Size(330, 31);
            mskTC.TabIndex = 2;
            mskTC.ValidatingType = typeof(int);
            // 
            // txtAd
            // 
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(56, 118);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(330, 31);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(56, 188);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(330, 31);
            txtSoyad.TabIndex = 1;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifre.ForeColor = Color.FromArgb(13, 59, 102);
            lblSifre.Location = new Point(56, 373);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(53, 23);
            lblSifre.TabIndex = 19;
            lblSifre.Text = "Şifre:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTelefon.ForeColor = Color.FromArgb(13, 59, 102);
            lblTelefon.Location = new Point(56, 303);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(73, 23);
            lblTelefon.TabIndex = 18;
            lblTelefon.Text = "Telefon:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSoyad.ForeColor = Color.FromArgb(13, 59, 102);
            lblSoyad.Location = new Point(56, 163);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(64, 23);
            lblSoyad.TabIndex = 17;
            lblSoyad.Text = "Soyad:";
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTC.ForeColor = Color.FromArgb(13, 59, 102);
            lblTC.Location = new Point(56, 233);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(120, 23);
            lblTC.TabIndex = 16;
            lblTC.Text = "TC Kimlik No:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAd.ForeColor = Color.FromArgb(13, 59, 102);
            lblAd.Location = new Point(56, 93);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(38, 23);
            lblAd.TabIndex = 15;
            lblAd.Text = "Ad:";
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.FromArgb(13, 59, 102);
            lblBaslik.Location = new Point(56, 33);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(309, 46);
            lblBaslik.TabIndex = 14;
            lblBaslik.Text = "Hasta Kayıt Ekranı";
            // 
            // FrmBilgiDuzenle
            // 
            AcceptButton = btnBilgiGuncelle;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(432, 673);
            Controls.Add(btnBilgiGuncelle);
            Controls.Add(cmbCinsiyet);
            Controls.Add(txtSifre);
            Controls.Add(lblCinsiyet);
            Controls.Add(mskTelefon);
            Controls.Add(mskTC);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(lblSifre);
            Controls.Add(lblTelefon);
            Controls.Add(lblSoyad);
            Controls.Add(lblTC);
            Controls.Add(lblAd);
            Controls.Add(lblBaslik);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmBilgiDuzenle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBilgiDuzenle";
            Load += FrmBilgiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBilgiGuncelle;
        private ComboBox cmbCinsiyet;
        private TextBox txtSifre;
        private Label lblCinsiyet;
        private MaskedTextBox mskTelefon;
        private MaskedTextBox mskTC;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label lblSifre;
        private Label lblTelefon;
        private Label lblSoyad;
        private Label lblTC;
        private Label lblAd;
        private Label lblBaslik;
    }
}