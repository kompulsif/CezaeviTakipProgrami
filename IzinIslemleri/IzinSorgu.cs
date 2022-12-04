using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.IzinIslemleri
{
    public partial class IzinSorgu : Form
    {
        public IzinSorgu()
        {
            InitializeComponent();
        }

        string datetime_pattern = "yyyy/MM/dd HH:mm:ss";

        private void IzinSorgu_Load(object sender, EventArgs e)
        {
            tarihBaslangic.CustomFormat = datetime_pattern;
            tarihBitis.CustomFormat = datetime_pattern;
            tarihBaslangic.Value = DateTime.Now.AddDays(-1);
            tarihBitis.Value = DateTime.Now;

            try
            {
                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                using (SqlDataAdapter da = new SqlDataAdapter(
                    "select kayitID, kisiKimlik as Kimlik, kisiTip as 'Kişi Ünvanı', " +
                    $"izinDetay as 'İzin Detayı', izinTarih as 'İzin Tarihi' from MudurIzinKayit where firmaID = '{AnaBolum.firmaID}'",
                    conn)) {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "IzinKayit");
                    dataGridView1.DataSource = ds.Tables["IzinKayit"];
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[4].DefaultCellStyle.Format = datetime_pattern;
                }
            }
            catch
            {
                MessageBox.Show("Veritabanı bağlantısı yapılamadı, veritabanınızı kontrol ediniz.");
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kimlik.Text = "";
            detay.Text = "";
            tarihBaslangic.Value = DateTime.Parse("1900/01/01 00:00:00");
            tarihBitis.Value = DateTime.Parse(DateTime.Now.ToString(datetime_pattern));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmd = "select kayitID, kisiKimlik as Kimlik, kisiTip as 'Kişi Ünvanı', " +
                    $"izinDetay as 'İzin Detayı', izinTarih as 'İzin Tarihi' from MudurIzinKayit where firmaID = '{AnaBolum.firmaID}' and ";
            string cmd_suffix = "";
            if (kimlik.Text.Trim() != "")
                cmd_suffix += $"kisiKimlik = '{kimlik.Text.Trim()}' and ";
            string x = tarihBaslangic.Value.ToString(datetime_pattern);
            string y = tarihBitis.Value.ToString(datetime_pattern);
            cmd_suffix += $"izinTarih between '{x}' and '{y}'";
            cmd += cmd_suffix;
            using (SqlConnection con = new SqlConnection(AnaBolum.conn_str))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd, con))
            {
                DataSet ds = new DataSet();
                da.Fill(ds, "Yoklama");
                dataGridView1.DataSource = ds.Tables["Yoklama"];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AnaBolum.yetkiler["izin_ekle"] == "1")
            {
                IzinEkle ie = new IzinEkle();
                ie.ShowDialog();
            } else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indx = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indx];
                detay.Text = row.Cells[3].Value.ToString();
                kimlik.Text = row.Cells[1].Value.ToString();
            }
        }

        private void sdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (AnaBolum.yetkiler["izin_sil"] == "1")
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                        {
                            conn.Open();
                            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                            string kayitID = selectedRow.Cells["kayitID"].Value.ToString();
                            using (SqlCommand cmd = new SqlCommand(
                                "delete from MudurIzinKayit where kayitID = @kayitID", conn))
                            {
                                cmd.Parameters.AddWithValue("@kayitID", kayitID);
                                cmd.ExecuteNonQuery();
                            }
                            dataGridView1.Rows.RemoveAt(selectedrowindex);
                        }
                    }
                    catch { MessageBox.Show("Silme işlemi tamamlanamadı, daha sonra tekrar deneyiniz."); }
                } else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
            }
            else MessageBox.Show("Seçili kayıt bulunamadı!");
        }

        private void kimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void izinKaydiniDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (AnaBolum.yetkiler["izin_duzenle"] == "1")
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    IzinDuzenle iduz = new IzinDuzenle(selectedRow);
                    iduz.ShowDialog();
                }
                else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
            }
            else MessageBox.Show("Seçili bir kayıt bulunamadı!");
        }
    }
}
