using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Orleans;

namespace TicketMachine.Interfaces
{
    public interface IEventManager: IGrain
    {

        Task<Guid> AddEvent (EventSettings eventSettings);
        Task<EventInfo[]> GetAllEvents();
        Task<EventInfo> GetEvent(Guid id);
    }

    public class EventSettings
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class EventInfo
    {
        public Guid Id { get; set; }

        public EventInfo(Guid id, EventSettings settings)
        {
            Id = id;
            Name = settings.Name;
            Description = settings.Description;
        }

        public string Description { get; set; }

        public string Name { get; set; }
    }
}
