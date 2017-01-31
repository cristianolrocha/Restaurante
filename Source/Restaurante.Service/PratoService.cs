using Restaurante.Model;
using Restaurante.Repository.Base.Interfaces;
using Restaurante.Repository.Interfaces;
using Restaurante.Service.Base;
using Restaurante.Service.Interfaces;
using System.Collections.Generic;

namespace Restaurante.Service
{
    public class PratoService : EntityService<Prato>, IPratoService
    {
        IUnitOfWork _unitOfWork;
        IPratoRepository _pratoRepository;

        public PratoService(IUnitOfWork unitOfWork, IPratoRepository pratoRepository)
            : base(unitOfWork, pratoRepository)
        {
            _unitOfWork = unitOfWork;
            _pratoRepository = pratoRepository;
        }

        public Prato GetById(long Id)
        {
            return _pratoRepository.GetById(Id);
        }

        public IEnumerable<Prato> GetByRestauranteId(long id)
        {
            return _pratoRepository.GetByRestauranteId(id);
        }
    }
}
