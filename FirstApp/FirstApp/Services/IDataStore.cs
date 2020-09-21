using System.Collections.ObjectModel;

namespace FirstApp.Services
{
    public interface IDataStore<T> where T : class
    {
        ObservableCollection<T> GetAllEntities();
        void AddEntity(T entity);
        void UpdateEntity(int id, T entity);
        void DeleteEntity(int id, T entity);
    }
}
