using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace finalproje
{
    public partial class DokumanEkle : Form
    {
        static string connectionString = "Server=172.21.54.148;Port=3306;Database=NYP23-1;User=NYP23-1;Password=Uludag9512357.";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlCommand insertCommand;
        MySqlDataAdapter adapter;
        DataTable dt;
        public DokumanEkle()
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
        private void DokumanEkle_Load(object sender, EventArgs e)
        {
            veriGetir();
        }



        private void dkmSilButton_Click(object sender, EventArgs e)
        {
            DokumanSil formsil = new DokumanSil();
            this.Hide();
            formsil.Show();
        }

        private void dkmGuncelleButton_Click(object sender, EventArgs e)
        {
            DokumanGuncelle form17 = new DokumanGuncelle();
            this.Hide();
            form17.Show();
        }

        private void dkmEmanetButton_Click_1(object sender, EventArgs e)
        {
            DokumanEmanet form5gecis = new DokumanEmanet();
            this.Hide();
            form5gecis.Show();
        }

        private void dkmListeleButton_Click(object sender, EventArgs e)
        {
            DokumanListele form7gecis = new DokumanListele();
            this.Hide();
            form7gecis.Show();
        }

        private void anasayfaButton_Click_1(object sender, EventArgs e)
        {
            FakulteSekreteriSayfasi form17 = new FakulteSekreteriSayfasi();
            this.Hide();
            form17.Show();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string insertSql = "INSERT INTO Dokuman (dokuman_id, dokuman_ad, dokuman_tur, dokuman_aciklama, teslim_veren, eklenme_tarihi, raf_no ) VALUES (@dokuman_id, @dokuman_ad, @dokuman_tur, @dokuman_aciklama, @teslim_veren, @eklenme_tarihi, @raf_no )";
            MySqlCommand insertCommand = new MySqlCommand(insertSql, connection);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();

                insertCommand.Parameters.AddWithValue("@dokuman_id", Convert.ToInt32(dokumanIdButton.Text));
                insertCommand.Parameters.AddWithValue("@dokuman_ad", dokumanAdButton.Text);
                insertCommand.Parameters.AddWithValue("@dokuman_tur", turCmbBox1.Text);
                insertCommand.Parameters.AddWithValue("@dokuman_aciklama", dokumanAcıklaButton.Text);
                insertCommand.Parameters.AddWithValue("@teslim_veren", dokumanVerenButton.Text);
                insertCommand.Parameters.AddWithValue("@eklenme_tarihi", dateTimePicker1.Value);
                insertCommand.Parameters.AddWithValue("@raf_no", rafnoButton.Text);

                insertCommand.ExecuteNonQuery();
                connection.Close();
                veriGetir();


                MessageBox.Show("Döküman Eklendi!");
            }
        }

        
    }
}
 