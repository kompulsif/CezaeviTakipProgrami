using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.PersonelTipIslemleri
{
    public partial class TipSorgu : Form
    {
        public TipSorgu()
        {
            InitializeComponent();
        }

        public static bool add_or_edit = false;
        private void TipSorgu_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                using (SqlDataAdapter da = new SqlDataAdapter($"select tipID, tip as 'Tip Bilgisi' from PersonelTipleri where firmaID = {AnaBolum.firmaID}", conn))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tipler");
                    dataGridView1.DataSource = ds.Tables["Tipler"];
                    dataGridView1.Columns[0].Visible = false;
                }
            } catch
            {
                MessageBox.Show("Veritabanı bağlantısı sırasında bir hata oluştu daha sonra tekra deneyiniz");
                Close();
            }
        }

        private void tipSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("delete from PersonelTipleri where tipID = @tipID", conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@tipID",
                            dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        cmd.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        MessageBox.Show("Seçili personel tipi silindi!");
                    }
                }
                catch { MessageBox.Show("Seçili personel tipi silinemedi, bağlantı hatası!"); }
            }
            else { MessageBox.Show("Seçili bir personel tipi bulunamadı!"); }
        }

        private void tipDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                TipDuzenle yduzenle = new TipDuzenle(
                    dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                yduzenle.ShowDialog();
                if (add_or_edit)
                {
                    add_or_edit = false;
                    this.TipSorgu_Load(sender, e);
                }
            }
            else { MessageBox.Show("Seçili bir personel tipi bulunamadı!"); }
        }

        private void tipEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipEkle kEkle = new TipEkle();
            kEkle.ShowDialog();
            if (add_or_edit)
            {
                this.TipSorgu_Load(sender, e);
                add_or_edit = false;
            }
        }
    }
}
