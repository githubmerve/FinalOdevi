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
    public partial class MemurDokumanEmaneti : Form
    {
        static string connectionString = "Server=172.21.54.148;Port=3306;Database=NYP23-1;User=NYP23-1;Password=Uludag9512357.";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlCommand insertCommand;
        MySqlDataAdapter adapter;
        DataTable dt;
        public MemurDokumanEmaneti()
        {
            InitializeComponent();
        }
        void veriGetir()
        {
            dt = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM Dokuman", connection);
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();
        }
        private void MemurDokumanEmaneti_Load(object sender, EventArgs e)
        {
            veriGetir();
        }
        private void mdkmListButton_Click(object sender, EventArgs e)
        {
            MemurDokumanListele form12 = new MemurDokumanListele();
            this.Hide();
            form12.Show();
        }

        private void manasayfaButton_Click(object sender, EventArgs e)
        {
            MemurSayfasi form15 = new MemurSayfasi();
            this.Hide();
            form15.Show();
        }
        private void textArama_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Dokuman WHERE dokuman_id LIKE @aramaKelimesi OR dokuman_ad LIKE @aramaKelimesi OR dokuman_tur LIKE @aramaKelimesi OR dokuman_aciklama LIKE @aramaKelimesi OR teslim_veren LIKE @aramaKelimesi OR eklenme_tarihi LIKE @aramaKelimesi OR eklenme_tarihi LIKE @aramaKelimesi";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {

                    cmd.Parameters.AddWithValue("@aramaKelimesi", "%" + textArama.Text + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView2.DataSource = dt;
                }
            }
        }
            private void emanetButton_Click(object sender, EventArgs e)
        {
                string insertSql = "INSERT INTO Emanet (dokuman_id, dokuman_ad, dokuman_tur, dokuman_aciklama, teslim_alan, alinma_tarihi, verilme_tarihi, raf_no ) VALUES (@dokuman_id, @dokuman_ad, @dokuman_tur, @dokuman_aciklama, @teslim_alan, @alinma_tarihi, @verilme_tarihi, @raf_no )";
                MySqlCommand insertCommand = new MySqlCommand(insertSql, connection);

                try
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    insertCommand.Parameters.AddWithValue("@dokuman_id", Convert.ToInt32(dokumanIdButton.Text));
                    insertCommand.Parameters.AddWithValue("@dokuman_ad", dokumanAdButton.Text);
                    insertCommand.Parameters.AddWithValue("@dokuman_tur", turCmbBox1.Text);
                    insertCommand.Parameters.AddWithValue("@dokuman_aciklama", dokumanAcıklaButton.Text);
                    insertCommand.Parameters.AddWithValue("@teslim_alan", dokumanAlanButton.Text);
                    insertCommand.Parameters.AddWithValue("@verilme_tarihi", dateTimePicker1.Value);
                    insertCommand.Parameters.AddWithValue("@alinma_tarihi", dateTimePicker2.Value);
                    insertCommand.Parameters.AddWithValue("@raf_no", rafnoButton.Text);

                    insertCommand.ExecuteNonQuery();

                    int dokumanId = Convert.ToInt32(dokumanIdButton.Text);
                    KaldırDokuman(dokumanId);

                    veriGetir();

                    MessageBox.Show("Emanet kaydı başarıyla eklendi!");
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
            private void KaldırDokuman(int dokumanId)
            {
                try
                {
                    string deleteSql = "DELETE FROM Dokuman WHERE dokuman_id = @dokuman_id";
                    MySqlCommand deleteCommand = new MySqlCommand(deleteSql, connection);

                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    deleteCommand.Parameters.AddWithValue("@dokuman_id", dokumanId);
                    deleteCommand.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
            }

        }


    }

