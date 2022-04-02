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
    public partial class frmAracKayıt : Form
    {
        Galeri galeri = new Galeri();
        
        public frmAracKayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SERBAY\SQLEXPRESS;Initial Catalog=GaleriOtomasyon;Integrated Security=True");
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Items.Clear();
                if(comboBox1.SelectedIndex==0)
                {
                    comboBox2.Items.Add("Micra");
                    comboBox2.Items.Add("Juke");
                    comboBox2.Items.Add("Qashqai");
                    comboBox2.Items.Add("Navara");
                }
                else if(comboBox1.SelectedIndex==1)
                {
                    comboBox2.Items.Add("3.20d");
                    comboBox2.Items.Add("5.20d");
                    comboBox2.Items.Add("M");
                    comboBox2.Items.Add("1.20i");
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    comboBox2.Items.Add("C180");
                    comboBox2.Items.Add("CLA200");
                    comboBox2.Items.Add("S500");
                    comboBox2.Items.Add("E180");
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            string cümle = "insert into araclar(personel_id,model_id,fiyat,motor_hacmi,motor_gucu,kilometre,renk_id,vites_id,cikis_yili) values(@personel_id,@model_id,@fiyat,@motor_hacmi,@motor_gucu,@kilometre,@renk_id,@vites_id,@cikis_yili)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@personel_id",comboBox5.SelectedIndex + 1);
            komut2.Parameters.AddWithValue("@model_id", comboBox2.SelectedIndex + 1);
            komut2.Parameters.AddWithValue("@fiyat", textBox2.Text);
            komut2.Parameters.AddWithValue("@motor_hacmi", textBox1.Text);
            komut2.Parameters.AddWithValue("@motor_gucu", textBox3.Text);
            komut2.Parameters.AddWithValue("@kilometre", textBox4.Text);
            komut2.Parameters.AddWithValue("@renk_id", comboBox3.SelectedIndex + 1);
            komut2.Parameters.AddWithValue("@vites_id", comboBox4.SelectedIndex + 1);
            komut2.Parameters.AddWithValue("@cikis_yili", textBox5.Text);
            galeri.ekle_sil_guncelle(komut2,cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";


        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmAracKayıt_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from personeller",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                comboBox5.Items.Add(read["personel_ad"]);
            }

            baglanti.Close();

        }
    }
}
