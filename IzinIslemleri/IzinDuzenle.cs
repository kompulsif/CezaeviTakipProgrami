using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.IzinIslemleri
{
    public partial class IzinDuzenle : Form
    {
        DataGridViewRow row;
        public IzinDuzenle(DataGridViewRow r)
        {
            row = r;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yeniAciklama.Text.Trim().Length > 9)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("update MudurIzinKayit set izinDetay = @izinDetay, " +
                        "izinTarih = @izinTarih where kayitID = @kayitID", conn))
                    {
                        conn.Open();
                        string kayitID = row.Cells[0].Value.ToString();
                        string tarih = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                        cmd.Parameters.AddWithValue("@izinDetay", yeniAciklama.Text);
                        cmd.Parameters.AddWithValue("@izinTarih", tarih);
                        cmd.Parameters.AddWithValue("@kayitID", kayitID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Açıklama Güncellendi!");
                    }
                } catch {
                    MessageBox.Show("Açıklama güncellenemedi, daha sonra tekrar deneyiniz");
                    Hide();
                }
            }
            else MessageBox.Show("Açıklama en az 10 karakterden oluşmalıdır!");
        }
    }
}
