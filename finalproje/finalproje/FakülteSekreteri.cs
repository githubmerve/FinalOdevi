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
    public partial class FakulteSekreteriSayfasi : Form
    {
        static string connectionString = "Server=172.21.54.148;Port=3306;Database=NYP23-1;User=NYP23-1;Password=Uludag9512357.";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlCommand insertCommand;
        MySqlDataAdapter adapter;
        DataTable dt;
        public FakulteSekreteriSayfasi()
        {
            InitializeComponent();
        }
        void veriGetir()
        {
            dt = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM Emanet", connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }




        private void dkmEkleButton_Click_1(object sender, EventArgs e)
        {
            DokumanEkle form3gecis = new DokumanEkle();
            this.Hide();
            form3gecis.Show();
        }

        private void dkmSilButton_Click(object sender, EventArgs e)
        {
            DokumanSil form8gecis = new DokumanSil();
            this.Hide();
            form8gecis.Show();
        }

        private void dkmGuncelleButton_Click(object sender, EventArgs e)
        {
            DokumanGuncelle formguncelle = new DokumanGuncelle();
            this.Hide();
            formguncelle.Show();
        }

        private void dkmEmanetButton_Click_1(object sender, EventArgs e)
        {
            DokumanEmanet form4gecis = new DokumanEmanet();
            this.Hide();
            form4gecis.Show();
        }

        private void dkmListeleButton_Click(object sender, EventArgs e)
        {
            DokumanListele form6gecis = new DokumanListele();
            this.Hide();
            form6gecis.Show();
        }

        private void FakulteSekreteriSayfasi_Load(object sender, EventArgs e)
        {
            veriGetir();
        }
        private void GeçikmişEmanetleriListele()
        {
            try
            {
                connection.Open();

               
                string query = "SELECT * FROM Emanet WHERE verilme_tarihi < CURRENT_DATE AND alinma_tarihi IS NULL";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                DataTable dt = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }

                DataColumn emanetGecikmeColumn = new DataColumn("Gecikme Durumu", typeof(string));
                emanetGecikmeColumn.DefaultValue = "Gecikmiş Emanet";
                dt.Columns.Add(emanetGecikmeColumn);


                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
            finally
            {
                connection.Close();
            }
        }

        
        private void btnGeçikmişEmanetleriListele_Click(object sender, EventArgs e)
        {
            GeçikmişEmanetleriListele();
        }
    }
    }

