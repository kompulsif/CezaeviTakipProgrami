﻿namespace CezaeviProgram.PersonelIslemleri
{
    partial class PersonelDuzenle
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
            this.gorevYerBilgi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gorevYeri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maas = new System.Windows.Forms.TextBox();
            this.cikis = new System.Windows.Forms.DateTimePicker();
            this.giris = new System.Windows.Forms.DateTimePicker();
            this.babaAdi = new System.Windows.Forms.TextBox();
            this.anneAdi = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.personelTipi = new System.Windows.Forms.ComboBox();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.kimlik = new System.Windows.Forms.TextBox();
            this.adi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gorevYerBilgi
            // 
            this.gorevYerBilgi.BackColor = System.Drawing.SystemColors.Window;
            this.gorevYerBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.gorevYerBilgi.Location = new System.Drawing.Point(295, 243);
            this.gorevYerBilgi.Multiline = true;
            this.gorevYerBilgi.Name = "gorevYerBilgi";
            this.gorevYerBilgi.ReadOnly = true;
            this.gorevYerBilgi.Size = new System.Drawing.Size(244, 95);
            this.gorevYerBilgi.TabIndex = 159;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(328, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 57);
            this.button1.TabIndex = 158;
            this.button1.Text = "Personeli Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gorevYeri
            // 
            this.gorevYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gorevYeri.FormattingEnabled = true;
            this.gorevYeri.Location = new System.Drawing.Point(415, 212);
            this.gorevYeri.Name = "gorevYeri";
            this.gorevYeri.Size = new System.Drawing.Size(124, 24);
            this.gorevYeri.TabIndex = 157;
            this.gorevYeri.SelectedIndexChanged += new System.EventHandler(this.gorevYeri_SelectedIndexChanged);
            this.gorevYeri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gorevYeri_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Olive;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(296, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 152;
            this.label1.Text = "Görev Yeri   ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Olive;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(296, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 24);
            this.label6.TabIndex = 145;
            this.label6.Text = "                  Adres                   ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // adres
            // 
            this.adres.BackColor = System.Drawing.SystemColors.Window;
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.adres.Location = new System.Drawing.Point(296, 103);
            this.adres.MaxLength = 300;
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(244, 95);
            this.adres.TabIndex = 148;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(140, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(289, 41);
            this.label13.TabIndex = 135;
            this.label13.Text = "Personel Düzenle";
            // 
            // maas
            // 
            this.maas.BackColor = System.Drawing.SystemColors.Window;
            this.maas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.maas.Location = new System.Drawing.Point(137, 368);
            this.maas.MaxLength = 11;
            this.maas.Multiline = true;
            this.maas.Name = "maas";
            this.maas.Size = new System.Drawing.Size(126, 24);
            this.maas.TabIndex = 179;
            this.maas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maas_KeyPress);
            // 
            // cikis
            // 
            this.cikis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cikis.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.cikis.CustomFormat = "HH:mm:ss";
            this.cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cikis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cikis.Location = new System.Drawing.Point(137, 335);
            this.cikis.Name = "cikis";
            this.cikis.ShowUpDown = true;
            this.cikis.Size = new System.Drawing.Size(126, 24);
            this.cikis.TabIndex = 177;
            // 
            // giris
            // 
            this.giris.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.giris.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.giris.CustomFormat = "HH:mm:ss";
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.giris.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.giris.Location = new System.Drawing.Point(137, 302);
            this.giris.Name = "giris";
            this.giris.ShowUpDown = true;
            this.giris.Size = new System.Drawing.Size(126, 24);
            this.giris.TabIndex = 176;
            // 
            // babaAdi
            // 
            this.babaAdi.BackColor = System.Drawing.SystemColors.Window;
            this.babaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.babaAdi.Location = new System.Drawing.Point(137, 236);
            this.babaAdi.MaxLength = 50;
            this.babaAdi.Multiline = true;
            this.babaAdi.Name = "babaAdi";
            this.babaAdi.Size = new System.Drawing.Size(126, 24);
            this.babaAdi.TabIndex = 173;
            this.babaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.babaAdi_KeyPress);
            // 
            // anneAdi
            // 
            this.anneAdi.BackColor = System.Drawing.SystemColors.Window;
            this.anneAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.anneAdi.Location = new System.Drawing.Point(137, 203);
            this.anneAdi.MaxLength = 50;
            this.anneAdi.Multiline = true;
            this.anneAdi.Name = "anneAdi";
            this.anneAdi.Size = new System.Drawing.Size(126, 24);
            this.anneAdi.TabIndex = 172;
            this.anneAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anneAdi_KeyPress);
            // 
            // telefon
            // 
            this.telefon.BackColor = System.Drawing.SystemColors.Window;
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.telefon.Location = new System.Drawing.Point(137, 269);
            this.telefon.MaxLength = 10;
            this.telefon.Multiline = true;
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(126, 24);
            this.telefon.TabIndex = 171;
            this.telefon.Text = "5";
            // 
            // personelTipi
            // 
            this.personelTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.personelTipi.FormattingEnabled = true;
            this.personelTipi.Location = new System.Drawing.Point(137, 104);
            this.personelTipi.Name = "personelTipi";
            this.personelTipi.Size = new System.Drawing.Size(126, 24);
            this.personelTipi.TabIndex = 167;
            // 
            // soyadi
            // 
            this.soyadi.BackColor = System.Drawing.SystemColors.Window;
            this.soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.soyadi.Location = new System.Drawing.Point(137, 170);
            this.soyadi.MaxLength = 50;
            this.soyadi.Multiline = true;
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(126, 24);
            this.soyadi.TabIndex = 164;
            this.soyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyadi_KeyPress);
            // 
            // kimlik
            // 
            this.kimlik.BackColor = System.Drawing.SystemColors.Window;
            this.kimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.kimlik.Location = new System.Drawing.Point(137, 72);
            this.kimlik.MaxLength = 11;
            this.kimlik.Multiline = true;
            this.kimlik.Name = "kimlik";
            this.kimlik.ReadOnly = true;
            this.kimlik.Size = new System.Drawing.Size(126, 24);
            this.kimlik.TabIndex = 165;
            this.kimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kimlik_KeyPress);
            // 
            // adi
            // 
            this.adi.BackColor = System.Drawing.SystemColors.Window;
            this.adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.adi.Location = new System.Drawing.Point(137, 136);
            this.adi.MaxLength = 50;
            this.adi.Multiline = true;
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(126, 25);
            this.adi.TabIndex = 166;
            this.adi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adi_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.Olive;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label12.Location = new System.Drawing.Point(12, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 24);
            this.label12.TabIndex = 189;
            this.label12.Text = "Maaş           ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.Olive;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.Location = new System.Drawing.Point(12, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 24);
            this.label11.TabIndex = 188;
            this.label11.Text = "Çıkış Saati   ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.Olive;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(12, 302);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 24);
            this.label9.TabIndex = 187;
            this.label9.Text = "Giriş Saati    ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Olive;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(12, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 24);
            this.label7.TabIndex = 185;
            this.label7.Text = "Anne Adı      ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Olive;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 184;
            this.label5.Text = "Telefon        ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Olive;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(12, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 24);
            this.label8.TabIndex = 186;
            this.label8.Text = "Baba Adı      ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Olive;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 182;
            this.label4.Text = "Soyadı          ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Olive;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 180;
            this.label2.Text = "Kimlik            ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Olive;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 181;
            this.label3.Text = "Adı                ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.Olive;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(12, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 24);
            this.label10.TabIndex = 183;
            this.label10.Text = "Personel Tipi";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // PersonelDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(552, 415);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.maas);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.babaAdi);
            this.Controls.Add(this.anneAdi);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.personelTipi);
            this.Controls.Add(this.soyadi);
            this.Controls.Add(this.kimlik);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.gorevYerBilgi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gorevYeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.label13);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelDuzenle";
            this.Text = "Personel Düzenleme Paneli";
            this.Load += new System.EventHandler(this.PersonelDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gorevYerBilgi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox gorevYeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox maas;
        private System.Windows.Forms.DateTimePicker cikis;
        private System.Windows.Forms.DateTimePicker giris;
        private System.Windows.Forms.TextBox babaAdi;
        private System.Windows.Forms.TextBox anneAdi;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.ComboBox personelTipi;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.TextBox kimlik;
        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
    }
}