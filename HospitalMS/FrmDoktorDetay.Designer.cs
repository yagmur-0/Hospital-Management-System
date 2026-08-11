namespace HospitalMs
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            grpDoktorBilgi = new GroupBox();
            lblAdSoyad = new Label();
            lblAdSoyadBaslik = new Label();
            lblTC = new Label();
            lblTCBaslik = new Label();
            grpRandevuDetay = new GroupBox();
            rtbRandevuDetay = new RichTextBox();
            grpHizliErisim = new GroupBox();
            btnCikis = new Button();
            btnDuyurular = new Button();
            btnBilgiDuzenle = new Button();
            grpRandevuListesi = new GroupBox();
            dgvRandevuListesi = new DataGridView();
            grpDoktorBilgi.SuspendLayout();
            grpRandevuDetay.SuspendLayout();
            grpHizliErisim.SuspendLayout();
            grpRandevuListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRandevuListesi).BeginInit();
            SuspendLayout();
            // 
            // grpDoktorBilgi
            // 
            grpDoktorBilgi.Controls.Add(lblAdSoyad);
            grpDoktorBilgi.Controls.Add(lblAdSoyadBaslik);
            grpDoktorBilgi.Controls.Add(lblTC);
            grpDoktorBilgi.Controls.Add(lblTCBaslik);
            grpDoktorBilgi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpDoktorBilgi.ForeColor = Color.FromArgb(13, 59, 102);
            grpDoktorBilgi.Location = new Point(20, 20);
            grpDoktorBilgi.Name = "grpDoktorBilgi";
            grpDoktorBilgi.Size = new Size(300, 130);
            grpDoktorBilgi.TabIndex = 0;
            grpDoktorBilgi.TabStop = false;
            grpDoktorBilgi.Text = "Doktor Bilgileri";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAdSoyad.Location = new Point(142, 85);
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
            lblTC.Location = new Point(142, 45);
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
            // grpRandevuDetay
            // 
            grpRandevuDetay.Controls.Add(rtbRandevuDetay);
            grpRandevuDetay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpRandevuDetay.ForeColor = Color.FromArgb(13, 59, 102);
            grpRandevuDetay.Location = new Point(20, 160);
            grpRandevuDetay.Name = "grpRandevuDetay";
            grpRandevuDetay.Size = new Size(300, 310);
            grpRandevuDetay.TabIndex = 1;
            grpRandevuDetay.TabStop = false;
            grpRandevuDetay.Text = "Randevu Detayı (Şikayet)";
            // 
            // rtbRandevuDetay
            // 
            rtbRandevuDetay.BorderStyle = BorderStyle.FixedSingle;
            rtbRandevuDetay.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rtbRandevuDetay.Location = new Point(20, 40);
            rtbRandevuDetay.Name = "rtbRandevuDetay";
            rtbRandevuDetay.Size = new Size(260, 250);
            rtbRandevuDetay.TabIndex = 0;
            rtbRandevuDetay.Text = "";
            rtbRandevuDetay.TextChanged += richTextBox1_TextChanged;
            // 
            // grpHizliErisim
            // 
            grpHizliErisim.Controls.Add(btnCikis);
            grpHizliErisim.Controls.Add(btnDuyurular);
            grpHizliErisim.Controls.Add(btnBilgiDuzenle);
            grpHizliErisim.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpHizliErisim.ForeColor = Color.FromArgb(13, 59, 102);
            grpHizliErisim.Location = new Point(20, 480);
            grpHizliErisim.Name = "grpHizliErisim";
            grpHizliErisim.Size = new Size(300, 160);
            grpHizliErisim.TabIndex = 2;
            grpHizliErisim.TabStop = false;
            grpHizliErisim.Text = "Hızlı Erişim";
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(31, 78, 121);
            btnCikis.Cursor = Cursors.Hand;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            btnCikis.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(20, 100);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(265, 45);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += button4_Click;
            // 
            // btnDuyurular
            // 
            btnDuyurular.BackColor = Color.FromArgb(31, 78, 121);
            btnDuyurular.Cursor = Cursors.Hand;
            btnDuyurular.FlatAppearance.BorderSize = 0;
            btnDuyurular.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            btnDuyurular.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            btnDuyurular.FlatStyle = FlatStyle.Flat;
            btnDuyurular.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDuyurular.ForeColor = Color.White;
            btnDuyurular.Location = new Point(155, 40);
            btnDuyurular.Name = "btnDuyurular";
            btnDuyurular.Size = new Size(130, 45);
            btnDuyurular.TabIndex = 1;
            btnDuyurular.Text = "Duyurular";
            btnDuyurular.UseVisualStyleBackColor = false;
            btnDuyurular.Click += btnDuyurular_Click;
            // 
            // btnBilgiDuzenle
            // 
            btnBilgiDuzenle.BackColor = Color.FromArgb(31, 78, 121);
            btnBilgiDuzenle.Cursor = Cursors.Hand;
            btnBilgiDuzenle.FlatAppearance.BorderSize = 0;
            btnBilgiDuzenle.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            btnBilgiDuzenle.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            btnBilgiDuzenle.FlatStyle = FlatStyle.Flat;
            btnBilgiDuzenle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBilgiDuzenle.ForeColor = Color.White;
            btnBilgiDuzenle.Location = new Point(15, 40);
            btnBilgiDuzenle.Name = "btnBilgiDuzenle";
            btnBilgiDuzenle.Size = new Size(130, 45);
            btnBilgiDuzenle.TabIndex = 0;
            btnBilgiDuzenle.Text = "Bilgi Düzenle";
            btnBilgiDuzenle.UseVisualStyleBackColor = false;
            btnBilgiDuzenle.Click += btnBilgiDuzenle_Click;
            // 
            // grpRandevuListesi
            // 
            grpRandevuListesi.Controls.Add(dgvRandevuListesi);
            grpRandevuListesi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpRandevuListesi.ForeColor = Color.FromArgb(13, 59, 102);
            grpRandevuListesi.Location = new Point(340, 20);
            grpRandevuListesi.Name = "grpRandevuListesi";
            grpRandevuListesi.Size = new Size(670, 620);
            grpRandevuListesi.TabIndex = 3;
            grpRandevuListesi.TabStop = false;
            grpRandevuListesi.Text = "Randevu Listesi";
            // 
            // dgvRandevuListesi
            // 
            dgvRandevuListesi.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 247, 250);
            dgvRandevuListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRandevuListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRandevuListesi.BackgroundColor = Color.White;
            dgvRandevuListesi.BorderStyle = BorderStyle.None;
            dgvRandevuListesi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRandevuListesi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 59, 102);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRandevuListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRandevuListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(13, 59, 102);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(31, 78, 121);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRandevuListesi.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRandevuListesi.Dock = DockStyle.Fill;
            dgvRandevuListesi.EnableHeadersVisualStyles = false;
            dgvRandevuListesi.Location = new Point(3, 30);
            dgvRandevuListesi.Name = "dgvRandevuListesi";
            dgvRandevuListesi.ReadOnly = true;
            dgvRandevuListesi.RowHeadersVisible = false;
            dgvRandevuListesi.RowHeadersWidth = 51;
            dgvRandevuListesi.RowTemplate.Height = 35;
            dgvRandevuListesi.Size = new Size(664, 587);
            dgvRandevuListesi.TabIndex = 0;
            dgvRandevuListesi.CellDoubleClick += dgvRandevuListesi_CellDoubleClick;
            // 
            // FrmDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(1032, 653);
            Controls.Add(grpRandevuListesi);
            Controls.Add(grpHizliErisim);
            Controls.Add(grpRandevuDetay);
            Controls.Add(grpDoktorBilgi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmDoktorDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Paneli";
            Load += FrmDoktorDetay_Load;
            grpDoktorBilgi.ResumeLayout(false);
            grpDoktorBilgi.PerformLayout();
            grpRandevuDetay.ResumeLayout(false);
            grpHizliErisim.ResumeLayout(false);
            grpRandevuListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRandevuListesi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDoktorBilgi;
        private GroupBox grpRandevuDetay;
        private GroupBox grpHizliErisim;
        private Label lblAdSoyad;
        private Label lblAdSoyadBaslik;
        private Label lblTC;
        private Label lblTCBaslik;
        private RichTextBox rtbRandevuDetay;
        private GroupBox grpRandevuListesi;
        private Button btnCikis;
        private Button btnDuyurular;
        private Button btnBilgiDuzenle;
        private DataGridView dgvRandevuListesi;
    }
}