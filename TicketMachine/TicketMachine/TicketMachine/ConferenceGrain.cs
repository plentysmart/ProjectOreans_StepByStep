using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Orleans;
using TicketMachine.Interfaces;

namespace TicketMachine
{
    /// <summary>
    /// Orleans grain implementation class Grain1.
    /// </summary>
    public class ConferenceGrain : Orleans.GrainBase, IConference
    {
        // TODO: replace placeholder grain interface with actual grain
        // communication interface(s).
        private string _name = "conference name";

        public Task<string> GetName()
        {
            return Task.FromResult(_name);
        }
    }
}
