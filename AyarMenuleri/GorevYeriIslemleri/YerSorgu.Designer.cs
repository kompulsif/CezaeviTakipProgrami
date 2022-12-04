namespace CezaeviProgram.AyarMenuleri.GorevYeriIslemleri
{
    partial class YerSorgu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.görevYeriniSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görevYeriniGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniGörevYeriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 87);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(347, 197);
            this.dataGridView1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görevYeriniSilToolStripMenuItem,
            this.görevYeriniGüncelleToolStripMenuItem,
            this.yeniGörevYeriEkleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 70);
            // 
            // görevYeriniSilToolStripMenuItem
            // 
            this.görevYeriniSilToolStripMenuItem.Name = "görevYeriniSilToolStripMenuItem";
            this.görevYeriniSilToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.görevYeriniSilToolStripMenuItem.Text = "Görev Yerini Sil";
            this.görevYeriniSilToolStripMenuItem.Click += new System.EventHandler(this.gorevYeriniSilToolStripMenuItem_Click);
            // 
            // görevYeriniGüncelleToolStripMenuItem
            // 
            this.görevYeriniGüncelleToolStripMenuItem.Name = "görevYeriniGüncelleToolStripMenuItem";
            this.görevYeriniGüncelleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.görevYeriniGüncelleToolStripMenuItem.Text = "Görev Yerini Güncelle";
            this.görevYeriniGüncelleToolStripMenuItem.Click += new System.EventHandler(this.gorevYeriniGuncelleToolStripMenuItem_Click);
            // 
            // yeniGörevYeriEkleToolStripMenuItem
            // 
            this.yeniGörevYeriEkleToolStripMenuItem.Name = "yeniGörevYeriEkleToolStripMenuItem";
            this.yeniGörevYeriEkleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.yeniGörevYeriEkleToolStripMenuItem.Text = "Yeni Görev Yeri Ekle";
            this.yeniGörevYeriEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniGorevYeriEkleToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Görev Yerleri Ayar Menüsü";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // YerSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(360, 288);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YerSorgu";
            this.Text = "YerSorgu";
            this.Load += new System.EventHandler(this.YerSorgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem görevYeriniSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görevYeriniGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniGörevYeriEkleToolStripMenuItem;
    }
}