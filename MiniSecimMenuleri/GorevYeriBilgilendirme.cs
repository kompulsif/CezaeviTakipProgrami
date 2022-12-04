using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CezaeviProgram.PersonelIslemleri
{
    public partial class GorevYeriBilgilendirme : Form
    {
        public GorevYeriBilgilendirme()
        {
            InitializeComponent();
        }

        private void GorevYeriBilgilendirme_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> gorevYeriBilgileri = PersonelSorgu.gorevYeriSozluk;
            DataTable yerTablo = new DataTable("Yerler");
            yerTablo.Columns.Add("Yer ID");
            yerTablo.Columns.Add("Yer Bilgisi");
            foreach (string s in gorevYeriBilgileri.Keys)
                yerTablo.Rows.Add(s, gorevYeriBilgileri[s]);
            DataSet ds = new DataSet();
            ds.Tables.Add(yerTablo);
            bilgilendirme.DataSource = ds.Tables["Yerler"];
        }

        private void bilgilendirme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bilgilendirme.SelectedRows.Count > 0)
                PersonelSorgu.gy.Text = bilgilendirme.SelectedRows[0].Cells[0].Value.ToString();
            else MessageBox.Show("Görev yeri bulunamadı!");
            Close();
        }
    }
}
