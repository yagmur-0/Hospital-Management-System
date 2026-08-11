using Microsoft.Data.SqlClient;

namespace HospitalMs
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifbaglanti = bgl.baglanti();
            SqlCommand girisKomut = new SqlCommand("SELECT RolId FROM Kullanicilar WHERE TCKimlik=@tc AND Sifre=@sifre ",aktifbaglanti);
            girisKomut.Parameters.AddWithValue("@tc", mskTC.Text);
            girisKomut.Parameters.AddWithValue("@sifre", txtSifre.Text);

            SqlDataReader dr = girisKomut.ExecuteReader();

            if (dr.Read())
            {
                int rol = Convert.ToInt32(dr["RolId"]);

                if (rol == 1)
                {
                    FrmHastaDetay frmHasta = new FrmHastaDetay();
                    frmHasta.tc = mskTC.Text;
                    frmHasta.Show();
                    this.Hide();
                }
                else if (rol == 2)
                {
                    FrmDoktorDetay frmDoktor = new FrmDoktorDetay();
                    frmDoktor.TCNo= mskTC.Text;
                    frmDoktor.Show();
                    this.Hide();
                }

                else if (rol == 3)
                {
                    FrmSekreterDetay frmSekreter = new FrmSekreterDetay();
                    frmSekreter.TcNo2 = mskTC.Text;
                    frmSekreter.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hatalı T.C. Kimlik Numarası veya Şifre girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dr.Close();           
            aktifbaglanti.Close();

        }

        private void lnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit frmHastaKayıt= new FrmHastaKayit(); 
            frmHastaKayıt.Show();

        }
    }
}
