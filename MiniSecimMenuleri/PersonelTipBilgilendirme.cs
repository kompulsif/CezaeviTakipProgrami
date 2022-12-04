using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CezaeviProgram.PersonelIslemleri
{
    public partial class PersonelTipBilgilendirme : Form
    {
        string form_name = "";
        public PersonelTipBilgilendirme(string name)
        {
            InitializeComponent();
            form_name = name;
        }

        private void PersonelTipBilgilendirme_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> personelTipBilgileri = PersonelSorgu.personelTipleri;
            DataTable tipTablo = new DataTable("Tipler");
            tipTablo.Columns.Add("Tip ID");
            tipTablo.Columns.Add("Personel Tipi");
            foreach (string s in personelTipBilgileri.Keys)
                tipTablo.Rows.Add(s, personelTipBilgileri[s]);
            DataSet ds = new DataSet();
            ds.Tables.Add(tipTablo);
            bilgilendirme.DataSource = ds.Tables["Tipler"];
        }

        private void bilgilendirme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bilgilendirme.SelectedRows.Count > 0)
            {
                if (form_name == "PersonelSorgu") PersonelSorgu.pt.Text = bilgilendirme.SelectedRows[0].Cells[0].Value.ToString();
                else if (form_name == "PersonelDuzenle") PersonelDuzenle.pt.Text = bilgilendirme.SelectedRows[0].Cells[0].Value.ToString();
                else if (form_name == "PersonelEkle") PersonelEkle.pt.Text = bilgilendirme.SelectedRows[0].Cells[0].Value.ToString();
            }
            else MessageBox.Show("Personel tipi bulunamadı!");
            Close();
        }
    }
}
