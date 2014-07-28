using System.Threading.Tasks;
using System.Web.Mvc;
using AttributeRouting.Web.Mvc;
using TicketMachine.Interfaces;

namespace TicketMaster.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var eventManager=  EventManagerFactory.GetGrain(0);
            var events = await eventManager.GetAllEvents();
            return View(events);
        }
        [GET("/add/{eventName}")]
        public async Task<ActionResult> Add(string eventName)
        {

            var eventManager = EventManagerFactory.GetGrain(0);
            var settings = new EventSettings()
            {
                Name = eventName ?? "some conference" 
            };
            var eventId= await eventManager.AddEvent(settings);
            var response = new
            {
                EventId = eventId
            };
            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}