using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park24
{
    public partial class homePageForm : Form
    {
        private bool isDragging;
        private Point lastCursorPosition;
        private Timer timer;
        private parkStatusForm form1;

        

        
    
        private int _gelenKullaniciID;

        public int GelenKullaniciID
        {
            get { return _gelenKullaniciID; }
            set
            {
                _gelenKullaniciID = value;
                
            }
        }



        public homePageForm()
        {

            InitializeComponent();


            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();




           

            loginForm gform = new loginForm();
            Point formLocation = gform.Location;
            gform.Close();

            this.Location = new Point(formLocation.X, formLocation.Y);


            form2 = new infoForm();
            form1 = new parkStatusForm();
            form3 = new logListForm();


            

         
            headerLineButton.FlatStyle = FlatStyle.Flat;
            headerLineButton.FlatAppearance.BorderSize = 0;



            headerLineButton.MouseDown += Button1_MouseDown;
            headerLineButton.MouseMove += Button1_MouseMove;
            headerLineButton.MouseUp += Button1_MouseUp;
        }

        

        private void Timer_Tick(object sender, EventArgs e)
        {
            // her saniye yapılacak işlemler. test için eklendi
        }

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





        private void Form22_Load(object sender, EventArgs e)
        {
          
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowFormInPanel(Form formToShow)
        {

            if (contentPanel1.Controls.Count > 0)
            {
                contentPanel1.Controls[0].Hide();
            }
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            contentPanel1.Controls.Add(formToShow);
            formToShow.Show();


        }
        private infoForm form2; // info - Otopark Durumu// form1 status - Otopark Bilgileri
        private logListForm form3;

        private void status_Button_Click(object sender, EventArgs e)
        {
            form1.VeritabanindanBilgileriGetir();
            if (!form1.Visible)
            {
                if (form2 != null && !form2.IsDisposed && form2.Visible) // Eğer form2 görünürse, gizle
                {
                    form2.Hide();
                }
                if (form3 != null && !form3.IsDisposed && form3.Visible) // Eğer form3 görünürse, gizle
                {
                    form3.Hide();
                }
                ShowFormInPanel(form1);
                carRegisterButton.Visible = true;
                carEditButton.Visible = true;
                carExitButton.Visible = true;
            }

        }

        private void info_Button_Click(object sender, EventArgs e)
        {
            form2.ParkYeriSayVeAta();
            if (!form2.Visible)
            {
                carRegisterButton.Visible = false;
                carEditButton.Visible = false;
                carExitButton.Visible = false;
                if (form1 != null && !form1.IsDisposed && form1.Visible) // Eğer form1 görünürse, gizle
                {
                    form1.Hide();
                }
                if (form3 != null && !form3.IsDisposed && form3.Visible) // Eğer form3 görünürse, gizle
                {
                    form3.Hide();
                }
                ShowFormInPanel(form2);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!form3.Visible)
            {
                carRegisterButton.Visible = false;
                carEditButton.Visible = false;
                carExitButton.Visible = false;
                if (form1 != null && !form1.IsDisposed && form1.Visible)
                {
                    form1.Hide();
                }
                if (form2 != null && !form2.IsDisposed && form2.Visible)
                {
                    form2.Hide();
                }
                ShowFormInPanel(form3);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void aracKayit_Buton_Click(object sender, EventArgs e)
        {
            
            addForm addFormInstance = new addForm();
            addFormInstance.GelenKullaniciID = GelenKullaniciID;

            addFormInstance.FormClosed += AddFormClosed;
            addFormInstance.ShowDialog();

        }
        private void aracDuzenle_Buton_Click(object sender, EventArgs e)
        {
            
            int selectedRowIndex = form1.parkListGView1.SelectedRows.Count > 0
                ? form1.parkListGView1.SelectedRows[0].Index
                : -1;

           
            if (selectedRowIndex != -1)
            {
                
                string plaka = form1.parkListGView1.Rows[selectedRowIndex].Cells["Column4"].Value.ToString();

                
                carEditForm editFormInstance = new carEditForm();

                editFormInstance.FormClosed += EditFormClosed;
                editFormInstance.AracPlaka = plaka;

                editFormInstance.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz aracı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void AddFormClosed(object sender, FormClosedEventArgs e)
        {
            form1.VeritabanindanBilgileriGetir();
        }

        private void EditFormClosed(object sender, FormClosedEventArgs e)
        {
            form1.VeritabanindanBilgileriGetir();
        }

        private void carExitFormClosed(object sender, FormClosedEventArgs e)
        {
            form1.VeritabanindanBilgileriGetir();
        }




        private void aracCikis_Buton_Click(object sender, EventArgs e)
        {

              int selectedRowIndex = form1.parkListGView1.SelectedRows.Count > 0
                ? form1.parkListGView1.SelectedRows[0].Index
                : -1;

           
            if (selectedRowIndex != -1)
            {

                string plaka = form1.parkListGView1.Rows[selectedRowIndex].Cells["Column4"].Value.ToString();

                DateTime girisTarihi = Convert.ToDateTime(form1.parkListGView1.Rows[selectedRowIndex].Cells["Column6"].Value).Date;
                DateTime girisSaati = Convert.ToDateTime(form1.parkListGView1.Rows[selectedRowIndex].Cells["Column7"].Value);

                carExitForm CarExitForm = new carExitForm(girisTarihi, girisSaati, selectedRowIndex, form1);
                CarExitForm.FormClosed += carExitFormClosed;
                CarExitForm.GelenKullaniciID = _gelenKullaniciID;
                CarExitForm.AracPlaka = plaka;

               CarExitForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen çıkış yapmak istediğiniz aracı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

      
    }
    
}
