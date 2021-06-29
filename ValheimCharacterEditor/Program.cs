using System;
using System.Windows.Forms;
using ValheimCharacterEditor.Forms;

namespace ValheimCharacterEditor
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

            LastFormClosingApplicationContext appContext = new LastFormClosingApplicationContext(new FrmMain());
            Application.Run(appContext);
        }
    }
}
