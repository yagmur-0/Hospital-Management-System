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
    public partial class FrmHastaDetay : Form
    {
        public string tc;
        public FrmHastaDetay()
        {
            InitializeComponent();
        }



        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            Sqlbaglantisi baglanti = new Sqlbaglantisi();
            SqlConnection aktifBaglanti = baglanti.baglanti();

            llblTC.Text = tc;
            try
            {
                SqlCommand komut1 = new SqlCommand("SELECT Ad, Soyad FROM Kullanicilar WHERE TCKimlik=@tc", aktifBaglanti);
                komut1.Parameters.AddWithValue("@tc", tc);

                SqlDataReader dr = komut1.ExecuteReader();

                if (dr.Read())
                {
                    lblAdSoyad.Text = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
                }

                dr.Close();


                DataTable dt = new DataTable();


                string randevuSorgu = @"SELECT r.RandevuTarihi AS [Randevu Tarihi], r.RandevuSaati AS [Randevu Saati], 
                        p.BolumAdi AS [Poliklinik], (kd.Ad + ' ' + kd.Soyad) AS [Doktor], 
                        r.Durum, r.HastaSikayeti AS [Şikayet] 
                        FROM Randevular r 
                        INNER JOIN Hastalar h ON r.HastaID = h.HastaID 
                        INNER JOIN Kullanicilar k ON h.KullaniciID = k.KullaniciID 
                        INNER JOIN Doktorlar d ON r.DoktorID = d.DoktorID
                        INNER JOIN Kullanicilar kd ON d.KullaniciID = kd.KullaniciID
                        INNER JOIN Poliklinikler p ON d.PoliklinikID = p.PoliklinikID
                        WHERE k.TCKimlik = @tc";

                SqlDataAdapter da = new SqlDataAdapter(randevuSorgu, aktifBaglanti);
                da.SelectCommand.Parameters.AddWithValue("@tc", tc);

                da.Fill(dt);

                dgvGecmis.DataSource = dt;

                SqlCommand komut2 = new SqlCommand("SELECT BolumAdi FROM Poliklinikler ORDER BY BolumAdi", aktifBaglanti);
                SqlDataReader dr2 = komut2.ExecuteReader();
                cmbBrans.Items.Clear();
                while (dr2.Read())
                {
                    cmbBrans.Items.Add(dr2["BolumAdi"]);
                }
                dr2.Close();



            }
            catch (Exception hata)
            {
                MessageBox.Show("Bilgiler çekilirken bir hata oluştu" +hata.Message);
            }
            finally
            {

                aktifBaglanti.Close();
            }
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            if (dgvAktif.CurrentRow != null)
            {
                if (string.IsNullOrWhiteSpace(rtbSikayet.Text))
                {
                    MessageBox.Show("Lütfen randevu almadan önce şikayetinizi giriniz.");
                    return;
                }

         
                int secilenRandevuID = Convert.ToInt32(dgvAktif.CurrentRow.Cells["RandevuID"].Value);

               
                string tcKimlik = llblTC.Text;

                Sqlbaglantisi bgl = new Sqlbaglantisi();
                SqlConnection aktifBgl = bgl.baglanti();

                try
                {
                   
                    string hastaBulSorgu = @"SELECT h.HastaID FROM Hastalar h 
                                     INNER JOIN Kullanicilar k ON h.KullaniciID = k.KullaniciID 
                                     WHERE k.TCKimlik = @tc";

                    SqlCommand komutHastaBul = new SqlCommand(hastaBulSorgu, aktifBgl);
                    komutHastaBul.Parameters.AddWithValue("@tc", tcKimlik);

                    object sonuc = komutHastaBul.ExecuteScalar();
                    int aktifHastaID = 0;

                    if (sonuc != null)
                    {
                        aktifHastaID = Convert.ToInt32(sonuc);
                    }
                    else
                    {
                        MessageBox.Show("Hasta kimlik bilgisi doğrulanamadı. Lütfen tekrar giriş yapın.");
                        return; 
                    }

                    string randevuGuncelle = "UPDATE Randevular SET HastaID = @hasta, HastaSikayeti = @sikayet, Durum = 1 WHERE RandevuID = @id";
                    SqlCommand komutGuncelle = new SqlCommand(randevuGuncelle, aktifBgl);

                    komutGuncelle.Parameters.AddWithValue("@hasta", aktifHastaID);
                    komutGuncelle.Parameters.AddWithValue("@sikayet", rtbSikayet.Text);
                    komutGuncelle.Parameters.AddWithValue("@id", secilenRandevuID);

                    komutGuncelle.ExecuteNonQuery();
                    MessageBox.Show("Randevunuz başarıyla oluşturuldu.");

                    rtbSikayet.Clear();
                    dgvAktif.DataSource = null;
                    cmbDoktor.Items.Clear();

                    FrmHastaDetay_Load(this,null);
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Randevu alınırken bir hata oluştu: " + hata.Message);
                }
                finally
                {
                    aktifBgl.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen sağdaki Müsait Randevu Saatleri tablosundan bir saat seçiniz.");
            }
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            string secilenBrans = cmbBrans.Text;
            Sqlbaglantisi yenibgl = new Sqlbaglantisi();
            SqlConnection sqlConnection = yenibgl.baglanti();

            try
            {
                string sorgu = "SELECT K.Ad, K.Soyad FROM Kullanicilar K INNER JOIN Doktorlar D ON K.KullaniciID = D.KullaniciID INNER JOIN Poliklinikler P ON D.PoliklinikID=P.PoliklinikID WHERE P.BolumAdi=@Brans";
                   
                SqlCommand komut4 = new SqlCommand(sorgu, sqlConnection);
                komut4.Parameters.AddWithValue("@Brans", secilenBrans);
                SqlDataReader dr3 = komut4.ExecuteReader();
                while (dr3.Read())
                {
                    cmbDoktor.Items.Add(dr3["Ad"].ToString() + " " + dr3["Soyad"].ToString());
                }

                dr3.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show("Doktorlar yüklenirken bir hata oluştu");
            }

            finally
            {
                sqlConnection.Close();
            }


        }

        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle frmBilgi = new FrmBilgiDuzenle();
            frmBilgi.TCNo = llblTC.Text;
            frmBilgi.Show();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenDoktor = cmbDoktor.Text;
            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifBaglanti = bgl.baglanti();

            try
            {
                DataTable dt = new DataTable();
                string randevuSorgu = "SELECT R.RandevuID,R.RandevuTarihi AS [Randevu Tarihi], R.RandevuSaati AS [Randevu Saati] FROM Randevular R INNER JOIN Doktorlar D ON R.DoktorID = D.DoktorID INNER JOIN Kullanicilar K ON D.KullaniciID = K.KullaniciID WHERE (K.Ad + ' ' + K.Soyad) = @doktorAdSoyad AND R.Durum = 0";
                 
                SqlDataAdapter da = new SqlDataAdapter(randevuSorgu, aktifBaglanti);
                da.SelectCommand.Parameters.AddWithValue("@doktorAdSoyad", secilenDoktor);
                da.Fill(dt);
                dgvAktif.DataSource = dt;
                dgvAktif.Columns["RandevuID"].Visible = false;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Müsait randevular getirilirken hata oluştu");
            }
            finally
            {

                aktifBaglanti.Close();
            }
        }

    }
}