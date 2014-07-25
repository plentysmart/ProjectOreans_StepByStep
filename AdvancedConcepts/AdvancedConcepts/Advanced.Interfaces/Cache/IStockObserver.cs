using System.Threading.Tasks;
using Orleans;

namespace Advanced.Interfaces.Cache
{
    public interface IStockObserver: IGrainObserver
    {
         void UpdatAvailableItems(int avaiable);
    }
}
