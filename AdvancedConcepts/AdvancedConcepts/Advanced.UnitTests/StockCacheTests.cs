using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced.Interfaces.Cache;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orleans.Samples.Testing;

namespace Advanced.UnitTests
{
    [TestClass]
    public class StockCacheTests
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
        public async void StockCacheProduct_available_update_should_update_observers()
        {
            var product = StockProductFactory.GetGrain(0);
            var cache = StockCacheFactory.GetGrain(0);
            await product.UpdateAvailability(10);
            var actual = await cache.GetAvailable();
            Assert.Equals(10, actual);
            await product.UpdateAvailability(20);
            actual = await cache.GetAvailable();

            Assert.Equals(20, actual);
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
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }
            _unitTestSiloHost = null;
        }

    }
}
