using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.GorevYeriIslemleri
{
    public partial class YerSorgu : Form
    {
        public YerSorgu()
        {
            InitializeComponent();
        }

        public static bool add_or_edit = false;
        private void YerSorgu_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                using (SqlDataAdapter da = new SqlDataAdapter("select bolgeID, bolgeAdi as 'Bölge Bilgisi', firmaID " +
                    $"from Bolge where firmaID = {AnaBolum.firmaID}", conn))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Bolgeler");
                    dataGridView1.DataSource = ds.Tables["Bolgeler"];
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Veritabanından bilgi alınamadı, bağlantılarınızı kontrol ediniz");
                Close();
            }
        }

        private void gorevYeriniGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                YerDuzenle yduzenle = new YerDuzenle(
                    dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                yduzenle.ShowDialog();
                if (add_or_edit)
                {
                    this.YerSorgu_Load(sender, e);
                    add_or_edit = false;
                }
            } else { MessageBox.Show("Seçili bir görev yeri bulunamadı!"); }
        }

        private void gorevYeriniSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("delete from Bolge where bolgeID = @bolgeID", conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@bolgeID", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        cmd.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        MessageBox.Show("Seçili görev yeri silindi!");
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex + "\n\nSeçili görev yeri silinemedi, bağlantı hatası!"); }
            } else { MessageBox.Show("Seçili bir görev yeri bulunamadı!"); }
        }

        private void yeniGorevYeriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YerEkle yekle = new YerEkle();
            yekle.ShowDialog();
            if (add_or_edit)
            {
                this.YerSorgu_Load(sender, e);
                add_or_edit = false;
            }
        }
    }
}
