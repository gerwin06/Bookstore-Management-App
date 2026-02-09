using System.Globalization;
using System.Threading;

namespace BookstoreManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.         
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-PH");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-PH");

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}