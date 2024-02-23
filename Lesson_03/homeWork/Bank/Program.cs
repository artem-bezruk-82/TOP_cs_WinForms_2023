using System.Configuration;

namespace Bank
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
            Application.Run(new FormClients());
            // dotnet ef dbcontext scaffold "Data Source=DataModel\\bank.db" Microsoft.EntityFrameworkCore.Sqlite

        }
    }
}