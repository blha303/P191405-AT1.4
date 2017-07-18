// Steven Smith
// P191405
// Wed 19 Jul 2017 00:01:52 AWST
// Program main

using System;
using System.Windows.Forms;

namespace AT1_4_7 {
    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form7());
        }
    }
}
