using System;
using System.Collections.Generic;

namespace InfrastructureBaselineSolution.ViewModels
{
    public abstract class RepositoryBase<T> : IRepository<T>
    {
        protected readonly string connection;
        protected readonly IUnitOfWorkManager worker;

        protected RepositoryBase(IUnitOfWorkManager unitOfWorkManager, string connectionName)
        {
            worker = unitOfWorkManager;
            connection = connectionName;
        }

        public T Get(object id)
        {
            throw new NotImplementedException();
        }

        public T Load(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Save(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IList<T> batch)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }

    public interface IUnitOfWorkManager
    {

    }
}