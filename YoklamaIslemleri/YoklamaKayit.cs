using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram
{
    public partial class YoklamaKayit : Form
    {
        public YoklamaKayit()
        {
            InitializeComponent();
        }
        private void YoklamaKayit_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Var");
            comboBox1.Items.Add("Yok");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length != 11) MessageBox.Show("Kimlik bilgisi uygun uzunlukta değil");
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(
                            $"select kimlik from Mahkum where kimlik = '{textBox1.Text}'", conn);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "kimlik");
                        if (ds.Tables["kimlik"].Rows.Count == 1)
                        {
                            string tarih = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                            da.UpdateCommand = new SqlCommand(
                                $"insert into YoklamaKayit values " +
                                $"('{textBox1.Text}', '{comboBox1.Items[comboBox1.SelectedIndex]}', '{tarih}', '{AnaBolum.firmaID}')", conn);
                            da.UpdateCommand.ExecuteNonQuery();
                            MessageBox.Show("Kayıt Eklendi!");
                        }
                        else MessageBox.Show("Kişinin kimlik bilgisi Mahkum kayıtlarında bulunamadı!");
                    }
                }
                catch { MessageBox.Show("Bir hata oluştu, daha sonra tekrar deneyin..."); }
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
