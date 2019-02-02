using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.DatabaseCore.Entity
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DatabaseContext _databaseContext;

        public MovieRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Delete(Movie movie)
        {
            _databaseContext.Movies.Remove(movie);
        }

        public IEnumerable<Movie> FindAll()
        {
            IQueryable<Movie> movies = from m in _databaseContext.Movies
                                       select m;

            return movies.ToList();
        }

        public Movie FindById(int id)
        {
            IQueryable<Movie> movies = from m in _databaseContext.Movies
                                       select m;

            return movies.First();
        }

        public void Insert(Movie movie)
        {
            _databaseContext.Movies.Add(movie);
        }

        public void Save()
        {
            _databaseContext.SaveChanges();
        }

        public void Update(Movie movie)
        {
            _databaseContext.Movies.Update(movie);
        }
    }
}
