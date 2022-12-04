namespace CezaeviProgram.IzinIslemleri
{
    partial class IzinEkle
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
            this.aciklama = new System.Windows.Forms.TextBox();
            this.mahkum = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.personel = new System.Windows.Forms.RadioButton();
            this.kimlik = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(71, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "İzin Ekleme Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kimlik Bilgisi";
            // 
            // aciklama
            // 
            this.aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.aciklama.Location = new System.Drawing.Point(6, 26);
            this.aciklama.MaxLength = 500;
            this.aciklama.Multiline = true;
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(354, 142);
            this.aciklama.TabIndex = 3;
            // 
            // mahkum
            // 
            this.mahkum.AutoSize = true;
            this.mahkum.Checked = true;
            this.mahkum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mahkum.Location = new System.Drawing.Point(136, 85);
            this.mahkum.Name = "mahkum";
            this.mahkum.Size = new System.Drawing.Size(88, 24);
            this.mahkum.TabIndex = 4;
            this.mahkum.TabStop = true;
            this.mahkum.Text = "Mahkum";
            this.mahkum.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kişi Ünvanı  ";
            // 
            // personel
            // 
            this.personel.AutoSize = true;
            this.personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.personel.Location = new System.Drawing.Point(247, 85);
            this.personel.Name = "personel";
            this.personel.Size = new System.Drawing.Size(89, 24);
            this.personel.TabIndex = 6;
            this.personel.Text = "Personel";
            this.personel.UseVisualStyleBackColor = true;
            // 
            // kimlik
            // 
            this.kimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.kimlik.Location = new System.Drawing.Point(136, 128);
            this.kimlik.MaxLength = 11;
            this.kimlik.Name = "kimlik";
            this.kimlik.Size = new System.Drawing.Size(199, 27);
            this.kimlik.TabIndex = 7;
            this.kimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kimlik_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(136, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "İzin Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aciklama);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 174);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İzin Açıklaması";
            // 
            // IzinEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(390, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kimlik);
            this.Controls.Add(this.personel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mahkum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IzinEkle";
            this.Text = "IzinEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.RadioButton mahkum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton personel;
        private System.Windows.Forms.TextBox kimlik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}