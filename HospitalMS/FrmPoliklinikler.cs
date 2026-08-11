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
    public partial class FrmPoliklinikler : Form
    {
        public FrmPoliklinikler()
        {
            InitializeComponent();
        }
        string secilenPoliklinikID = "";
        private void FrmPoliklinikler_Load(object sender, EventArgs e)
        {
            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifBgl = bgl.baglanti();

            SqlDataAdapter da = new SqlDataAdapter("SELECT PoliklinikID AS [ID], BolumAdi AS [Poliklinik Adı] FROM Poliklinikler", aktifBgl);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGecmis.DataSource = dt;

            aktifBgl.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBransAd.Text == "")
            {
                MessageBox.Show("Lütfen eklenecek poliklinik adını yazın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifBgl = bgl.baglanti();

            try
            {

                string sorgu = "INSERT INTO Poliklinikler (BolumAdi, AktifMi) VALUES (@bolumAd, 1)";

                SqlCommand komut = new SqlCommand(sorgu, aktifBgl);
                komut.Parameters.AddWithValue("@bolumAd", txtBransAd.Text);

                komut.ExecuteNonQuery();

                MessageBox.Show("Poliklinik sisteme başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtBransAd.Text = "";
                FrmPoliklinikler_Load(this, null);

            }
            catch (Exception hata)
            {
                MessageBox.Show("Poliklinik eklenirken hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                aktifBgl.Close();
            }
        }

        private void dgvGecmis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int secilen = dgvGecmis.SelectedCells[0].RowIndex;


                secilenPoliklinikID = dgvGecmis.Rows[secilen].Cells[0].Value.ToString();


                txtBransId.Text = dgvGecmis.Rows[secilen].Cells[0].Value.ToString();
                txtBransAd.Text = dgvGecmis.Rows[secilen].Cells[1].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (secilenPoliklinikID == "")
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz polikliniği listeden seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifBgl = bgl.baglanti();

            try
            {
                string sorguGuncelle = "UPDATE Poliklinikler SET BolumAdi = @bolumAd WHERE PoliklinikID = @id";
                SqlCommand komutGuncelle = new SqlCommand(sorguGuncelle, aktifBgl);
                komutGuncelle.Parameters.AddWithValue("@bolumAd", txtBransAd.Text);
                komutGuncelle.Parameters.AddWithValue("@id", secilenPoliklinikID);

                komutGuncelle.ExecuteNonQuery();

                MessageBox.Show("Poliklinik başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                secilenPoliklinikID = "";
                txtBransId.Text = "";
                txtBransAd.Text = "";

                FrmPoliklinikler_Load(this, null);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                aktifBgl.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (secilenPoliklinikID == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz polikliniği listeden seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult onay = MessageBox.Show(txtBransAd.Text + " polikliniğini silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                Sqlbaglantisi bgl = new Sqlbaglantisi();
                SqlConnection aktifBgl = bgl.baglanti();

                try
                {
                    SqlCommand komutSil = new SqlCommand("DELETE FROM Poliklinikler WHERE PoliklinikID = @id", aktifBgl);
                    komutSil.Parameters.AddWithValue("@id", secilenPoliklinikID);
                    komutSil.ExecuteNonQuery();

                    MessageBox.Show("Poliklinik başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    secilenPoliklinikID = "";
                    txtBransId.Text = "";
                    txtBransAd.Text = "";

                    FrmPoliklinikler_Load(this, null);
                }
                catch (SqlException)
                {
                   
                    MessageBox.Show("Bu poliklinik silinemez! Çünkü bu poliklinikte çalışan doktorlar bulunmaktadır.", "Silme Reddedildi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Beklenmeyen bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    aktifBgl.Close();
                }
            }
        }
    }
}