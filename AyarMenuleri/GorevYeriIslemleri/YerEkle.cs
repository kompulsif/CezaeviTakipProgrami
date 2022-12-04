using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.GorevYeriIslemleri
{
    public partial class YerEkle : Form
    {
        public YerEkle()
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
                    using (SqlCommand cmd = new SqlCommand("insert into Bolge values (@bolgeAdi, @firmaID)", conn))
                    {
                        cmd.Parameters.AddWithValue("@bolgeAdi", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        YerSorgu.add_or_edit = true;
                        MessageBox.Show("Yeni görev yeri eklendi!");
                        Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Bağlantı hatası, yer eklenemedi!\nTekrar deneyiniz");
                    Hide();
                }
            } else { MessageBox.Show("Görev yeri en az 2 karakter olmalıdır!"); }
        }
    }
}
