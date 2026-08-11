namespace HospitalMs
{
    partial class FrmRandevuListesi1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevuListesi1));
            grpGecmis = new GroupBox();
            dgvGecmis = new DataGridView();
            grpGecmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).BeginInit();
            SuspendLayout();
            // 
            // grpGecmis
            // 
            grpGecmis.Controls.Add(dgvGecmis);
            grpGecmis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpGecmis.ForeColor = Color.FromArgb(13, 59, 102);
            grpGecmis.Location = new Point(34, 27);
            grpGecmis.Name = "grpGecmis";
            grpGecmis.Size = new Size(900, 500);
            grpGecmis.TabIndex = 3;
            grpGecmis.TabStop = false;
            grpGecmis.Text = "Tüm Randevular Listesi";
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
            dgvGecmis.Size = new Size(894, 467);
            dgvGecmis.TabIndex = 0;
            dgvGecmis.CellDoubleClick += dgvGecmis_CellDoubleClick;
            // 
            // FrmRandevuListesi1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(982, 553);
            Controls.Add(grpGecmis);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmRandevuListesi1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tüm Randevular Listesi";
            Load += FrmRandevuListesi1_Load;
            grpGecmis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpGecmis;
        private DataGridView dgvGecmis;
    }
}