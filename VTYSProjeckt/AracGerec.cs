using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYSProjeckt
{
    public partial class AracGerec : Form
    {
        public AracGerec()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database=Kutuphane; user ID=postgres;password=Eray5252+");
        private void AracGerec_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from aracgerec";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource= ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into aracgerec(aracadi,aracno,odano,ucreti) values(@p1,@p2,@p3,@p4", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBox1.Text);
            komut1.Parameters.AddWithValue("@p2", textBox3.Text);
            komut1.Parameters.AddWithValue("@p3", textBox4.Text);
            komut1.Parameters.AddWithValue("@p4", textBox5.Text);
            komut1.ExecuteNonQuery();
            MessageBox.Show("Arac Ekleme Islemi Basarili");
        }
    }
}
