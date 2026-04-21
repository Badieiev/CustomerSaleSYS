using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSaleSYS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseLoader.IsCustomerTableExists();
            DatabaseLoader.IsProductTableExists();
            DatabaseLoader.IsOrderTableExists();

            Application.Run(new CustomerSaleSystem());
        }
    }
}
