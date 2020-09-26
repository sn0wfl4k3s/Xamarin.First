using System.Collections.Generic;

namespace FirstApp.Services
{
    public interface IDataStore<T> where T : class
    {
        IEnumerable<T> GetAllEntities();
        void AddEntity(T entity);
        void UpdateEntity(int id, T entity);
        void DeleteEntity(T entity);
    }
}
