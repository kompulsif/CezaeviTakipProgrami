using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CezaeviProgram.ZiyaretciIslemleri
{
    public partial class ZiyaretciDuzenle : Form
    {
        Dictionary<string, string> yer_sozluk = new Dictionary<string, string>();
        string ziyaretciID;
        public ZiyaretciDuzenle(DataGridViewRow r)
        {
            InitializeComponent();
            ziyaretciID = r.Cells[0].Value.ToString();
            kimlik.Text = r.Cells[1].Value.ToString();
            adi.Text = r.Cells[2].Value.ToString();
            soyadi.Text = r.Cells[3].Value.ToString();
            adres.Text = r.Cells[4].Value.ToString();
            telefon.Text = r.Cells[5].Value.ToString();
            anneAdi.Text = r.Cells[6].Value.ToString();
            babaAdi.Text = r.Cells[7].Value.ToString();
            mahkumKimligi.Text = r.Cells[9].Value.ToString();
            yerID.Text = r.Cells[10].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList durumlar = new ArrayList() {
                adres.Text.Trim().Length < 9, adi.Text.Trim().Length < 2, soyadi.Text.Trim().Length < 1,
                anneAdi.Text.Trim().Length < 2, babaAdi.Text.Trim().Length < 2, telefon.Text.Trim().Length != 10,
                mahkumKimligi.Text.Trim().Length != 11
            };

            if (durumlar.Contains(true)) { MessageBox.Show("Bütün bilgileri formatına uygun şekilde doldurunuz."); }
            else
            {
                using (SqlConnection conn = new SqlConnection("Server=localhost; Database=Cezaevi; Integrated Security=True;"))
                {
                    int i = 0;
                    using (SqlCommand cmd = new SqlCommand("select adi from Mahkum where kimlik = @kimlik", conn))
                    {
                        cmd.Parameters.AddWithValue("@kimlik", mahkumKimligi.Text.Trim());
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader()) while (reader.Read()) i++;
                    }

                    if (i != 0)
                    {
                        using (SqlCommand cmd = new SqlCommand(
                                        "update ZiyaretciKayit set adi = @adi, soyadi = @soyadi, " +
                                        "adres = @adres, telefon = @telefon, anneAdi = @anneAdi, " +
                                        "babaAdi = @babaAdi, ziyaret_tarih = @ziyaret_tarih, " +
                                        "ziyaret_edilen = @ziyaret_edilen, ziyaret_yerID = @ziyaret_yerID " +
                                        "where ziyaretciID = @ziyaretciID", conn))
                        {
                            cmd.Parameters.AddWithValue("@adi", adi.Text.Trim());
                            cmd.Parameters.AddWithValue("@soyadi", soyadi.Text.Trim());
                            cmd.Parameters.AddWithValue("@adres", adres.Text.Trim());
                            cmd.Parameters.AddWithValue("@telefon", telefon.Text.Trim());
                            cmd.Parameters.AddWithValue("@anneAdi", anneAdi.Text.Trim());
                            cmd.Parameters.AddWithValue("@babaAdi", babaAdi.Text.Trim());
                            cmd.Parameters.AddWithValue("@ziyaret_tarih", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                            cmd.Parameters.AddWithValue("@ziyaret_edilen", mahkumKimligi.Text.Trim());
                            cmd.Parameters.AddWithValue("@ziyaret_yerID", yerID.Text.Trim());
                            cmd.Parameters.AddWithValue("@ziyaretciID", ziyaretciID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Kayıt güncellendi!");
                            Hide();
                        }
                    }
                    else { MessageBox.Show("Ziyaret edilecek mahkum kayıtlarda bulunamadı!"); }
                }
            }
        }

        private void yerID_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void yerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            yerDetay.Text = yer_sozluk[yerID.SelectedItem.ToString()];
        }

        private void kimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mahkumKimligi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ZiyaretciDuzenle_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                {
                    string command = "select yerID, yerBilgi from ZiyaretYerleri where firmaID = @firmaID";

                    using (SqlCommand cmd = new SqlCommand(command, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            yer_sozluk.Add(dr[0].ToString(), dr[1].ToString());
                            yerID.Items.Add(dr[0].ToString());
                        }
                    }
                }
            }
            catch { MessageBox.Show("Veritabanı bağlantısı sağlanamadı, veritabanınızı kontrol ediniz!"); }
        }
    }
}
