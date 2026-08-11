using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalMs
{
    public partial class FrmDoktorKayit : Form
    {
        string secilenKullaniciID = "";
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        public FrmDoktorKayit()
        {
            InitializeComponent();
        }

        private void FrmDoktorKayit_Load(object sender, EventArgs e)
        {
            PoliklinikleriGetir();
            DoktorListesiniGetir(); 
        }

        private void PoliklinikleriGetir()
        {
            SqlConnection aktifBgl = bgl.baglanti();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT PoliklinikID, BolumAdi FROM Poliklinikler WHERE AktifMi=1 ORDER BY BolumAdi", aktifBgl);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBrans.DisplayMember = "BolumAdi";
                cmbBrans.ValueMember = "PoliklinikID";
                cmbBrans.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Poliklinikler yüklenirken hata: " + ex.Message); }
            finally { aktifBgl.Close(); }
        }

        private void DoktorListesiniGetir()
        {
            SqlConnection aktifBgl = bgl.baglanti();
            try
            {
                
                string sorgu = "SELECT K.KullaniciID, K.Ad AS [Doktor Adı], K.Soyad AS [Doktor Soyadı], K.TCKimlik AS [TC Kimlik No], P.BolumAdi AS [Poliklinik] " +
                               "FROM Kullanicilar K " +
                               "INNER JOIN Doktorlar D ON K.KullaniciID = D.KullaniciID " +
                               "INNER JOIN Poliklinikler P ON D.PoliklinikID = P.PoliklinikID";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, aktifBgl);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGecmis.DataSource = dt;
                dgvGecmis.Columns["KullaniciID"].Visible = false; 
            }
            catch (Exception ex) { MessageBox.Show("Doktorlar yüklenirken hata: " + ex.Message); }
            finally { aktifBgl.Close(); }
        }

       
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Zorunlu alanları boş bırakmayın!"); return;
            }

            SqlConnection aktifBgl = bgl.baglanti();
            try
            {

                string sorguKullanici = "INSERT INTO Kullanicilar (TCKimlik, Sifre, Ad, Soyad, RolId) VALUES (@TC, @sifre, @ad, @soyad, 2); SELECT SCOPE_IDENTITY();";
                SqlCommand komut = new SqlCommand(sorguKullanici, aktifBgl);
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@TC", mskTC.Text);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);

                int yeniKullaniciID = Convert.ToInt32(komut.ExecuteScalar());

                string sorguDoktor = "INSERT INTO Doktorlar (KullaniciID, PoliklinikID) VALUES (@kullID, @polID)";
                SqlCommand komutDoktor = new SqlCommand(sorguDoktor, aktifBgl);
                komutDoktor.Parameters.AddWithValue("@kullID", yeniKullaniciID);
                komutDoktor.Parameters.AddWithValue("@polID", cmbBrans.SelectedValue);
                komutDoktor.ExecuteNonQuery();

                MessageBox.Show("Doktor eklendi.");
                DoktorListesiniGetir(); 
                Temizle();
            }
            catch (Exception ex) { MessageBox.Show("Ekleme Hatası: " + ex.Message); }
            finally { aktifBgl.Close(); }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (secilenKullaniciID == "") { MessageBox.Show("Tablodan silinecek doktoru seçin!"); return; }

            DialogResult cevap = MessageBox.Show("Doktoru silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.No) return;

            SqlConnection aktifBgl = bgl.baglanti();
            try
            {
               
                SqlCommand komutSilDoktor = new SqlCommand("DELETE FROM Doktorlar WHERE KullaniciID=@id", aktifBgl);
                komutSilDoktor.Parameters.AddWithValue("@id", secilenKullaniciID);
                komutSilDoktor.ExecuteNonQuery();

                SqlCommand komutSilKull = new SqlCommand("DELETE FROM Kullanicilar WHERE KullaniciID=@id", aktifBgl);
                komutSilKull.Parameters.AddWithValue("@id", secilenKullaniciID);
                komutSilKull.ExecuteNonQuery();

                MessageBox.Show("Doktor silindi.");
                DoktorListesiniGetir();
                Temizle();
            }
            catch (Exception ex) { MessageBox.Show("Silme Hatası (Muhtemelen hastası var): " + ex.Message); }
            finally { aktifBgl.Close(); }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (secilenKullaniciID == "") { MessageBox.Show("Tablodan güncellenecek doktoru seçin!"); return; }

            SqlConnection aktifBgl = bgl.baglanti();
            try
            {
                
                SqlCommand komutKull = new SqlCommand("UPDATE Kullanicilar SET TCKimlik=@tc, Ad=@ad, Soyad=@soyad WHERE KullaniciID=@id", aktifBgl);
                komutKull.Parameters.AddWithValue("@tc", mskTC.Text);
                komutKull.Parameters.AddWithValue("@ad", txtAd.Text);
                komutKull.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komutKull.Parameters.AddWithValue("@id", secilenKullaniciID);
                komutKull.ExecuteNonQuery();

                SqlCommand komutDok = new SqlCommand("UPDATE Doktorlar SET PoliklinikID=@polID WHERE KullaniciID=@id", aktifBgl);
                komutDok.Parameters.AddWithValue("@polID", cmbBrans.SelectedValue);
                komutDok.Parameters.AddWithValue("@id", secilenKullaniciID);
                komutDok.ExecuteNonQuery();

                MessageBox.Show("Bilgiler güncellendi.");
                DoktorListesiniGetir();
                Temizle();
            }
            catch (Exception ex) { MessageBox.Show("Güncelleme Hatası: " + ex.Message); }
            finally { aktifBgl.Close(); }
        }

        private void dgvGecmis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int secilen = dgvGecmis.SelectedCells[0].RowIndex;
                secilenKullaniciID = dgvGecmis.Rows[secilen].Cells["KullaniciID"].Value.ToString();
                txtAd.Text = dgvGecmis.Rows[secilen].Cells["Doktor Adı"].Value.ToString();
                txtSoyad.Text = dgvGecmis.Rows[secilen].Cells["Doktor Soyadı"].Value.ToString();
                mskTC.Text = dgvGecmis.Rows[secilen].Cells["TC Kimlik No"].Value.ToString();
                cmbBrans.Text = dgvGecmis.Rows[secilen].Cells["Poliklinik"].Value.ToString();
                txtSifre.Text = "";
            }
        }

       
        private void Temizle()
        {
            secilenKullaniciID = "";
            txtAd.Clear();
            txtSoyad.Clear();
            mskTC.Clear();
            txtSifre.Clear();
        }
    }
}