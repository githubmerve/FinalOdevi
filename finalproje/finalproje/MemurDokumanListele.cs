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
    public partial class MemurDokumanListele : Form
    {
        static string connectionString = "Server=172.21.54.148;Port=3306;Database=NYP23-1;User=NYP23-1;Password=Uludag9512357.";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlCommand insertCommand;
        MySqlDataAdapter adapter;
        DataTable dtEmanet;
        DataTable dtDokuman;
        public MemurDokumanListele()
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
        private void MemurDokumanListele_Load(object sender, EventArgs e)
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

                // İndeks numaralarını düzelt
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
    
        private void manasayfaButton_Click(object sender, EventArgs e)
        {
            MemurSayfasi form16 = new MemurSayfasi();
            this.Hide();
            form16.Show();
        }

        private void mdkmListButton_Click(object sender, EventArgs e)
        {

        }

        private void mdkmEkleButton_Click(object sender, EventArgs e)
        {
            MemurDokumanEkle formdokumanı = new MemurDokumanEkle();
            this.Hide();
            formdokumanı.Show();
        }

        private void mdkmEmanetButton_Click(object sender, EventArgs e)
        {
            MemurDokumanEmaneti formemanet = new MemurDokumanEmaneti();
            this.Hide();
            formemanet.Show();
        }
    }
}
