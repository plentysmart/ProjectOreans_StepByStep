using System.Threading.Tasks;
using System.Web.Mvc;
using TicketMachine.Interfaces;

namespace TicketMaster.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var eventManager=  EventManagerFactory.GetGrain(0);
            var events = eventManager.GetAllEvents().Result;
            return View(events);
        }
    }
}