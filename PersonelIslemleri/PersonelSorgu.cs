using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.PersonelIslemleri
{
    public partial class PersonelSorgu : Form
    {
        public static Dictionary<string, string> gorevYeriSozluk;
        public static Dictionary<string, string> personelTipleri;
        public static ComboBox gy;
        public static ComboBox pt;
        public PersonelSorgu()
        {
            InitializeComponent();
        }
        private void PersonelSorgu_Load(object sender, EventArgs e)
        {
            gorevYeriSozluk = new Dictionary<string, string>();
            personelTipleri = new Dictionary<string, string>();
            giris.CustomFormat = "HH:mm:ss";
            cikis.CustomFormat = "HH:mm:ss";
            tarihBaslangic.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            tarihBaslangic.Value = DateTime.Parse("1900/01/01 00:00:00");
            tarihBitis.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            giris.Value = DateTime.Parse("00:01:00");
            cikis.Value = DateTime.Parse("23:59:59");
            gy = gorevYeri;
            pt = personelTipi;
            string command = "select personelID, kimlik as Kimlik, adi as Adi, soyadi as Soyadi, anneAdi as 'Anne Adı', " +
                "babaAdi as 'Baba Adı', telefon as 'Telefon', adres as 'Adres', tipi as 'Personel', isAlimTarihi as 'Kayıt Tarihi', " +
                "gorevYeri as 'Görev Yeri', giris as 'Giriş Saati', cikis as 'Çıkış Saati', maas as 'Maaşı' " +
                $"from Personel where firmaID = {AnaBolum.firmaID}" ;

            using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(command, conn))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Personeller");
                    personelTipi.Items.Add("");
                    using (SqlCommand cmd = new SqlCommand("select tipID, tip from PersonelTipleri where firmaID = @firmaID", conn))
                    {
                        cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                personelTipleri.Add(reader[0].ToString(), reader[1].ToString());
                                personelTipi.Items.Add(reader[0].ToString());
                            }
                        }
                        personelTipi.SelectedIndex = 0;
                        gorevYeri.Items.Add("");
                        cmd.CommandText = $"select * from Bolge where firmaID = {AnaBolum.firmaID}";
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                gorevYeriSozluk.Add(reader[0].ToString(), reader[1].ToString());
                                gorevYeri.Items.Add(reader[0].ToString());
                            }
                        }
                        gorevYeri.SelectedIndex = 0;
                    }
                    dataGridView1.DataSource = ds.Tables["Personeller"];
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[9].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kimlik.Text = "";
            adi.Text = "";
            soyadi.Text = "";
            anneAdi.Text = "";
            babaAdi.Text = "";
            adres.Text = "";
            telefon.Text = "";
            maas.Text = "";
            personelTipi.SelectedIndex = 0;
            gorevYeri.SelectedIndex = 0;
            tarihBaslangic.Value = DateTime.Parse("1900/01/01 00:00:00");
            tarihBitis.Value = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            giris.Value = DateTime.Parse("00:01:00");
            cikis.Value = DateTime.Parse(DateTime.Now.ToString("HH:mm:ss"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList alist = new ArrayList() { 
                kimlik.Text.Trim() != "" && kimlik.TextLength != 11,
                telefon.Text.Trim() != "" && telefon.TextLength != 10,
                adi.Text.Trim() != "" && adi.TextLength < 3,
                soyadi.Text.Trim() != "" && soyadi.TextLength < 2,
                anneAdi.Text.Trim() != "" && anneAdi.TextLength < 3,
                babaAdi.Text.Trim() != "" && babaAdi.TextLength < 3,
                adres.Text.Trim() != "" && adres.Text.Length < 10,
                maas.Text.Trim() != "" && maas.Text.Length < 4
            };

            if (alist.Contains(true)) MessageBox.Show("Lütfen bilgileri doğru uzunlukta girdiğinize dikkat ediniz");
            else
            {
                string kosul = $"kimlik like '%{kimlik.Text}%' and adi like '%{adi.Text}%' and soyadi like '%{soyadi.Text}%' and " +
                                $"telefon like '%{telefon.Text}%' and anneAdi like '%{anneAdi.Text}%' and babaAdi like '%{babaAdi.Text}%' and " +
                                $"gorevYeri like '%{gorevYeri.SelectedItem}%' and tipi like '%{personelTipi.SelectedItem}%' and " +
                                $"maas >= '{maas.Text}' and isAlimTarihi between '{tarihBaslangic.Value}' and '{tarihBitis.Value}'";


                string select = "select personelID, kimlik as Kimlik, adi as Adi, soyadi as Soyadi, anneAdi as 'Anne Adı', " +
                "babaAdi as 'Baba Adı', telefon as 'Telefon', adres as 'Adres', tipi as 'Personel', isAlimTarihi as 'Kayıt Tarihi', " +
                "gorevYeri as 'Görev Yeri', giris as 'Giriş Saati', cikis as 'Çıkış Saati', maas as 'Maaşı' " +
                "from Personel where firmaID = @firmaID and " + kosul;

                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                using (SqlCommand cmd = new SqlCommand(select, conn))
                {
                    cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                    if (radioButton1.Checked) cmd.CommandText += $" and giris >= '{giris.Value}'";
                    else cmd.CommandText += $" and cikis <= '{cikis.Value}'";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        conn.Open();
                        DataSet ds = new DataSet();
                        da.Fill(ds, "PersonelSorgu");
                        dataGridView1.DataSource = ds.Tables["PersonelSorgu"];
                    }
                }
            }
        }

        private void gorevYeri_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void personelTipi_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AnaBolum.yetkiler["personel_ekle"] == "1")
            {
                PersonelEkle pekle = new PersonelEkle();
                pekle.ShowDialog();
            } else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dataGridView1.SelectedRows[0];
                kimlik.Text = r.Cells[1].Value.ToString();
                adi.Text = r.Cells[2].Value.ToString();
                soyadi.Text = r.Cells[3].Value.ToString();
                anneAdi.Text = r.Cells[4].Value.ToString();
                babaAdi.Text = r.Cells[5].Value.ToString();
                telefon.Text = r.Cells[6].Value.ToString();
                adres.Text = r.Cells[7].Value.ToString();
                personelTipi.Text = r.Cells[8].Value.ToString();
                kayitTarih.Text = r.Cells[9].FormattedValue.ToString();
                gorevYeri.Text = r.Cells[10].Value.ToString();
                giris.Text = r.Cells[11].Value.ToString();
                cikis.Text = r.Cells[12].Value.ToString();
                maas.Text = r.Cells[13].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GorevYeriBilgilendirme gb = new GorevYeriBilgilendirme();
            gb.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            PersonelTipBilgilendirme pbilgi = new PersonelTipBilgilendirme(this.Name);
            pbilgi.ShowDialog();
        }

        private void personeliSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (AnaBolum.yetkiler["personel_sil"] == "1")
                {
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("delete from Personel where personelID = @perID", conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@perID", r.Cells[0].Value.ToString());
                        cmd.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(r.Index);
                        MessageBox.Show("Seçili personel silindi!");
                        button1_Click(sender, e);
                    }
                } else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
            } else { MessageBox.Show("Seçili bir personel bulunamadı!"); }
        }

        private void kimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void adi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void soyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void anneAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void babaAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void personeliDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (AnaBolum.yetkiler["personel_duzenle"] == "1")
                {
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    PersonelDuzenle pduzenle = new PersonelDuzenle(r);
                    pduzenle.ShowDialog();
                }
                else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
            }
            else { MessageBox.Show("Seçili bir personel bulunamadı!"); }
        }
    }
}
