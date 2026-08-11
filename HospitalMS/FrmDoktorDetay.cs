using HospitalMs;
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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string TCNo;
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCNo;
            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifBgl = bgl.baglanti();

            try
            {
                SqlCommand komut6 = new SqlCommand("SELECT Ad, Soyad FROM Kullanicilar WHERE TCKimlik=@tc", aktifBgl);


                komut6.Parameters.AddWithValue("@tc", TCNo);


                SqlDataReader dr = komut6.ExecuteReader();

                DoktorBilgileriniGetir();
                RandevulariGetir();


                if (dr.Read())
                {
                    lblAdSoyad.Text = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Sayfa yüklenirken bir hata oluştu");
            }
            finally
            {
                aktifBgl.Close();
            }
        }
        private void DoktorBilgileriniGetir()
        {
            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifBgl = bgl.baglanti();

            try
            {
                SqlCommand komut = new SqlCommand("SELECT Ad, Soyad FROM Kullanicilar WHERE TCKimlik=@tc", aktifBgl);
                komut.Parameters.AddWithValue("@tc", TCNo);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    lblAdSoyad.Text = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor bilgileri yüklenirken hata: " + ex.Message);
            }
            finally
            {
                aktifBgl.Close();
            }
        }


        private void RandevulariGetir()
        {
            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifBgl = bgl.baglanti();

            try
            {

                string sorgu = @"SELECT r.RandevuTarihi, r.RandevuSaati, k_hasta.Ad + ' ' + k_hasta.Soyad AS [Hasta Ad Soyad], r.HastaSikayeti 
                                 FROM Randevular r 
                                 INNER JOIN Hastalar h ON r.HastaID = h.HastaID
                                 INNER JOIN Kullanicilar k_hasta ON h.KullaniciID = k_hasta.KullaniciID
                                 INNER JOIN Doktorlar d ON r.DoktorID = d.DoktorID 
                                 INNER JOIN Kullanicilar k_doktor ON d.KullaniciID = k_doktor.KullaniciID 
                                 WHERE k_doktor.TCKimlik = @tc AND r.Durum = 1";

                SqlCommand komut = new SqlCommand(sorgu, aktifBgl);
                komut.Parameters.AddWithValue("@tc", TCNo);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRandevuListesi.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Randevu hatası: " + ex.Message); }
            finally { aktifBgl.Close(); }
        }
        private void btnBilgiDuzenle_Click(object sender, EventArgs e)
        {

            FrmDoktorDüzenle frmDoktorDuzenle = new FrmDoktorDüzenle();
            frmDoktorDuzenle.TCNo = lblTC.Text;
            frmDoktorDuzenle.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyuru = new FrmDuyurular();
            frmDuyuru.Show();
        }

        private void dgvRandevuListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int secilen = dgvRandevuListesi.SelectedCells[0].RowIndex;
                rtbRandevuDetay.Text = dgvRandevuListesi.Rows[secilen].Cells["HastaSikayeti"].Value.ToString();
            }
        }
    }
}








