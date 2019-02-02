using Model.DatabaseCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.DatabaseCore.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly DatabaseContext _databaseContext;

        public GenreRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _databaseContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Delete(Genre genre)
        {
            _databaseContext.Genres.Remove(genre);
        }

        public IEnumerable<Genre> FindAll()
        { 
            IQueryable<Genre> genre = (from g in _databaseContext.Genres
                select g);

            return genre.ToList();
        }

        public Genre FindById(int id)
        {
            return _databaseContext.Genres.Find(id);
        }

        public void Insert(Genre genre) =>
            _databaseContext.Genres.Add(genre);

        public void Save() =>
            _databaseContext.SaveChanges();

        public void Update(Genre genre) => 
            _databaseContext.Update(genre);
    }
}
