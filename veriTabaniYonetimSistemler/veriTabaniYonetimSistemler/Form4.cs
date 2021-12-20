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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database= odev2;user ID= postgres; password =Sa272727");

        private void btnara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand girdi3 = new NpgsqlCommand("select uyelogin(@prmt1) ", baglanti);
            girdi3.Parameters.AddWithValue("@prmt1", long.Parse(txtuyeid.Text));
            int sonuc=(int)girdi3.ExecuteScalar(); 
            baglanti.Close();
            if (sonuc>=1)
            {
                Form5 form5 = new Form5();
                form5.Show();
            }
            else
            {
                MessageBox.Show("YANLIŞ GİRİŞ");
            }
        }
    }
}
