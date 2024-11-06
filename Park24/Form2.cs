using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace Park24
{
    public partial class recentsForm : Form
    {



        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = otoparkDB.accdb");

        public recentsForm()
        {
            InitializeComponent();





        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void recentsForm_Load(object sender, EventArgs e)
        {
            VeritabanindanEskiKayitlariGetir();
        }

        private void VeritabanindanEskiKayitlariGetir()
        {
            try
            {
                connection.Open();

                // Eski kayıtları çekmek için sorgu
                OleDbCommand eskiKayitlarKomut = new OleDbCommand("SELECT * FROM eskiKayitlar", connection);
                OleDbDataReader reader = eskiKayitlarKomut.ExecuteReader();

                // DataGridView temizle
                dataGridView1.Rows.Clear();

                // Her bir kayıt için DataGridView'e ekleme
                while (reader.Read())
                {
                    // Verileri sütunlara göre çek
                    string parkNo = reader["park_No"].ToString();
                    string adSoyad = reader["musteri_Ad"].ToString() + " " + reader["musteri_Soyad"].ToString();
                    string telefonNo = reader["musteri_Tel"].ToString();
                    string aracPlaka = reader["arac_Plaka"].ToString();
                    string aracMarka = reader["arac_Marka"].ToString();
                    string aracModel = reader["arac_Model"].ToString();
                    string girisTarihi = reader["giris_Tarihi"].ToString() + " " + reader["giris_Saati"].ToString();
                    string cikisTarihi = reader["cikis_Tarihi"].ToString() + " " + reader["cikis_Saati"].ToString();
                    string ucret = reader["ucret"].ToString();
                    string kayitGorevli = reader["giris_Gorevli"].ToString();
                    string cikisGorevli = reader["cikis_Gorevli"].ToString();

                    // DataGridView'e ekleme
                    dataGridView1.Rows.Add(parkNo, adSoyad, telefonNo, aracPlaka, aracMarka, aracModel, girisTarihi, cikisTarihi, ucret, kayitGorevli, cikisGorevli);
                }

            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanı Hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
