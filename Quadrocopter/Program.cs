using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadrocopter
{
    static class Program
    {
        static Setup SETUP;
        static Quadrocopter QUADROCOPTER;

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SETUP = new Setup();
            Application.Run(SETUP);
            if (SETUP.DialogResult == DialogResult.OK)
            {
                QUADROCOPTER = new Quadrocopter(SETUP.COMPort, SETUP.Baudrate);
                Application.Run(QUADROCOPTER);
            }
        }
    }
}
