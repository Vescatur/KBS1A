using KBS1SE.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KBS1SE.View;

namespace KBS1SE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new MainView());
=======
            Application.Run(new Form1());
>>>>>>> 23a83df4bb0b3d69286725d72d38894456a59fca
        }
    }
}
