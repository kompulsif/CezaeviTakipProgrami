using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.PersonelTipIslemleri
{
    public partial class TipDuzenle : Form
    {
        string tipID;
        public TipDuzenle(string tID)
        {
            InitializeComponent();
            tipID = tID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 2)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("update PersonelTipleri set tip = @perTip where tipID = @tipID", conn))
                    {
                        cmd.Parameters.AddWithValue("@tipID", tipID);
                        cmd.Parameters.AddWithValue("@perTip", textBox1.Text.Trim());
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        TipSorgu.add_or_edit = true;
                        MessageBox.Show("Personel tip bilgisi güncellendi!");
                        Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Personel tip bilgisi güncellenemedi!\nVeritabanı bağlantısı sırasında bir hata oluştu, lütfen daha sonra tekrar deneyiniz");
                    Hide();
                }
            } else { MessageBox.Show("Personel tip bilgisi en az 3 karakter olmalıdır!"); }
        }
    }
}
