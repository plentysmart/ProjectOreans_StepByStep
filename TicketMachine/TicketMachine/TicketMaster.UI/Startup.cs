using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketMaster.UI.Startup))]
namespace TicketMaster.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
