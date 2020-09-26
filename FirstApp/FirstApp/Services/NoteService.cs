using FirstApp.Contracts;
using FirstApp.DataAccess;
using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp.Services
{
    public class NoteService : IDataStore<Note>
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public void AddEntity(Note entity)
        {
            _context.Notes.Add(entity);
            _context.SaveChanges();
        }

        public void DeleteEntity(Note entity)
        {
            _context.Notes.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Note> GetAllEntities()
        {
            return _context.Notes.ToList();
        }

        public void UpdateEntity(int id, Note entity)
        {
            _context.Notes.Update(entity);
            _context.SaveChanges();
        }
    }
}
