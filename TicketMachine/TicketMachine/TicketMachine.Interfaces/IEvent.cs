using System;
using System.Threading.Tasks;
using Orleans;

namespace TicketMachine.Interfaces
{
    public interface IEvent:IGrain
    {
        Task Initialize(EventSettings eventSettings);
    }
}