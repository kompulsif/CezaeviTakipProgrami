using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.MahkumIslemleri
{
    public partial class MahkumKogusBilgilendirme : Form
    {
        string form_name = "";
        public MahkumKogusBilgilendirme(string fn)
        {
            InitializeComponent();
            form_name = fn;
        }

        private void MahkumKogusBilgilendirme_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
            {
                using (SqlDataAdapter da = new SqlDataAdapter($"select kogusID, kogusBilgisi from Kogus where firmaID = {AnaBolum.firmaID}", conn))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "KogusBilgileri");
                    ds.Tables["KogusBilgileri"].Columns[0].ColumnName = "Koğuş Numarası";
                    ds.Tables["KogusBilgileri"].Columns[1].ColumnName = "Koğuş Bilgisi";
                    bilgilendirme.DataSource = ds.Tables["KogusBilgileri"];
                    bilgilendirme.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        private void bilgilendirme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bilgilendirme.SelectedRows.Count > 0)
            {
                if (form_name == "AnaBolum") AnaBolum.kTextPublic.Text = bilgilendirme.SelectedRows[0].Cells[0].Value.ToString();
                else if (form_name == "MahkumEkle") MahkumEkle.k.Text = bilgilendirme.SelectedRows[0].Cells[0].Value.ToString();
                else if (form_name == "MahkumDuzenle") MahkumDuzenle.k.Text = bilgilendirme.SelectedRows[0].Cells[0].Value.ToString();
            }
                
            else MessageBox.Show("Koğuş bilgisi bulunamadı!");
            Close();
        }
    }
}
