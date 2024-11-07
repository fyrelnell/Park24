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

    public partial class loginForm : Form
    {
        private bool isDragging;
        private Point lastCursorPosition;
        private Timer timer;

        public int KullaniciID { get; set; }







        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = otoparkDB.accdb");

        public loginForm()
        {
            

            InitializeComponent();

            headerLineButton.FlatStyle = FlatStyle.Flat;
            headerLineButton.FlatAppearance.BorderSize = 0;
            headerLineButton.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            headerLineButton.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            Park24_ImageButton.FlatStyle = FlatStyle.Flat;
            Park24_ImageButton.FlatAppearance.BorderSize = 0;  

            
            headerLineButton.MouseDown += Button1_MouseDown;
            headerLineButton.MouseMove += Button1_MouseMove;
            headerLineButton.MouseUp += Button1_MouseUp;


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
            dateLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy\n dd MMMM dddd \nHHH:mm:ss");
        }

        // ----------------------------------------------------------------



        private void giris_Form_Load(object sender, EventArgs e)
        {
            usernameTBox.Location = new Point((this.ClientSize.Width - usernameTBox.Width) / 2, (this.ClientSize.Height - usernameTBox.Height) / 2 + 90);
            passwordTBox.Location = new Point((this.ClientSize.Width - passwordTBox.Width) / 2, (this.ClientSize.Height - passwordTBox.Height) / 2 + 128);
            Point currentLocation = loginButton.Location;
            Point currentLocation2 = Park24_ImageButton.Location;
            loginButton.Location = new Point((this.ClientSize.Width - loginButton.Width)/ 2, currentLocation.Y + 100);
            Park24_ImageButton.Location = new Point((this.ClientSize.Width - Park24_ImageButton.Width) / 2, currentLocation2.Y + 10);
            headerLineButton.FlatStyle = FlatStyle.Flat;
            headerLineButton.FlatAppearance.BorderSize = 0;

            
            // Giriş ekranında tarihi gösterme



            // Form yüklenirken bir kere tarih ve saati güncelle
            dateLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy\n dd MMMM dddd \nHHH:mm:ss");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button4_Click(object sender, EventArgs e)
        {

            if (usernameTBox.Text == "" || passwordTBox.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Kısmı boş olamaz.");
            }

            else
            {
                connection.Open();
                OleDbCommand kullanicilar = new OleDbCommand("select * from Kullanici where kullanici_Ad='" + usernameTBox.Text.ToString() + "'", connection);
                OleDbDataReader okuyucu = kullanicilar.ExecuteReader();
                if (okuyucu.Read() == true)
                {
                    if (usernameTBox.Text.ToString() == okuyucu["kullanici_Ad"].ToString() && passwordTBox.Text.ToString() == okuyucu["kullanici_Sifre"].ToString())
                    {
                        loginForm gform = new loginForm();

                        KullaniciID = Convert.ToInt32(okuyucu["kullanici_ID"]);

                        homePageForm yeniForm = new homePageForm
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
                        passwordTBox.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı yok.");
                    usernameTBox.Clear();
                    passwordTBox.Clear();
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
