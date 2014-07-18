using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Orleans;

namespace HelloWorld.Common
{
    /// <summary>
    /// Orleans grain communication interface IGrain1
    /// </summary>
    public interface IHelloWorld : Orleans.IGrain
    {
        Task Hello(string name);
    }
}
