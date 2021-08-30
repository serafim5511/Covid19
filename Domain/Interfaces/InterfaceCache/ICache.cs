using Domain.Interfaces.Generics;
using Entities;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceUsuario
{
    public interface ICache : IGeneric<Cache>
    {
        Task<Cache> Recente();
    }
}
