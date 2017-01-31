using Restaurante.Repository.Base;
using Restaurante.Repository.Interfaces;
using System.Data.Entity;
using System.Linq;

namespace Restaurante.Repository
{
    public class RestauranteRepository : GenericRepository<Restaurante.Model.Restaurante>, IRestauranteRepository
    {
        public RestauranteRepository(DbContext context)
            : base(context)
        { }

        public Restaurante.Model.Restaurante GetById(long id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }
    }
}
