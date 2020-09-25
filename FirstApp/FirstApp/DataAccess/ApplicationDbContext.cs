using FirstApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

using Xamarin.Forms;

namespace FirstApp.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string dbFilename = "banco1.db";

        public virtual DbSet<Note> Notes { get; set; }

        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = string.Format("Data Source={0}", DatabasePath);

            optionsBuilder.UseSqlite(connection);
        }

        private string DatabasePath => Device.RuntimePlatform switch
        {
            Device.Android => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), dbFilename),
            Device.iOS or Device.macOS => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", dbFilename),
            Device.UWP => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), dbFilename),
            _ => throw new Exception("Sistema não suportado")
        };
    }
}
