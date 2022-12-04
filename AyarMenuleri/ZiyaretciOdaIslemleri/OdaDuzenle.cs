using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.ZiyaretciOdaIslemleri
{
    public partial class OdaDuzenle : Form
    {
        string odaID;
        public OdaDuzenle(string oID)
        {
            InitializeComponent();
            odaID = oID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 1)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("update ZiyaretYerleri set yerBilgi = @yerBilgi where yerID = @yerID", conn))
                    {
                        cmd.Parameters.AddWithValue("@yerID", odaID);
                        cmd.Parameters.AddWithValue("@yerBilgi", textBox1.Text.Trim());
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        OdaSorgu.add_or_edit = true;
                        MessageBox.Show("Ziyaretçi odası güncellendi!");
                        Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Ziyaretçi oda bilgisi güncellenemedi!\nVeritabanı bağlantısı sırasında bir hata oluştu, lütfen daha sonra tekrar deneyiniz");
                    Hide();
                }
            } else { MessageBox.Show("Oda bilgisi en az 2 karakter olmalıdır!"); }
        }
    }
}
