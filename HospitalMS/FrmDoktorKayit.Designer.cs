namespace HospitalMs
{
    partial class FrmDoktorKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorKayit));
            grpDoktorIslemleri = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            btnEkle = new Button();
            txtSifre = new TextBox();
            mskTC = new MaskedTextBox();
            cmbBrans = new ComboBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            lblSifre = new Label();
            lblTC = new Label();
            lblBrans = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            grpDoktorListesi = new GroupBox();
            dgvGecmis = new DataGridView();
            grpDoktorIslemleri.SuspendLayout();
            grpDoktorListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).BeginInit();
            SuspendLayout();
            // 
            // grpDoktorIslemleri
            // 
            grpDoktorIslemleri.Controls.Add(button2);
            grpDoktorIslemleri.Controls.Add(button1);
            grpDoktorIslemleri.Controls.Add(btnEkle);
            grpDoktorIslemleri.Controls.Add(txtSifre);
            grpDoktorIslemleri.Controls.Add(mskTC);
            grpDoktorIslemleri.Controls.Add(cmbBrans);
            grpDoktorIslemleri.Controls.Add(txtSoyad);
            grpDoktorIslemleri.Controls.Add(txtAd);
            grpDoktorIslemleri.Controls.Add(lblSifre);
            grpDoktorIslemleri.Controls.Add(lblTC);
            grpDoktorIslemleri.Controls.Add(lblBrans);
            grpDoktorIslemleri.Controls.Add(lblSoyad);
            grpDoktorIslemleri.Controls.Add(lblAd);
            grpDoktorIslemleri.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpDoktorIslemleri.ForeColor = Color.FromArgb(13, 59, 102);
            grpDoktorIslemleri.Location = new Point(20, 20);
            grpDoktorIslemleri.Name = "grpDoktorIslemleri";
            grpDoktorIslemleri.Size = new Size(300, 480);
            grpDoktorIslemleri.TabIndex = 0;
            grpDoktorIslemleri.TabStop = false;
            grpDoktorIslemleri.Text = "Doktor Bilgileri";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(31, 78, 121);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(20, 430);
            button2.Name = "button2";
            button2.Size = new Size(260, 40);
            button2.TabIndex = 14;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 78, 121);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(155, 380);
            button1.Name = "button1";
            button1.Size = new Size(125, 40);
            button1.TabIndex = 13;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(31, 78, 121);
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            btnEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(20, 380);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(125, 40);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(20, 325);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(260, 31);
            txtSifre.TabIndex = 9;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // mskTC
            // 
            mskTC.BorderStyle = BorderStyle.FixedSingle;
            mskTC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mskTC.Location = new Point(20, 260);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(260, 31);
            mskTC.TabIndex = 8;
            mskTC.ValidatingType = typeof(int);
            // 
            // cmbBrans
            // 
            cmbBrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrans.FlatStyle = FlatStyle.Flat;
            cmbBrans.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(20, 195);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(260, 33);
            cmbBrans.TabIndex = 7;
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(20, 130);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(260, 31);
            txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(20, 65);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(260, 31);
            txtAd.TabIndex = 5;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSifre.Location = new Point(20, 300);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(53, 23);
            lblSifre.TabIndex = 4;
            lblSifre.Text = "Şifre:";
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTC.Location = new Point(20, 235);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(120, 23);
            lblTC.TabIndex = 3;
            lblTC.Text = "TC Kimlik No:";
            // 
            // lblBrans
            // 
            lblBrans.AutoSize = true;
            lblBrans.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBrans.Location = new Point(20, 170);
            lblBrans.Name = "lblBrans";
            lblBrans.Size = new Size(111, 23);
            lblBrans.TabIndex = 2;
            lblBrans.Text = "Poliklinikler:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSoyad.Location = new Point(20, 105);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(64, 23);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAd.Location = new Point(20, 40);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(38, 23);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // grpDoktorListesi
            // 
            grpDoktorListesi.Controls.Add(dgvGecmis);
            grpDoktorListesi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpDoktorListesi.ForeColor = Color.FromArgb(13, 59, 102);
            grpDoktorListesi.Location = new Point(340, 20);
            grpDoktorListesi.Name = "grpDoktorListesi";
            grpDoktorListesi.Size = new Size(570, 480);
            grpDoktorListesi.TabIndex = 3;
            grpDoktorListesi.TabStop = false;
            grpDoktorListesi.Text = "Doktor Listesi";
            // 
            // dgvGecmis
            // 
            dgvGecmis.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 247, 250);
            dgvGecmis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGecmis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGecmis.BackgroundColor = Color.White;
            dgvGecmis.BorderStyle = BorderStyle.None;
            dgvGecmis.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGecmis.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 59, 102);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGecmis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGecmis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(13, 59, 102);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(31, 78, 121);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGecmis.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGecmis.Dock = DockStyle.Fill;
            dgvGecmis.EnableHeadersVisualStyles = false;
            dgvGecmis.Location = new Point(3, 30);
            dgvGecmis.Name = "dgvGecmis";
            dgvGecmis.ReadOnly = true;
            dgvGecmis.RowHeadersVisible = false;
            dgvGecmis.RowHeadersWidth = 51;
            dgvGecmis.RowTemplate.Height = 35;
            dgvGecmis.Size = new Size(564, 447);
            dgvGecmis.TabIndex = 0;
            dgvGecmis.CellDoubleClick += dgvGecmis_CellDoubleClick;
            // 
            // FrmDoktorKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(932, 533);
            Controls.Add(grpDoktorListesi);
            Controls.Add(grpDoktorIslemleri);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmDoktorKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Kayıt ve Yönetim Paneli";
            Load += FrmDoktorKayit_Load;
            grpDoktorIslemleri.ResumeLayout(false);
            grpDoktorIslemleri.PerformLayout();
            grpDoktorListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDoktorIslemleri;
        private Label lblSifre;
        private Label lblTC;
        private Label lblBrans;
        private Label lblSoyad;
        private Label lblAd;
        private Button btnEkle;
        private TextBox txtSifre;
        private MaskedTextBox mskTC;
        private ComboBox cmbBrans;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Button button2;
        private Button button1;
        private GroupBox grpDoktorListesi;
        private DataGridView dgvGecmis;
    }
}