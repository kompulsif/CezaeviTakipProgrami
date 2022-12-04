namespace CezaeviProgram.PersonelIslemleri
{
    partial class PersonelTipBilgilendirme
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
            this.bilgilendirme = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilendirme)).BeginInit();
            this.SuspendLayout();
            // 
            // bilgilendirme
            // 
            this.bilgilendirme.AllowUserToAddRows = false;
            this.bilgilendirme.AllowUserToDeleteRows = false;
            this.bilgilendirme.AllowUserToOrderColumns = true;
            this.bilgilendirme.AllowUserToResizeRows = false;
            this.bilgilendirme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bilgilendirme.BackgroundColor = System.Drawing.Color.Silver;
            this.bilgilendirme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bilgilendirme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bilgilendirme.GridColor = System.Drawing.Color.Gray;
            this.bilgilendirme.Location = new System.Drawing.Point(12, 57);
            this.bilgilendirme.MultiSelect = false;
            this.bilgilendirme.Name = "bilgilendirme";
            this.bilgilendirme.ReadOnly = true;
            this.bilgilendirme.RowHeadersVisible = false;
            this.bilgilendirme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bilgilendirme.Size = new System.Drawing.Size(392, 139);
            this.bilgilendirme.TabIndex = 115;
            this.bilgilendirme.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bilgilendirme_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 114;
            this.label1.Text = "Personel Tip Bilgileri";
            // 
            // PersonelTipBilgilendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(413, 205);
            this.Controls.Add(this.bilgilendirme);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelTipBilgilendirme";
            this.Text = "PersonelTipBilgilendirme";
            this.Load += new System.EventHandler(this.PersonelTipBilgilendirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bilgilendirme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bilgilendirme;
        private System.Windows.Forms.Label label1;
    }
}