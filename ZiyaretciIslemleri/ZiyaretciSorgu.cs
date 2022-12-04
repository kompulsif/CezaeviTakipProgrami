using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.ZiyaretciIslemleri
{
    public partial class ZiyaretciSorgu : Form
    {
        Dictionary<string, string> yer_sozluk = new Dictionary<string, string>();
        public ZiyaretciSorgu()
        {
            InitializeComponent();
        }

        private void ZiyaretciSorgu_Load(object sender, EventArgs e)
        {
            tarihBaslangic.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            tarihBitis.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            tarihBaslangic.Value = DateTime.Now.AddDays(-1);
            tarihBitis.Value = DateTime.Now;
            button1_Click(sender, e);
            button2_Click(sender, e);
            try
            {
                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                {
                    using (SqlCommand cmd = new SqlCommand("select yerID, yerBilgi from ZiyaretYerleri where firmaID = @firmaID", conn))
                    {
                        cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            yer_sozluk.Add(dr[0].ToString(), dr[1].ToString());
                        }
                    }
                }
            }
            catch {
                MessageBox.Show("Veritabanı bağlantısı sağlanamadı, veritabanınızı kontrol ediniz!");
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AnaBolum.yetkiler["ziyaretci_ekle"] == "1")
            {
                ZiyaretciEkle ziEkle = new ZiyaretciEkle();
                ziEkle.ShowDialog();
            } else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kimlik.Text = "";
            mahkumKimlik.Text = "";
            yerDetay.Text = "";
            adres.Text = "";
            tarihBaslangic.Value = DateTime.Parse("1900/01/01 00:00:00");
            tarihBitis.Value = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string command = "select ziyaretciID, kimlik as Kimlik, adi as Adi, soyadi as Soyadi, " +
                        "adres as Adres, telefon as Telefon, anneAdi as 'Anne Adı', babaAdi as 'Baba Adı', " +
                        "ziyaret_tarih as 'Ziyaret Tarihi', ziyaret_edilen as 'Mahkum Kimliği', ziyaret_yerID " +
                        $"from ZiyaretciKayit where firmaID = '{AnaBolum.firmaID}' and ziyaret_tarih between '{tarihBaslangic.Value}' and '{tarihBitis.Value}' and ";
            if (kimlik.Text.Trim() != "") command += $"kimlik = '{kimlik.Text}' and ";
            if (mahkumKimlik.Text.Trim() != "") command += $"ziyaret_edilen = '{mahkumKimlik.Text}'";
            if (command.EndsWith(" and ")) command = command.Substring(0, command.Length - 5);
            try
            {
                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(command, conn))
                    {
                        conn.Open();
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Ziyaretciler");
                        dataGridView1.DataSource = ds.Tables["Ziyaretciler"];
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[7].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";
                        dataGridView1.Columns[10].Visible = false;
                    }
                }
            } catch {
                MessageBox.Show("Veritabanınınızı kontrol ediniz ve programı kapatıp tekrar deneyiniz");
                Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dataGridView1.SelectedRows[0];
                adres.Text = r.Cells[4].Value.ToString();
                yerDetay.Text = yer_sozluk[r.Cells[10].Value.ToString()];
                kimlik.Text = r.Cells[1].Value.ToString();
                mahkumKimlik.Text = r.Cells[9].Value.ToString();
            }
        }

        private void sdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (AnaBolum.yetkiler["ziyaretci_sil"] == "1")
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                        {
                            conn.Open();
                            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                            string zID = selectedRow.Cells["ziyaretciID"].Value.ToString();
                            using (SqlCommand cmd = new SqlCommand(
                                "delete from ZiyaretciKayit where ziyaretciID = @zID", conn))
                            {
                                cmd.Parameters.AddWithValue("@zID", zID);
                                cmd.ExecuteNonQuery();
                                button1_Click(sender, e);
                            }
                            dataGridView1.Rows.RemoveAt(selectedrowindex);
                        }
                    }
                    catch { MessageBox.Show("Silme işlemi tamamlanamadı daha sonra tekrar deneyiniz."); }
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

        private void mahkumKimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ziyaretciDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (AnaBolum.yetkiler["ziyaretci_duzenle"] == "1")
                {
                    ZiyaretciDuzenle zDuzenle = new ZiyaretciDuzenle(dataGridView1.SelectedRows[0]);
                    zDuzenle.ShowDialog();
                }
                else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
            }
            else { MessageBox.Show("Seçili bir kayıt bulunamadı!"); }
        }
    }
}
