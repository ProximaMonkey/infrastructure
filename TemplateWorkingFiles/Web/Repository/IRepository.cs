using System.Collections.Generic;

namespace InfrastructureBaselineSolution.ViewModels
{
    public interface IRepository<T>
    {
        T Get(object id);
        T Load(object id);
        void Delete(T entity);
        void Save(T entity);
        void SaveAll(IList<T> batch);
        void Update(T entity);
        IList<T> GetAll();
    }
}