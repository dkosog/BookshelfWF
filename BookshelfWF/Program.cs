using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookshelfWF
{
    internal static class Program
    {
       
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F_Main());
        }
    }
    /// <summary>
    /// Обмен данными между формами
    /// </summary>
    static class SharedId
    {
        public static int Id { get; set; }
    }
}
