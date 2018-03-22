using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_SearchFile_
{
    public delegate void myDelegate(string data,string data1);

    static class Program
    {
        //обьявляем делегат для передачи данных в форму

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFormWithWorks());
            
        }
    }
}
