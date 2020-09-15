using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessApplication
{
    static class Program
    {
        public static string connString;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContainer appWindow = new AppContainer();
            Application.Run(appWindow);
        }
    }
}
