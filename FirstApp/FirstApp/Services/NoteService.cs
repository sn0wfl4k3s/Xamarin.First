using FirstApp.Models;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FirstApp.Services
{
    public class NoteService : IDataStore<Note>
    {
        public Task AddEntity(Note entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEntity(int id, Note entity)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Note> GetAllEntities()
        {
            return new ObservableCollection<Note>
            {
                new Note { Title = "titulo 1", Description = "Description número um." },
                new Note { Title = "titulo 2", Description = "Description número dois." },
            };
        }

        public Task<ObservableCollection<Note>> GetAllEntitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateEntity(int id, Note entity)
        {
            throw new NotImplementedException();
        }
    }
}
