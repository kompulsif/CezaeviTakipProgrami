namespace CezaeviProgram.ZiyaretciIslemleri
{
    partial class ZiyaretciSorgu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZiyaretciSorgu));
            this.tarihBitis = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tarihBaslangic = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.kimlik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ziyaretçiDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yerDetay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mahkumKimlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tarihBitis
            // 
            this.tarihBitis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tarihBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tarihBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarihBitis.Location = new System.Drawing.Point(186, 113);
            this.tarihBitis.Name = "tarihBitis";
            this.tarihBitis.Size = new System.Drawing.Size(174, 23);
            this.tarihBitis.TabIndex = 43;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "ekle.png";
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(625, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 54);
            this.button3.TabIndex = 41;
            this.button3.Text = "Ziyaretçi Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sil.png");
            this.imageList1.Images.SetKeyName(1, "izin.png");
            this.imageList1.Images.SetKeyName(2, "ekle.png");
            this.imageList1.Images.SetKeyName(3, "calistir.png");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "calistir.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(310, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 54);
            this.button2.TabIndex = 40;
            this.button2.Text = "     Sorgulama Yap";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(423, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Görüş Yeri";
            // 
            // tarihBaslangic
            // 
            this.tarihBaslangic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tarihBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tarihBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarihBaslangic.Location = new System.Drawing.Point(186, 80);
            this.tarihBaslangic.Name = "tarihBaslangic";
            this.tarihBaslangic.Size = new System.Drawing.Size(174, 23);
            this.tarihBaslangic.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "sil.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(13, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 54);
            this.button1.TabIndex = 39;
            this.button1.Text = "    Parametreleri\r\n   Temizle\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kimlik
            // 
            this.kimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kimlik.Location = new System.Drawing.Point(186, 12);
            this.kimlik.MaxLength = 11;
            this.kimlik.Name = "kimlik";
            this.kimlik.Size = new System.Drawing.Size(173, 26);
            this.kimlik.TabIndex = 38;
            this.kimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kimlik_KeyPress);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tarih Bitiş         ";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ziyaretçi Kimliği";
            // 
            // sdfToolStripMenuItem
            // 
            this.sdfToolStripMenuItem.Name = "sdfToolStripMenuItem";
            this.sdfToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sdfToolStripMenuItem.Text = "Ziyaret Kaydını Sil";
            this.sdfToolStripMenuItem.Click += new System.EventHandler(this.sdfToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfToolStripMenuItem,
            this.ziyaretçiDüzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 48);
            // 
            // ziyaretçiDüzenleToolStripMenuItem
            // 
            this.ziyaretçiDüzenleToolStripMenuItem.Name = "ziyaretçiDüzenleToolStripMenuItem";
            this.ziyaretçiDüzenleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ziyaretçiDüzenleToolStripMenuItem.Text = "Ziyaretçi Düzenle";
            this.ziyaretçiDüzenleToolStripMenuItem.Click += new System.EventHandler(this.ziyaretciDuzenleToolStripMenuItem_Click);
            // 
            // yerDetay
            // 
            this.yerDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yerDetay.Location = new System.Drawing.Point(528, 11);
            this.yerDetay.Multiline = true;
            this.yerDetay.Name = "yerDetay";
            this.yerDetay.ReadOnly = true;
            this.yerDetay.Size = new System.Drawing.Size(274, 60);
            this.yerDetay.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tarih Başlangıç";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 223);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(861, 293);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mahkumKimlik
            // 
            this.mahkumKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mahkumKimlik.Location = new System.Drawing.Point(186, 45);
            this.mahkumKimlik.MaxLength = 11;
            this.mahkumKimlik.Name = "mahkumKimlik";
            this.mahkumKimlik.Size = new System.Drawing.Size(173, 26);
            this.mahkumKimlik.TabIndex = 46;
            this.mahkumKimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mahkumKimlik_KeyPress);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 26);
            this.label4.TabIndex = 45;
            this.label4.Text = "Mahkum Kimliği";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(423, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Adres        ";
            // 
            // adres
            // 
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adres.Location = new System.Drawing.Point(528, 81);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.ReadOnly = true;
            this.adres.Size = new System.Drawing.Size(274, 56);
            this.adres.TabIndex = 48;
            // 
            // ZiyaretciSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(887, 528);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.mahkumKimlik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tarihBitis);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tarihBaslangic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kimlik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yerDetay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZiyaretciSorgu";
            this.Text = "ZiyaretciSorgu";
            this.Load += new System.EventHandler(this.ZiyaretciSorgu_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tarihBitis;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tarihBaslangic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kimlik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem sdfToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox yerDetay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox mahkumKimlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.ToolStripMenuItem ziyaretçiDüzenleToolStripMenuItem;
    }
}