using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRun
{
    public class Program
    {
        private const string CalcAppName = "calc";

        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to run Calc, another key to exit...");
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                Process.Start(CalcAppName);
                return;
            }
        }
    }
}
