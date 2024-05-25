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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalproje
{
    public partial class DokumanGuncelle : Form
    {
        static string connectionString = "Server=172.21.54.148;Port=3306;Database=NYP23-1;User=NYP23-1;Password=Uludag9512357.";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlCommand insertCommand;
        MySqlDataAdapter adapter;
        DataTable dt;
        public DokumanGuncelle()
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


        private void dkmEmanetButton_Click_1(object sender, EventArgs e)
        {
            DokumanEmanet form21 = new DokumanEmanet();
            this.Hide();
            form21.Show();
        }

        private void dkmListButton_Click_1(object sender, EventArgs e)
        {
            DokumanEkle form24 = new DokumanEkle();
            this.Hide();
            form24.Show();
        }

        private void dkmEkleButton_Click_1(object sender, EventArgs e)
        {
            DokumanEkle form24 = new DokumanEkle();
            this.Hide();
            form24.Show();
        }

        private void dkmEkleButton_Click(object sender, EventArgs e)
        {
            DokumanEkle form24 = new DokumanEkle();
            this.Hide();
            form24.Show();
        }

        private void anasayfaButton_Click_1(object sender, EventArgs e)
        {
            FakulteSekreteriSayfasi form25 = new FakulteSekreteriSayfasi();
            this.Hide();
            form25.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedField = comboBox1.Text;

            // Güncelleme SQL komutu
            string updateSql = "";
            MySqlCommand updateCommand = new MySqlCommand(updateSql, connection);

            switch (selectedField)
            {
                case "dokuman_ad":
                    updateSql = "UPDATE Dokuman SET dokuman_ad = @newDokuman_ad WHERE dokuman_id = @dokuman_id";
                    break;
                case "dokuman_aciklama":
                    updateSql = "UPDATE Dokuman SET dokuman_aciklama = @newDokuman_aciklama WHERE dokuman_id = @dokuman_id";
                    break;
                case "dokuman_tur":
                    updateSql = "UPDATE Dokuman SET dokuman_tur = @newDokuman_tur WHERE dokuman_id = @dokuman_id";
                    break;
                case "raf_no":
                    updateSql = "UPDATE Dokuman SET raf_no = @newDokuman_tur WHERE dokuman_id = @dokuman_id";
                    break;

                default:
                    MessageBox.Show("Lütfen güncellenecek alanı seçin.");
                    return;
            }

            updateCommand.CommandText = updateSql;

            updateCommand.Parameters.AddWithValue("@newDokuman_ad", textBox1.Text);
            updateCommand.Parameters.AddWithValue("@newDokuman_aciklama", textBox1.Text);
            updateCommand.Parameters.AddWithValue("@newDokuman_tur", textBox1.Text);
            updateCommand.Parameters.AddWithValue("@newraf_no", textBox1.Text);
            updateCommand.Parameters.AddWithValue("@dokuman_id", textBox2.Text);

            try
            {
                connection.Open();
                int rowAffected = updateCommand.ExecuteNonQuery();
                textBox2.Text = $"Dokuman ID: {textBox2.Text}, {selectedField}: {textBox1.Text}";

                MessageBox.Show(rowAffected + " satır güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
                veriGetir();
            }
        }
        private void DokumanGuncelle_Load(object sender, EventArgs e)
        {
            veriGetir();
        }

        private void veriGetir(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
         
                string selectQuery = "SELECT * FROM Dokuman";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);

                using (MySqlDataReader reader = selectCommand.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    { 
                        dataGridView1.Rows.Add(
                            reader["dokuman_id"].ToString(),
                            reader["dokuman_ad"].ToString(),
                            reader["dokuman_aciklama"].ToString(),
                            reader["dokuman_tur"].ToString()
                        );
                    }
                }
            }

            finally
            {
                insertCommand.ExecuteNonQuery();
                connection.Close();
                veriGetir();
            }
        }

        private void dkmSilButtton_Click(object sender, EventArgs e)
        {

        }

        
    }
}





