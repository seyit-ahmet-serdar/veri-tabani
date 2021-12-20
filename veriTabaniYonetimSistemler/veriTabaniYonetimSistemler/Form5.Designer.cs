namespace veriTabaniYonetimSistemler
{
    partial class Form5
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
            this.btntumkitaplar = new System.Windows.Forms.Button();
            this.btnkitapara = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsayfasayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnodunckitaplar = new System.Windows.Forms.Button();
            this.txtkitapkutupid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkitapid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbasimid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnoduncal = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btncikar = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtyayinid = new System.Windows.Forms.TextBox();
            this.txtsalonid = new System.Windows.Forms.TextBox();
            this.txtuyeid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btntumkitaplar
            // 
            this.btntumkitaplar.Location = new System.Drawing.Point(268, 70);
            this.btntumkitaplar.Name = "btntumkitaplar";
            this.btntumkitaplar.Size = new System.Drawing.Size(75, 23);
            this.btntumkitaplar.TabIndex = 0;
            this.btntumkitaplar.Text = "Tüm kitaplar";
            this.btntumkitaplar.UseVisualStyleBackColor = true;
            this.btntumkitaplar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnkitapara
            // 
            this.btnkitapara.Location = new System.Drawing.Point(268, 115);
            this.btnkitapara.Name = "btnkitapara";
            this.btnkitapara.Size = new System.Drawing.Size(75, 23);
            this.btnkitapara.TabIndex = 1;
            this.btnkitapara.Text = "Kitap ara";
            this.btnkitapara.UseVisualStyleBackColor = true;
            this.btnkitapara.Click += new System.EventHandler(this.btnkitapara_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 192);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(431, 324);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 200);
            this.dataGridView2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Adı :";
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Location = new System.Drawing.Point(113, 73);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(100, 20);
            this.txtkitapadi.TabIndex = 5;
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(113, 122);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(100, 20);
            this.txtyazar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yazar :";
            // 
            // txtsayfasayisi
            // 
            this.txtsayfasayisi.Location = new System.Drawing.Point(113, 170);
            this.txtsayfasayisi.Name = "txtsayfasayisi";
            this.txtsayfasayisi.Size = new System.Drawing.Size(100, 20);
            this.txtsayfasayisi.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sayfa Sayısı :";
            // 
            // btnodunckitaplar
            // 
            this.btnodunckitaplar.Location = new System.Drawing.Point(268, 170);
            this.btnodunckitaplar.Name = "btnodunckitaplar";
            this.btnodunckitaplar.Size = new System.Drawing.Size(75, 56);
            this.btnodunckitaplar.TabIndex = 10;
            this.btnodunckitaplar.Text = "Ödünç Alınabilecek Kitaplar";
            this.btnodunckitaplar.UseVisualStyleBackColor = true;
            this.btnodunckitaplar.Click += new System.EventHandler(this.btnodunckitaplar_Click);
            // 
            // txtkitapkutupid
            // 
            this.txtkitapkutupid.Location = new System.Drawing.Point(113, 270);
            this.txtkitapkutupid.Name = "txtkitapkutupid";
            this.txtkitapkutupid.Size = new System.Drawing.Size(100, 20);
            this.txtkitapkutupid.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kitabın Kütüphane ID:";
            // 
            // txtkitapid
            // 
            this.txtkitapid.Location = new System.Drawing.Point(113, 216);
            this.txtkitapid.Name = "txtkitapid";
            this.txtkitapid.Size = new System.Drawing.Size(100, 20);
            this.txtkitapid.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kitap ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ÖDÜNÇ ALINABİLECEK KİTAPLAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "TÜM KİTAPLAR";
            // 
            // txtbasimid
            // 
            this.txtbasimid.Location = new System.Drawing.Point(113, 327);
            this.txtbasimid.Name = "txtbasimid";
            this.txtbasimid.Size = new System.Drawing.Size(100, 20);
            this.txtbasimid.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Kitap Basım ID";
            // 
            // btnoduncal
            // 
            this.btnoduncal.Location = new System.Drawing.Point(268, 267);
            this.btnoduncal.Name = "btnoduncal";
            this.btnoduncal.Size = new System.Drawing.Size(75, 23);
            this.btnoduncal.TabIndex = 28;
            this.btnoduncal.Text = "Ödünç AL";
            this.btnoduncal.UseVisualStyleBackColor = true;
            this.btnoduncal.Click += new System.EventHandler(this.btnoduncal_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(268, 325);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 27;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btncikar
            // 
            this.btncikar.Location = new System.Drawing.Point(268, 432);
            this.btncikar.Name = "btncikar";
            this.btncikar.Size = new System.Drawing.Size(75, 23);
            this.btncikar.TabIndex = 20;
            this.btncikar.Text = "Çıkar";
            this.btncikar.UseVisualStyleBackColor = true;
            this.btncikar.Click += new System.EventHandler(this.btncikar_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(268, 379);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 19;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 437);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Kitap Yayınevi ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Kitap Salon ID";
            // 
            // txtyayinid
            // 
            this.txtyayinid.Location = new System.Drawing.Point(113, 431);
            this.txtyayinid.Name = "txtyayinid";
            this.txtyayinid.Size = new System.Drawing.Size(100, 20);
            this.txtyayinid.TabIndex = 37;
            // 
            // txtsalonid
            // 
            this.txtsalonid.Location = new System.Drawing.Point(113, 381);
            this.txtsalonid.Name = "txtsalonid";
            this.txtsalonid.Size = new System.Drawing.Size(100, 20);
            this.txtsalonid.TabIndex = 36;
            // 
            // txtuyeid
            // 
            this.txtuyeid.Location = new System.Drawing.Point(113, 488);
            this.txtuyeid.Name = "txtuyeid";
            this.txtuyeid.Size = new System.Drawing.Size(100, 20);
            this.txtuyeid.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Üye ID:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 536);
            this.Controls.Add(this.txtuyeid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtyayinid);
            this.Controls.Add(this.txtsalonid);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtbasimid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnoduncal);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btncikar);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtkitapkutupid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtkitapid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnodunckitaplar);
            this.Controls.Add(this.txtsayfasayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtyazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkitapadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnkitapara);
            this.Controls.Add(this.btntumkitaplar);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntumkitaplar;
        private System.Windows.Forms.Button btnkitapara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsayfasayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnodunckitaplar;
        private System.Windows.Forms.TextBox txtkitapkutupid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkitapid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbasimid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnoduncal;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btncikar;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtyayinid;
        private System.Windows.Forms.TextBox txtsalonid;
        private System.Windows.Forms.TextBox txtuyeid;
        private System.Windows.Forms.Label label9;
    }
}