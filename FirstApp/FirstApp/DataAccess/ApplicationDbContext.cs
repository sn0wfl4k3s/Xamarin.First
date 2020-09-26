using FirstApp.Contracts;
using FirstApp.Models;
using Microsoft.EntityFrameworkCore;
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
            var fileHelper = DependencyService.Get<IFileHelper>();

            string connection = string.Format("Filename={0}", fileHelper.GetLocalFilePath(dbFilename));

            optionsBuilder.UseSqlite(connection);
        }
    }
}
