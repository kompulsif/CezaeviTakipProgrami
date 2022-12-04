using CezaeviProgram.AyarMenuleri;
using CezaeviProgram.AyarMenuleri.KogusIslemleri;
using CezaeviProgram.AyarMenuleri.PersonelTipIslemleri;
using CezaeviProgram.IzinIslemleri;
using CezaeviProgram.PersonelIslemleri;
using CezaeviProgram.ZiyaretciIslemleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CezaeviProgram
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giris());
        }
    }
}
