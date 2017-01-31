using Restaurante.Model;
using Restaurante.Repository.Base.Interfaces;
using System.Collections.Generic;

namespace Restaurante.Repository.Interfaces
{
    public interface IPratoRepository : IGenericRepository<Prato>
    {
        Prato GetById(long id);
        IEnumerable<Prato> GetByRestauranteId(long id);
    }
}
