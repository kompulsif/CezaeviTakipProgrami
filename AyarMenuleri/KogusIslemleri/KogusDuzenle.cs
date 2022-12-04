using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.KogusIslemleri
{
    public partial class KogusDuzenle : Form
    {
        string kogusID;
        public KogusDuzenle(string kID)
        {
            InitializeComponent();
            kogusID = kID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 1)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("update Kogus set kogusBilgisi = @kogusBilgisi where kogusID = @kogusID", conn))
                    {
                        cmd.Parameters.AddWithValue("@kogusID", kogusID);
                        cmd.Parameters.AddWithValue("@kogusBilgisi", textBox1.Text.Trim());
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        KogusSorgu.add_or_edit = true;
                        MessageBox.Show("Koğuş bilgisi güncellendi!");
                        Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Koğuş bilgisi güncellenemedi!\nVeritabanı bağlantısı sırasında bir hata oluştu, lütfen daha sonra tekrar deneyiniz");
                    Hide();
                }
            } else { MessageBox.Show("Koğuş bilgisi en az 2 karakter olmalı!"); }
        }
    }
}
