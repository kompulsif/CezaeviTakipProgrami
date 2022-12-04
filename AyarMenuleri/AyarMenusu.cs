using CezaeviProgram.AyarMenuleri.GorevYeriIslemleri;
using CezaeviProgram.AyarMenuleri.KogusIslemleri;
using CezaeviProgram.AyarMenuleri.KullaniciIslemleri;
using CezaeviProgram.AyarMenuleri.PersonelTipIslemleri;
using CezaeviProgram.AyarMenuleri.ZiyaretciOdaIslemleri;
using System;
using System.Windows.Forms;

namespace CezaeviProgram.AyarMenuleri
{
    public partial class AyarMenusu : Form
    {
        public AyarMenusu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AnaBolum.yetkiler["kogus_ayarlari"] == "1")
            {
                KogusSorgu menu_k = new KogusSorgu();
                menu_k.ShowDialog();
            } else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AnaBolum.yetkiler["ziyaret_odasi_ayarlari"] == "1")
            {
                OdaSorgu menu_z = new OdaSorgu();
                menu_z.ShowDialog();
            } else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (AnaBolum.yetkiler["personel_tip_ayarlari"] == "1")
            {
                TipSorgu menu_p = new TipSorgu();
                menu_p.ShowDialog();
            } else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (AnaBolum.yetkiler["gorev_yeri_ayarlari"] == "1")
            {
                YerSorgu ySorgu = new YerSorgu();
                ySorgu.ShowDialog();
            } else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (AnaBolum.yetkiler["kullanici_ayarlari"] == "1")
            {
                KullaniciSorgu kSorgu = new KullaniciSorgu();
                kSorgu.ShowDialog();
            } else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }
    }
}
