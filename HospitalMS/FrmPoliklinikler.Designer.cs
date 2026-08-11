namespace HospitalMs
{
    partial class FrmPoliklinikler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPoliklinikler));
            txtBransAd = new TextBox();
            txtBransId = new TextBox();
            lblBransAd = new Label();
            lblBransId = new Label();
            grpBransIslemleri = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            btnEkle = new Button();
            grpDoktorListesi = new GroupBox();
            dgvGecmis = new DataGridView();
            grpBransIslemleri.SuspendLayout();
            grpDoktorListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).BeginInit();
            SuspendLayout();
            // 
            // txtBransAd
            // 
            txtBransAd.BorderStyle = BorderStyle.FixedSingle;
            txtBransAd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBransAd.Location = new Point(20, 135);
            txtBransAd.Name = "txtBransAd";
            txtBransAd.Size = new Size(260, 31);
            txtBransAd.TabIndex = 10;
            // 
            // txtBransId
            // 
            txtBransId.BorderStyle = BorderStyle.FixedSingle;
            txtBransId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBransId.Location = new Point(20, 65);
            txtBransId.Name = "txtBransId";
            txtBransId.Size = new Size(260, 31);
            txtBransId.TabIndex = 9;
            // 
            // lblBransAd
            // 
            lblBransAd.AutoSize = true;
            lblBransAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBransAd.Location = new Point(20, 110);
            lblBransAd.Name = "lblBransAd";
            lblBransAd.Size = new Size(122, 23);
            lblBransAd.TabIndex = 8;
            lblBransAd.Text = "Poliklinik Adı:";
            // 
            // lblBransId
            // 
            lblBransId.AutoSize = true;
            lblBransId.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBransId.Location = new Point(20, 40);
            lblBransId.Name = "lblBransId";
            lblBransId.Size = new Size(110, 23);
            lblBransId.TabIndex = 7;
            lblBransId.Text = "Poliklinik id:";
            // 
            // grpBransIslemleri
            // 
            grpBransIslemleri.Controls.Add(button2);
            grpBransIslemleri.Controls.Add(button1);
            grpBransIslemleri.Controls.Add(btnEkle);
            grpBransIslemleri.Controls.Add(txtBransId);
            grpBransIslemleri.Controls.Add(txtBransAd);
            grpBransIslemleri.Controls.Add(lblBransId);
            grpBransIslemleri.Controls.Add(lblBransAd);
            grpBransIslemleri.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpBransIslemleri.ForeColor = Color.FromArgb(13, 59, 102);
            grpBransIslemleri.Location = new Point(20, 20);
            grpBransIslemleri.Name = "grpBransIslemleri";
            grpBransIslemleri.Size = new Size(300, 320);
            grpBransIslemleri.TabIndex = 11;
            grpBransIslemleri.TabStop = false;
            grpBransIslemleri.Text = "Poliklinik Bilgileri";
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
            button2.Location = new Point(17, 242);
            button2.Name = "button2";
            button2.Size = new Size(260, 40);
            button2.TabIndex = 17;
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
            button1.Location = new Point(152, 192);
            button1.Name = "button1";
            button1.Size = new Size(125, 40);
            button1.TabIndex = 16;
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
            btnEkle.Location = new Point(17, 192);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(125, 40);
            btnEkle.TabIndex = 15;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // grpDoktorListesi
            // 
            grpDoktorListesi.Controls.Add(dgvGecmis);
            grpDoktorListesi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpDoktorListesi.ForeColor = Color.FromArgb(13, 59, 102);
            grpDoktorListesi.Location = new Point(340, 20);
            grpDoktorListesi.Name = "grpDoktorListesi";
            grpDoktorListesi.Size = new Size(470, 320);
            grpDoktorListesi.TabIndex = 12;
            grpDoktorListesi.TabStop = false;
            grpDoktorListesi.Text = "Poliklinikler Listesi";
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
            dgvGecmis.Size = new Size(464, 287);
            dgvGecmis.TabIndex = 0;
            dgvGecmis.CellDoubleClick += dgvGecmis_CellDoubleClick;
            // 
            // FrmPoliklinikler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(832, 373);
            Controls.Add(grpDoktorListesi);
            Controls.Add(grpBransIslemleri);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmPoliklinikler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poliklinikler Yönetim Paneli";
            Load += FrmPoliklinikler_Load;
            grpBransIslemleri.ResumeLayout(false);
            grpBransIslemleri.PerformLayout();
            grpDoktorListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBransAd;
        private TextBox txtBransId;
        private Label lblBransAd;
        private Label lblBransId;
        private GroupBox grpBransIslemleri;
        private Button button2;
        private Button button1;
        private Button btnEkle;
        private GroupBox grpDoktorListesi;
        private DataGridView dgvGecmis;
    }
}