using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalMs
{
    public partial class FrmRandevuListesi1 : Form
    {
        public FrmRandevuListesi1()
        {
            InitializeComponent();
        }

        private void dgvGecmis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmRandevuListesi1_Load(object sender, EventArgs e)
        {
            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifBgl = bgl.baglanti();
            try
            {
                string sorgu = @"SELECT
                               R.RandevuID AS [Randevu No], 
                               R.RandevuTarihi AS [Tarih], 
                               R.RandevuSaati AS [Saat], 
                               P.BolumAdi AS [Poliklinik], 
                               (K.Ad + ' ' + K.Soyad) AS [Doktor Adı Soyadı], 
                               KH.TCKimlik AS [Hasta TC], 
                               R.Durum AS [Aktif Mi]
                               FROM Randevular R
                               INNER JOIN Doktorlar D ON R.DoktorID = D.DoktorID
                               INNER JOIN Kullanicilar K ON D.KullaniciID = K.KullaniciID
                               INNER JOIN Poliklinikler P ON D.PoliklinikID = P.PoliklinikID
                               LEFT JOIN Kullanicilar KH ON R.HastaID = KH.KullaniciID";
                         

                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, aktifBgl);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvGecmis.DataSource = dt;


            }
            catch (Exception hata)
            {
                MessageBox.Show("Randevular listelenirken hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                aktifBgl.Close();
            }


        }

        private void dgvGecmis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvGecmis.SelectedCells[0].RowIndex;

            FrmSekreterDetay frmSekreter = (FrmSekreterDetay)Application.OpenForms["FrmSekreterDetay"];

            if (frmSekreter != null)
            {

                string secilenId = dgvGecmis.Rows[secilen].Cells[0].Value.ToString();
                string secilenTarih = dgvGecmis.Rows[secilen].Cells[1].Value.ToString();
                string secilenSaat = dgvGecmis.Rows[secilen].Cells[2].Value.ToString();
                string secilenPoliklinik = dgvGecmis.Rows[secilen].Cells[3].Value.ToString();
                string secilenDoktor = dgvGecmis.Rows[secilen].Cells[4].Value.ToString();
                string secilenTc = dgvGecmis.Rows[secilen].Cells[5].Value.ToString();
                frmSekreter.RandevuBilgileriniDoldur(secilenId, secilenTarih, secilenSaat, secilenPoliklinik, secilenDoktor, secilenTc);
                this.Close();
            }
        }
    }
}
