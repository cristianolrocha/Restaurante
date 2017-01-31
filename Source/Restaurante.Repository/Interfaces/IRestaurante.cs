using Restaurante.Model;
using Restaurante.Repository.Base.Interfaces;

namespace Restaurante.Repository.Interfaces
{
    public interface IRestauranteRepository : IGenericRepository<Restaurante.Model.Restaurante>
    {
        Restaurante.Model.Restaurante GetById(long id);
    }
}
