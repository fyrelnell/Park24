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
using System.Text.RegularExpressions;

namespace Park24
{




   
    public partial class carExitForm : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = otoparkDB.accdb");


        public int KullaniciIDs;
        private DateTime girisTarihi;
        private DateTime girisSaati;
        int selectedRowIndex;
        private statusForm form1;

        private string _aracPlaka;

        public string AracPlaka
        {
            get { return _aracPlaka; }
            set { _aracPlaka = value; }
        }

        public carExitForm(DateTime girisTarihi, DateTime girisSaati, int selectedRowIndex, statusForm form1)
        {
            InitializeComponent();
            this.girisTarihi = girisTarihi;
            this.girisSaati = girisSaati;
            this.selectedRowIndex = selectedRowIndex;
            this.form1 = form1;

        }


        public int GelenKullaniciID
        {
            set { KullaniciIDs = value; }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void carExitForm_Load(object sender, EventArgs e)
        {
            VeritabanindanBilgileriGetir(_aracPlaka);
            GorevliBilgileriniGetir(label13.Text);

        }

        private void VeritabanindanBilgileriGetir(string plaka)
        {
            TimeSpan girisSaatit = girisSaati.TimeOfDay;


            girisT.Text = girisTarihi.ToString("dd.MM.yyyy");
            girisS.Text = girisSaatit.ToString("hh\\:mm");





            DateTime girisTarihiVeSaati = girisTarihi.Date.Add(girisSaatit);

            DateTime suAn = DateTime.Now;


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

            if (gecenSure.Hours < 1)
            {
                toplamSure = $"{gecenDakika} dakika";
                if (gecenSure.Hours < 0)
                    toplamSure = "#HATALI";
            }


            sure.Text = toplamSure;

            ucret.Text = (HesaplaUcret(Convert.ToDateTime(girisTarihi), Convert.ToDateTime(girisSaati)).ToString() + " ₺");

            try
            {
                connection.Open();

                
                OleDbCommand aracKomut = new OleDbCommand("SELECT * FROM Musteri WHERE arac_Plaka = ?", connection);
                aracKomut.Parameters.AddWithValue("@arac_Plaka", plaka);

                OleDbDataReader aracReader = aracKomut.ExecuteReader();

                if (aracReader.Read())
                {
                    textBox1.Text = aracReader["arac_Plaka"].ToString();
                    textBox2.Text = aracReader["arac_Marka"].ToString();
                    textBox3.Text = aracReader["arac_Model"].ToString();
                    label13.Text = aracReader["park_No"].ToString();
                }

                connection.Close();
                connection.Open();

                
                OleDbCommand musteriKomut = new OleDbCommand("SELECT * FROM Musteri WHERE arac_Plaka = ?", connection);
                musteriKomut.Parameters.AddWithValue("@arac_Plaka", plaka);

                OleDbDataReader musteriReader = musteriKomut.ExecuteReader();

                if (musteriReader.Read())
                {
                    textBox6.Text = musteriReader["musteri_Ad"].ToString();
                    textBox5.Text = musteriReader["musteri_Soyad"].ToString();
                    textBox4.Text = musteriReader["musteri_Tel"].ToString();
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


        private void GorevliBilgileriniGetir(string parkNo)
        {
            try
            {
                connection.Open();

                
                string musteriSorgu = "SELECT giris_Gorevlisi FROM Musteri WHERE park_No = @parkNo";
                OleDbCommand musteriKomut = new OleDbCommand(musteriSorgu, connection);
                musteriKomut.Parameters.AddWithValue("@parkNo", parkNo);

                object girisGorevlisiObj = musteriKomut.ExecuteScalar();

                if (girisGorevlisiObj != null && girisGorevlisiObj != DBNull.Value)
                {
                    int girisGorevlisi = Convert.ToInt32(girisGorevlisiObj);

                    
                    string gorevliSorgu = "SELECT gorevli_Ad, gorevli_Soyad FROM Gorevli WHERE kullanici_ID = @kullaniciID";
                    OleDbCommand gorevliKomut = new OleDbCommand(gorevliSorgu, connection);
                    gorevliKomut.Parameters.AddWithValue("@kullaniciID", girisGorevlisi);

                    OleDbDataReader gorevliReader = gorevliKomut.ExecuteReader();

                    if (gorevliReader.Read())
                    {
                        string gorevliAd = gorevliReader["gorevli_Ad"].ToString();
                        string gorevliSoyad = gorevliReader["gorevli_Soyad"].ToString();

                        
                        kayitG.Text = $"{gorevliAd} {gorevliSoyad}";
                    }

                    gorevliReader.Close();
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



        private string musteriTel;
        private string musteriAd;
        private string aracMarka;
        private int girisGorevlisi;
        private string parkNo;
        private string musteriSoyad;
        private string aracModel;

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (selectedRowIndex != -1)
            {
                try
                {
                    connection.Open();

                    // Musteri tablosundan ilgili plakaya göre kaydı bulmak için sorgu
                    OleDbCommand musteriKomut = new OleDbCommand("SELECT * FROM Musteri WHERE arac_Plaka = @plaka", connection);
                    musteriKomut.Parameters.AddWithValue("@plaka", AracPlaka);

                    OleDbDataReader musteriReader = musteriKomut.ExecuteReader();

                    if (musteriReader.Read())
                    {
                        // Veritabanından gelen bilgileri kullanarak işlemlerinizi gerçekleştirin
                         parkNo = musteriReader["park_No"].ToString();
                         musteriAd = musteriReader["musteri_Ad"].ToString();
                         musteriSoyad = musteriReader["musteri_Soyad"].ToString();
                         musteriTel = musteriReader["musteri_Tel"].ToString();
                         aracMarka = musteriReader["arac_Marka"].ToString();
                        aracModel = musteriReader["arac_Model"].ToString();
                        girisGorevlisi = Convert.ToInt32(musteriReader["giris_Gorevlisi"]);

                        // Daha sonra bu bilgileri kullanarak işlemlerinizi gerçekleştirin
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen plakaya ait kayıt bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    connection.Close();

                    // Çıkış görevlisini al
                    int cikisGorevlisi = Convert.ToInt32(KullaniciIDs); // Giriş formundan alınan KullaniciIDs değerini kullanıyoruz


                    int ucret = HesaplaUcret(Convert.ToDateTime(girisTarihi), Convert.ToDateTime(girisSaati));

                    string saat = DateTime.Now.ToShortTimeString();

                    string cikisTarihi = DateTime.Now.ToShortDateString();
                    string cikisSaati = DateTime.Now.ToShortTimeString();

                    connection.Open();
                    // Eski kayıtlar tablosuna ekle
                    OleDbCommand eskiKayitEkleKomut = new OleDbCommand("INSERT INTO eskiKayitlar (park_No, musteri_Ad,musteri_Soyad, musteri_Tel, arac_Plaka, arac_Marka, arac_Model, giris_Tarihi, giris_Saati,cikis_Tarihi, cikis_Saati, giris_Gorevli, cikis_Gorevli, ucret) VALUES (?,?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?,?)", connection);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@park_No", parkNo);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@musteri_Ad", musteriAd);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@musteri_Soyad", musteriSoyad);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@musteri_Tel", musteriTel);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@arac_Plaka", AracPlaka);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@arac_Marka", aracMarka);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@arac_Model", aracModel);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@giris_Tarihi", girisTarihi);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@giris_Saati", girisSaati);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@cikis_Tarihi", cikisTarihi);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@cikis_Saati", cikisSaati);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@giris_Gorevli", girisGorevlisi);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@cikis_Gorevli", cikisGorevlisi);
                    eskiKayitEkleKomut.Parameters.AddWithValue("@ucret", ucret);

                    eskiKayitEkleKomut.ExecuteNonQuery();

                    // Park yerini false yap
                    OleDbCommand parkYeriGuncelleKomut = new OleDbCommand("UPDATE parkYeri SET Durum = false WHERE Park_Yeri = ?", connection);
                    parkYeriGuncelleKomut.Parameters.AddWithValue("@Park_Yeri", parkNo);
                    parkYeriGuncelleKomut.ExecuteNonQuery();

                    // Musteri tablosundan ilgili plakaya göre kaydı silmek için sorgu
                    OleDbCommand musteriSilKomut = new OleDbCommand("DELETE FROM Musteri WHERE arac_Plaka = @plaka", connection);
                    musteriSilKomut.Parameters.AddWithValue("@plaka", AracPlaka);
                    musteriSilKomut.ExecuteNonQuery();

                    MessageBox.Show("Çıkış başarılı. Bilgiler eski kayıtlara eklendi.");
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
            else
            {
                MessageBox.Show("Lütfen çıkış yapmak istediğiniz aracı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }

        private int HesaplaUcret(DateTime girisTarihi, DateTime girisSaati)
        {
            DateTime suAn = DateTime.Now;
            TimeSpan gecenSure = suAn - girisTarihi.Add(girisSaati.TimeOfDay);

            //her saat 10 Tl ücret
            int ucret = (int)Math.Ceiling(gecenSure.TotalHours) * 10;

            return ucret;
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
