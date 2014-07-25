using System.Threading.Tasks;
using Orleans;

namespace Advanced.Interfaces.Cache
{
    [StatelessWorker]
    public interface IStockCache: IGrain
    {
        Task<int> GetAvailable();
    }
}
