using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram
{
    public partial class YoklamaSorgu : Form
    {
        public YoklamaSorgu()
        {
            InitializeComponent();
        }
        string datetime_pattern = "yyyy/MM/dd HH:mm:ss";
        string tarih;
        private void YoklamaSorgu_Load(object sender, EventArgs e)
        {
            tarihBaslangic.CustomFormat = datetime_pattern;
            tarihBitis.CustomFormat = datetime_pattern;
            tarihBaslangic.Value = DateTime.Now.AddDays(-1);
            tarihBitis.Value = DateTime.Now;

            try
            {
                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "select kayitID, kayitKimlik as Kimlik, " +
                        $"durum as Durum, kayitTarih as Tarih from YoklamaKayit where firmaID = {AnaBolum.firmaID}",
                        conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Yoklama");
                    dataGridView1.DataSource = ds.Tables["Yoklama"];
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[3].DefaultCellStyle.Format = datetime_pattern;
                    durum.Items.Add("Var");
                    durum.Items.Add("Yok");
                    durum.Items.Add("Hepsi");
                    durum.SelectedIndex = 2;
                }
            } catch { 
                MessageBox.Show("Veritabanı bağlantısı yapılamadı, veritabanını kontrol ediniz");
                Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kimlik.Text = "";
            durum.SelectedIndex = 2;
            tarihBaslangic.Value = DateTime.Parse("1900/01/01 00:00:00");
            tarihBitis.Value = DateTime.Parse(DateTime.Now.ToString(datetime_pattern));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmd = $"select kayitID, kayitKimlik as Kimlik, durum as Durum, kayitTarih as Tarih from YoklamaKayit where firmaID = {AnaBolum.firmaID} and ";
            string cmd_suffix = "";
            if (kimlik.Text.Trim() != "")
                cmd_suffix += $"kayitKimlik = '{kimlik.Text.Trim()}' and ";
            if (durum.SelectedIndex != 2)
                cmd_suffix += $"durum = '{durum.Items[durum.SelectedIndex]}' and ";
            string x = tarihBaslangic.Value.ToString(datetime_pattern);
            string y = tarihBitis.Value.ToString(datetime_pattern);
            cmd_suffix += $"kayitTarih between '{x}' and '{y}'";
            using (SqlConnection con = new SqlConnection(AnaBolum.conn_str))
            {
                cmd += cmd_suffix;
                SqlDataAdapter da = new SqlDataAdapter(cmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Yoklama");
                dataGridView1.DataSource = ds.Tables["Yoklama"];
            }
        }

        private void durum_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AnaBolum.yetkiler["yoklama_ekle"] == "1")
            {
                YoklamaKayit yk = new YoklamaKayit();
                yk.ShowDialog();
            } else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }

        private void sdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (AnaBolum.yetkiler["yoklama_sil"] == "1")
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    {
                        conn.Open();
                        int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                        string kayitID = selectedRow.Cells["kayitID"].Value.ToString();
                        using (SqlCommand cmd = new SqlCommand(
                            "delete from YoklamaKayit where kayitID = @kayitID", conn))
                        {
                            cmd.Parameters.AddWithValue("@kayitID", kayitID);
                            cmd.ExecuteNonQuery();
                        }
                        dataGridView1.Rows.RemoveAt(selectedrowindex);
                    }
                }
                else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
            }
            else { MessageBox.Show("Seçili kayıt bulunamadı!"); }
        }

        private void varToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (AnaBolum.yetkiler["yoklama_duzenle"] == "1")
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    if (selectedRow.Cells[2].Value.ToString() != "Var")
                    {
                        using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                        {
                            conn.Open();
                            string kayitID = selectedRow.Cells["kayitID"].Value.ToString();
                            using (SqlCommand cmd = new SqlCommand(
                                "update YoklamaKayit set durum = 'Var', kayitTarih = @tarih where kayitID = @kayitID", conn))
                            {
                                tarih = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                                cmd.Parameters.AddWithValue("@tarih", tarih);
                                cmd.Parameters.AddWithValue("@kayitID", kayitID);
                                cmd.ExecuteNonQuery();
                            }
                            selectedRow.Cells[2].Value = "Var";
                            selectedRow.Cells[3].Value = tarih;
                        }
                    }
                    else MessageBox.Show("Durum zaten 'Var' değeri almıştır");
                }
                else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
            }
            else MessageBox.Show("Seçili kayıt bulunamadı!");
        }

        private void yokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (AnaBolum.yetkiler["yoklama_duzenle"] == "1")
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    if (selectedRow.Cells[2].Value.ToString() != "Yok")
                    {
                        using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                        {
                            conn.Open();
                            string kayitID = selectedRow.Cells["kayitID"].Value.ToString();
                            using (SqlCommand cmd = new SqlCommand(
                                "update YoklamaKayit set durum = 'Yok', kayitTarih = @tarih where kayitID = @kayitID", conn))
                            {
                                tarih = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                                cmd.Parameters.AddWithValue("@tarih", tarih);
                                cmd.Parameters.AddWithValue("@kayitID", kayitID);
                                cmd.ExecuteNonQuery();
                            }
                            selectedRow.Cells[2].Value = "Yok";
                            selectedRow.Cells[3].Value = tarih;
                        }
                    }
                    else MessageBox.Show("Durum zaten 'Yok' değeri almıştır");
                } else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
            }
            else MessageBox.Show("Seçili kayıt bulunamadı!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kimlik.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void kimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
