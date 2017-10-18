using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWORK_Var2_VendingMachine
{
    static class Program
    {
        public static GeneralForm GF;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GF = new GeneralForm();
            Application.Run(GF);
        }
    }
}