using KT_TaskManage.Controller;
using KT_TaskManage.Data;

namespace KT_TaskManage
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
            ApplicationConfiguration.Initialize();

            MasterModel _masterData = new();
            var controller = new MainController(_masterData);
            var mainForm = new MainForm(controller);

            Application.Run(mainForm);
        }
    }
}