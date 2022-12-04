using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri.ZiyaretciOdaIslemleri
{
    public partial class OdaEkle : Form
    {
        public OdaEkle()
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
                    using (SqlCommand cmd = new SqlCommand("insert into ZiyaretYerleri values (@yer, @firmaID)", conn))
                    {
                        cmd.Parameters.AddWithValue("@yer", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        OdaSorgu.add_or_edit = true;
                        MessageBox.Show("Yeni ziyaret yeri eklendi!");
                        Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Bağlantı hatası, yer eklenemedi!\nTekrar deneyiniz");
                    Hide();
                }
            } else { MessageBox.Show("Oda bilgisi en az 2 karakter olmalıdır!"); }
        }
    }
}
