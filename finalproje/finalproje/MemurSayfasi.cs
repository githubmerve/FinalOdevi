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
    public partial class MemurSayfasi : Form
    {
        public MemurSayfasi()
        {
            InitializeComponent();
        }

        private void mdkmEkleButton_Click(object sender, EventArgs e)
        {
            MemurDokumanEkle form10 = new MemurDokumanEkle();
            this.Hide();
            form10.Show();
        }

        private void mdkmListButton_Click(object sender, EventArgs e)
        {
            MemurDokumanListele form13 = new MemurDokumanListele();
            this.Hide();
            form13.Show();
        }

        private void mdkmEmanetButton_Click(object sender, EventArgs e)
        {
            MemurDokumanEmaneti form14 = new MemurDokumanEmaneti();
            this.Hide();
            form14.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
