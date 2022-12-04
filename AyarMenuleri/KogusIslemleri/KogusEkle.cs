using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.KogusIslemleri
{
    public partial class KogusEkle : Form
    {
        public KogusEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 1)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("insert into Kogus values (@kogusBilgisi, @firmaID)", conn))
                    {
                        cmd.Parameters.AddWithValue("@kogusBilgisi", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        KogusSorgu.add_or_edit = true;
                        MessageBox.Show("Yeni koğuş eklendi!");
                        Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Bağlantı hatası, yer eklenemedi!\nTekrar deneyiniz");
                    Hide();
                }
            } else { MessageBox.Show("Koğuş bilgisi en az 2 karakter olmalı!"); }
        }
    }
}
