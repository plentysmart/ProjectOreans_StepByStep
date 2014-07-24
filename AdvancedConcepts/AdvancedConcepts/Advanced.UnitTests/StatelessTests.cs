using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orleans.Samples.Testing;

namespace Advanced.UnitTests
{
     [TestClass]
    public class StatelessTests
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
            var max = 1000;
             ConcurrentBag<int> bag = new ConcurrentBag<int>();
            var tasksList = new List<Task>();
            for (int i = 0; i < max; i++)
            {
                var task = new Task(async () =>
                {
                    var grain = StatelessGrainFactory.GetGrain(0);
                    var reference = await grain.GetObjectReference();
                    bag.Add(reference);
                });
                tasksList.Add(task);
            }
            Parallel.ForEach(tasksList, (t) => t.Start());
            Task.WaitAll(tasksList.ToArray());
            Assert.IsTrue(bag.Any());
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

