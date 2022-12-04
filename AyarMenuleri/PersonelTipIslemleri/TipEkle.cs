using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.PersonelTipIslemleri
{
    public partial class TipEkle : Form
    {
        public TipEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 2)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("insert into PersonelTipleri values (@firmaID, @tip)", conn))
                    {
                        cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                        cmd.Parameters.AddWithValue("@tip", textBox1.Text.Trim());
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        TipSorgu.add_or_edit = true;
                        MessageBox.Show("Yeni personel tipi eklendi!");
                        Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Bağlantı hatası, yer eklenemedi!\nTekrar deneyiniz");
                    Hide();
                }
            } else { MessageBox.Show("Personel tip bilgisi en az 3 karakter olmalıdır!"); }
        }
    }
}
