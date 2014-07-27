using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans;
using TicketMachine.Interfaces;

namespace TicketMachine
{
    public class EventManager : GrainBase<IEventManagerState>, IEventManager
    {
         public override Task ActivateAsync()
         {
             if (this.GetPrimaryKeyLong() != 0 || this.GetPrimaryKey() != Guid.Empty)
                 throw new InvalidOperationException("You can't get other event manager other than with id = 0");
             if (State.Events == null)
                 this.State.Events = new List<EventInfo>();
             this.State.WriteStateAsync();
             return base.ActivateAsync();
         }

         public async Task<Guid> AddEvent(EventSettings eventSettings)
        {
            var newId = Guid.NewGuid();
            var newEvent = EventFactory.GetGrain(newId);
            await newEvent.Initialize(eventSettings);
            var eventInfo = new EventInfo(newId, eventSettings);
            this.State.Events.Add(eventInfo);
            State.WriteStateAsync();
            return newId;
        }

        public Task<EventInfo[]> GetAllEvents()
        {
            return Task.FromResult(State.Events.ToArray());
        }
    }

    public interface IEventManagerState : IGrainState
    {
        List<EventInfo> Events { get; set; }
    }
}