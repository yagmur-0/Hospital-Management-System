namespace HospitalMs
{
    partial class FrmDuyurular
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuyurular));
            grpRandevuListesi = new GroupBox();
            dgvDuyuru = new DataGridView();
            grpRandevuListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDuyuru).BeginInit();
            SuspendLayout();
            // 
            // grpRandevuListesi
            // 
            grpRandevuListesi.Controls.Add(dgvDuyuru);
            grpRandevuListesi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpRandevuListesi.ForeColor = Color.FromArgb(13, 59, 102);
            grpRandevuListesi.Location = new Point(27, 8);
            grpRandevuListesi.Name = "grpRandevuListesi";
            grpRandevuListesi.Size = new Size(733, 437);
            grpRandevuListesi.TabIndex = 4;
            grpRandevuListesi.TabStop = false;
            grpRandevuListesi.Text = "Duyurular";
            
            // 
            // dgvDuyuru
            // 
            dgvDuyuru.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(244, 247, 250);
            dgvDuyuru.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDuyuru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDuyuru.BackgroundColor = Color.White;
            dgvDuyuru.BorderStyle = BorderStyle.None;
            dgvDuyuru.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDuyuru.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(13, 59, 102);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDuyuru.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDuyuru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(13, 59, 102);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(31, 78, 121);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDuyuru.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDuyuru.Dock = DockStyle.Fill;
            dgvDuyuru.EnableHeadersVisualStyles = false;
            dgvDuyuru.Location = new Point(3, 30);
            dgvDuyuru.Name = "dgvDuyuru";
            dgvDuyuru.ReadOnly = true;
            dgvDuyuru.RowHeadersVisible = false;
            dgvDuyuru.RowHeadersWidth = 51;
            dgvDuyuru.RowTemplate.Height = 35;
            dgvDuyuru.Size = new Size(727, 404);
            dgvDuyuru.TabIndex = 0;
            
            // 
            // FrmDuyurular
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(782, 453);
            Controls.Add(grpRandevuListesi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmDuyurular";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Duyurular";
            Load += FrmDuyurular_Load;
            grpRandevuListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDuyuru).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpRandevuListesi;
        private DataGridView dgvDuyuru;
    }
}