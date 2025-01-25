using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboShelf
{
    internal static class Program
    {
        static LoginForm lg;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //Application.Run(new EmployeeForm();
            //Application.Run(new CheckoutForm());
            Application.Run(new AdminForm(lg));
        }
    }
}
