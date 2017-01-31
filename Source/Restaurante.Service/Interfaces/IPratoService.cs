using Restaurante.Model;
using Restaurante.Service.Base.Interfaces;
using System.Collections.Generic;

namespace Restaurante.Service.Interfaces
{
    public interface IPratoService : IEntityService<Prato>
    {
        Prato GetById(long Id);
        IEnumerable<Prato> GetByRestauranteId(long id);
    }
}
