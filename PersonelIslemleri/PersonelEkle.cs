using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CezaeviProgram.PersonelIslemleri
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        Dictionary<string, string> gorevYeriSozluk;
        public static ComboBox pt;
        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            gorevYeriSozluk = new Dictionary<string, string>();
            pt = personelTipi;
            using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
            using (SqlCommand cmd = new SqlCommand("select distinct tipID from PersonelTipleri where firmaID = @firmaID", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        personelTipi.Items.Add(reader[0].ToString());
                }
                if (personelTipi.Items.Count > 0)
                {
                    personelTipi.SelectedIndex = 0;
                    cmd.CommandText = "select * from Bolge where firmaID = @firmaID_";
                    cmd.Parameters.AddWithValue("@firmaID_", AnaBolum.firmaID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            gorevYeriSozluk.Add(reader[0].ToString(), reader[1].ToString());
                            gorevYeri.Items.Add(reader[0].ToString());
                        }
                    }
                    if (gorevYeriSozluk.Count > 0) gorevYeri.SelectedIndex = 0;
                    else { MessageBox.Show("Personel için eklenilebilecek bir görev yeri bulunamadı!"); Close(); }
                } else { MessageBox.Show("Eklenebilecek bir personel tipi bulunamadı, yöneticiniz eklemelidir!"); Close(); }
            }
        }

        private void personelTipi_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void gorevYeri_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void gorevYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            gorevYerBilgi.Text = gorevYeriSozluk[gorevYeri.SelectedItem.ToString()];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList durumlar = new ArrayList() {
                kimlik.Text.Trim().Length != 11, adi.Text.Trim().Length < 2, soyadi.Text.Trim().Length < 1, 
                adres.Text.Trim().Length < 9, telefon.Text.Trim().Length != 10, anneAdi.Text.Trim().Length < 2,
                babaAdi.Text.Trim().Length < 2, maas.Text.Trim().Length < 3,
            };
            if (durumlar.Contains(true)) MessageBox.Show("Bilgiler uygun uzunlukta değil");
            try
            {
                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                using (SqlCommand cmd = new SqlCommand(
                    "insert into Personel values (@kimlik, @tipi, @adi, @soyadi, @adres, @telefon," +
                    " @anneAdi, @babaAdi, @gorevYeri, @giris, @cikis, @alimTarih, @maas, @firmaID)", conn))
                {
                    cmd.Parameters.AddWithValue("@kimlik", kimlik.Text.Trim());
                    cmd.Parameters.AddWithValue("@tipi", personelTipi.Text);
                    cmd.Parameters.AddWithValue("@adi", adi.Text.Trim());
                    cmd.Parameters.AddWithValue("@soyadi", soyadi.Text.Trim());
                    cmd.Parameters.AddWithValue("@adres", adres.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefon", telefon.Text.Trim());
                    cmd.Parameters.AddWithValue("@anneAdi", anneAdi.Text.Trim());
                    cmd.Parameters.AddWithValue("@babaAdi", babaAdi.Text.Trim());
                    cmd.Parameters.AddWithValue("@gorevYeri", gorevYeri.Text);
                    cmd.Parameters.AddWithValue("@giris", giris.Text);
                    cmd.Parameters.AddWithValue("@cikis", cikis.Text);
                    cmd.Parameters.AddWithValue("@alimTarih", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@maas", maas.Text.Trim());
                    cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Personel eklendi!");
                    Close();
                }
            } catch { MessageBox.Show("Veritabanına ekleme sırasında bir problem oluştu,\n" +
                "Bilgi formatlarını ve veritabanını kontrol edip tekrar deneyiniz"); }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            PersonelTipBilgilendirme ptipbilgi = new PersonelTipBilgilendirme(this.Name);
            ptipbilgi.ShowDialog();
        }

        private void kimlik_KeyPress(object sender, KeyPressEventArgs e)
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
