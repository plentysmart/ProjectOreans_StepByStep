using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans;

namespace HelloWorld.Common
{
    public interface ISystemConsole:IGrain
    {
        Task Display(string message, ConsoleColor? color);
    }
}
