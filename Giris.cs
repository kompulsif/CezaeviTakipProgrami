using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CezaeviProgram
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        public static DataSet ds = new DataSet();
        public static string firmaAdi;
        public static string kAdi;

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text.Trim();
            string parola = textBox2.Text.Trim();
            if (kullaniciAdi != "" && parola != "")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Server= localhost; Database=Cezaevi; Integrated Security=True;"))
                    using (SqlDataAdapter da = new SqlDataAdapter($"select * from Kullanicilar where kullaniciAdi = '{kullaniciAdi}' collate Latin1_General_CS_AI and parola = '{parola}' collate Latin1_General_CS_AI", conn))
                    {
                        conn.Open();
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Bilgiler");
                        if (ds.Tables["Bilgiler"].Rows.Count == 1)
                        {
                            if (ds.Tables["Bilgiler"].Rows[0]["aktiflik"].ToString() == "1")
                            {
                                string yetkileri = ds.Tables["Bilgiler"].Rows[0]["yetkiler"].ToString();
                                kAdi = kullaniciAdi;
                                AnaBolum anaBolum = new AnaBolum(ds.Tables["Bilgiler"].Rows[0]["firmaID"].ToString(), kullaniciAdi, yetkileri);
                                anaBolum.Show();
                                Hide();
                            } else { 
                                MessageBox.Show("Hesabınız aktif değildir!\nLütfen yöneticinize başvurun");
                                Close();
                            }
                        }
                        else { MessageBox.Show("Girdiğiniz bilgiler hatalıdır!"); }
                    }
                }
                catch { MessageBox.Show("Bağlantı hatası, daha sonra tekrar deneyin"); }
            } else { MessageBox.Show("Kullanıcı adı ve parolanızı giriniz"); }

        }

        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
    }
}
