﻿namespace CezaeviProgram.ZiyaretciIslemleri
{
    partial class ZiyaretciDuzenle
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
            this.yerDetay = new System.Windows.Forms.TextBox();
            this.yerID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mahkumKimligi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.babaAdi = new System.Windows.Forms.TextBox();
            this.anneAdi = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.adi = new System.Windows.Forms.TextBox();
            this.kimlik = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yerDetay
            // 
            this.yerDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yerDetay.Location = new System.Drawing.Point(343, 241);
            this.yerDetay.Multiline = true;
            this.yerDetay.Name = "yerDetay";
            this.yerDetay.ReadOnly = true;
            this.yerDetay.Size = new System.Drawing.Size(360, 60);
            this.yerDetay.TabIndex = 83;
            this.yerDetay.Text = "Ziyaret Yer Detay";
            // 
            // yerID
            // 
            this.yerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.yerID.FormattingEnabled = true;
            this.yerID.Location = new System.Drawing.Point(151, 277);
            this.yerID.Name = "yerID";
            this.yerID.Size = new System.Drawing.Size(179, 26);
            this.yerID.TabIndex = 82;
            this.yerID.SelectedIndexChanged += new System.EventHandler(this.yerID_SelectedIndexChanged);
            this.yerID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yerID_KeyDown);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(7, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 26);
            this.label10.TabIndex = 81;
            this.label10.Text = "Ziyaret Yeri      ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(275, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 47);
            this.button1.TabIndex = 80;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label9.Location = new System.Drawing.Point(8, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(695, 48);
            this.label9.TabIndex = 79;
            this.label9.Text = "Ziyaretçi Düzenle";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mahkumKimligi
            // 
            this.mahkumKimligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mahkumKimligi.Location = new System.Drawing.Point(151, 242);
            this.mahkumKimligi.MaxLength = 11;
            this.mahkumKimligi.Name = "mahkumKimligi";
            this.mahkumKimligi.Size = new System.Drawing.Size(178, 24);
            this.mahkumKimligi.TabIndex = 78;
            this.mahkumKimligi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mahkumKimligi_KeyPress);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(6, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 77;
            this.label5.Text = "Mahkum Kimliği";
            // 
            // babaAdi
            // 
            this.babaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.babaAdi.Location = new System.Drawing.Point(484, 110);
            this.babaAdi.MaxLength = 50;
            this.babaAdi.Name = "babaAdi";
            this.babaAdi.Size = new System.Drawing.Size(219, 24);
            this.babaAdi.TabIndex = 76;
            this.babaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.babaAdi_KeyPress);
            // 
            // anneAdi
            // 
            this.anneAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.anneAdi.Location = new System.Drawing.Point(484, 74);
            this.anneAdi.MaxLength = 50;
            this.anneAdi.Name = "anneAdi";
            this.anneAdi.Size = new System.Drawing.Size(219, 24);
            this.anneAdi.TabIndex = 75;
            this.anneAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anneAdi_KeyPress);
            // 
            // adres
            // 
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.adres.Location = new System.Drawing.Point(484, 146);
            this.adres.MaxLength = 300;
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(219, 86);
            this.adres.TabIndex = 74;
            // 
            // telefon
            // 
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.telefon.Location = new System.Drawing.Point(151, 207);
            this.telefon.MaxLength = 10;
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(178, 24);
            this.telefon.TabIndex = 73;
            this.telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefon_KeyPress);
            // 
            // soyadi
            // 
            this.soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.soyadi.Location = new System.Drawing.Point(151, 145);
            this.soyadi.MaxLength = 50;
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(178, 24);
            this.soyadi.TabIndex = 72;
            this.soyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyadi_KeyPress);
            // 
            // adi
            // 
            this.adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.adi.Location = new System.Drawing.Point(151, 109);
            this.adi.MaxLength = 50;
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(178, 24);
            this.adi.TabIndex = 71;
            this.adi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adi_KeyPress);
            // 
            // kimlik
            // 
            this.kimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.kimlik.Location = new System.Drawing.Point(151, 74);
            this.kimlik.MaxLength = 11;
            this.kimlik.Name = "kimlik";
            this.kimlik.ReadOnly = true;
            this.kimlik.Size = new System.Drawing.Size(178, 24);
            this.kimlik.TabIndex = 70;
            this.kimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kimlik_KeyPress);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(343, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 24);
            this.label8.TabIndex = 69;
            this.label8.Text = "Adres               ";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(343, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 68;
            this.label7.Text = "Anne Adı          ";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(343, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 67;
            this.label6.Text = "Baba Adı          ";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 66;
            this.label4.Text = "Adı                    ";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(7, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "Soyadı              ";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(6, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 64;
            this.label2.Text = "Telefon             ";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Ziyaretçi Kimliği";
            // 
            // ZiyaretciDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(710, 372);
            this.Controls.Add(this.yerDetay);
            this.Controls.Add(this.yerID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mahkumKimligi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.babaAdi);
            this.Controls.Add(this.anneAdi);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.soyadi);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.kimlik);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZiyaretciDuzenle";
            this.Text = "ZiyaretciDuzenle";
            this.Load += new System.EventHandler(this.ZiyaretciDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yerDetay;
        private System.Windows.Forms.ComboBox yerID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mahkumKimligi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox babaAdi;
        private System.Windows.Forms.TextBox anneAdi;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.TextBox kimlik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}