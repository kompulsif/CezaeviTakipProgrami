using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.GorevYeriIslemleri
{
    public partial class YerDuzenle : Form
    {
        string bolge_id;
        public YerDuzenle(string bolgeId)
        {
            InitializeComponent();
            bolge_id = bolgeId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 1)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("update Bolge set bolgeAdi = @bolgeAdi where bolgeID = @bolgeID", conn))
                    {
                        cmd.Parameters.AddWithValue("@bolgeID", bolge_id);
                        cmd.Parameters.AddWithValue("@bolgeAdi", textBox1.Text.Trim());
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        YerSorgu.add_or_edit = true;
                        MessageBox.Show("Bölge bilgisi güncellendi!");
                        Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Bölge bilgisi güncellenemedi!\nVeritabanı bağlantısı sırasında bir hata oluştu, lütfen daha sonra tekrar deneyiniz");
                    Hide();
                }
            } else { MessageBox.Show("Görev yeri en az 2 karakter olmalıdır!"); }
        }
    }
}
