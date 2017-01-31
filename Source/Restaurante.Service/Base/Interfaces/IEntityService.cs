using Restaurante.Model;
using Restaurante.Model.Base;
using System.Collections.Generic;

namespace Restaurante.Service.Base.Interfaces
{
    public interface IEntityService<T> : IService
        where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
