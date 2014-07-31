using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using AttributeRouting.Web.Mvc;
using TicketMachine;
using TicketMachine.Interfaces;

namespace TicketMaster.WebUI.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual async Task<ActionResult> Index()
        {
            var eventManager = EventManagerFactory.GetGrain(0);
            var events = await eventManager.GetAllEvents();
            return View(events);
        }

        [GET("/add")]
        public virtual ActionResult Add(EventSettings settings)
        {
            return this.View(settings ?? new EventSettings());
        }


        [POST("/add/")]
        public virtual async Task<ActionResult> Added(string eventName, string eventDescription)
        {
            var settings = new EventSettings()
            {
                Name = eventName,
                Description = eventDescription
            };
            if (string.IsNullOrEmpty(eventName))
            {
                return Add(settings);
            }

            var eventManager = EventManagerFactory.GetGrain(0);

            var eventId = await eventManager.AddEvent(settings);
            return this.RedirectToAction(MVC.Home.Index());
        }

        [GET("event/{id}")]
        public virtual async Task<ActionResult> Event(Guid id)
        {
            if (id == Guid.Empty)
                return this.HttpNotFound();
            var eventManager = EventManagerFactory.GetGrain(0);
            var eventInfo = await eventManager.GetEvent(id);
            if(eventInfo == null)
                return this.HttpNotFound();
            return this.View(eventInfo);

        }
    }
}