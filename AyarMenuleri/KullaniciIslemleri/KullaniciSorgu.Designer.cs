namespace CezaeviProgram.AyarMenuleri.KullaniciIslemleri
{
    partial class KullaniciSorgu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gorevYeriniSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gorevYeriniGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gorevYeriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı İşlemleri Menüsü";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 61);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(510, 196);
            this.dataGridView1.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gorevYeriniSilToolStripMenuItem,
            this.gorevYeriniGuncelleToolStripMenuItem,
            this.gorevYeriEkleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // gorevYeriniSilToolStripMenuItem
            // 
            this.gorevYeriniSilToolStripMenuItem.Name = "gorevYeriniSilToolStripMenuItem";
            this.gorevYeriniSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gorevYeriniSilToolStripMenuItem.Text = "Kullanıcıyı Sil";
            this.gorevYeriniSilToolStripMenuItem.Click += new System.EventHandler(this.kullaniciSilToolStripMenuItem_Click);
            // 
            // gorevYeriniGuncelleToolStripMenuItem
            // 
            this.gorevYeriniGuncelleToolStripMenuItem.Name = "gorevYeriniGuncelleToolStripMenuItem";
            this.gorevYeriniGuncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gorevYeriniGuncelleToolStripMenuItem.Text = "Kullanıcıyı Düzenle";
            this.gorevYeriniGuncelleToolStripMenuItem.Click += new System.EventHandler(this.kullaniciDuzenleToolStripMenuItem_Click);
            // 
            // gorevYeriEkleToolStripMenuItem
            // 
            this.gorevYeriEkleToolStripMenuItem.Name = "gorevYeriEkleToolStripMenuItem";
            this.gorevYeriEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gorevYeriEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.gorevYeriEkleToolStripMenuItem.Click += new System.EventHandler(this.kullaniciEkleToolStripMenuItem_Click);
            // 
            // KullaniciSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(514, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciSorgu";
            this.Text = "KullaniciSorgu";
            this.Load += new System.EventHandler(this.KullaniciSorgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gorevYeriniSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gorevYeriniGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gorevYeriEkleToolStripMenuItem;
    }
}