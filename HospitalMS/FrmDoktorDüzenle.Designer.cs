namespace HospitalMs
{
    partial class FrmDoktorDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDüzenle));
            mskTC = new MaskedTextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            lblSoyad = new Label();
            lblTC = new Label();
            lblAd = new Label();
            lblBaslik = new Label();
            btnBilgiGuncelle = new Button();
            cmPoliklinik2 = new ComboBox();
            txtSifre = new TextBox();
            lblCinsiyet = new Label();
            lblSifre = new Label();
            SuspendLayout();
            // 
            // mskTC
            // 
            mskTC.BorderStyle = BorderStyle.FixedSingle;
            mskTC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mskTC.Location = new Point(48, 340);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.PromptChar = ' ';
            mskTC.Size = new Size(330, 31);
            mskTC.TabIndex = 29;
            mskTC.ValidatingType = typeof(int);
            // 
            // txtAd
            // 
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(48, 200);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(330, 31);
            txtAd.TabIndex = 28;
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(48, 270);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(330, 31);
            txtSoyad.TabIndex = 27;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSoyad.ForeColor = Color.FromArgb(13, 59, 102);
            lblSoyad.Location = new Point(48, 245);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(64, 23);
            lblSoyad.TabIndex = 26;
            lblSoyad.Text = "Soyad:";
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTC.ForeColor = Color.FromArgb(13, 59, 102);
            lblTC.Location = new Point(48, 315);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(120, 23);
            lblTC.TabIndex = 25;
            lblTC.Text = "TC Kimlik No:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAd.ForeColor = Color.FromArgb(13, 59, 102);
            lblAd.Location = new Point(48, 175);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(38, 23);
            lblAd.TabIndex = 24;
            lblAd.Text = "Ad:";
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.FromArgb(13, 59, 102);
            lblBaslik.Location = new Point(48, 115);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(353, 46);
            lblBaslik.TabIndex = 23;
            lblBaslik.Text = "Doktor Bilgi Düzenle";
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
            btnBilgiGuncelle.Location = new Point(48, 565);
            btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            btnBilgiGuncelle.Size = new Size(330, 50);
            btnBilgiGuncelle.TabIndex = 34;
            btnBilgiGuncelle.Text = "GÜNCELLE";
            btnBilgiGuncelle.UseVisualStyleBackColor = false;
            btnBilgiGuncelle.Click += btnBilgiGuncelle_Click;
            // 
            // cmPoliklinik2
            // 
            cmPoliklinik2.BackColor = Color.White;
            cmPoliklinik2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmPoliklinik2.FlatStyle = FlatStyle.Flat;
            cmPoliklinik2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmPoliklinik2.FormattingEnabled = true;
            cmPoliklinik2.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmPoliklinik2.Location = new Point(48, 491);
            cmPoliklinik2.Name = "cmPoliklinik2";
            cmPoliklinik2.Size = new Size(330, 33);
            cmPoliklinik2.TabIndex = 33;
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(48, 420);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(330, 30);
            txtSifre.TabIndex = 32;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCinsiyet.ForeColor = Color.FromArgb(13, 59, 102);
            lblCinsiyet.Location = new Point(48, 465);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(90, 23);
            lblCinsiyet.TabIndex = 31;
            lblCinsiyet.Text = "Poliklinik:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifre.ForeColor = Color.FromArgb(13, 59, 102);
            lblSifre.Location = new Point(48, 395);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(53, 23);
            lblSifre.TabIndex = 30;
            lblSifre.Text = "Şifre:";
            // 
            // FrmDoktorDüzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(432, 673);
            Controls.Add(btnBilgiGuncelle);
            Controls.Add(cmPoliklinik2);
            Controls.Add(txtSifre);
            Controls.Add(lblCinsiyet);
            Controls.Add(lblSifre);
            Controls.Add(mskTC);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(lblSoyad);
            Controls.Add(lblTC);
            Controls.Add(lblAd);
            Controls.Add(lblBaslik);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmDoktorDüzenle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDoktorDüzenle";
            Load += FrmDoktorDüzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskTC;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label lblSoyad;
        private Label lblTC;
        private Label lblAd;
        private Label lblBaslik;
        private Button btnBilgiGuncelle;
        private ComboBox cmPoliklinik2;
        private TextBox txtSifre;
        private Label lblCinsiyet;
        private Label lblSifre;
    }
}