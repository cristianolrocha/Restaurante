using Restaurante.Model;
using Restaurante.Repository.Base;
using Restaurante.Repository.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Restaurante.Repository
{
    public class PratoRepository : GenericRepository<Prato>, IPratoRepository
    {
        public PratoRepository(DbContext context)
            : base(context)
        {

        }

        public Prato GetById(long id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Prato> GetByRestauranteId(long id)
        {
            return FindBy(x => x.RestauranteId == id);
        }
    }
}
