using System;
using System.Threading.Tasks;
using Orleans;
using TicketMachine.Interfaces;

namespace TicketMachine
{
     [StorageProvider(ProviderName = "MemoryStore")]
    public class Event:GrainBase<IEventState>,IEvent
    {

        public Task Initialize(EventSettings eventSettings)
        {
            if(State.Initialized)
                throw new InvalidOperationException("Already initialized");
            this.State.Name = eventSettings.Name;
            this.State.Id = this.GetPrimaryKey();
            this.State.Initialized = true;
            return this.State.WriteStateAsync();
        }
    }

    public interface IEventState : IGrainState
    {
        string Name { get; set; }
        Guid Id { get; set; }
        bool Initialized { get; set; }
    }
}