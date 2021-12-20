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

namespace veriTabaniYonetimSistemler
{
   
    public partial class Form3 : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=odev2; user ID=postgres; password=Sa272727");
        public Form3()
        {
            InitializeComponent();
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {
           

        }

        private void listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from uye";
            NpgsqlDataAdapter da=new NpgsqlDataAdapter(sorgu,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand girdi = new NpgsqlCommand("insert into uye (uyeId,uyeadi,uyeoldkutup,uyesoyadi) values (@prmt1,@prmt2,@prmt3,@prmt4)",baglanti);
            girdi.Parameters.AddWithValue("@prmt1",long.Parse(txtuyeıd.Text));
            girdi.Parameters.AddWithValue("@prmt2", txtuyeadi.Text);
            girdi.Parameters.AddWithValue("@prmt3", int.Parse(txtuyekutupıd.Text));
            girdi.Parameters.AddWithValue("@prmt4", txtuyesoyadi.Text);
            girdi.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt başaşrılı");

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kisilistele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from insan";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void kisiekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand girdi = new NpgsqlCommand("insert into insan (insankimlik,insanadi,insansoyadi) values (@prmt1,@prmt2,@prmt3)",baglanti);
            girdi.Parameters.AddWithValue("@prmt1", long.Parse( (txtkimlikno.Text)));
            girdi.Parameters.AddWithValue("@prmt2", txtkisiadi.Text);
            girdi.Parameters.AddWithValue("@prmt3", txtkisisoyadi.Text);
            girdi.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt başarılı");
        }

        private void çıkar_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand girdi2 = new NpgsqlCommand("delete from uye where uyeid=@prmt", baglanti);
            girdi2.Parameters.AddWithValue("@prmt", long.Parse(txtuyeıd.Text));
            girdi2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("silme gerçekleşti");

        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand girdi3 = new NpgsqlCommand("update uye set uyeadi=@prmt1,uyesoyadi=@prmt2 where uyeid=@prmt3",baglanti);
            girdi3.Parameters.AddWithValue("@prmt1",txtuyeadi.Text);
            girdi3.Parameters.AddWithValue("@prmt2", txtuyesoyadi.Text);
            girdi3.Parameters.AddWithValue("@prmt3",long.Parse(txtuyeıd.Text));
            girdi3.ExecuteNonQuery();
            MessageBox.Show("güncelleme işlemi gerçekleştirilmiştir","uyarı"
               , MessageBoxButtons.OK,MessageBoxIcon.Warning);
               
            baglanti.Close();

        }

        private void ara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable ds = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from uye where uyeadi like '%" +txtuyeadi.Text + "%' ", baglanti);
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            baglanti.Close();
        }

        private void odunc_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
