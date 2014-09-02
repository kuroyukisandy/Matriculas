using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            F_matricula login = new F_matricula();
            login.ShowDialog();
            if(login.DialogResult==DialogResult.OK){
                Application.Run(new F_Principal());
            }
        }
    }
}
