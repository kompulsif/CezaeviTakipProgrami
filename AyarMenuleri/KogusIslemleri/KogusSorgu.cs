using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.KogusIslemleri
{
    public partial class KogusSorgu : Form
    {
        public KogusSorgu()
        {
            InitializeComponent();
        }
        public static bool add_or_edit = false;
        private void KogusSorgu_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                using (SqlDataAdapter da = new SqlDataAdapter("select kogusID, kogusBilgisi as 'Koğuş Bilgisi', firmaID " +
                    $"from Kogus where firmaID = {AnaBolum.firmaID}", conn))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Koguslar");
                    dataGridView1.DataSource = ds.Tables["Koguslar"];
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

        private void kogusSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("delete from Kogus where kogusID = @kogusID", conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@kogusID",
                            dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        cmd.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        MessageBox.Show("Seçili koğuş silindi!");
                    }
                }
                catch { MessageBox.Show("Seçili koğuş silinemedi, bağlantı hatası!"); }
            }
            else { MessageBox.Show("Seçili bir koğuş yeri bulunamadı!"); }
        }

        private void kogusDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                KogusDuzenle yduzenle = new KogusDuzenle(
                    dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                yduzenle.ShowDialog();
                if (add_or_edit)
                {
                    add_or_edit = false;
                    this.KogusSorgu_Load(sender, e);
                }
            }
            else { MessageBox.Show("Seçili bir koğuş bulunamadı!"); }
        }

        private void kogusEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KogusEkle kEkle = new KogusEkle();
            kEkle.ShowDialog();
            if (add_or_edit)
            {
                this.KogusSorgu_Load(sender, e);
                add_or_edit = false;
            }
        }
    }
}
