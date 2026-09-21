using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp13
{
    public partial class marka : Form
    {
        public marka()
        {
            InitializeComponent();
        }

        
        private SqlConnection baglanti = new SqlConnection(@"Data Source=emine\SQLEXPRESS;Initial Catalog=oto;Integrated Security=True");

        
        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtbox12.Text))
            {
                MessageBox.Show("Lütfen bir marka adı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                
                string sorgu = "INSERT INTO marka_bilgileri (marka) VALUES (@p1)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtbox12.Text.Trim()); 

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Yeni marka başarıyla sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbox12.Clear(); 
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void marka_Load(object sender, EventArgs e)
        {

        }

        private void btn24_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO marka_bilgileri (marka) VALUES (@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtbox12.Text); 
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka eklendi!");
                this.Close(); 
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }
    }
}
