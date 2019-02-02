using Microsoft.EntityFrameworkCore;
using Model.DatabaseCore.Entity;
using System;

namespace Model.DatabaseCore
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
