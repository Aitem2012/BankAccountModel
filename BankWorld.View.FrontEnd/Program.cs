using BankWorld.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankWorld.View.FrontEnd
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Add instance of global config
                GlobalConfig.AddInstance();
                //Call the custoomer Instance
                var customerInstance = GlobalConfig.customerService;
                var auth = GlobalConfig.authService;
                var account = GlobalConfig.accountService;


                Application.Run(new Login(customerInstance, auth, account));
                //Application.Run(new Dashboard());
                GlobalConfig.RemoveInstance();
            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message, "An Error Occur", MessageBoxButtons.OK);
            }

        }
    }
}
