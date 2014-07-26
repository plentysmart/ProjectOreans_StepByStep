using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketMaster.WebUI.Startup))]
namespace TicketMaster.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
