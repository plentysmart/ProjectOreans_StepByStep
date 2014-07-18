using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using HelloWorld.Common;
using Orleans;

namespace HelloWorld.Core
{
    /// <summary>
    /// Orleans grain implementation class Grain1.
    /// </summary>

    public class HelloWorld : Orleans.GrainBase, IHelloWorld
    {
        // TODO: replace placeholder grain interface with actual grain
        // communication interface(s).
        private int currentColorIndex = 0;

        private ConsoleColor[] _colors =
        {
            ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow
        };

        public async Task Hello(string name)
        {
            var systemConsole = SystemConsoleFactory.GetGrain(0);
            var color = _colors[++currentColorIndex%_colors.Length];
            await Task.Delay(500);
            await systemConsole.Display(string.Format("{1} - Hello {0}", name, currentColorIndex), color);
        }
    }
}
