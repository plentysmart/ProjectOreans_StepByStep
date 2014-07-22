using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans.Samples.Testing;
using TicketMachine.Interfaces;
using Xunit;

namespace TicketMachine.UnitTests
{
    public class ConferenceTests : IDisposable
    {
        private static readonly UnitTestSiloOptions siloOptions = new UnitTestSiloOptions
        {
            StartFreshOrleans = true
        };
        private static readonly UnitTestClientOptions clientOptions = new UnitTestClientOptions
        {
            ResponseTimeout = TimeSpan.FromSeconds(30)
        };

        private UnitTestSiloHost _unitTestSiloHost;


        public ConferenceTests()
        {
            _unitTestSiloHost = new UnitTestSiloHost(siloOptions, clientOptions);
        }

        [Fact]
        public async void GetName_Should_return_name()
        {
            var conferenceId = Guid.NewGuid();
            var conference = ConferenceFactory.GetGrain(conferenceId);
            var name = await conference.GetName();
            Debug.WriteLine(name);
            Assert.False(string.IsNullOrEmpty(name));
        }

        public void Dispose()
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
