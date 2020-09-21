using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FirstApp.Services
{
    public interface IDataStore<T> where T : class
    {
        ObservableCollection<T> GetAllEntities();
        Task<ObservableCollection<T>> GetAllEntitiesAsync();
        Task AddEntity(T entity);
        Task UpdateEntity(int id, T entity);
        Task DeleteEntity(int id, T entity);
    }
}
