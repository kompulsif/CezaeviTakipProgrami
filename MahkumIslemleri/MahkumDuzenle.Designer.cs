namespace CezaeviProgram.MahkumIslemleri
{
    partial class MahkumDuzenle
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kimlik = new System.Windows.Forms.TextBox();
            this.adi = new System.Windows.Forms.TextBox();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.anneAdi = new System.Windows.Forms.TextBox();
            this.babaAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.koguslar = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kimlik Bilgisi ";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(12, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon         ";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı          ";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adı                ";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(12, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Koğuş ID       ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(12, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Baba Adı       ";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(12, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Anne Adı       ";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(12, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Adres            ";
            // 
            // kimlik
            // 
            this.kimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.kimlik.Location = new System.Drawing.Point(135, 88);
            this.kimlik.MaxLength = 11;
            this.kimlik.Name = "kimlik";
            this.kimlik.ReadOnly = true;
            this.kimlik.Size = new System.Drawing.Size(178, 24);
            this.kimlik.TabIndex = 9;
            // 
            // adi
            // 
            this.adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.adi.Location = new System.Drawing.Point(135, 124);
            this.adi.MaxLength = 50;
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(178, 24);
            this.adi.TabIndex = 10;
            // 
            // soyadi
            // 
            this.soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.soyadi.Location = new System.Drawing.Point(135, 160);
            this.soyadi.MaxLength = 50;
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(178, 24);
            this.soyadi.TabIndex = 11;
            // 
            // telefon
            // 
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.telefon.Location = new System.Drawing.Point(135, 196);
            this.telefon.MaxLength = 10;
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(178, 24);
            this.telefon.TabIndex = 12;
            this.telefon.Text = "5";
            // 
            // adres
            // 
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.adres.Location = new System.Drawing.Point(135, 232);
            this.adres.MaxLength = 300;
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(178, 63);
            this.adres.TabIndex = 13;
            // 
            // anneAdi
            // 
            this.anneAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.anneAdi.Location = new System.Drawing.Point(135, 307);
            this.anneAdi.MaxLength = 50;
            this.anneAdi.Name = "anneAdi";
            this.anneAdi.Size = new System.Drawing.Size(178, 24);
            this.anneAdi.TabIndex = 14;
            // 
            // babaAdi
            // 
            this.babaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.babaAdi.Location = new System.Drawing.Point(135, 342);
            this.babaAdi.MaxLength = 50;
            this.babaAdi.Name = "babaAdi";
            this.babaAdi.Size = new System.Drawing.Size(178, 24);
            this.babaAdi.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label10.Location = new System.Drawing.Point(107, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(345, 33);
            this.label10.TabIndex = 18;
            this.label10.Text = "Mahkum Düzenleme Paneli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Salmon;
            this.pictureBox1.Location = new System.Drawing.Point(344, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(344, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 60);
            this.button1.TabIndex = 20;
            this.button1.Text = "Düzeni Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(342, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Resim seçmek için dokunun";
            // 
            // koguslar
            // 
            this.koguslar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.koguslar.FormattingEnabled = true;
            this.koguslar.Location = new System.Drawing.Point(135, 379);
            this.koguslar.Name = "koguslar";
            this.koguslar.Size = new System.Drawing.Size(178, 24);
            this.koguslar.TabIndex = 24;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MahkumDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(537, 416);
            this.Controls.Add(this.koguslar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MahkumDuzenle";
            this.Text = "Mahkum Düzenle";
            this.Load += new System.EventHandler(this.MahkumDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kimlik;
        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox anneAdi;
        private System.Windows.Forms.TextBox babaAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox koguslar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}