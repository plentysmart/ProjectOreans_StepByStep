using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelloWorld.Common;

namespace HelloWorldHost
{
    /// <summary>
    /// Orleans test silo host
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // The Orleans silo environment is initialized in its own app domain in order to more
            // closely emulate the distributed situation, when the client and the server cannot
            // pass data via shared memory.
            AppDomain hostDomain = AppDomain.CreateDomain("OrleansHost", null, new AppDomainSetup
            {
                AppDomainInitializer = InitSilo,
                AppDomainInitializerArguments = args,
            });

            Orleans.OrleansClient.Initialize("DevTestClientConfiguration.xml");

            // TODO: once the previous call returns, the silo is up and running.
            //       This is the place your custom logic, for example calling client logic
            //       or initializing an HTTP front end for accepting incoming requests.

            Console.WriteLine("Orleans Silo is running.\nPress Enter to terminate...");

            var helloWorld = HelloWorldFactory.GetGrain(0);
            var tasks = new List<Task>();
            tasks.Add(Task.Factory.StartNew(() =>
                helloWorld.Hello("Bartek")));
            tasks.Add(Task.Factory.StartNew(() =>
                helloWorld.Hello("Monika")));
            tasks.Add(Task.Factory.StartNew(() =>
                helloWorld.Hello("World")));
            tasks.Add(Task.Factory.StartNew(() =>
                helloWorld.Hello("World again")));
            tasks.Add(Task.Factory.StartNew(() =>
                helloWorld.Hello("Something else again")));
            Task.WaitAll(tasks.ToArray());

            Console.ReadLine();

            hostDomain.DoCallBack(ShutdownSilo);
        }

        static void InitSilo(string[] args)
        {
            hostWrapper = new OrleansHostWrapper(args);

            if (!hostWrapper.Run())
            {
                Console.Error.WriteLine("Failed to initialize Orleans silo");
            }
        }

        static void ShutdownSilo()
        {
            if (hostWrapper != null)
            {
                hostWrapper.Dispose();
                GC.SuppressFinalize(hostWrapper);
            }
        }

        private static OrleansHostWrapper hostWrapper;
    }
}
