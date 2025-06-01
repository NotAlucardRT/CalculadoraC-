using System;
using System.Windows.Forms;
using CalculadoraApp.Vista;

namespace CalculadoraApp
{
    /// <summary>
    /// Clase principal del programa.
    /// </summary>
    static class MainClass
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculadoraForm());
        }
    }
}
