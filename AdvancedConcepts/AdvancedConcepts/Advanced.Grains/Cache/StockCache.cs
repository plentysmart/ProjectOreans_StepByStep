using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Advanced.Interfaces.Cache;
using Orleans;

namespace Advanced.Grains
{
    public class StockCache :GrainBase, Advanced.Interfaces.Cache.IStockCache, Advanced.Interfaces.Cache.IStockObserver
    {
        private int _currentAvailablity=0;

        public override Task ActivateAsync()
        {
            var stockProduct = StockProductFactory.GetGrain(0);
            this._currentAvailablity = stockProduct.AddSubscriber(this).Result;
            return base.ActivateAsync();
        }

        public Task<int> GetAvailable()
        {
            return Task.FromResult(_currentAvailablity);
        }

        public void UpdatAvailableItems(int avaiable)
        {
            _currentAvailablity = avaiable;
        }
    }
}
