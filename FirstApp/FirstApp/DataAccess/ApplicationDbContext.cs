using FirstApp.Contracts;
using FirstApp.Models;
using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;

namespace FirstApp.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string dbFilename = "banco.db";

        public virtual DbSet<Note> Notes { get; set; }

        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var helper = DependencyService.Get<IFileHelper>();

            string connection = string.Format("Filename={0}", helper.GetLocalFilePath(dbFilename));

            optionsBuilder.UseSqlite(connection);
        }
    }
}
