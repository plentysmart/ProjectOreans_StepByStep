﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Orleans;
using TicketMachine.Interfaces;

namespace TicketMachine
{
    [StorageProvider(ProviderName = "MemoryStore")]
    public class EventManager : GrainBase<IEventManagerState>, IEventManager
    {
        public override Task ActivateAsync()
        {
            if (this.GetPrimaryKeyLong() != 0 || this.GetPrimaryKey() != Guid.Empty) throw new InvalidOperationException("You can't get other event manager other than with id = 0");
            if (State.Events == null) this.State.Events = new List<EventInfo>();
            return this.State.WriteStateAsync();
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

        public Task<EventInfo> GetEvent(Guid id)
        {
            EventInfo eventInfo = State.Events.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(eventInfo);
        }
    }

    public interface IEventManagerState : IGrainState
    {
        List<EventInfo> Events { get; set; }
    }
}