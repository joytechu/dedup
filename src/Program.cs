using Dedup.Core;
using Dedup.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dedup
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dedup());
            var builder = new HostBuilder()
             .ConfigureServices((hostContext, services) =>
             {
                 services.AddTransient<IFileHasher, FileHasher>();
                 services.AddSingleton<Dedup>();

             });
            var host = builder.Build();
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var form1 = services.GetRequiredService<Dedup>();


                    Application.Run(form1);
                } catch(Exception e)
                {
                    
                }
            }
        }
    }
}
