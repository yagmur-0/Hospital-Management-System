namespace HospitalMs
{
    partial class FrmGirisler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            panelSol = new Panel();
            pictureBox1 = new PictureBox();
            lblHastaneAdi = new Label();
            lblBaslik = new Label();
            lblTCKimlikNo = new Label();
            label1 = new Label();
            label2 = new Label();
            mskTC = new MaskedTextBox();
            txtSifre = new TextBox();
            button1 = new Button();
            lnkUyeOl = new LinkLabel();
            panelSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSol
            // 
            panelSol.BackColor = Color.FromArgb(13, 59, 102);
            panelSol.Controls.Add(pictureBox1);
            panelSol.Controls.Add(lblHastaneAdi);
            panelSol.Dock = DockStyle.Left;
            panelSol.Location = new Point(0, 0);
            panelSol.Name = "panelSol";
            panelSol.Size = new Size(338, 463);
            panelSol.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-22, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 360);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblHastaneAdi
            // 
            lblHastaneAdi.BackColor = Color.FromArgb(13, 59, 102);
            lblHastaneAdi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHastaneAdi.ForeColor = Color.White;
            lblHastaneAdi.Location = new Point(12, 50);
            lblHastaneAdi.Name = "lblHastaneAdi";
            lblHastaneAdi.Size = new Size(300, 132);
            lblHastaneAdi.TabIndex = 0;
            lblHastaneAdi.Text = "HASTANE YÖNETİM SİSTEMİ";
            lblHastaneAdi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.FromArgb(13, 59, 102);
            lblBaslik.Location = new Point(400, 70);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(220, 41);
            lblBaslik.TabIndex = 1;
            lblBaslik.Text = "Kullanıcı Girişi";
            // 
            // lblTCKimlikNo
            // 
            lblTCKimlikNo.AutoSize = true;
            lblTCKimlikNo.ForeColor = Color.FromArgb(13, 59, 102);
            lblTCKimlikNo.Location = new Point(400, 150);
            lblTCKimlikNo.Name = "lblTCKimlikNo";
            lblTCKimlikNo.Size = new Size(116, 23);
            lblTCKimlikNo.TabIndex = 2;
            lblTCKimlikNo.Text = "TC Kimlik No :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(13, 59, 102);
            label1.Location = new Point(400, 225);
            label1.Name = "label1";
            label1.Size = new Size(47, 23);
            label1.TabIndex = 3;
            label1.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(578, 254);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // mskTC
            // 
            mskTC.BorderStyle = BorderStyle.FixedSingle;
            mskTC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mskTC.Location = new Point(400, 175);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.PromptChar = ' ';
            mskTC.Size = new Size(300, 31);
            mskTC.TabIndex = 5;
            mskTC.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(400, 250);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(300, 31);
            txtSifre.TabIndex = 6;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 78, 121);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 37, 68);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 59, 102);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(400, 301);
            button1.Name = "button1";
            button1.Size = new Size(300, 45);
            button1.TabIndex = 7;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lnkUyeOl
            // 
            lnkUyeOl.ActiveLinkColor = Color.FromArgb(13, 59, 102);
            lnkUyeOl.LinkBehavior = LinkBehavior.NeverUnderline;
            lnkUyeOl.LinkColor = Color.FromArgb(31, 78, 121);
            lnkUyeOl.Location = new Point(400, 355);
            lnkUyeOl.Name = "lnkUyeOl";
            lnkUyeOl.Size = new Size(300, 25);
            lnkUyeOl.TabIndex = 9;
            lnkUyeOl.TabStop = true;
            lnkUyeOl.Text = "Hesabınız yok mu? Üye Ol";
            lnkUyeOl.TextAlign = ContentAlignment.MiddleCenter;
            lnkUyeOl.LinkClicked += lnkUyeOl_LinkClicked;
            // 
            // FrmGirisler
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(880, 463);
            Controls.Add(lnkUyeOl);
            Controls.Add(button1);
            Controls.Add(txtSifre);
            Controls.Add(mskTC);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTCKimlikNo);
            Controls.Add(lblBaslik);
            Controls.Add(panelSol);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmGirisler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hastane Yönetim Sistemi";
            panelSol.ResumeLayout(false);
            panelSol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSol;
        private Label lblHastaneAdi;
        private Label lblBaslik;
        private Label lblTCKimlikNo;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private MaskedTextBox mskTC;
        private TextBox txtSifre;
        private Button button1;
        private LinkLabel lnkUyeOl;
    }
}
