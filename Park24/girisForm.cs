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

namespace Park24
{

    /* Listview tanımlandı AracListeView
     * butonlar arası geçiş senkronizasyonları ayarlandı
     * araç listesi butonuna basınca form açılıp kapanıyor
     * liste eğer kapalıysa başka sekmeye (otopark bilgileri) gidip geldiğimizde tekrar görünür hale geliyor.
     * girişe tarih eklendi
 
         
         
         
         
         
         
         
         */

    public partial class giris_Form : Form
    {
        private bool isDragging;
        private Point lastCursorPosition;
        private Timer timer;

        public int KullaniciID { get; set; }







        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = otoparkDB.accdb");

        public giris_Form()
        {
            

            InitializeComponent();

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            button1.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;  

            
            button1.MouseDown += Button1_MouseDown;
            button1.MouseMove += Button1_MouseMove;
            button1.MouseUp += Button1_MouseUp;


            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick; // Timer'ın Tick olayına Timer_Tick metodu atanıyor
            timer.Start();
        }


        // --------------- Üst sarı bar sürüklendiğinde formun hareket etmesi  ---------------

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPosition = e.Location;
            }
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - lastCursorPosition.X;
                int deltaY = e.Y - lastCursorPosition.Y;

                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        // ----------------------------------------------------------------


        // --------------- giriş formu labeldeki tarihi güncelleme ---------------

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Her saniyede bir tetiklenecek olay
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            // Şu anki tarih ve saati al ve Label'a ata
            girismetin_Tarih.Text = DateTime.Now.ToString("dd/MM/yyyy\n dd MMMM dddd \nHHH:mm:ss");
        }

        // ----------------------------------------------------------------



        private void giris_Form_Load(object sender, EventArgs e)
        {
            textBox1.Location = new Point((this.ClientSize.Width - textBox1.Width) / 2, (this.ClientSize.Height - textBox1.Height) / 2 + 90);
            textBox2.Location = new Point((this.ClientSize.Width - textBox2.Width) / 2, (this.ClientSize.Height - textBox2.Height) / 2 + 128);
            Point currentLocation = button4.Location;
            Point currentLocation2 = button3.Location;
            button4.Location = new Point((this.ClientSize.Width - button4.Width)/ 2, currentLocation.Y + 100);
            button3.Location = new Point((this.ClientSize.Width - button3.Width) / 2, currentLocation2.Y + 10);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            
            // Giriş ekranında tarihi gösterme



            // Form yüklenirken bir kere tarih ve saati güncelle
            girismetin_Tarih.Text = DateTime.Now.ToString("dd/MM/yyyy\n dd MMMM dddd \nHHH:mm:ss");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Kısmı boş olamaz.");
            }

            else
            {
                connection.Open();
                OleDbCommand kullanicilar = new OleDbCommand("select * from Kullanici where kullanici_Ad='" + textBox1.Text.ToString() + "'", connection);
                OleDbDataReader okuyucu = kullanicilar.ExecuteReader();
                if (okuyucu.Read() == true)
                {
                    if (textBox1.Text.ToString() == okuyucu["kullanici_Ad"].ToString() && textBox2.Text.ToString() == okuyucu["kullanici_Sifre"].ToString())
                    {
                        giris_Form gform = new giris_Form();

                        KullaniciID = Convert.ToInt32(okuyucu["kullanici_ID"]);

                        Form22 yeniForm = new Form22
                        {
                            StartPosition = FormStartPosition.CenterScreen,
                            GelenKullaniciID = KullaniciID

                        };
                        timer.Stop();
                        yeniForm.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre yanlış. Kontrol Edin!");
                        textBox2.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı yok.");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                connection.Close();
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
