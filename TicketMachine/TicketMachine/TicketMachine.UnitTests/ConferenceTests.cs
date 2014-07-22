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
    public class ConferenceTests
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
        public async Task GetName_Should_return_name()
        {
            var conferenceId = Guid.NewGuid();
            var conference = ConferenceFactory.GetGrain(conferenceId);
            var name = await conference.GetName();
            Debug.WriteLine(name);
            Assert.False(string.IsNullOrEmpty(name));
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
