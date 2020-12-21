using System;
using HCGStudio.SystemRefresher.Core.Scanner;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HCGStudio.SystemRefresher.ManualTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddLogging(option =>
            {
                option.SetMinimumLevel(LogLevel.Trace);
                option.AddConsole();
            });
            if (OperatingSystem.IsWindows())
            {
                services.AddScoped<ISoftwareScanner, WindowsVcPkgScanner>();
                services.AddScoped<VcPkgScanner, WindowsVcPkgScanner>();

                using var container = services.BuildServiceProvider();
                foreach (var softwareScanner in container.GetServices<ISoftwareScanner>())
                foreach (var software in softwareScanner.ScanSoftware())
                    Console.WriteLine(software);
            }
        }
    }
}