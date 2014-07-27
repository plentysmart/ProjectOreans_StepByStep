using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Orleans;
//using Orleans.Host.SiloHost;
using GlobalConfiguration = System.Web.Http.GlobalConfiguration;

namespace TicketMaster.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //private static OrleansSiloHost siloHost;
        protected void Application_Start()
        {
        //    string mapPath = Server.MapPath(@"~/OrleansConfiguration.xml");
        //    AppDomain hostDomain = AppDomain.CreateDomain("OrleansHost", null, new AppDomainSetup
        //    {
        //        AppDomainInitializer = InitSilo,
        //        AppDomainInitializerArguments = new string[] {mapPath },
        //        ApplicationBase = Server.MapPath(@"~/bin/")
        //    });

            OrleansClient.Initialize(Server.MapPath(@"~/LocalConfiguration.xml"));
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //private static void InitSilo(string[] args)
        //{

        //    string configFileName = args[0];
        //    string siloName = Dns.GetHostName();
        //    siloHost = new OrleansSiloHost(siloName);
        //    siloHost.ConfigFileName = configFileName;
        //    siloHost.Debug = true;
        //    siloHost.InitializeOrleansSilo();

        //    bool ok = siloHost.StartOrleansSilo();

        //    if (ok)
        //    {
        //        Debug.WriteLine("Successfully started Orleans silo '{0}' as a {1} node.", siloHost.SiloName, siloHost.SiloType);
        //    }
        //    else
        //    {
        //        throw new SystemException(string.Format("Failed to start Orleans silo '{0}' as a {1} node.", siloHost.SiloName, siloHost.SiloType));
        //    }
        //}

        protected void Application_Stop()
        {
        }

    }
}
