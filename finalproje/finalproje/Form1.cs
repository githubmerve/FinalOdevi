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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String mysqlCon = "Server=172.21.54.148;Port=3306;Database=NYP23-1;User=NYP23-1;Password=Uludag9512357.";
            MySqlConnection mysqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mysqlConnection.Open();
                MessageBox.Show("Giriş Başarılı");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullanici.Text;
            string sifre = txtSifre.Text;

            if (kullaniciAdi == "admin" && sifre == "12345")
            {
                FakulteSekreteriSayfasi form2gecis = new FakulteSekreteriSayfasi();
                this.Hide();
                form2gecis.Show();
            }
            else if (kullaniciAdi == "kullanıcı" && sifre == "abcdf")
            {
                MemurSayfasi form3gecis = new MemurSayfasi();
                this.Hide();
                form3gecis.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }
        }

       
    }
}
