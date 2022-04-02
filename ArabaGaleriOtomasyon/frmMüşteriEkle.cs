using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaGaleriOtomasyon
{
    public partial class frmMüşteriEkle : Form
    {
        Galeri galeri = new Galeri();
        public frmMüşteriEkle()
        {
            InitializeComponent();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string cumle = "insert into musteriler(musteri_ad,musteri_soyad,telefon) values(@musteri_ad,@musteri_soyad,@telefon)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@musteri_ad",txtmusteriad.Text);
            komut2.Parameters.AddWithValue("@musteri_soyad", txtmusterisoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtmusteritelefon.Text);
            galeri.ekle_sil_guncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }
    }
}
