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
    public partial class kitap : Form
    {
        public kitap()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database=Kutuphane; user ID=postgres;password=Eray5252+");
        private void kitap_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from tur", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cturid.DisplayMember = "turadi";
            cturid.ValueMember = "turid";
            cturid.DataSource= dt;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from kitap";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into kitap(adi,isbn,kutuphaneno,turid,yayinciid,yazarno) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", int.Parse(txtisb.Text));
            komut.Parameters.AddWithValue("@p3", int.Parse(txtkutuphane.Text));
            komut.Parameters.AddWithValue("@p4", int.Parse(cturid.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@p5", int.Parse(txtyayinci.Text));
            komut.Parameters.AddWithValue("@p6", int.Parse(txtyazar.Text));

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap kaydi yapildi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("DElete From kitap where isbn=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtisb.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap silindi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("Update kitap set adi=@p1, stokadet=@p2, kutuphaneno=@p3, turid=@p4, yayinciid=@p5, yazarno=@p6 where isbn=@p7", baglanti);
            komut3.Parameters.AddWithValue("@p1", txtAd.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(txtstok.Text));
            komut3.Parameters.AddWithValue("@p3", int.Parse(txtkutuphane.Text));
            komut3.Parameters.AddWithValue("@p4", int.Parse(cturid.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p5", int.Parse(txtyayinci.Text));
            komut3.Parameters.AddWithValue("@p6", int.Parse(txtyazar.Text));
            komut3.Parameters.AddWithValue("@p7", int.Parse(txtisb.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Girilen ISBN ait Kitap Bilgileri Guncellendi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "Select * from kitap where adi=@adi";
            NpgsqlCommand komut4 = new NpgsqlCommand(kayit, baglanti);
            komut4.Parameters.AddWithValue("@adi", txtAd.Text);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
