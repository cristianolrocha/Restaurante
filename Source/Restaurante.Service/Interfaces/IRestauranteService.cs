using Restaurante.Service.Base.Interfaces;

namespace Restaurante.Service.Interfaces
{
    public interface IRestauranteService : IEntityService<Model.Restaurante>
    {
        Model.Restaurante GetById(long Id);
    }
}
