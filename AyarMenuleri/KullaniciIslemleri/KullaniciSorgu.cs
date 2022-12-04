using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.KullaniciIslemleri
{
    public partial class KullaniciSorgu : Form
    {
        public KullaniciSorgu()
        {
            InitializeComponent();
        }
        public static bool add_or_edit = false;
        private void KullaniciSorgu_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                using (SqlDataAdapter da = new SqlDataAdapter("select id, kullaniciAdi as 'Kullanıcının Adı', " +
                    "parola as 'Kullanıcının Parolası', yetkiler, aktiflik as 'Hesap Durumu', firmaID " +
                    $"from Kullanicilar where firmaID = {AnaBolum.firmaID}", conn))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Kullanicilar");
                    dataGridView1.DataSource = ds.Tables["Kullanicilar"];
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Veritabanından bilgi alınamadı, bağlantılarınızı kontrol ediniz");
                Close();
            }
        }

        private void kullaniciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() != Giris.kAdi)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                        using (SqlCommand cmd = new SqlCommand("delete from Kullanicilar where id = @id", conn))
                        {
                            conn.Open();
                            cmd.Parameters.AddWithValue("@id",
                                dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                            cmd.ExecuteNonQuery();
                            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                            MessageBox.Show("Seçili kullanıcı silindi!");
                        }
                    }
                    catch { MessageBox.Show("Seçili kullanıcı silinemedi!"); }
                } else { MessageBox.Show("Kendinizi silemezsiniz!"); }
            }
            else { MessageBox.Show("Seçili bir kullanıcı bulunamadı!"); }
        }

        private void kullaniciDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                KullaniciDuzenle kduzenle = new KullaniciDuzenle(
                    dataGridView1.SelectedRows[0]);
                kduzenle.ShowDialog();
                if (add_or_edit)
                {
                    add_or_edit = false;
                    this.KullaniciSorgu_Load(sender, e);
                }
            }
            else { MessageBox.Show("Seçili bir kullanıcı bulunamadı!"); }
        }

        private void kullaniciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciEkle kEkle = new KullaniciEkle();
            kEkle.ShowDialog();
            if (add_or_edit)
            {
                this.KullaniciSorgu_Load(sender, e);
                add_or_edit = false;
            }
        }
    }
}
