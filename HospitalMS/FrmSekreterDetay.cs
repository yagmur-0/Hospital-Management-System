using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace HospitalMs
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

     
        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi1 frmRandevu = new FrmRandevuListesi1();
            frmRandevu.Show();
        }

      


        public string TcNo2;
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TcNo2;
            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifBgl = bgl.baglanti();

            try
            {

                SqlCommand komut6 = new SqlCommand("SELECT Ad, Soyad FROM Kullanicilar WHERE TCKimlik=@tc", aktifBgl);


                komut6.Parameters.AddWithValue("@tc", TcNo2);


                SqlDataReader dr = komut6.ExecuteReader();




                if (dr.Read())
                {
                    lblAdSoyad.Text = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
                }

                dr.Close();

                cmbBrans.Items.Clear();
                SqlCommand komut2 = new SqlCommand("SELECT BolumAdi FROM Poliklinikler ORDER BY BolumAdi", aktifBgl);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    cmbBrans.Items.Add(dr2["BolumAdi"]);
                }
                dr2.Close();

                DataTable dt1 = new DataTable();
                string bransSorgu = "SELECT BolumAdi AS [Poliklinik Adı] FROM Poliklinikler";
                SqlDataAdapter da = new SqlDataAdapter(bransSorgu, aktifBgl);
                da.Fill(dt1);
                dgvBranslar.DataSource = dt1;

                DataTable dt2 = new DataTable();
                string sorgu2 = "SELECT K.Ad+' '+K.Soyad AS[Doktor Adı Soyadı],P.BolumAdi AS [Poliklinik] FROM Kullanicilar K INNER JOIN Doktorlar D ON K.KullaniciID=D.KullaniciID INNER JOIN Poliklinikler P ON D.PoliklinikID=P.PoliklinikID ";
                SqlDataAdapter da2 = new SqlDataAdapter(sorgu2, aktifBgl);
                da2.Fill(dt2);
                dgvDoktorlar.DataSource = dt2;

            }
            catch (Exception hata)
            {
                MessageBox.Show("Sayfa yüklenirken hata oluştu");
            }
            finally
            {

                aktifBgl.Close();
            }
        }

      

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifBgl = bgl.baglanti();

            try
            {

                string bulSorgusu = "SELECT D.DoktorID FROM Doktorlar D INNER JOIN Kullanicilar K ON D.KullaniciID = K.KullaniciID WHERE (K.Ad + ' ' + K.Soyad) = @adSoyad";

                SqlCommand komut1 = new SqlCommand(bulSorgusu, aktifBgl);
                komut1.Parameters.AddWithValue("@adSoyad", cmbDoktor.Text);

                int secilenDoktorID = Convert.ToInt32(komut1.ExecuteScalar());

                int durumDegeri = chkDurum.Checked ? 1 : 0;

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    string ekleSorgusu = "INSERT INTO Randevular (RandevuTarihi, RandevuSaati, DoktorID, Durum) VALUES (@tarih, @saat, @id, @durum)";
                    SqlCommand komutEkle = new SqlCommand(ekleSorgusu, aktifBgl);
                    komutEkle.Parameters.AddWithValue("@tarih", mskTarih.Text);
                    komutEkle.Parameters.AddWithValue("@saat", mskSaat.Text);
                    komutEkle.Parameters.AddWithValue("@id", secilenDoktorID);
                    komutEkle.Parameters.AddWithValue("@durum", durumDegeri);

                    komutEkle.ExecuteNonQuery();
                    MessageBox.Show("Boş randevu saati sisteme başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                else
                {
                    string guncelleSorgusu = "UPDATE Randevular SET RandevuTarihi=@tarih, RandevuSaati=@saat, DoktorID=@id, Durum=@durum WHERE RandevuID=@randevuId";
                    SqlCommand komutGuncelle = new SqlCommand(guncelleSorgusu, aktifBgl);
                    komutGuncelle.Parameters.AddWithValue("@tarih", mskTarih.Text);
                    komutGuncelle.Parameters.AddWithValue("@saat", mskSaat.Text);
                    komutGuncelle.Parameters.AddWithValue("@id", secilenDoktorID);
                    komutGuncelle.Parameters.AddWithValue("@durum", durumDegeri);
                    komutGuncelle.Parameters.AddWithValue("@randevuId", txtId.Text);

                    komutGuncelle.ExecuteNonQuery();
                    MessageBox.Show("Randevu bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                txtId.Clear();
                mskTarih.Clear();
                mskSaat.Clear();
                mskTC.Clear();
                cmbBrans.SelectedIndex = -1;
                cmbDoktor.SelectedIndex = -1;
                chkDurum.Checked = false;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Randevu açılırken hata oluştu");
            }
            finally
            {
                aktifBgl.Close();
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
                MessageBox.Show("Sayfa yüklenirken bir hata oluştu");
            }

            finally
            {
                sqlConnection.Close();
            }

        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            Sqlbaglantisi bglnti = new Sqlbaglantisi();
            SqlConnection cn = bglnti.baglanti();
            try
            {
                SqlCommand komut7 = new SqlCommand("INSERT INTO Duyurular(Duyuru) VALUES (@duyuru)", cn);
                komut7.Parameters.AddWithValue("@duyuru", rtbDuyuru.Text);
                komut7.ExecuteNonQuery();


                MessageBox.Show("Duyuru başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbDuyuru.Text = "";
            }
            catch (Exception hata)
            {
                MessageBox.Show("Duyuru oluşturulurken hata oluştu.");
            }
            finally
            {
                cn.Close();

            }
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorKayit doktorKayit = new FrmDoktorKayit();
            doktorKayit.Show();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmPoliklinikler frp = new FrmPoliklinikler();
            frp.Show();

        }

        public void RandevuBilgileriniDoldur(string id, string tarih, string saat, string poliklinik, string doktor, string tc)
        {
            txtId.Text = id;
            mskTarih.Text = tarih;
            mskSaat.Text = saat;
            cmbBrans.Text = poliklinik;
            cmbDoktor.Text = doktor;
            mskTC.Text = tc;
        }

      

        private void Duyurular1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyuru = new FrmDuyurular();
            frmDuyuru.Show();
        }
    }
    }

