using System;
using System.Windows.Forms;
using Healing.Views;

namespace Healing
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.LoginForm());
        }
    }
}
