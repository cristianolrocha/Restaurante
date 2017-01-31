using Restaurante.Repository.Base.Interfaces;
using Restaurante.Repository.Interfaces;
using Restaurante.Service.Base;
using Restaurante.Service.Interfaces;

namespace Restaurante.Service
{
    public class RestauranteService : EntityService<Model.Restaurante>, IRestauranteService
    {
        IUnitOfWork _unitOfWork;
        IRestauranteRepository _restauranteRepository;

        public RestauranteService(IUnitOfWork unitOfWork, IRestauranteRepository restauranteRepository)
            : base(unitOfWork, restauranteRepository)
        {
            _unitOfWork = unitOfWork;
            _restauranteRepository = restauranteRepository;
        }

        public Model.Restaurante GetById(long Id)
        {
            return _restauranteRepository.GetById(Id);
        }
    }
}
