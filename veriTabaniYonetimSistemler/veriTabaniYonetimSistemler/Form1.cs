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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database= odev2;user ID= postgres; password =Sa272727");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             Form2 form2=new Form2() ;
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 from3=new Form3() ; 
            from3.Show();
        }
    }
}
