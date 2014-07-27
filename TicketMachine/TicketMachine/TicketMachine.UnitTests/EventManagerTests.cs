using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orleans.Samples.Testing;
using TicketMachine.Interfaces;
using Xunit;
using Assert = Xunit.Assert;

namespace TicketMachine.UnitTests
{
     [TestClass]
    public class EventManagerTests
    {
        private static readonly UnitTestSiloOptions siloOptions = new UnitTestSiloOptions
        {
            StartFreshOrleans = true,
        };
        private static readonly UnitTestClientOptions clientOptions = new UnitTestClientOptions
        {
            ResponseTimeout = TimeSpan.FromSeconds(30)
        };

        private static UnitTestSiloHost _unitTestSiloHost;

         [ClassInitialize]
         public static void ClassInitialize(TestContext testContext)
         {
             _unitTestSiloHost = new UnitTestSiloHost(siloOptions, clientOptions);
         }

         [TestMethod]
         public async Task when_new_event_added_should_return_id()
         {
             var eventSettings = new EventSettings {Name = "NewEvent"};
             var eventManager = EventManagerFactory.GetGrain(0);
             var eventId = await eventManager.AddEvent(eventSettings);
             Assert.NotEqual(Guid.Empty, eventId);
         }

         [TestMethod]
         public async Task should_throw_exception_when_initalizing_event_manager_with_id_other_than_0()
         {
             var eventManager = EventManagerFactory.GetGrain(124);
             Assert.Throws<AggregateException>(() => eventManager.GetAllEvents().Wait());
         }


         [ClassCleanup]
        public static void ClassCleanup()
        {
            if (_unitTestSiloHost != null)
            {
                try
                {
                    _unitTestSiloHost.StopDefaultSilos();
                }
                catch (Exception exc) { Console.WriteLine(exc); }
            }
            _unitTestSiloHost = null;
        }
    }
}
