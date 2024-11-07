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
    public partial class parkStatusForm : Form
    {

        

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = otoparkDB.accdb");

        public parkStatusForm()
        {
            InitializeComponent();
            parkPlacesPanel1.Visible = false;




          
        }

   


        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            parkPlacesPanel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parkPlacesPanel1.Visible = true;
            panel1.Visible = false;
        }

        private void statusForm_Load(object sender, EventArgs e)
        {
            VeritabanindanBilgileriGetir();
        }



        public void VeritabanindanBilgileriGetir()
        {

            try
            {
               //temizle
                parkListGView1.Rows.Clear();

                //verileri çek
                connection.Open();
                OleDbCommand kom = new OleDbCommand("SELECT * FROM Musteri", connection);
                OleDbDataReader okuyucu = kom.ExecuteReader();

                //verileri oku, yazdır
                while (okuyucu.Read())
                {


                    

                    DateTime girisTarihi = (DateTime)okuyucu["giris_Tarihi"];
                    DateTime girisSaati = (DateTime)okuyucu["giris_Saati"];

                    TimeSpan girisSaatit = girisSaati.TimeOfDay;

                    DateTime girisTarihiVeSaati = girisTarihi.Date.Add(girisSaatit);

                    DateTime suAn = DateTime.Now;

                    int ucret = HesaplaUcret(Convert.ToDateTime(girisTarihi), Convert.ToDateTime(girisSaati));

                    TimeSpan gecenSure = suAn - girisTarihiVeSaati;
                    string gecenSureFormatted = $"{gecenSure.Hours} H, {gecenSure.Minutes} M";

                    int gecenGun = gecenSure.Days;
                    int gecenSaat = gecenSure.Hours;
                    int gecenDakika = gecenSure.Minutes;

                    string toplamSure = $"{gecenGun} gün {gecenSaat} saat {gecenDakika} dakika";


                    if (gecenSure.Days < 1)
                    {
                        toplamSure = $"{gecenSaat} saat {gecenDakika} dakika";
                    }
                    else
                    {
                        toplamSure = $"{gecenGun} Gün  {gecenSaat} Saat";
                    }

                    if(gecenSure.Hours < 1)
                    {
                        toplamSure = $"{gecenDakika} dakika";
                        if (gecenSure.Hours < 0)
                            toplamSure = "#HATALI";
                    }


                    parkListGView1.Rows.Add(
                        okuyucu["park_No"].ToString(),
                        okuyucu["musteri_Ad"].ToString() +"  "+ okuyucu["musteri_Soyad"].ToString(),
                        okuyucu["musteri_Tel"].ToString(),
                        okuyucu["arac_Plaka"].ToString(),
                        okuyucu["arac_Marka"].ToString(),
                        girisTarihi.ToShortDateString(),
                        girisSaati.ToShortTimeString(),
                        toplamSure,
                        ucret + " ₺"
                    );
                }

                okuyucu.Close();
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

        private int HesaplaUcret(DateTime girisTarihi, DateTime girisSaati)
        {
            DateTime suAn = DateTime.Now;
            TimeSpan gecenSure = suAn - girisTarihi.Add(girisSaati.TimeOfDay);

            //her saat 10 Tl ücret
            int ucret = (int)Math.Ceiling(gecenSure.TotalHours) * 10;

            return ucret;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
