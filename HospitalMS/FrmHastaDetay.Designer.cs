namespace HospitalMs
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            grpKisiBilgi = new GroupBox();
            lblAdSoyad = new Label();
            lblAdSoyadBaslik = new Label();
            llblTC = new Label();
            lblTCBaslik = new Label();
            grpRandevuPaneli = new GroupBox();
            lnkBilgiDuzenle = new LinkLabel();
            btnRandevuAl = new Button();
            rtbSikayet = new RichTextBox();
            cmbDoktor = new ComboBox();
            cmbBrans = new ComboBox();
            lblSikayet = new Label();
            lblDoktor = new Label();
            lblBrans = new Label();
            grpGecmis = new GroupBox();
            dgvGecmis = new DataGridView();
            grpAktif = new GroupBox();
            dgvAktif = new DataGridView();
            grpKisiBilgi.SuspendLayout();
            grpRandevuPaneli.SuspendLayout();
            grpGecmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).BeginInit();
            grpAktif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAktif).BeginInit();
            SuspendLayout();
            // 
            // grpKisiBilgi
            // 
            grpKisiBilgi.Controls.Add(lblAdSoyad);
            grpKisiBilgi.Controls.Add(lblAdSoyadBaslik);
            grpKisiBilgi.Controls.Add(llblTC);
            grpKisiBilgi.Controls.Add(lblTCBaslik);
            grpKisiBilgi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpKisiBilgi.Location = new Point(20, 20);
            grpKisiBilgi.Name = "grpKisiBilgi";
            grpKisiBilgi.Size = new Size(300, 150);
            grpKisiBilgi.TabIndex = 0;
            grpKisiBilgi.TabStop = false;
            grpKisiBilgi.Text = "Kişi Bilgileri";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAdSoyad.Location = new Point(140, 90);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(91, 23);
            lblAdSoyad.TabIndex = 3;
            lblAdSoyad.Text = "\"Null Null\"";
            // 
            // lblAdSoyadBaslik
            // 
            lblAdSoyadBaslik.AutoSize = true;
            lblAdSoyadBaslik.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdSoyadBaslik.Location = new Point(20, 90);
            lblAdSoyadBaslik.Name = "lblAdSoyadBaslik";
            lblAdSoyadBaslik.Size = new Size(97, 23);
            lblAdSoyadBaslik.TabIndex = 2;
            lblAdSoyadBaslik.Text = "Ad Soyad :";
            // 
            // llblTC
            // 
            llblTC.AutoSize = true;
            llblTC.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            llblTC.Location = new Point(140, 50);
            llblTC.Name = "llblTC";
            llblTC.Size = new Size(109, 23);
            llblTC.TabIndex = 1;
            llblTC.Text = "00000000000";
            // 
            // lblTCBaslik
            // 
            lblTCBaslik.AutoSize = true;
            lblTCBaslik.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTCBaslik.Location = new Point(20, 50);
            lblTCBaslik.Name = "lblTCBaslik";
            lblTCBaslik.Size = new Size(125, 23);
            lblTCBaslik.TabIndex = 0;
            lblTCBaslik.Text = "TC Kimlik No :";
            // 
            // grpRandevuPaneli
            // 
            grpRandevuPaneli.Controls.Add(lnkBilgiDuzenle);
            grpRandevuPaneli.Controls.Add(btnRandevuAl);
            grpRandevuPaneli.Controls.Add(rtbSikayet);
            grpRandevuPaneli.Controls.Add(cmbDoktor);
            grpRandevuPaneli.Controls.Add(cmbBrans);
            grpRandevuPaneli.Controls.Add(lblSikayet);
            grpRandevuPaneli.Controls.Add(lblDoktor);
            grpRandevuPaneli.Controls.Add(lblBrans);
            grpRandevuPaneli.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpRandevuPaneli.ForeColor = Color.FromArgb(13, 59, 102);
            grpRandevuPaneli.Location = new Point(20, 190);
            grpRandevuPaneli.Name = "grpRandevuPaneli";
            grpRandevuPaneli.Size = new Size(300, 451);
            grpRandevuPaneli.TabIndex = 1;
            grpRandevuPaneli.TabStop = false;
            grpRandevuPaneli.Text = "Randevu Paneli";
            // 
            // lnkBilgiDuzenle
            // 
            lnkBilgiDuzenle.ActiveLinkColor = Color.FromArgb(13, 59, 102);
            lnkBilgiDuzenle.AutoSize = true;
            lnkBilgiDuzenle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lnkBilgiDuzenle.LinkBehavior = LinkBehavior.NeverUnderline;
            lnkBilgiDuzenle.LinkColor = Color.FromArgb(31, 78, 121);
            lnkBilgiDuzenle.Location = new Point(20, 400);
            lnkBilgiDuzenle.Name = "lnkBilgiDuzenle";
            lnkBilgiDuzenle.Size = new Size(157, 23);
            lnkBilgiDuzenle.TabIndex = 7;
            lnkBilgiDuzenle.TabStop = true;
            lnkBilgiDuzenle.Text = "Bilgilerini Düzenle";
            lnkBilgiDuzenle.LinkClicked += lnkBilgiDuzenle_LinkClicked;
            // 
            // btnRandevuAl
            // 
            btnRandevuAl.BackColor = Color.FromArgb(31, 78, 121);
            btnRandevuAl.Cursor = Cursors.Hand;
            btnRandevuAl.FlatAppearance.BorderSize = 0;
            btnRandevuAl.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 78, 121);
            btnRandevuAl.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            btnRandevuAl.FlatStyle = FlatStyle.Flat;
            btnRandevuAl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRandevuAl.ForeColor = Color.White;
            btnRandevuAl.Location = new Point(20, 355);
            btnRandevuAl.Name = "btnRandevuAl";
            btnRandevuAl.Size = new Size(250, 40);
            btnRandevuAl.TabIndex = 6;
            btnRandevuAl.Text = "Randevu Al";
            btnRandevuAl.UseVisualStyleBackColor = false;
            btnRandevuAl.Click += btnRandevuAl_Click;
            // 
            // rtbSikayet
            // 
            rtbSikayet.BorderStyle = BorderStyle.FixedSingle;
            rtbSikayet.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rtbSikayet.Location = new Point(20, 215);
            rtbSikayet.Name = "rtbSikayet";
            rtbSikayet.Size = new Size(250, 120);
            rtbSikayet.TabIndex = 5;
            rtbSikayet.Text = "";
            // 
            // cmbDoktor
            // 
            cmbDoktor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoktor.FlatStyle = FlatStyle.Flat;
            cmbDoktor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(20, 145);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(250, 31);
            cmbDoktor.TabIndex = 4;
            cmbDoktor.SelectedIndexChanged += cmbDoktor_SelectedIndexChanged;
            // 
            // cmbBrans
            // 
            cmbBrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrans.FlatStyle = FlatStyle.Flat;
            cmbBrans.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(20, 75);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(250, 31);
            cmbBrans.TabIndex = 3;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // lblSikayet
            // 
            lblSikayet.AutoSize = true;
            lblSikayet.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSikayet.Location = new Point(20, 190);
            lblSikayet.Name = "lblSikayet";
            lblSikayet.Size = new Size(67, 23);
            lblSikayet.TabIndex = 2;
            lblSikayet.Text = "Şikayet:";
            // 
            // lblDoktor
            // 
            lblDoktor.AutoSize = true;
            lblDoktor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDoktor.Location = new Point(20, 120);
            lblDoktor.Name = "lblDoktor";
            lblDoktor.Size = new Size(66, 23);
            lblDoktor.TabIndex = 1;
            lblDoktor.Text = "Doktor:";
            // 
            // lblBrans
            // 
            lblBrans.AutoSize = true;
            lblBrans.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBrans.Location = new Point(20, 50);
            lblBrans.Name = "lblBrans";
            lblBrans.Size = new Size(79, 23);
            lblBrans.TabIndex = 0;
            lblBrans.Text = "Poliklinik:";
            // 
            // grpGecmis
            // 
            grpGecmis.Controls.Add(dgvGecmis);
            grpGecmis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpGecmis.ForeColor = Color.FromArgb(13, 59, 102);
            grpGecmis.Location = new Point(340, 20);
            grpGecmis.Name = "grpGecmis";
            grpGecmis.Size = new Size(670, 300);
            grpGecmis.TabIndex = 2;
            grpGecmis.TabStop = false;
            grpGecmis.Text = "Randevu Geçmişi";
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
            dgvGecmis.Size = new Size(664, 267);
            dgvGecmis.TabIndex = 0;
            // 
            // grpAktif
            // 
            grpAktif.Controls.Add(dgvAktif);
            grpAktif.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpAktif.ForeColor = Color.FromArgb(13, 59, 102);
            grpAktif.Location = new Point(340, 340);
            grpAktif.Name = "grpAktif";
            grpAktif.Size = new Size(670, 310);
            grpAktif.TabIndex = 3;
            grpAktif.TabStop = false;
            grpAktif.Text = "Müsait Randevu Saatleri";
            // 
            // dgvAktif
            // 
            dgvAktif.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(244, 247, 250);
            dgvAktif.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvAktif.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAktif.BackgroundColor = Color.White;
            dgvAktif.BorderStyle = BorderStyle.None;
            dgvAktif.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(13, 59, 102);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAktif.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAktif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(13, 59, 102);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(31, 78, 121);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvAktif.DefaultCellStyle = dataGridViewCellStyle6;
            dgvAktif.Dock = DockStyle.Fill;
            dgvAktif.EnableHeadersVisualStyles = false;
            dgvAktif.Location = new Point(3, 30);
            dgvAktif.Name = "dgvAktif";
            dgvAktif.ReadOnly = true;
            dgvAktif.RowHeadersVisible = false;
            dgvAktif.RowHeadersWidth = 51;
            dgvAktif.RowTemplate.Height = 35;
            dgvAktif.Size = new Size(664, 277);
            dgvAktif.TabIndex = 0;
            // 
            // FrmHastaDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(1032, 653);
            Controls.Add(grpAktif);
            Controls.Add(grpGecmis);
            Controls.Add(grpRandevuPaneli);
            Controls.Add(grpKisiBilgi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmHastaDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Paneli";
            Load += FrmHastaDetay_Load;
            grpKisiBilgi.ResumeLayout(false);
            grpKisiBilgi.PerformLayout();
            grpRandevuPaneli.ResumeLayout(false);
            grpRandevuPaneli.PerformLayout();
            grpGecmis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).EndInit();
            grpAktif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAktif).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpKisiBilgi;
        private Label lblAdSoyad;
        private Label lblAdSoyadBaslik;
        private Label llblTC;
        private Label lblTCBaslik;
        private GroupBox grpRandevuPaneli;
        private LinkLabel lnkBilgiDuzenle;
        private Button btnRandevuAl;
        private RichTextBox rtbSikayet;
        private ComboBox cmbDoktor;
        private ComboBox cmbBrans;
        private Label lblSikayet;
        private Label lblDoktor;
        private Label lblBrans;
        private GroupBox grpGecmis;
        private GroupBox grpAktif;
        private DataGridView dgvGecmis;
        private DataGridView dgvAktif;
    }
}