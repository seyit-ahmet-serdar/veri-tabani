namespace veriTabaniYonetimSistemler
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtpersonelgorev = new System.Windows.Forms.TextBox();
            this.txtpersonelyetkinlik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpersonelkutupid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnkisiliste = new System.Windows.Forms.Button();
            this.txtpsoyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnpercikar = new System.Windows.Forms.Button();
            this.txtpadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnperekle = new System.Windows.Forms.Button();
            this.txtpersonelid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnperliste = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnguvliste = new System.Windows.Forms.Button();
            this.btnyonliste = new System.Windows.Forms.Button();
            this.btnhizlistele = new System.Windows.Forms.Button();
            this.btnpersonelguncel = new System.Windows.Forms.Button();
            this.btniletisim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Görev :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(460, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 148);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtpersonelgorev
            // 
            this.txtpersonelgorev.Location = new System.Drawing.Point(149, 403);
            this.txtpersonelgorev.Name = "txtpersonelgorev";
            this.txtpersonelgorev.Size = new System.Drawing.Size(100, 20);
            this.txtpersonelgorev.TabIndex = 4;
            this.txtpersonelgorev.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtpersonelyetkinlik
            // 
            this.txtpersonelyetkinlik.Location = new System.Drawing.Point(149, 348);
            this.txtpersonelyetkinlik.Name = "txtpersonelyetkinlik";
            this.txtpersonelyetkinlik.Size = new System.Drawing.Size(100, 20);
            this.txtpersonelyetkinlik.TabIndex = 7;
            this.txtpersonelyetkinlik.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel Grubu :";
            // 
            // txtpersonelkutupid
            // 
            this.txtpersonelkutupid.Location = new System.Drawing.Point(149, 286);
            this.txtpersonelkutupid.Name = "txtpersonelkutupid";
            this.txtpersonelkutupid.Size = new System.Drawing.Size(100, 20);
            this.txtpersonelkutupid.TabIndex = 10;
            this.txtpersonelkutupid.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Personelin Kütüphane ID :";
            // 
            // btnkisiliste
            // 
            this.btnkisiliste.Location = new System.Drawing.Point(279, 331);
            this.btnkisiliste.Name = "btnkisiliste";
            this.btnkisiliste.Size = new System.Drawing.Size(111, 25);
            this.btnkisiliste.TabIndex = 8;
            this.btnkisiliste.Text = "Kişi Listele";
            this.btnkisiliste.UseVisualStyleBackColor = true;
            this.btnkisiliste.Click += new System.EventHandler(this.btnkisiliste_Click);
            // 
            // txtpsoyadi
            // 
            this.txtpsoyadi.Location = new System.Drawing.Point(149, 243);
            this.txtpsoyadi.Name = "txtpsoyadi";
            this.txtpsoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtpsoyadi.TabIndex = 13;
            this.txtpsoyadi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Personel Soyadı";
            // 
            // btnpercikar
            // 
            this.btnpercikar.Location = new System.Drawing.Point(279, 273);
            this.btnpercikar.Name = "btnpercikar";
            this.btnpercikar.Size = new System.Drawing.Size(111, 25);
            this.btnpercikar.TabIndex = 11;
            this.btnpercikar.Text = "Personel Çıkar";
            this.btnpercikar.UseVisualStyleBackColor = true;
            this.btnpercikar.Click += new System.EventHandler(this.btnpercikar_Click);
            // 
            // txtpadi
            // 
            this.txtpadi.Location = new System.Drawing.Point(149, 200);
            this.txtpadi.Name = "txtpadi";
            this.txtpadi.Size = new System.Drawing.Size(100, 20);
            this.txtpadi.TabIndex = 16;
            this.txtpadi.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Personel Adı";
            // 
            // btnperekle
            // 
            this.btnperekle.Location = new System.Drawing.Point(279, 211);
            this.btnperekle.Name = "btnperekle";
            this.btnperekle.Size = new System.Drawing.Size(111, 25);
            this.btnperekle.TabIndex = 14;
            this.btnperekle.Text = "Personel ekle";
            this.btnperekle.UseVisualStyleBackColor = true;
            this.btnperekle.Click += new System.EventHandler(this.btnperekle_Click);
            // 
            // txtpersonelid
            // 
            this.txtpersonelid.Location = new System.Drawing.Point(149, 158);
            this.txtpersonelid.Name = "txtpersonelid";
            this.txtpersonelid.Size = new System.Drawing.Size(100, 20);
            this.txtpersonelid.TabIndex = 19;
            this.txtpersonelid.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Personel ID :";
            // 
            // btnperliste
            // 
            this.btnperliste.Location = new System.Drawing.Point(279, 147);
            this.btnperliste.Name = "btnperliste";
            this.btnperliste.Size = new System.Drawing.Size(111, 25);
            this.btnperliste.TabIndex = 17;
            this.btnperliste.Text = "Listele personel";
            this.btnperliste.UseVisualStyleBackColor = true;
            this.btnperliste.Click += new System.EventHandler(this.btnperliste_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(704, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Kişiler Tablosu";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(556, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 20;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(679, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Personel Veya Mecra";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(640, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 22;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(460, 354);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(613, 150);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnguvliste
            // 
            this.btnguvliste.Location = new System.Drawing.Point(683, 29);
            this.btnguvliste.Name = "btnguvliste";
            this.btnguvliste.Size = new System.Drawing.Size(111, 25);
            this.btnguvliste.TabIndex = 25;
            this.btnguvliste.Text = "Listele Güvenlik";
            this.btnguvliste.UseVisualStyleBackColor = true;
            this.btnguvliste.Click += new System.EventHandler(this.btnguvliste_Click);
            // 
            // btnyonliste
            // 
            this.btnyonliste.Location = new System.Drawing.Point(475, 29);
            this.btnyonliste.Name = "btnyonliste";
            this.btnyonliste.Size = new System.Drawing.Size(111, 25);
            this.btnyonliste.TabIndex = 26;
            this.btnyonliste.Text = "Listele Yönetim";
            this.btnyonliste.UseVisualStyleBackColor = true;
            this.btnyonliste.Click += new System.EventHandler(this.btnyonliste_Click);
            // 
            // btnhizlistele
            // 
            this.btnhizlistele.Location = new System.Drawing.Point(923, 29);
            this.btnhizlistele.Name = "btnhizlistele";
            this.btnhizlistele.Size = new System.Drawing.Size(111, 25);
            this.btnhizlistele.TabIndex = 27;
            this.btnhizlistele.Text = "Listele Hizmetli";
            this.btnhizlistele.UseVisualStyleBackColor = true;
            this.btnhizlistele.Click += new System.EventHandler(this.btnhizlistele_Click);
            // 
            // btnpersonelguncel
            // 
            this.btnpersonelguncel.Location = new System.Drawing.Point(279, 394);
            this.btnpersonelguncel.Name = "btnpersonelguncel";
            this.btnpersonelguncel.Size = new System.Drawing.Size(111, 25);
            this.btnpersonelguncel.TabIndex = 28;
            this.btnpersonelguncel.Text = "Personel Güncelle";
            this.btnpersonelguncel.UseVisualStyleBackColor = true;
            this.btnpersonelguncel.Click += new System.EventHandler(this.btnpersonelguncel_Click);
            // 
            // btniletisim
            // 
            this.btniletisim.Location = new System.Drawing.Point(149, 29);
            this.btniletisim.Name = "btniletisim";
            this.btniletisim.Size = new System.Drawing.Size(156, 45);
            this.btniletisim.TabIndex = 29;
            this.btniletisim.Text = "Personel İletişim Bilgileri";
            this.btniletisim.UseVisualStyleBackColor = true;
            this.btniletisim.Click += new System.EventHandler(this.btniletisim_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 619);
            this.Controls.Add(this.btniletisim);
            this.Controls.Add(this.btnpersonelguncel);
            this.Controls.Add(this.btnhizlistele);
            this.Controls.Add(this.btnyonliste);
            this.Controls.Add(this.btnguvliste);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtpersonelid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnperliste);
            this.Controls.Add(this.txtpadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnperekle);
            this.Controls.Add(this.txtpsoyadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnpercikar);
            this.Controls.Add(this.txtpersonelkutupid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnkisiliste);
            this.Controls.Add(this.txtpersonelyetkinlik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpersonelgorev);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "PERSONEL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtpersonelgorev;
        private System.Windows.Forms.TextBox txtpersonelyetkinlik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpersonelkutupid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnkisiliste;
        private System.Windows.Forms.TextBox txtpsoyadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnpercikar;
        private System.Windows.Forms.TextBox txtpadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnperekle;
        private System.Windows.Forms.TextBox txtpersonelid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnperliste;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnguvliste;
        private System.Windows.Forms.Button btnyonliste;
        private System.Windows.Forms.Button btnhizlistele;
        private System.Windows.Forms.Button btnpersonelguncel;
        private System.Windows.Forms.Button btniletisim;
    }
}