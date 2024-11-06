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






    /* 
     datagridView işlemleri yapılacak *****
         
         
         */
    public partial class addForm : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = otoparkDB.accdb");

        Form22 girisFormNesnesi = new Form22();

        public int KullaniciIDs;



        public addForm()
    {
        InitializeComponent();

        }


        public int GelenKullaniciID
        {
            set { KullaniciIDs = value; }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addForm_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand kom = new OleDbCommand("SELECT Park_Yeri FROM parkYeri WHERE Durum = false ORDER BY Park_Yeri ASC", connection);

            OleDbDataReader okuyucu = kom.ExecuteReader();
            while (okuyucu.Read())
            {
                comboBox1.Items.Add(okuyucu["Park_Yeri"].ToString());
            }
            connection.Close();
            
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
            connection.Close();

            // TextBox'a otomatik tamamlama özelliğini ekle
            textBox2.AutoCompleteMode = AutoCompleteMode.Append;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox2.AutoCompleteCustomSource = veriKaynagi;
        }


        // hata kontrolleri metodu

        private bool HatalariKontrolEt()
        {

            string plakaPattern = @"^(0[1-9]|[1-7][0-9]|80|81) [A-PR-VY-ZÇĞİÖŞÜ]{1,3} (?!0000)\d{1,4}$";



            string girilenPlaka = textBox1.Text.ToUpper();

            bool plakaUygun = PlakaKontrol(plakaPattern, girilenPlaka);

            if (!plakaUygun)
            {
                MessageBox.Show("Geçersiz plaka formatı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            /*
            if (string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrWhiteSpace(textBox3.Text) )
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Lütfen bir park yeri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            */
            return true;
        }

        private bool PlakaKontrol(string pattern, string plaka)
        {
            return Regex.IsMatch(plaka, pattern);
        }

        

        private void arackayitOK_Click(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToShortTimeString();
            string tarih = DateTime.Now.ToShortDateString();

            CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text);

            if (!HatalariKontrolEt())
            {
                // Eğer kontroller dolu değilse işlemi sonlandır
                return;
            }

            try
            {
                connection.Open();
                OleDbCommand eklekom = new OleDbCommand("insert into Musteri (park_No, musteri_Ad,musteri_Soyad,musteri_Tel,arac_Plaka,arac_Marka,arac_Model,giris_Tarihi,giris_Saati,giris_Gorevlisi) values('" + comboBox1.Text + "','" + Buyuk(textBox6.Text) + "','" + Buyuk(textBox5.Text) + "','" + textBox4.Text + "','" + textBox1.Text.ToUpper() + "','" + English(textBox2.Text.ToUpper()) + "','" + English(textBox3.Text.ToUpper()) + "','" + tarih.ToString() + "','" + saat.ToString() + "','" + KullaniciIDs + "')", connection);
                eklekom.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                OleDbCommand kom2 = new OleDbCommand("update parkYeri set Durum = true where park_Yeri like'" + comboBox1.Text.ToString() + "'", connection);
                kom2.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("Başarıyla Kaydedildi");
                comboBox1.Items.Clear();

                this.Close();


            }

            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanı Hatası: " + ex.Message);
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
        }
    }
}
