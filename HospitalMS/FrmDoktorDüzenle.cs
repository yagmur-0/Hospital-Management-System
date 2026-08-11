using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalMs
{
    public partial class FrmDoktorDüzenle : Form
    {
        
        public string TCNo;
        string kullaniciId = "";
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        public FrmDoktorDüzenle()
        {
            InitializeComponent();
        }

        private void FrmDoktorDüzenle_Load(object sender, EventArgs e)
        {
            SqlConnection aktifBgl = bgl.baglanti();
            try
            {
                
                SqlDataAdapter da = new SqlDataAdapter("SELECT PoliklinikID, BolumAdi FROM Poliklinikler WHERE AktifMi=1", aktifBgl);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmPoliklinik2.DisplayMember = "BolumAdi";
                cmPoliklinik2.ValueMember = "PoliklinikID";
                cmPoliklinik2.DataSource = dt;

              
                string sorgu = @"SELECT K.KullaniciID, K.Ad, K.Soyad, K.TCKimlik, K.Sifre, D.PoliklinikID 
                                 FROM Kullanicilar K 
                                 INNER JOIN Doktorlar D ON K.KullaniciID = D.KullaniciID 
                                 WHERE K.TCKimlik=@tc";

                SqlCommand komut = new SqlCommand(sorgu, aktifBgl);
                komut.Parameters.AddWithValue("@tc", TCNo);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    
                    kullaniciId = dr["KullaniciID"].ToString();
                    txtAd.Text = dr["Ad"].ToString();
                    txtSoyad.Text = dr["Soyad"].ToString();
                    mskTC.Text = dr["TCKimlik"].ToString();
                    txtSifre.Text = dr["Sifre"].ToString();
                    cmPoliklinik2.SelectedValue = dr["PoliklinikID"];
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgiler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                aktifBgl.Close();
            }
        }

      
        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection aktifBgl = bgl.baglanti();
            try
            {
                int yeniPolId = Convert.ToInt32(cmPoliklinik2.SelectedValue);

                
                SqlCommand cmdEskiPol = new SqlCommand("SELECT PoliklinikID FROM Doktorlar WHERE KullaniciID=@kId", aktifBgl);
                cmdEskiPol.Parameters.AddWithValue("@kId", kullaniciId);
                int eskiPolId = Convert.ToInt32(cmdEskiPol.ExecuteScalar());

                if (eskiPolId != yeniPolId)
                {
                    string randevuSorgu = @"SELECT COUNT(*) FROM Randevular r 
                                            INNER JOIN Doktorlar d ON r.DoktorID = d.DoktorID 
                                            WHERE d.KullaniciID = @kId AND r.Durum = 1";

                    SqlCommand cmdRandevuKontrol = new SqlCommand(randevuSorgu, aktifBgl);
                    cmdRandevuKontrol.Parameters.AddWithValue("@kId", kullaniciId);

                    int aktifRandevuSayisi = Convert.ToInt32(cmdRandevuKontrol.ExecuteScalar());

                   
                    if (aktifRandevuSayisi > 0)
                    {
                        MessageBox.Show($"Üzerinize kayıtlı bekleyen {aktifRandevuSayisi} adet randevu bulunmaktadır!\n\nAktif randevunuz varken poliklinik değiştiremezsiniz.",
                                        "İşlem Reddedildi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                }

                
                SqlCommand komut = new SqlCommand("UPDATE Kullanicilar SET Ad=@ad, Soyad=@soyad, Sifre=@sifre WHERE TCKimlik=@tc", aktifBgl);
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
                komut.Parameters.AddWithValue("@tc", mskTC.Text);
                komut.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand("UPDATE Doktorlar SET PoliklinikID=@polId WHERE KullaniciID=@kId", aktifBgl);
                komut2.Parameters.AddWithValue("@polId", yeniPolId);
                komut2.Parameters.AddWithValue("@kId", kullaniciId);
                komut2.ExecuteNonQuery();

                MessageBox.Show("Bilgileriniz başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                aktifBgl.Close();
            }
        }
    }
}