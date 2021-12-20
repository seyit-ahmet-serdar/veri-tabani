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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=odev2; user ID=postgres; password=Sa272727");

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = " select  * from kitap ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnodunckitaplar_Click(object sender, EventArgs e)
        {
            string sorgu = " select  * from kitap where oad='1'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        
        }

        private void btnkitapara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable ds = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from kitap where kitapadi like '%" + txtkitapadi.Text + "%' ", baglanti);
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            baglanti.Close();
        }

        private void btnoduncal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand girdi = new NpgsqlCommand("update kitap set oad='0' where kitapid=@prmt1", baglanti);
          
            girdi.Parameters.AddWithValue("@prmt1", txtkitapid.Text);

            NpgsqlCommand girdi2 = new NpgsqlCommand("insert into odunc (oduncid,odunckitapid,odunctarihi,oduncuyeid) values (nextval('odunc_oduncid_seq'),@p1,current_date,@p2))", baglanti);
            girdi2.Parameters.AddWithValue("@p1", txtkitapid.Text);
            girdi2.Parameters.AddWithValue("@p2", long.Parse(txtuyeid.Text));
            girdi2.ExecuteNonQuery();
            girdi.ExecuteNonQuery();
            
            baglanti.Close();
            MessageBox.Show("kayıt başarılı");
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand girdi = new NpgsqlCommand("insert into kitap (kitapadi,kitapyazar,sayfasayisi,kitapid,kitapkutupid,kitapbasimid,kitapsalonid,kitapyayineviid) values (@prmt1,@prmt2,@prmt3,@prmt4,@prmt5,@prmt6,@prmt7,@prmt8)", baglanti);
            girdi.Parameters.AddWithValue("@prmt1", (txtkitapadi.Text));
            girdi.Parameters.AddWithValue("@prmt2", txtyazar.Text);
            girdi.Parameters.AddWithValue("@prmt3", txtsayfasayisi.Text);
            girdi.Parameters.AddWithValue("@prmt4", txtkitapid.Text);
            girdi.Parameters.AddWithValue("@prmt5", txtkitapkutupid.Text);
            girdi.Parameters.AddWithValue("@prmt6", txtbasimid.Text);
            girdi.Parameters.AddWithValue("@prmt7", txtsalonid.Text);
            girdi.Parameters.AddWithValue("@prmt8", txtyayinid.Text);

            girdi.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("kayıt başarılı");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand girdi = new NpgsqlCommand("update kitap set (kitapadi,kitapyazar,sayfasayisi,kitapkutupid,kitapbasimid,kitapsalonid,kitapyayineviid) = (@prmt1,@prmt2,@prmt3,@prmt5,@prmt6,@prmt7,@prmt8 where kitapid=@prmt4)", baglanti);
            girdi.Parameters.AddWithValue("@prmt1", (txtkitapadi.Text));
            girdi.Parameters.AddWithValue("@prmt2", txtyazar.Text);
            girdi.Parameters.AddWithValue("@prmt3", txtsayfasayisi.Text);
            girdi.Parameters.AddWithValue("@prmt4", txtkitapid.Text);
            girdi.Parameters.AddWithValue("@prmt5", txtkitapkutupid.Text);
            girdi.Parameters.AddWithValue("@prmt6", txtbasimid.Text);
            girdi.Parameters.AddWithValue("@prmt7", txtsalonid.Text);
            girdi.Parameters.AddWithValue("@prmt8", txtyayinid.Text);

            girdi.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("kayıt başarılı");
        }

        private void btncikar_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand girdi2 = new NpgsqlCommand("delete from kitap where kitapid=@prmt", baglanti);
            girdi2.Parameters.AddWithValue("@prmt", long.Parse(txtkitapid.Text));
            girdi2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("silme gerçekleşti");
        }
    }
}
