using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.ZiyaretciOdaIslemleri
{
    public partial class OdaSorgu : Form
    {
        public OdaSorgu()
        {
            InitializeComponent();
        }
        public static bool add_or_edit = false;
        private void OdaSorgu_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                using (SqlDataAdapter da = new SqlDataAdapter("select yerID, yerBilgi as 'Ziyaret Yeri Bilgisi', firmaID " +
                    $"from ZiyaretYerleri where firmaID = {AnaBolum.firmaID}", conn))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Yerler");
                    dataGridView1.DataSource = ds.Tables["Yerler"];
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

        private void ziyaretYeriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("delete from ZiyaretYerleri where yerID = @yerID", conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@yerID",
                            dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        cmd.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        MessageBox.Show("Seçili ziyaret yeri silindi!");
                    }
                }
                catch { MessageBox.Show("Seçili ziyaret yeri silinemedi, bağlantı hatası!"); }
            }
            else { MessageBox.Show("Seçili bir ziyaret yeri bulunamadı!"); }
        }

        private void yeriDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                OdaDuzenle yduzenle = new OdaDuzenle(
                    dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                yduzenle.ShowDialog();
                if (add_or_edit)
                {
                    add_or_edit = false;
                    this.OdaSorgu_Load(sender, e);
                }
            }
            else { MessageBox.Show("Seçili bir ziyaret yeri bulunamadı!"); }
        }

        private void odaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaEkle kEkle = new OdaEkle();
            kEkle.ShowDialog();
            if (add_or_edit)
            {
                this.OdaSorgu_Load(sender, e);
                add_or_edit = false;
            }
        }
    }
}
