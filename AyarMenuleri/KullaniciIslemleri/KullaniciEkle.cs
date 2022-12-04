using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Collections;

namespace CezaeviProgram.AyarMenuleri.KullaniciIslemleri
{
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length < 1) { MessageBox.Show("Kullanıcı adı en az 2 karakter olmalıdır"); }
            else if (textBox2.Text.Trim().Length < 7) { MessageBox.Show("Parola en az 8 karakter olmalıdır"); }
            else
            {
                int i = 0;
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("select kullaniciAdi from Kullanicilar where firmaID = @firmaID and kullaniciAdi = @kAdi", conn))
                        {
                            cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                            cmd.Parameters.AddWithValue("@kAdi", textBox1.Text.ToString());
                            using (SqlDataReader reader = cmd.ExecuteReader()) while (reader.Read()) i += 1;
                        }
                        if (i != 0) { MessageBox.Show("Bu kullanıcı adı kullanılıyor, eklenemez"); }
                        else
                        {
                            string yetkisi = "";
                            ArrayList kutular = new ArrayList() { 
                                checkBox1, checkBox2, checkBox21,
                                checkBox3, checkBox4, checkBox5, checkBox22,
                                checkBox6, checkBox7, checkBox8, checkBox25,
                                checkBox9, checkBox10, checkBox11, checkBox23,
                                checkBox12, checkBox14, checkBox13, checkBox24,
                                checkBox15, checkBox17, checkBox18, checkBox19, checkBox16, checkBox27
                            };
                            foreach (CheckBox item in kutular) yetkisi += (item.Checked) ? "1," : "0,";
                            yetkisi = yetkisi.Trim(',');
                            using (SqlCommand cmd = new SqlCommand("insert into Kullanicilar values (@kullaniciAdi, @parola, @yetkiler, @aktiflik, @firmaID)", conn))
                            {
                                cmd.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text.Trim());
                                cmd.Parameters.AddWithValue("@parola", textBox2.Text.Trim());
                                cmd.Parameters.AddWithValue("@yetkiler", yetkisi);
                                cmd.Parameters.AddWithValue("@aktiflik", (checkBox26.Checked) ? "1" : "0");
                                cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                                cmd.ExecuteNonQuery();
                                KullaniciSorgu.add_or_edit = true;
                                MessageBox.Show("Yeni kullanıcı eklendi!");
                                Hide();
                            }
                        }
                    }
                }
                catch { MessageBox.Show("Kullanıcı eklenemedi, bağlantınızı kontrol ediniz."); }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '_'))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && !textBox1.Text[0].ToString().All(Char.IsLetter))
            {
                textBox1.Text = textBox1.Text.Substring(1);
            }
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
            } else
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
            } else
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
            } else
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
            } else
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
    }
}
