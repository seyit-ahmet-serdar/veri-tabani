namespace veriTabaniYonetimSistemler
{
    partial class Form4
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
            this.btnara = new System.Windows.Forms.Button();
            this.txtuyeid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(88, 130);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 0;
            this.btnara.Text = "GİRİŞ";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // txtuyeid
            // 
            this.txtuyeid.Location = new System.Drawing.Point(77, 90);
            this.txtuyeid.Name = "txtuyeid";
            this.txtuyeid.Size = new System.Drawing.Size(100, 20);
            this.txtuyeid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üye ID\'nizi Giriniz";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 198);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtuyeid);
            this.Controls.Add(this.btnara);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.TextBox txtuyeid;
        private System.Windows.Forms.Label label1;
    }
}