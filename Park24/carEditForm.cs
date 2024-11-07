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
    public partial class carEditForm : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = otoparkDB.accdb");

        private string _aracPlaka;
        private string kayitYeri;

        public string AracPlaka
        {
            get { return _aracPlaka; }
            set { _aracPlaka = value; }
        }

        public carEditForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void editForm_Load(object sender, EventArgs e)
        {
            // Plaka bilgisini kullanarak veritabanından ilgili bilgileri çek
            VeritabanindanBilgileriGetir(_aracPlaka);

            // Park yerleri ve markaları combobox'lara yükleme
            ParkYerleriniYukle(kayitYeri);
            MarkalariYukle();
        }

        // Plaka bilgisini kullanarak veritabanından ilgili bilgileri çeken fonksiyon
        private void VeritabanindanBilgileriGetir(string plaka)
        {
            try
            {
                connection.Open();

                // Araç bilgilerini çek
                OleDbCommand aracKomut = new OleDbCommand("SELECT * FROM Musteri WHERE arac_Plaka = ?", connection);
                aracKomut.Parameters.AddWithValue("@arac_Plaka", plaka);

                OleDbDataReader aracReader = aracKomut.ExecuteReader();

                if (aracReader.Read())
                {
                    plateTBox.Text = aracReader["arac_Plaka"].ToString();
                    brandTBox.Text = aracReader["arac_Marka"].ToString();
                    modelTBox.Text = aracReader["arac_Model"].ToString();
                    parknoCBox.Text = aracReader["park_No"].ToString();
                }

                kayitYeri = aracReader["park_No"].ToString();

                connection.Close();
                connection.Open();

                // Müşteri bilgilerini çek
                OleDbCommand musteriKomut = new OleDbCommand("SELECT * FROM Musteri WHERE arac_Plaka = ?", connection);
                musteriKomut.Parameters.AddWithValue("@arac_Plaka", plaka);

                OleDbDataReader musteriReader = musteriKomut.ExecuteReader();

                if (musteriReader.Read())
                {
                    nameTBox.Text = musteriReader["musteri_Ad"].ToString();
                    surnTBox.Text = musteriReader["musteri_Soyad"].ToString();
                    phoneTBox.Text = musteriReader["musteri_Tel"].ToString();
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

        // Park yerlerini combobox'a yükleyen fonksiyon
        private void ParkYerleriniYukle(string kayitYeri)
        {
            try
            {
                connection.Open();
                OleDbCommand kom = new OleDbCommand("SELECT Park_Yeri FROM parkYeri WHERE Durum = false ORDER BY Park_Yeri ASC", connection);

                OleDbDataReader okuyucu = kom.ExecuteReader();

                parknoCBox.Items.Clear();
                
                parknoCBox.Items.Add(kayitYeri);
                parknoCBox.SelectedItem = kayitYeri;

                while (okuyucu.Read())
                {
                    parknoCBox.Items.Add(okuyucu["Park_Yeri"].ToString());
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

        // Markaları combobox'a yükleyen fonksiyon
        private void MarkalariYukle()
        {
            try
            {
                connection.Open();
                AutoCompleteStringCollection veriKaynagi = new AutoCompleteStringCollection();

                string query = "SELECT marka FROM Markalar";
                OleDbCommand kom2 = new OleDbCommand(query, connection);

                OleDbDataReader reader = kom2.ExecuteReader();

                while (reader.Read())
                {
                    veriKaynagi.Add(reader["marka"].ToString());
                }

                reader.Close();
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

        // Hata kontrolleri metodu
        private bool HatalariKontrolEt()
        {
            string plakaPattern = @"^(0[1-9]|[1-7][0-9]|80|81) [A-PR-VY-ZÇĞİÖŞÜ]{1,3} (?!0000)\d{1,4}$";

            string girilenPlaka = plateTBox.Text.ToUpper();
            bool plakaUygun = PlakaKontrol(plakaPattern, girilenPlaka);

            if (!plakaUygun)
            {
                MessageBox.Show("Geçersiz plaka formatı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool PlakaKontrol(string pattern, string plaka)
        {
            return Regex.IsMatch(plaka, pattern);
        }

        

        private void arackayitOK_Click(object sender, EventArgs e)
        {
            if (!HatalariKontrolEt())
            {
                // Eğer kontroller dolu değilse işlemi sonlandır
                return;
            }

            try
            {
                string eskiParkYeri = kayitYeri;

                // Yeni park yeri bilgisini al
                string yeniParkYeri = parknoCBox.Text;

                // Araç bilgilerini güncelle
                connection.Open();
                OleDbCommand aracGuncelleKomut = new OleDbCommand("UPDATE Musteri SET arac_Plaka=?, arac_Marka=?, arac_Model=?, park_No=? WHERE park_No=?", connection);
                aracGuncelleKomut.Parameters.AddWithValue("@arac_Plaka", plateTBox.Text.ToUpper());
                aracGuncelleKomut.Parameters.AddWithValue("@arac_Marka", English(brandTBox.Text.ToUpper()));
                aracGuncelleKomut.Parameters.AddWithValue("@arac_Model", English(modelTBox.Text.ToUpper()));
                aracGuncelleKomut.Parameters.AddWithValue("@park_No", yeniParkYeri); // Yeni park yerini burada kullan
                aracGuncelleKomut.Parameters.AddWithValue("@eskiParkYeri", eskiParkYeri); // Eski park yerini burada kullan
                aracGuncelleKomut.ExecuteNonQuery();

                // Eski park yerini false olarak güncelle
                OleDbCommand eskiParkYeriGuncelleKomut = new OleDbCommand("UPDATE parkYeri SET Durum=false WHERE Park_Yeri=?", connection);
                eskiParkYeriGuncelleKomut.Parameters.AddWithValue("@Park_Yeri", eskiParkYeri);
                eskiParkYeriGuncelleKomut.ExecuteNonQuery();

                // Yeni park yerini true olarak güncelle
                OleDbCommand yeniParkYeriGuncelleKomut = new OleDbCommand("UPDATE parkYeri SET Durum=true WHERE Park_Yeri=?", connection);
                yeniParkYeriGuncelleKomut.Parameters.AddWithValue("@Park_Yeri", yeniParkYeri);
                yeniParkYeriGuncelleKomut.ExecuteNonQuery();

                MessageBox.Show("Güncelleme Başarılı");

                parknoCBox.Items.Clear();

                this.Close();
                
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanı Hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        static string Buyuk(string texts)
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            return textInfo.ToTitleCase(texts);
        }

        static string English(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                switch (c)
                {
                    case 'ç':
                        result.Append('c');
                        break;
                    case 'ğ':
                        result.Append('g');
                        break;
                    case 'ı':
                        result.Append('i');
                        break;
                    case 'ö':
                        result.Append('o');
                        break;
                    case 'ş':
                        result.Append('s');
                        break;
                    case 'ü':
                        result.Append('u');
                        break;
                    case 'Ç':
                        result.Append('C');
                        break;
                    case 'Ğ':
                        result.Append('G');
                        break;
                    case 'İ':
                        result.Append('I');
                        break;
                    case 'Ö':
                        result.Append('O');
                        break;
                    case 'Ş':
                        result.Append('S');
                        break;
                    case 'Ü':
                        result.Append('U');
                        break;
                    default:
                        result.Append(c);
                        break;
                }
            }

            return result.ToString();
        }
    }
}
