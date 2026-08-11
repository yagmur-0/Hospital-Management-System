namespace HospitalMs
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            lblBaslik = new Label();
            lblAd = new Label();
            lblSoyad = new Label();
            lblTC = new Label();
            lblSifre = new Label();
            lblTelefon = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            mskTC = new MaskedTextBox();
            mskTelefon = new MaskedTextBox();
            lblCinsiyet = new Label();
            txtSifre = new TextBox();
            cmbCinsiyet = new ComboBox();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.FromArgb(13, 59, 102);
            lblBaslik.Location = new Point(50, 30);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(309, 46);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Hasta Kayıt Ekranı";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAd.ForeColor = Color.FromArgb(13, 59, 102);
            lblAd.Location = new Point(50, 90);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(38, 23);
            lblAd.TabIndex = 1;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSoyad.ForeColor = Color.FromArgb(13, 59, 102);
            lblSoyad.Location = new Point(50, 160);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(64, 23);
            lblSoyad.TabIndex = 3;
            lblSoyad.Text = "Soyad:";
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTC.ForeColor = Color.FromArgb(13, 59, 102);
            lblTC.Location = new Point(50, 230);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(120, 23);
            lblTC.TabIndex = 2;
            lblTC.Text = "TC Kimlik No:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifre.ForeColor = Color.FromArgb(13, 59, 102);
            lblSifre.Location = new Point(50, 370);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(53, 23);
            lblSifre.TabIndex = 5;
            lblSifre.Text = "Şifre:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTelefon.ForeColor = Color.FromArgb(13, 59, 102);
            lblTelefon.Location = new Point(50, 300);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(73, 23);
            lblTelefon.TabIndex = 4;
            lblTelefon.Text = "Telefon:";
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(50, 185);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(330, 31);
            txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(50, 115);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(330, 31);
            txtAd.TabIndex = 0;
            // 
            // mskTC
            // 
            mskTC.BorderStyle = BorderStyle.FixedSingle;
            mskTC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mskTC.Location = new Point(50, 255);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.PromptChar = ' ';
            mskTC.Size = new Size(330, 31);
            mskTC.TabIndex = 2;
            mskTC.ValidatingType = typeof(int);
            // 
            // mskTelefon
            // 
            mskTelefon.BorderStyle = BorderStyle.FixedSingle;
            mskTelefon.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mskTelefon.Location = new Point(50, 325);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(330, 31);
            mskTelefon.TabIndex = 3;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCinsiyet.ForeColor = Color.FromArgb(13, 59, 102);
            lblCinsiyet.Location = new Point(50, 440);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(78, 23);
            lblCinsiyet.TabIndex = 10;
            lblCinsiyet.Text = "Cinsiyet:";
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(50, 395);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(330, 30);
            txtSifre.TabIndex = 4;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.BackColor = Color.White;
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FlatStyle = FlatStyle.Flat;
            cmbCinsiyet.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmbCinsiyet.Location = new Point(50, 465);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(330, 33);
            cmbCinsiyet.TabIndex = 5;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.FromArgb(31, 78, 121);
            btnKayitOl.Cursor = Cursors.Hand;
            btnKayitOl.FlatAppearance.BorderSize = 0;
            btnKayitOl.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            btnKayitOl.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKayitOl.ForeColor = Color.White;
            btnKayitOl.Location = new Point(50, 540);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(330, 50);
            btnKayitOl.TabIndex = 13;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // FrmHastaKayit
            // 
            AcceptButton = btnKayitOl;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(432, 673);
            Controls.Add(btnKayitOl);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmHastaKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Hasta Kaydı";
            Load += FrmHastaKayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblTC;
        private Label lblSifre;
        private Label lblTelefon;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private MaskedTextBox mskTC;
        private MaskedTextBox mskTelefon;
        private Label lblCinsiyet;
        private TextBox txtSifre;
        private ComboBox cmbCinsiyet;
        private Button btnKayitOl;
    }
}