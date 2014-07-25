using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced.Interfaces.Cache;
using Orleans;

namespace Advanced.Grains.Cache
{
    public class StockProduct: GrainBase,IStockProduct
    {
        private int _availability;

        private ObserverSubscriptionManager<IStockObserver> subscribers;

        public override Task ActivateAsync()
        {
            subscribers = new ObserverSubscriptionManager<IStockObserver>();
            return base.ActivateAsync();
        }

        public Task UpdateAvailability(int availability)
        {
            _availability = availability;
            subscribers.Notify((so)=> so.UpdatAvailableItems(_availability));
            return TaskDone.Done;
        }

        public Task<int> AddSubscriber(IStockObserver observer)
        {
            subscribers.Subscribe(observer);
            return Task.FromResult(_availability);
        }
    }
}
