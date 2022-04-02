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
    public partial class frmAracListele : Form
    {
        Galeri galeri = new Galeri();
        public frmAracListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SERBAY\SQLEXPRESS;Initial Catalog=GaleriOtomasyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtAracID.Text = satır.Cells[0].Value.ToString();
            comboBox5.Text = satır.Cells[1].Value.ToString();
            comboBox2.Text = satır.Cells[2].Value.ToString();
            comboBox1.Text = satır.Cells[3].Value.ToString();
            textBox2.Text = satır.Cells[4].Value.ToString();
            textBox1.Text = satır.Cells[5].Value.ToString();
            textBox3.Text = satır.Cells[6].Value.ToString();
            textBox4.Text = satır.Cells[7].Value.ToString();
            comboBox3.Text = satır.Cells[8].Value.ToString();
            comboBox4.Text = satır.Cells[9].Value.ToString();
            textBox5.Text = satır.Cells[10].Value.ToString();



        }

        private void frmAracListele_Load(object sender, EventArgs e)
        {
            yenileAracListe();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from personeller", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                comboBox5.Items.Add(read["personel_ad"]);
            }

            

            baglanti.Close();
        }

        private void yenileAracListe()
        {
            string cümle = "select araclar.aractablo_id as ID,personeller.personel_ad as Personel,modeller.model_ad as Model,markalar.marka_ad as Marka,araclar.fiyat as Fiyat,araclar.motor_hacmi as MotorHacim,araclar.motor_gucu as MotorGücü,araclar.kilometre as Kilometre,renkler.renk_ad as Renk,vitesler.vites_turu as Vites,araclar.cikis_yili as CıkışYılı from araclar INNER JOIN modeller ON modeller.modeltablo_id=araclar.model_id INNER JOIN markalar ON markalar.markatablo_id = modeller.marka_id INNER JOIN personeller ON personeller.personeltablo_id=araclar.personel_id INNER JOIN renkler ON renkler.renktablo_id=araclar.renk_id INNER JOIN vitesler ON vitesler.vitestablo_id=araclar.vites_id";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = galeri.listele(adtr2, cümle);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Items.Clear();
                if (comboBox1.SelectedIndex == 0)
                {
                    comboBox2.Items.Add("Micra");
                    comboBox2.Items.Add("Juke");
                    comboBox2.Items.Add("Qashqai");
                    comboBox2.Items.Add("Navara");
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    comboBox2.Items.Add("3.20d");
                    comboBox2.Items.Add("5.20d");
                    comboBox2.Items.Add("M");
                    comboBox2.Items.Add("1.20i");
                    comboBox2.Items.Add("4.20d");
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    comboBox2.Items.Add("C180");
                    comboBox2.Items.Add("CLA200");
                    comboBox2.Items.Add("S500");
                    comboBox2.Items.Add("E180");
                    comboBox2.Items.Add("C");

                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    comboBox2.Items.Add("Civic");
                    comboBox2.Items.Add("City");
                    comboBox2.Items.Add("Jazz");
                    comboBox2.Items.Add("CRX");
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    comboBox2.Items.Add("Corolla");
                    comboBox2.Items.Add("Yaris");
                    comboBox2.Items.Add("Supra");
                    comboBox2.Items.Add("Auris");
                }

            }
            catch
            {
                ;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update araclar set personel_id=@personel_id,vites_id=@vites_id,fiyat=@fiyat ,motor_hacmi=@motor_hacmi,motor_gucu=@motor_gucu,renk_id=@renk_id,kilometre=@kilometre,cikis_yili=@cikis_yili where aractablo_id=@aractablo_id";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@aractablo_id", txtAracID.Text);
            komut2.Parameters.AddWithValue("@personel_id", comboBox5.SelectedIndex + 1);
            komut2.Parameters.AddWithValue("@fiyat", textBox2.Text);
            komut2.Parameters.AddWithValue("@motor_hacmi", textBox1.Text);
            komut2.Parameters.AddWithValue("@motor_gucu", textBox3.Text);
            komut2.Parameters.AddWithValue("@kilometre", textBox4.Text);
            komut2.Parameters.AddWithValue("@cikis_yili", textBox5.Text);
            komut2.Parameters.AddWithValue("@renk_id", comboBox3.SelectedIndex + 1);
            komut2.Parameters.AddWithValue("@vites_id", comboBox4.SelectedIndex + 1);
            galeri.ekle_sil_guncelle(komut2, cümle);
            yenileAracListe();

            /*string yenicümle;
            SqlCommand komut3 = new SqlCommand();
            yenicümle = "update araclar set renk_id=@renk_id,vites_id=@vites_id,personel_id=@personel_id,model_id=@model_id where aractablo_id=@aractablo_id";
            komut3.Parameters.AddWithValue("@aractablo_id",txtAracID.Text);
            komut3.Parameters.AddWithValue("@personel_id", comboBox5.SelectedIndex + 1);
            komut3.Parameters.AddWithValue("@model_id", comboBox2.SelectedIndex + 1);
            
            
            galeri.ekle_sil_guncelle(komut3, yenicümle);
            */


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from araclar where aractablo_id='"+satır.Cells["ID"].Value.ToString()+"'";
            SqlCommand komut2 = new SqlCommand();
            galeri.ekle_sil_guncelle(komut2, cümle);
            yenileAracListe();
        }
    }
}
