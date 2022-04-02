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
    public partial class frmMusteriListele : Form
    {
        Galeri galeri = new Galeri();
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            YenileListele();

        }

        private void YenileListele()
        {
            string cümle = "select * from musteriler";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = galeri.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Telefon";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select * from musteriler where musteri_ad like '%"+ textBox1.Text+ "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();


            dataGridView1.DataSource = galeri.listele(adtr2, cümle);
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtID.Text = satır.Cells[0].Value.ToString();
            txtmusteriad.Text = satır.Cells[1].Value.ToString();
            txtmusterisoyad.Text = satır.Cells[2].Value.ToString();
            txtmusteritelefon.Text = satır.Cells[3].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update musteriler set musteri_ad=@musteri_ad,musteri_soyad=@musteri_soyad,telefon=@telefon where musteritablo_id=@musteritablo_id";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@musteritablo_id", txtID.Text);
            komut2.Parameters.AddWithValue("@musteri_ad", txtmusteriad.Text);
            komut2.Parameters.AddWithValue("@musteri_soyad", txtmusterisoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtmusteritelefon.Text);
            galeri.ekle_sil_guncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cumle = "delete from musteriler where musteritablo_id='" + satır.Cells["musteritablo_id"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            galeri.ekle_sil_guncelle(komut2, cumle);
            YenileListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
