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
    public partial class DokumanListele : Form
    {
        static string connectionString = "Server=172.21.54.148;Port=3306;Database=NYP23-1;User=NYP23-1;Password=Uludag9512357.";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlCommand insertCommand;
        MySqlDataAdapter adapter;
        DataTable dtEmanet;
        DataTable dtDokuman;
        public DokumanListele()
        {
            InitializeComponent();
        }
       

        void veriGetir()
        {
            dtEmanet = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM Emanet", connection);
            adapter.Fill(dtEmanet);
            connection.Close();
        }

        void veriGetir1()
        {
            dtDokuman = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM Dokuman", connection);
            adapter.Fill(dtDokuman);
            connection.Close();
        }

        private void DokumanListele_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                DataTable emanetTable = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Emanet", connection))
                {
                    adapter.Fill(emanetTable);
                }

                DataColumn emanetDurumuColumn = new DataColumn("EmanetDurumu", typeof(string));
                emanetDurumuColumn.DefaultValue = "Emanet";
                emanetTable.Columns.Add(emanetDurumuColumn);

                DataTable dokumanTable = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Dokuman", connection))
                {
                    adapter.Fill(dokumanTable);
                }

                DataColumn dokumanDurumuColumn = new DataColumn("dokumanDurumu", typeof(string));
                dokumanDurumuColumn.DefaultValue = "dokuman";
                dokumanTable.Columns.Add(dokumanDurumuColumn);

                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(emanetTable);
                dataSet.Tables.Add(dokumanTable);

                dataGridViewEmanet.DataSource = dataSet.Tables[0];
                dataGridViewDokuman.DataSource = dataSet.Tables[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void dkmSilButtton_Click(object sender, EventArgs e)
        {
            DokumanSil form9gecis = new DokumanSil();
            this.Hide();
            form9gecis.Show();
        }

        private void dkmEmanetButton_Click(object sender, EventArgs e)
        {
            DokumanEmanet form25 = new DokumanEmanet();
            this.Hide();
            form25.Show();

        }

        private void dkmGuncelleButton_Click(object sender, EventArgs e)
        {
            DokumanGuncelle form26 = new DokumanGuncelle();
            this.Hide();
            form26.Show();
        }

        private void dkmSilButtton_Click_1(object sender, EventArgs e)
        {
            DokumanSil form27 = new DokumanSil();
            this.Hide();
            form27.Show();
        }

        private void dkmEkleButton_Click(object sender, EventArgs e)
        {
            DokumanEkle form28 = new DokumanEkle();
                this.Hide();
            form28.Show();
        }

        private void anasayfaButton_Click(object sender, EventArgs e)
        {
            FakulteSekreteriSayfasi form29 = new FakulteSekreteriSayfasi();
            this.Hide(); form29.Show();
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dkmListButton_Click(object sender, EventArgs e)
        {
            insertCommand.ExecuteNonQuery();
            connection.Close();
            veriGetir();
        }

       
    }
}
