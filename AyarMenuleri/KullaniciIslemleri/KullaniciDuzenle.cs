using System;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.KullaniciIslemleri
{
    public partial class KullaniciDuzenle : Form
    {
        string kullaniciID;
        string kullaniciAdi;
        string durum;
        string aktiflik;
        string[] yetkiler;
        ArrayList kutular;
        public KullaniciDuzenle(DataGridViewRow r)
        {
            InitializeComponent();
            kullaniciID = r.Cells[0].Value.ToString();
            kullaniciAdi = r.Cells[1].Value.ToString();
            durum = r.Cells[4].Value.ToString();
            yetkiler = r.Cells[3].Value.ToString().Split(',');
            label5.Text = (durum == "1") ? "Aktif" : "Aktif Değil";
            checkBox26.Text = (durum == "1") ? "Deaktif Et" : "Aktif Et";
            textBox1.Text = r.Cells[2].Value.ToString();
            kutular = new ArrayList() {
                checkBox1, checkBox2, checkBox21,
                checkBox3, checkBox4, checkBox5, checkBox22,
                checkBox6, checkBox7, checkBox8, checkBox25,
                checkBox9, checkBox10, checkBox11, checkBox23,
                checkBox12, checkBox14, checkBox13, checkBox24,
                checkBox15, checkBox17, checkBox18, checkBox19, checkBox16, checkBox27
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 7)
            {
                try
                {
                    string yetkisi = "";
                    foreach (CheckBox item in kutular) yetkisi += (item.Checked) ? "1," : "0,";
                    yetkisi = yetkisi.Trim(',');
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("update Kullanicilar set parola = @parola, yetkiler = @yetkiler, aktiflik = @aktiflik where id = @kullaniciID", conn))
                    {
                        cmd.Parameters.AddWithValue("@parola", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                        cmd.Parameters.AddWithValue("@yetkiler", yetkisi);
                        bool kapat = false;
                        if (durum == "1")
                        {
                            aktiflik = (checkBox26.Checked) ? "0" : "1";
                            kapat = (aktiflik == "0") ? true : false;
                        }
                        else aktiflik = (checkBox26.Checked) ? "1" : "0";
                        cmd.Parameters.AddWithValue("@aktiflik", aktiflik);
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        if (kullaniciAdi == Giris.kAdi)
                        {
                            if (kapat)
                            {
                                MessageBox.Show("Hesabınız artık aktif değildir, çıkış yapıldı!");
                                Application.Exit();
                            }
                            else
                            {
                                string[] values = yetkisi.Split(',');
                                string[] keys = {
                                    "mahkum_duzenle", "mahkum_ekle", "mahkum_sil",
                                    "izin_islem", "izin_duzenle", "izin_ekle", "izin_sil",
                                    "personel_islem", "personel_duzenle", "personel_ekle", "personel_sil",
                                    "yoklama_islem", "yoklama_duzenle", "yoklama_ekle", "yoklama_sil",
                                    "ziyaretci_islem", "ziyaretci_duzenle", "ziyaretci_ekle", "ziyaretci_sil",
                                    "ayarlar_tam", "kogus_ayarlari", "ziyaret_odasi_ayarlari",
                                    "gorev_yeri_ayarlari", "personel_tip_ayarlari", "kullanici_ayarlari"
                                };
                                AnaBolum.yetkiler = Enumerable.Range(0, keys.Length).ToDictionary(i => keys[i], i => values[i]);
                            }
                        }
                        KullaniciSorgu.add_or_edit = true;
                        Hide();
                        MessageBox.Show("Kullanıcının bilgileri düzenlendi!");
                    }
                }
                catch
                {
                    Hide();
                    MessageBox.Show("Kayıt güncellenemedi, bağlantınızı kontrol ediniz");
                }
            } else { MessageBox.Show("Parola en az 8 en fazla 30 karakter olmalıdır!"); }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            checkBox20.Checked = true;
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Visible = true;
                checkBox5.Visible = true;
                checkBox22.Visible = true;
            }
            else
            {
                checkBox4.Visible = false;
                checkBox4.Checked = false;
                checkBox5.Visible = false;
                checkBox5.Checked = false;
                checkBox22.Visible = false;
                checkBox22.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox7.Visible = true;
                checkBox8.Visible = true;
                checkBox25.Visible = true;
            }
            else
            {
                checkBox7.Visible = false;
                checkBox7.Checked = false;
                checkBox8.Visible = false;
                checkBox8.Checked = false;
                checkBox25.Visible = false;
                checkBox25.Checked = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox10.Visible = true;
                checkBox11.Visible = true;
                checkBox23.Visible = true;
            }
            else
            {
                checkBox10.Visible = false;
                checkBox10.Checked = false;
                checkBox11.Visible = false;
                checkBox11.Checked = false;
                checkBox23.Visible = false;
                checkBox23.Checked = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox13.Visible = true;
                checkBox14.Visible = true;
                checkBox24.Visible = true;
            }
            else
            {
                checkBox13.Visible = false;
                checkBox13.Checked = false;
                checkBox14.Visible = false;
                checkBox14.Checked = false;
                checkBox24.Visible = false;
                checkBox24.Checked = false;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                checkBox16.Visible = true;
                checkBox17.Visible = true;
                checkBox18.Visible = true;
                checkBox19.Visible = true;
                checkBox27.Visible = true;
            }
            else
            {
                checkBox16.Visible = false;
                checkBox16.Checked = false;
                checkBox17.Visible = false;
                checkBox17.Checked = false;
                checkBox18.Visible = false;
                checkBox18.Checked = false;
                checkBox19.Visible = false;
                checkBox19.Checked = false;
                checkBox27.Visible = false;
                checkBox27.Checked = false;
            }
        }

        private void KullaniciDuzenle_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < kutular.Count; i++)
            {
                CheckBox kutu = (CheckBox)kutular[i];
                if (yetkiler[i] == "1") kutu.Checked = true;
                else kutu.Checked = false;
            }
        }
    }
}
