using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproje
{
    public partial class DokumanSil : Form
    {
        static string connectionString = "Server=172.21.54.148;Port=3306;Database=NYP23-1;User=NYP23-1;Password=Uludag9512357.";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlCommand insertCommand;
        MySqlDataAdapter adapter;
        DataTable dt;
        public DokumanSil()
        {
            InitializeComponent();
        }
        void veriGetir()
        {
            dt = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM Dokuman", connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        private void DokumanSil_Load(object sender, EventArgs e)
        {
            veriGetir();
        }
        private void dkmSilButtton_Click(object sender, EventArgs e)
        {
            DokumanSil form9gecis = new DokumanSil();
            this.Hide();
            form9gecis.Show();
        }

       
        private void dkmEkleButton_Click(object sender, EventArgs e)
        {
            DokumanEkle form18 = new DokumanEkle();
            this.Hide();
            form18.Show();
        }

        private void dkmGuncelleButton_Click(object sender, EventArgs e)
        {
            DokumanGuncelle form16 = new DokumanGuncelle();
            this.Hide();
            form16.Show();
        }

        private void dkmEmanetButton_Click(object sender, EventArgs e)
        {
            DokumanEmanet form19 = new DokumanEmanet();
            this.Hide();
            form19.Show();
        }

        private void dkmListeleButton_Click(object sender, EventArgs e)
        {
            DokumanListele form20 = new DokumanListele();
                this.Hide();
                form20.Show();
        }

        private void ansayfaButton_Click(object sender, EventArgs e)
        {
            FakulteSekreteriSayfasi form33 = new FakulteSekreteriSayfasi();
            this.Hide();
            form33.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deleteSql = "DELETE FROM Dokuman WHERE dokuman_id = @dokuman_id";
            MySqlCommand deleteCommand = new MySqlCommand(deleteSql, connection);
            if(connection.State != ConnectionState.Open)
            {
                connection.Open();

                deleteCommand.Parameters.AddWithValue("@dokuman_id", dokumanIdButton.Text);

                deleteCommand.ExecuteNonQuery();
                connection.Close();
                veriGetir();

                MessageBox.Show("Döküman Silindi");

            }
        }

        
        

        private void textArama_TextChanged(object sender, EventArgs e)
        { 
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                 
                string query = "SELECT * FROM Dokuman WHERE dokuman_id LIKE @aramaKelimesi OR dokuman_ad LIKE @aramaKelimesi OR dokuman_tur LIKE @aramaKelimesi OR dokuman_aciklama LIKE @aramaKelimesi OR teslim_veren LIKE @aramaKelimesi OR eklenme_tarihi LIKE @aramaKelimesi OR raf_no LIKE @aramaKelimesi";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                   
                    cmd.Parameters.AddWithValue("@aramaKelimesi", "%" + textArama.Text + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
