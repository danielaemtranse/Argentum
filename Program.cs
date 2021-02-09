using System;
using System.Windows.Forms;
using Argentum.BLL;

namespace Argentum
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.AddMessageFilter(new Base.TestMessageFilter());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Argentum());
        }
    }
}
