namespace CezaeviProgram.AyarMenuleri.PersonelTipIslemleri
{
    partial class TipSorgu
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gorevYeriniSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gorevYeriniGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gorevYeriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Personel Tip Ayar Menüsü";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gorevYeriniSilToolStripMenuItem,
            this.gorevYeriniGuncelleToolStripMenuItem,
            this.gorevYeriEkleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 70);
            // 
            // gorevYeriniSilToolStripMenuItem
            // 
            this.gorevYeriniSilToolStripMenuItem.Name = "gorevYeriniSilToolStripMenuItem";
            this.gorevYeriniSilToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.gorevYeriniSilToolStripMenuItem.Text = "Tipi Sil";
            this.gorevYeriniSilToolStripMenuItem.Click += new System.EventHandler(this.tipSilToolStripMenuItem_Click);
            // 
            // gorevYeriniGuncelleToolStripMenuItem
            // 
            this.gorevYeriniGuncelleToolStripMenuItem.Name = "gorevYeriniGuncelleToolStripMenuItem";
            this.gorevYeriniGuncelleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.gorevYeriniGuncelleToolStripMenuItem.Text = "Tipi Düzenle";
            this.gorevYeriniGuncelleToolStripMenuItem.Click += new System.EventHandler(this.tipDuzenleToolStripMenuItem_Click);
            // 
            // gorevYeriEkleToolStripMenuItem
            // 
            this.gorevYeriEkleToolStripMenuItem.Name = "gorevYeriEkleToolStripMenuItem";
            this.gorevYeriEkleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.gorevYeriEkleToolStripMenuItem.Text = "Tip Ekle";
            this.gorevYeriEkleToolStripMenuItem.Click += new System.EventHandler(this.tipEkleToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 78);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(353, 196);
            this.dataGridView1.TabIndex = 10;
            // 
            // TipSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(367, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipSorgu";
            this.Text = "TipSorgu";
            this.Load += new System.EventHandler(this.TipSorgu_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gorevYeriniSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gorevYeriniGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gorevYeriEkleToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}