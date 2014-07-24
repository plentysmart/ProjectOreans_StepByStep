using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Advanced.Interfaces;
using Orleans;

namespace Advanced.Grains
{
    /// <summary>
    /// Orleans grain implementation class Grain1.
    /// </summary>
 
    public class StatelessGrain : Orleans.GrainBase, IStatelessGrain 
    {

        public Task<int> GetObjectReference()
        {
            return Task.FromResult(this.GetHashCode());
        }
    }
}
