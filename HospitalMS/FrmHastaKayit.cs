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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifBaglanti = bgl.baglanti();
            try
            {
                string sorgu1 = "INSERT INTO Kullanicilar(TCKimlik, Sifre, Ad, Soyad, RolId, Cinsiyet) VALUES(@tc, @sifre, @ad, @soyad, @rol, @cinsiyet);SELECT SCOPE_IDENTITY();";
                SqlCommand komut1 = new SqlCommand(sorgu1, aktifBaglanti);
                komut1.Parameters.AddWithValue("@tc", mskTC.Text);
                komut1.Parameters.AddWithValue("@sifre", txtSifre.Text);
                komut1.Parameters.AddWithValue("@ad", txtAd.Text);
                komut1.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut1.Parameters.AddWithValue("@rol", 1);
                komut1.Parameters.AddWithValue("@cinsiyet",cmbCinsiyet.Text);

                int yeniKullanici = Convert.ToInt32(komut1.ExecuteScalar());

                string sorgu2 = "INSERT INTO Hastalar(KullaniciID,TelefonNo) VALUES(@ıd,@telNo)";

                SqlCommand komut2 = new SqlCommand(sorgu2, aktifBaglanti);

                komut2.Parameters.AddWithValue("@ıd", yeniKullanici);
                komut2.Parameters.AddWithValue("@telNo", mskTelefon.Text);
                komut2.ExecuteNonQuery();

                MessageBox.Show("Hasta kaydınız başarıyla oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }

            catch (Exception hata)
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu: ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                aktifBaglanti.Close();
            }
        }

        private void FrmHastaKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
