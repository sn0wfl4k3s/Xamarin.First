using FirstApp.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace FirstApp.Services
{
    public class NoteService : IDataStore<Note>
    {
        private ObservableCollection<Note> _notes;

        public NoteService()
        {
            _notes = new ObservableCollection<Note>
            {
                new Note { Id = 1, Title = "titulo 1", Description = "Description número um." },
                new Note { Id = 2, Title = "titulo 2", Description = "Description número dois." }
            };
        }

        public void AddEntity(Note entity) => _notes.Add(entity);

        public void DeleteEntity(int id, Note entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Note entity) => _notes.Remove(entity);

        public ObservableCollection<Note> GetAllEntities() => _notes;

        public void UpdateEntity(int id, Note entity)
        {
            var index = _notes.IndexOf(_notes.First(n => n.Id == id));
            _notes.RemoveAt(index);
            _notes.Insert(index, entity);
        }
    }
}
