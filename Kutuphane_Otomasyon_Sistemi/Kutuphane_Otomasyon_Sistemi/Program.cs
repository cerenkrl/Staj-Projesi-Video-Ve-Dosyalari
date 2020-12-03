using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormKOS.Model;

namespace Kutuphane_Otomasyon_Sistemi
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormKayıt());

            if (IDataBase.DataToDataTable("select* from kullanicilar where aktif=1").Rows.Count > 0)
            {
                Application.Run(new FormGiris());
            }
            else
            {
                Application.Run(new FormKayıt());
            }
        }
    }
}
