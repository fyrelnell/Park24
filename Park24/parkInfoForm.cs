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
    public partial class infoForm : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = otoparkDB.accdb");


       

        public infoForm()
        {
            InitializeComponent();
        }

        private void infoForm_Load(object sender, EventArgs e)
        {
           
        }

        public void ParkYeriSayVeAta()
        {
            int yogunlukD, aracSayisi;
            try
            {
                connection.Open();

                // Park_Yeri tablosundan Durum'u true olan park yerlerini saymak için sorgu
                OleDbCommand parkYeriSayKomut = new OleDbCommand("SELECT COUNT(*) FROM parkYeri WHERE Durum = true", connection);

                int parkYeriSayisi = Convert.ToInt32(parkYeriSayKomut.ExecuteScalar());

                yogunlukD = (int)Math.Round((double)parkYeriSayisi / 15 * 100);
                aracSayisi = parkYeriSayisi;

                label7.Text = yogunlukD.ToString() + " %";
                label8.Text = aracSayisi.ToString() + " / 15";
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

    }
}
