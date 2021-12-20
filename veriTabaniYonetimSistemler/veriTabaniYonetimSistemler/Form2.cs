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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=odev2; user ID=postgres; password=Sa272727");
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnperliste_Click(object sender, EventArgs e)
        {
            string sorgu1 = "select * from personel.personel";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnperekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand girdi = new NpgsqlCommand("insert into personel.personel (personelid,padi,psoyadi,personelkutupid,yetkinlikseviyesi) values (@prmt1,@prmt2,@prmt3,@prmt4,@prmt5)", baglanti);
            NpgsqlCommand girdi2 = new NpgsqlCommand("insert into personel.yonetimkurulu (idariid,idarigorev) values (@prmt1,@prmt6)",baglanti);
            NpgsqlCommand girdi3 = new NpgsqlCommand("insert into personel.hizmetli(hizmetliid,hizmetligorevi) values (@prmt1,@prmt6)", baglanti);
            NpgsqlCommand girdi4 = new NpgsqlCommand("insert into personel.guvenlik(guvenlikid,guvenlikgorev) values (@prmt1,@prmt6)", baglanti);
            girdi.Parameters.AddWithValue("@prmt1", long.Parse(txtpersonelid.Text));
            girdi.Parameters.AddWithValue("@prmt2", txtpadi.Text);
            girdi.Parameters.AddWithValue("@prmt3", txtpsoyadi.Text);
            girdi.Parameters.AddWithValue("@prmt4",int.Parse(txtpersonelkutupid.Text));
            girdi.Parameters.AddWithValue("@prmt5", txtpersonelyetkinlik.Text);
            girdi.ExecuteNonQuery();

            if (txtpersonelyetkinlik.Text.ToString() == "y")
            {
                girdi2.Parameters.AddWithValue("@prmt1", long.Parse(txtpersonelid.Text));
                girdi2.Parameters.AddWithValue("@prmt6", txtpersonelgorev.Text);
                girdi2.ExecuteNonQuery();
            }
            else if (txtpersonelyetkinlik.Text.ToString() == "h")
            {
                girdi3.Parameters.AddWithValue("@prmt1", long.Parse(txtpersonelid.Text));
                girdi3.Parameters.AddWithValue("@prmt6", txtpersonelgorev.Text);
                girdi3.ExecuteNonQuery();
            }
            else if (txtpersonelyetkinlik.Text.ToString() == "g")
            {
                girdi4.Parameters.AddWithValue("prmt1", long.Parse(txtpersonelid.Text));
                girdi4.Parameters.AddWithValue("@prmt6", txtpersonelid.Text);
                girdi4.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("Yonetim kurulu için y " +
                    "Guvenlik için g " +
                    "Hizmetli için h girmelisiniz" +
                    "siz hiçbirini girmediniz " +
                    "lütfen düzeltip tekrar deneyin");
            }
            baglanti.Close();
            MessageBox.Show("personel kaydı başarılı");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpercikar_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand girdi2 = new NpgsqlCommand("delete from personel.personel where personelid=@prmt", baglanti);
            girdi2.Parameters.AddWithValue("@prmt", long.Parse(txtpersonelid.Text));
            girdi2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("silme gerçekleşti");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnkisiliste_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from insan";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnyonliste_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from personel.yonetimkurulu";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

        }

        private void btnguvliste_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from personel.guvenlik";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnhizlistele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from personel.hizmetli";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnpersonelguncel_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand girdi1 = new NpgsqlCommand("update personel.personel set padi=@prmt2,psoyadi=@prmt3,personelkutupid=@prmt4,yetkinlikseviyesi=@prmt5 where personelid=@prmt1", baglanti);
            NpgsqlCommand girdi2 = new NpgsqlCommand("update personel.yonetimkurulu set idarigorev=@prmt6 where iadriid=@prmt1", baglanti);
            NpgsqlCommand girdi3 = new NpgsqlCommand("update personel.hizmetli set hizmetligorevi=@prmt6 where hizmetliid=@prmt1", baglanti);
            NpgsqlCommand girdi4 = new NpgsqlCommand("update personel.guvenlik set guvenlikgorev=@prmt6 where guvenlikid=@prmt1", baglanti);
            girdi1.Parameters.AddWithValue("@prmt1", long.Parse(txtpersonelid.Text));
            girdi1.Parameters.AddWithValue("@prmt2", txtpadi.Text);
            girdi1.Parameters.AddWithValue("@prmt3", txtpsoyadi.Text);
            girdi1.Parameters.AddWithValue("@prmt4",int.Parse(txtpersonelkutupid.Text));
            girdi1.Parameters.AddWithValue("@prmt5",txtpersonelyetkinlik);
            girdi1.ExecuteNonQuery();
            if (txtpersonelyetkinlik.Text.ToString()=="y")
            {
                girdi2.Parameters.AddWithValue("@prmt1", long.Parse(txtpersonelid.Text));
                girdi2.Parameters.AddWithValue("@prmt6", txtpersonelgorev.Text);
                girdi2.ExecuteNonQuery();
            }
            else if (txtpersonelyetkinlik.Text.ToString() == "h")
            {
                girdi3.Parameters.AddWithValue("@prmt1", long.Parse(txtpersonelid.Text));
                girdi3.Parameters.AddWithValue("@prmt6", txtpersonelgorev.Text);
                girdi3.ExecuteNonQuery();
            }
            else if (txtpersonelyetkinlik.Text.ToString() == "g")
            {
                girdi4.Parameters.AddWithValue("prmt1", long.Parse(txtpersonelid.Text));
                girdi4.Parameters.AddWithValue("@prmt6", txtpersonelid.Text);
                girdi4.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("Yonetim kurulu için y " +
                    "Guvenlik için g " +
                    "Hizmetli için h girmelisiniz" +
                    "siz hiçbirini girmediniz " +
                    "lütfen düzeltip tekrar deneyin");
            }
            MessageBox.Show("güncelleme işlemi gerçekleştirilmiştir", "uyarı"
               , MessageBoxButtons.OK, MessageBoxIcon.Warning);

            baglanti.Close();
        }

        private void btniletisim_Click(object sender, EventArgs e)
        {
            string sorgu = " select personelid,padi,psoyadi,email(padi,psoyadi),telefonno(personelid) from personel.personel";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
    }
}
