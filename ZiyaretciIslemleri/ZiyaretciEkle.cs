using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CezaeviProgram.ZiyaretciIslemleri
{
    public partial class ZiyaretciEkle : Form
    {
        public ZiyaretciEkle()
        {
            InitializeComponent();
        }

        Dictionary<string, string> yer_sozluk = new Dictionary<string, string>();
        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList durumlar = new ArrayList() {
                    kimlik.Text.Length != 11, adres.Text.Trim().Length < 9,
                    adi.Text.Trim().Length < 2, soyadi.Text.Trim().Length < 1, anneAdi.Text.Trim().Length < 2,
                    babaAdi.Text.Trim().Length < 2, telefon.Text.Trim().Length != 10, mahkumKimligi.Text.Trim().Length != 11 
            };

            if (durumlar.Contains(true)) { MessageBox.Show("Bütün bilgileri formatına uygun şekilde doldurunuz."); }
            else
            {
                string command_insert = "insert into ZiyaretciKayit values (@kimlik, @adi, @soyadi, @adres, " +
                    "@telefon, @anneAdi, @babaAdi, @ziyaretTarih, @mahkumKimlik, @yerID, @firmaID)";
                string command_check = $"select * from Mahkum where kimlik = '{mahkumKimligi.Text}'";

                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    {
                        using (SqlCommand cmd = new SqlCommand(command_insert, conn))
                        {
                            conn.Open();
                            DataSet ds = new DataSet();
                            using (SqlDataAdapter da = new SqlDataAdapter(command_check, conn))
                                da.Fill(ds, "Kontrol");

                            if (ds.Tables["Kontrol"].Rows.Count == 1)
                            {
                                ds.Dispose();
                                cmd.Parameters.AddWithValue("@kimlik", kimlik.Text);
                                cmd.Parameters.AddWithValue("@adi", adi.Text);
                                cmd.Parameters.AddWithValue("@soyadi", soyadi.Text);
                                cmd.Parameters.AddWithValue("@adres", adres.Text);
                                cmd.Parameters.AddWithValue("@telefon", telefon.Text);
                                cmd.Parameters.AddWithValue("@anneAdi", anneAdi.Text);
                                cmd.Parameters.AddWithValue("@babaAdi", babaAdi.Text);
                                cmd.Parameters.AddWithValue("@ziyaretTarih", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                                cmd.Parameters.AddWithValue("@mahkumKimlik", mahkumKimligi.Text);
                                cmd.Parameters.AddWithValue("@yerID", yerID.SelectedItem);
                                cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Ziyaretçi Eklendi!");
                                Close();
                            }
                            else MessageBox.Show("Ziyaret edilecek kişinin kimlik bilgisi bulunamadi!");
                        }
                    }
                } catch { MessageBox.Show("Kayıt tamamlanamadı, tekrar deneyiniz..."); }
            }
        }

        private void ZiyaretciEkle_Load(object sender, EventArgs e)
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
            } catch { MessageBox.Show("Veritabanı bağlantısı sağlanamadı, veritabanınızı kontrol ediniz!"); }

            if (yerID.Items.Count > 0)
                yerID.SelectedIndex = 0;
            else
            {
                MessageBox.Show("Görüş yeri bilgisi bulunamadı, önce bir görüş alanı ekleyin");
                Close();
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
    }
}
