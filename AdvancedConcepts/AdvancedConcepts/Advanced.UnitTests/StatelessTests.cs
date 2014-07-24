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
        public async Task StatelessGrains()
        {
            var max = 1000;
            var maxTasks = 10;
             ConcurrentBag<int> bag = new ConcurrentBag<int>();
            var tasksList = new List<Task>();

            for (int j = 0; j < maxTasks; j++)
            {
                var task = new Task( () =>
                {
                    for (int i = 0; i < max; i++)
                    {
                        var grain = StatelessGrainFactory.GetGrain(0);
                        var reference = grain.GetObjectReference().Result;
                        bag.Add(reference);
                    }
                    ;
                });
                task.Start();
                tasksList.Add(task);
            }

            Task.WaitAll(tasksList.ToArray());
            Assert.IsTrue(bag.Any());
            Assert.IsTrue(bag.Distinct().Count() >1);
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

