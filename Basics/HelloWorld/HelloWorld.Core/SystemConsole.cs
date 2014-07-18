using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Common;

namespace HelloWorld.Core
{
    public class SystemConsole: Orleans.GrainBase, ISystemConsole
    {
        public async Task Display(string message, ConsoleColor? color)
        {
            if(color.HasValue)
            System.Console.ForegroundColor = color.Value;
            System.Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
