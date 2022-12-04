using System;
using System.Collections;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CezaeviProgram.MahkumIslemleri
{
    public partial class MahkumEkle : Form
    {
        public MahkumEkle()
        {
            InitializeComponent();
        }
        string imagePath = "";
        public static ComboBox k;

        private void MahkumEkle_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str)) 
            using (SqlCommand cmd = new SqlCommand("select kogusID from Kogus where firmaID = @firmaID", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read()) koguslar.Items.Add(reader["kogusID"]);
                if (koguslar.Items.Count > 0)
                    koguslar.SelectedIndex = 0;
                else
                {
                    MessageBox.Show("Mahkum için eklenebilecek bir koğuş bulunamamıştır, yöneticiniz eklemelidir!");
                    Close();
                }
            }
            k = koguslar;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resimler(*.jpeg; *.png; *.jpg) | *.jpeg;*.png;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        imagePath = openFileDialog.FileName;
                        if (myStream.Length > 512000) MessageBox.Show("Dosya boyutu aşıldı!");
                        else
                        {
                            pictureBox1.Image = Image.FromFile(imagePath);
                            myStream.Close();
                        }
                    }
                }
                catch { MessageBox.Show("Resim belgesini kontrol ediniz"); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList durumlar = new ArrayList() {
                    kimlik.Text.Length != 11, adres.Text.Length < 9,
                    adi.Text.Length < 2, soyadi.Text.Length < 1, anneAdi.Text.Length < 2,
                    babaAdi.Text.Length < 2, telefon.Text.Length != 10, imagePath == ""
                };

            if (durumlar.Contains(true)) MessageBox.Show("Bilgilerin doğruluğunu ve uzunluğunu kontrol ediniz!");
            else
            {
                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                {
                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);

                    if (stream.Length != 0)
                    {
                        string tarih = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                        string command = $"insert into Mahkum values (@kimlik, @adi, @soyadi, @telefon, " +
                            "@adres, @anneAdi, @babaAdi, @kogusID, @resim, @kayitTarih, @firmaID)";

                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(command, conn))
                            {
                                conn.Open();
                                cmd.Parameters.AddWithValue("@kimlik", kimlik.Text);
                                cmd.Parameters.AddWithValue("@adi", adi.Text);
                                cmd.Parameters.AddWithValue("@soyadi", soyadi.Text);
                                cmd.Parameters.AddWithValue("@telefon", telefon.Text);
                                cmd.Parameters.AddWithValue("@adres", adres.Text);
                                cmd.Parameters.AddWithValue("@anneAdi", anneAdi.Text);
                                cmd.Parameters.AddWithValue("@babaAdi", babaAdi.Text);
                                cmd.Parameters.AddWithValue("@kogusID", koguslar.SelectedItem);
                                cmd.Parameters.AddWithValue("@resim", stream.ToArray());
                                cmd.Parameters.AddWithValue("@kayitTarih", tarih);
                                cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                                stream.Close();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Mahkum Eklendi!");
                                Close();
                            }
                        }
                        catch { MessageBox.Show("Bilgilerinizin formatını/uzunlugunu kontrol ediniz"); }

                    }
                    else MessageBox.Show("Resim hatalıdır, jpeg, png ve jpg formatında resimler seçiniz");
                }
            }
        }

        private void koguslar_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MahkumKogusBilgilendirme mkogusbilgi = new MahkumKogusBilgilendirme(this.Name);
            mkogusbilgi.ShowDialog();
        }
    }
}
