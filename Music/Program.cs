using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    static class Program
    {
        public static fMusic fMusicCurent;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fMusicCurent = new fMusic();
            Application.Run(fMusicCurent);
           
        }
    }
}
