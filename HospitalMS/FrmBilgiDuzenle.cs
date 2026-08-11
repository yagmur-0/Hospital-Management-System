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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TCNo;
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCNo;

            Sqlbaglantisi yeniBaglanti = new Sqlbaglantisi();
            SqlConnection aktifbg = yeniBaglanti.baglanti();

            try
            {

                string sorgu = "SELECT K.Ad, K.Soyad, K.TCKimlik, K.Sifre, K.Cinsiyet, H.TelefonNo FROM Kullanicilar K INNER JOIN Hastalar H ON K.KullaniciID = H.KullaniciID WHERE K.TCKimlik = @tc";

                SqlCommand komut5 = new SqlCommand(sorgu, aktifbg);


                komut5.Parameters.AddWithValue("@tc", TCNo);

                SqlDataReader dr = komut5.ExecuteReader();


                if (dr.Read())
                {

                    txtAd.Text = dr["Ad"].ToString();
                    txtSoyad.Text = dr["Soyad"].ToString();
                    txtSifre.Text = dr["Sifre"].ToString();
                    cmbCinsiyet.Text = dr["Cinsiyet"].ToString();
                    mskTelefon.Text = dr["TelefonNo"].ToString();
                }

                dr.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bilgiler getirilirken hata oluştu");
            }
            finally
            {
                aktifbg.Close();
            }

        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifBaglanti = bgl.baglanti();
            try
            {
               

                string sorgu1 = "UPDATE Kullanicilar SET Ad=@ad, Soyad=@soyad, Sifre=@sifre, Cinsiyet=@cinsiyet WHERE TCKimlik=@tc";

                SqlCommand komut1 = new SqlCommand(sorgu1, aktifBaglanti);
                komut1.Parameters.AddWithValue("@ad", txtAd.Text);
                komut1.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut1.Parameters.AddWithValue("@sifre", txtSifre.Text);
                komut1.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.Text);
                komut1.Parameters.AddWithValue("@tc", mskTC.Text); 

                komut1.ExecuteNonQuery(); 

                string sorgu2 = "UPDATE H SET H.TelefonNo = @telefon FROM Hastalar H INNER JOIN Kullanicilar K ON H.KullaniciID = K.KullaniciID WHERE K.TCKimlik = @tc";

                SqlCommand komut2 = new SqlCommand(sorgu2, aktifBaglanti);
                komut2.Parameters.AddWithValue("@telefon", mskTelefon.Text);
                komut2.Parameters.AddWithValue("@tc", mskTC.Text);

                komut2.ExecuteNonQuery();

                MessageBox.Show("Bilgileriniz başarıyla güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
               
                MessageBox.Show("Güncelleme sırasında bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                aktifBaglanti.Close();
            }
        }
    }
}
