using System.Threading.Tasks;
using Orleans;

namespace Advanced.Interfaces
{
    /// <summary>
    /// Orleans grain communication interface IGrain1
    /// </summary>
    [StatelessWorker]
    public interface IStatelessGrain : Orleans.IGrain
    {
        Task<int> GetObjectReference();
    }
}
