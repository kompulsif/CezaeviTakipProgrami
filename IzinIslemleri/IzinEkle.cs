using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram.IzinIslemleri
{
    public partial class IzinEkle : Form
    {
        public IzinEkle()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (aciklama.Text.Trim().Length < 9) MessageBox.Show("Açıklama en az karakterden oluşmalıdır");
            else if (kimlik.Text.Trim().Length != 11) MessageBox.Show("Kimlik bilgisi 11 karakterden oluşmalıdır!");
            else
            {
                if (mahkum.Checked)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                        {
                            conn.Open();
                            SqlDataAdapter da = new SqlDataAdapter(
                                $"select kimlik from Mahkum where kimlik = '{kimlik.Text}'", conn);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "kimlik");
                            if (ds.Tables["kimlik"].Rows.Count == 1)
                            {
                                string tarih = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                                da.UpdateCommand = new SqlCommand(
                                    $"insert into MudurIzinKayit values " +
                                    $"('Mahkum', '{kimlik.Text}', '{aciklama.Text}', '{tarih}', '{AnaBolum.firmaID}')", conn);
                                da.UpdateCommand.ExecuteNonQuery();
                                MessageBox.Show("İzin Eklendi!");
                            }
                            else MessageBox.Show("Kişinin kimlik bilgisi Mahkum kayıtlarında bulunamadı!");
                        }
                    } catch { MessageBox.Show("Bir hata oluştu, daha sonra tekrar deneyin..."); }
                }
                else if (personel.Checked)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                        {
                            conn.Open();
                            SqlDataAdapter da = new SqlDataAdapter(
                                $"select kimlik from Personel where kimlik = '{kimlik.Text}'", conn);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "kimlik");
                            if (ds.Tables["kimlik"].Rows.Count == 1)
                            {
                                string tarih = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                                da.UpdateCommand = new SqlCommand(
                                    $"insert into MudurIzinKayit values " +
                                    $"('Personel', '{kimlik.Text}', '{aciklama.Text}', '{tarih}', '{AnaBolum.firmaID}')", conn);
                                da.UpdateCommand.ExecuteNonQuery();
                                MessageBox.Show("İzin Eklendi!");
                            }
                            else MessageBox.Show("Kişinin kimlik bilgisi Personel kayıtlarında bulunamadı!");
                        }
                    } catch { MessageBox.Show("Bir hata oluştu, daha sonra tekrar deneyin..."); }

                }
                else MessageBox.Show("İzin verilecek kişinin ünvanı seçilmelidir!");
            }
        }

        private void kimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
