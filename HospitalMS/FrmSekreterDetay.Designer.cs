namespace HospitalMs
{
    partial class FrmSekreterDetay
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            grpSekreterBilgi = new GroupBox();
            lblAdSoyad = new Label();
            lblAdSoyadBaslik = new Label();
            lblTC = new Label();
            lblTCBaslik = new Label();
            grpDuyuruOlustur = new GroupBox();
            btnDuyuruOlustur = new Button();
            rtbDuyuru = new RichTextBox();
            grpHizliErisim = new GroupBox();
            Duyurular1 = new Button();
            btnRandevuListe = new Button();
            btnBransPaneli = new Button();
            btnDoktorPaneli = new Button();
            grpRandevuPaneli = new GroupBox();
            btnKaydet = new Button();
            chkDurum = new CheckBox();
            mskTC = new MaskedTextBox();
            cmbDoktor = new ComboBox();
            cmbBrans = new ComboBox();
            mskSaat = new MaskedTextBox();
            mskTarih = new MaskedTextBox();
            txtId = new TextBox();
            lbl2TC = new Label();
            lblDoktor = new Label();
            lblBrans = new Label();
            lblSaat = new Label();
            lblTarih = new Label();
            lblId = new Label();
            grpBranslar = new GroupBox();
            dgvBranslar = new DataGridView();
            grpDoktorlar = new GroupBox();
            dgvDoktorlar = new DataGridView();
            grpSekreterBilgi.SuspendLayout();
            grpDuyuruOlustur.SuspendLayout();
            grpHizliErisim.SuspendLayout();
            grpRandevuPaneli.SuspendLayout();
            grpBranslar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBranslar).BeginInit();
            grpDoktorlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoktorlar).BeginInit();
            SuspendLayout();
            // 
            // grpSekreterBilgi
            // 
            grpSekreterBilgi.Controls.Add(lblAdSoyad);
            grpSekreterBilgi.Controls.Add(lblAdSoyadBaslik);
            grpSekreterBilgi.Controls.Add(lblTC);
            grpSekreterBilgi.Controls.Add(lblTCBaslik);
            grpSekreterBilgi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpSekreterBilgi.ForeColor = Color.FromArgb(13, 59, 102);
            grpSekreterBilgi.Location = new Point(20, 20);
            grpSekreterBilgi.Name = "grpSekreterBilgi";
            grpSekreterBilgi.Size = new Size(300, 130);
            grpSekreterBilgi.TabIndex = 0;
            grpSekreterBilgi.TabStop = false;
            grpSekreterBilgi.Text = "Sekreter Bilgileri";
           
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAdSoyad.Location = new Point(150, 85);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(91, 23);
            lblAdSoyad.TabIndex = 3;
            lblAdSoyad.Text = "\"Null Null\"";
            // 
            // lblAdSoyadBaslik
            // 
            lblAdSoyadBaslik.AutoSize = true;
            lblAdSoyadBaslik.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdSoyadBaslik.Location = new Point(20, 85);
            lblAdSoyadBaslik.Name = "lblAdSoyadBaslik";
            lblAdSoyadBaslik.Size = new Size(97, 23);
            lblAdSoyadBaslik.TabIndex = 2;
            lblAdSoyadBaslik.Text = "Ad Soyad :";
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTC.Location = new Point(150, 45);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(109, 23);
            lblTC.TabIndex = 1;
            lblTC.Text = "00000000000";
            // 
            // lblTCBaslik
            // 
            lblTCBaslik.AutoSize = true;
            lblTCBaslik.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTCBaslik.Location = new Point(20, 45);
            lblTCBaslik.Name = "lblTCBaslik";
            lblTCBaslik.Size = new Size(125, 23);
            lblTCBaslik.TabIndex = 0;
            lblTCBaslik.Text = "TC Kimlik No :";
            // 
            // grpDuyuruOlustur
            // 
            grpDuyuruOlustur.Controls.Add(btnDuyuruOlustur);
            grpDuyuruOlustur.Controls.Add(rtbDuyuru);
            grpDuyuruOlustur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpDuyuruOlustur.ForeColor = Color.FromArgb(13, 59, 102);
            grpDuyuruOlustur.Location = new Point(20, 170);
            grpDuyuruOlustur.Name = "grpDuyuruOlustur";
            grpDuyuruOlustur.Size = new Size(300, 337);
            grpDuyuruOlustur.TabIndex = 1;
            grpDuyuruOlustur.TabStop = false;
            grpDuyuruOlustur.Text = "Duyuru Oluştur";
            // 
            // btnDuyuruOlustur
            // 
            btnDuyuruOlustur.BackColor = Color.FromArgb(31, 78, 121);
            btnDuyuruOlustur.Cursor = Cursors.Hand;
            btnDuyuruOlustur.FlatAppearance.BorderSize = 0;
            btnDuyuruOlustur.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            btnDuyuruOlustur.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            btnDuyuruOlustur.FlatStyle = FlatStyle.Flat;
            btnDuyuruOlustur.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDuyuruOlustur.ForeColor = Color.White;
            btnDuyuruOlustur.Location = new Point(20, 245);
            btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            btnDuyuruOlustur.Size = new Size(260, 45);
            btnDuyuruOlustur.TabIndex = 1;
            btnDuyuruOlustur.Text = "Oluştur";
            btnDuyuruOlustur.UseVisualStyleBackColor = false;
            btnDuyuruOlustur.Click += btnDuyuruOlustur_Click;
            // 
            // rtbDuyuru
            // 
            rtbDuyuru.BorderStyle = BorderStyle.FixedSingle;
            rtbDuyuru.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rtbDuyuru.Location = new Point(20, 40);
            rtbDuyuru.Name = "rtbDuyuru";
            rtbDuyuru.Size = new Size(260, 190);
            rtbDuyuru.TabIndex = 0;
            rtbDuyuru.Text = "";
            // 
            // grpHizliErisim
            // 
            grpHizliErisim.Controls.Add(Duyurular1);
            grpHizliErisim.Controls.Add(btnRandevuListe);
            grpHizliErisim.Controls.Add(btnBransPaneli);
            grpHizliErisim.Controls.Add(btnDoktorPaneli);
            grpHizliErisim.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpHizliErisim.ForeColor = Color.FromArgb(13, 59, 102);
            grpHizliErisim.Location = new Point(20, 500);
            grpHizliErisim.Name = "grpHizliErisim";
            grpHizliErisim.Size = new Size(620, 100);
            grpHizliErisim.TabIndex = 2;
            grpHizliErisim.TabStop = false;
            grpHizliErisim.Text = "Hızlı Erişim Paneli";
            // 
            // Duyurular1
            // 
            Duyurular1.BackColor = Color.FromArgb(31, 78, 121);
            Duyurular1.Cursor = Cursors.Hand;
            Duyurular1.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            Duyurular1.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            Duyurular1.FlatStyle = FlatStyle.Flat;
            Duyurular1.ForeColor = Color.White;
            Duyurular1.Location = new Point(459, 35);
            Duyurular1.Name = "Duyurular1";
            Duyurular1.Size = new Size(145, 45);
            Duyurular1.TabIndex = 3;
            Duyurular1.Text = "Duyurular";
            Duyurular1.UseVisualStyleBackColor = false;
            Duyurular1.Click += Duyurular1_Click;
            // 
            // btnRandevuListe
            // 
            btnRandevuListe.BackColor = Color.FromArgb(31, 78, 121);
            btnRandevuListe.Cursor = Cursors.Hand;
            btnRandevuListe.FlatAppearance.BorderSize = 0;
            btnRandevuListe.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            btnRandevuListe.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            btnRandevuListe.FlatStyle = FlatStyle.Flat;
            btnRandevuListe.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRandevuListe.ForeColor = Color.White;
            btnRandevuListe.Location = new Point(308, 35);
            btnRandevuListe.Name = "btnRandevuListe";
            btnRandevuListe.Size = new Size(145, 45);
            btnRandevuListe.TabIndex = 2;
            btnRandevuListe.Text = "Randevu Liste";
            btnRandevuListe.UseVisualStyleBackColor = false;
            btnRandevuListe.Click += btnRandevuListe_Click;
            // 
            // btnBransPaneli
            // 
            btnBransPaneli.BackColor = Color.FromArgb(31, 78, 121);
            btnBransPaneli.Cursor = Cursors.Hand;
            btnBransPaneli.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            btnBransPaneli.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            btnBransPaneli.FlatStyle = FlatStyle.Flat;
            btnBransPaneli.ForeColor = Color.White;
            btnBransPaneli.Location = new Point(157, 35);
            btnBransPaneli.Name = "btnBransPaneli";
            btnBransPaneli.Size = new Size(145, 45);
            btnBransPaneli.TabIndex = 1;
            btnBransPaneli.Text = "Poliklinik Paneli";
            btnBransPaneli.UseVisualStyleBackColor = false;
            btnBransPaneli.Click += btnBransPaneli_Click;
            // 
            // btnDoktorPaneli
            // 
            btnDoktorPaneli.BackColor = Color.FromArgb(31, 78, 121);
            btnDoktorPaneli.Cursor = Cursors.Hand;
            btnDoktorPaneli.FlatAppearance.BorderSize = 0;
            btnDoktorPaneli.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            btnDoktorPaneli.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            btnDoktorPaneli.FlatStyle = FlatStyle.Flat;
            btnDoktorPaneli.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDoktorPaneli.ForeColor = Color.White;
            btnDoktorPaneli.Location = new Point(6, 35);
            btnDoktorPaneli.Name = "btnDoktorPaneli";
            btnDoktorPaneli.Size = new Size(145, 45);
            btnDoktorPaneli.TabIndex = 0;
            btnDoktorPaneli.Text = "Doktor Paneli";
            btnDoktorPaneli.UseVisualStyleBackColor = false;
            btnDoktorPaneli.Click += btnDoktorPaneli_Click;
            // 
            // grpRandevuPaneli
            // 
            grpRandevuPaneli.Controls.Add(btnKaydet);
            grpRandevuPaneli.Controls.Add(chkDurum);
            grpRandevuPaneli.Controls.Add(mskTC);
            grpRandevuPaneli.Controls.Add(cmbDoktor);
            grpRandevuPaneli.Controls.Add(cmbBrans);
            grpRandevuPaneli.Controls.Add(mskSaat);
            grpRandevuPaneli.Controls.Add(mskTarih);
            grpRandevuPaneli.Controls.Add(txtId);
            grpRandevuPaneli.Controls.Add(lbl2TC);
            grpRandevuPaneli.Controls.Add(lblDoktor);
            grpRandevuPaneli.Controls.Add(lblBrans);
            grpRandevuPaneli.Controls.Add(lblSaat);
            grpRandevuPaneli.Controls.Add(lblTarih);
            grpRandevuPaneli.Controls.Add(lblId);
            grpRandevuPaneli.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpRandevuPaneli.ForeColor = Color.FromArgb(13, 59, 102);
            grpRandevuPaneli.Location = new Point(340, 20);
            grpRandevuPaneli.Name = "grpRandevuPaneli";
            grpRandevuPaneli.Size = new Size(300, 487);
            grpRandevuPaneli.TabIndex = 3;
            grpRandevuPaneli.TabStop = false;
            grpRandevuPaneli.Text = "Randevu Paneli";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(31, 78, 121);
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            btnKaydet.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(20, 379);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(260, 45);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // chkDurum
            // 
            chkDurum.AutoSize = true;
            chkDurum.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkDurum.Location = new Point(100, 320);
            chkDurum.Name = "chkDurum";
            chkDurum.Size = new Size(134, 27);
            chkDurum.TabIndex = 12;
            chkDurum.Text = "Durum (Aktif)";
            chkDurum.UseVisualStyleBackColor = true;
            // 
            // mskTC
            // 
            mskTC.BorderStyle = BorderStyle.FixedSingle;
            mskTC.Location = new Point(100, 270);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(190, 34);
            mskTC.TabIndex = 11;
            mskTC.ValidatingType = typeof(int);
            // 
            // cmbDoktor
            // 
            cmbDoktor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoktor.FlatStyle = FlatStyle.Flat;
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(100, 225);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(190, 36);
            cmbDoktor.TabIndex = 10;
            // 
            // cmbBrans
            // 
            cmbBrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrans.FlatStyle = FlatStyle.Flat;
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(100, 180);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(190, 36);
            cmbBrans.TabIndex = 9;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // mskSaat
            // 
            mskSaat.BorderStyle = BorderStyle.FixedSingle;
            mskSaat.Location = new Point(100, 135);
            mskSaat.Mask = "90:00";
            mskSaat.Name = "mskSaat";
            mskSaat.Size = new Size(190, 34);
            mskSaat.TabIndex = 8;
            mskSaat.ValidatingType = typeof(DateTime);
            // 
            // mskTarih
            // 
            mskTarih.BorderStyle = BorderStyle.FixedSingle;
            mskTarih.Location = new Point(100, 90);
            mskTarih.Mask = "00/00/0000";
            mskTarih.Name = "mskTarih";
            mskTarih.Size = new Size(190, 34);
            mskTarih.TabIndex = 7;
            mskTarih.ValidatingType = typeof(DateTime);
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 45);
            txtId.Name = "txtId";
            txtId.Size = new Size(190, 34);
            txtId.TabIndex = 6;
            // 
            // lbl2TC
            // 
            lbl2TC.AutoSize = true;
            lbl2TC.Location = new Point(0, 270);
            lbl2TC.Name = "lbl2TC";
            lbl2TC.Size = new Size(40, 28);
            lbl2TC.TabIndex = 5;
            lbl2TC.Text = "TC:";
            // 
            // lblDoktor
            // 
            lblDoktor.AutoSize = true;
            lblDoktor.Location = new Point(0, 225);
            lblDoktor.Name = "lblDoktor";
            lblDoktor.Size = new Size(84, 28);
            lblDoktor.TabIndex = 4;
            lblDoktor.Text = "Doktor:";
            // 
            // lblBrans
            // 
            lblBrans.AutoSize = true;
            lblBrans.Location = new Point(0, 180);
            lblBrans.Name = "lblBrans";
            lblBrans.Size = new Size(105, 28);
            lblBrans.TabIndex = 3;
            lblBrans.Text = "Poliklinik:";
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Location = new Point(0, 135);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(58, 28);
            lblSaat.TabIndex = 2;
            lblSaat.Text = "Saat:";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(0, 90);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(64, 28);
            lblTarih.TabIndex = 1;
            lblTarih.Text = "Tarih:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(0, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(35, 28);
            lblId.TabIndex = 0;
            lblId.Text = "id:";
            // 
            // grpBranslar
            // 
            grpBranslar.Controls.Add(dgvBranslar);
            grpBranslar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpBranslar.ForeColor = Color.FromArgb(13, 59, 102);
            grpBranslar.Location = new Point(660, 20);
            grpBranslar.Name = "grpBranslar";
            grpBranslar.Size = new Size(500, 280);
            grpBranslar.TabIndex = 4;
            grpBranslar.TabStop = false;
            grpBranslar.Text = "Poliklinikler";
            // 
            // dgvBranslar
            // 
            dgvBranslar.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 247, 250);
            dgvBranslar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBranslar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBranslar.BackgroundColor = Color.White;
            dgvBranslar.BorderStyle = BorderStyle.None;
            dgvBranslar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBranslar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 59, 102);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBranslar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBranslar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(13, 59, 102);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(31, 78, 121);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBranslar.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBranslar.Dock = DockStyle.Fill;
            dgvBranslar.EnableHeadersVisualStyles = false;
            dgvBranslar.Location = new Point(3, 30);
            dgvBranslar.Name = "dgvBranslar";
            dgvBranslar.ReadOnly = true;
            dgvBranslar.RowHeadersVisible = false;
            dgvBranslar.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dgvBranslar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvBranslar.RowTemplate.Height = 35;
            dgvBranslar.Size = new Size(494, 247);
            dgvBranslar.TabIndex = 0;
            // 
            // grpDoktorlar
            // 
            grpDoktorlar.Controls.Add(dgvDoktorlar);
            grpDoktorlar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpDoktorlar.ForeColor = Color.FromArgb(13, 59, 102);
            grpDoktorlar.Location = new Point(660, 320);
            grpDoktorlar.Name = "grpDoktorlar";
            grpDoktorlar.Size = new Size(500, 280);
            grpDoktorlar.TabIndex = 5;
            grpDoktorlar.TabStop = false;
            grpDoktorlar.Text = "Doktorlar";
            // 
            // dgvDoktorlar
            // 
            dgvDoktorlar.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(244, 247, 250);
            dgvDoktorlar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDoktorlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoktorlar.BackgroundColor = Color.White;
            dgvDoktorlar.BorderStyle = BorderStyle.None;
            dgvDoktorlar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDoktorlar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(13, 59, 102);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvDoktorlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvDoktorlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(13, 59, 102);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(31, 78, 121);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvDoktorlar.DefaultCellStyle = dataGridViewCellStyle7;
            dgvDoktorlar.Dock = DockStyle.Fill;
            dgvDoktorlar.EnableHeadersVisualStyles = false;
            dgvDoktorlar.Location = new Point(3, 30);
            dgvDoktorlar.Name = "dgvDoktorlar";
            dgvDoktorlar.ReadOnly = true;
            dgvDoktorlar.RowHeadersVisible = false;
            dgvDoktorlar.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dgvDoktorlar.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvDoktorlar.RowTemplate.Height = 35;
            dgvDoktorlar.Size = new Size(494, 247);
            dgvDoktorlar.TabIndex = 1;
            // 
            // FrmSekreterDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(1182, 653);
            Controls.Add(grpDoktorlar);
            Controls.Add(grpBranslar);
            Controls.Add(grpRandevuPaneli);
            Controls.Add(grpHizliErisim);
            Controls.Add(grpDuyuruOlustur);
            Controls.Add(grpSekreterBilgi);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmSekreterDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sekreter Kontrol Paneli";
            Load += FrmSekreterDetay_Load;
            grpSekreterBilgi.ResumeLayout(false);
            grpSekreterBilgi.PerformLayout();
            grpDuyuruOlustur.ResumeLayout(false);
            grpHizliErisim.ResumeLayout(false);
            grpRandevuPaneli.ResumeLayout(false);
            grpRandevuPaneli.PerformLayout();
            grpBranslar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBranslar).EndInit();
            grpDoktorlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDoktorlar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSekreterBilgi;
        private Label lblAdSoyad;
        private Label lblAdSoyadBaslik;
        private Label lblTC;
        private Label lblTCBaslik;
        private GroupBox grpDuyuruOlustur;
        private Button btnDuyuruOlustur;
        private RichTextBox rtbDuyuru;
        private GroupBox grpHizliErisim;
        private Button btnRandevuListe;
        private Button btnBransPaneli;
        private Button btnDoktorPaneli;
        private GroupBox grpRandevuPaneli;
        private Label lblId;
        private Label lbl2TC;
        private Label lblDoktor;
        private Label lblBrans;
        private Label lblSaat;
        private Label lblTarih;
        private ComboBox cmbDoktor;
        private ComboBox cmbBrans;
        private MaskedTextBox mskSaat;
        private MaskedTextBox mskTarih;
        private TextBox txtId;
        private Button btnKaydet;
        private CheckBox chkDurum;
        private MaskedTextBox mskTC;
        private GroupBox grpBranslar;
        private DataGridView dgvBranslar;
        private GroupBox grpDoktorlar;
        private DataGridView dgvDoktorlar;
        private Button Duyurular1;
    }
}