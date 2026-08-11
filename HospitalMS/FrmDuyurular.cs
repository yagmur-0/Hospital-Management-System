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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }

       

        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            Sqlbaglantisi bgl = new Sqlbaglantisi();
            SqlConnection aktifBgl = bgl.baglanti();

            try
            {

                string sorgu = "SELECT DuyuruID AS [No], Duyuru AS [Duyuru Metni] FROM Duyurular";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, aktifBgl);
                DataTable dt = new DataTable();
                da.Fill(dt);


                dgvDuyuru.DataSource = dt;


                
            }
            catch (Exception hata)
            {
                MessageBox.Show("Duyurular yüklenirken hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                aktifBgl.Close();
            }
        }
    }
}