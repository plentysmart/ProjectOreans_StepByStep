using System.Threading.Tasks;
using Orleans;

namespace Advanced.Interfaces.Cache
{
    public interface IStockProduct:IGrain
    {
        Task UpdateAvailability(int availability);

        Task<int> AddSubscriber(IStockObserver observer);
        
    }
}
