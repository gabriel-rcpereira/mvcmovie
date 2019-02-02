using System;
using System.Collections.Generic;

namespace Model.DatabaseCore.Entity
{
    public interface IMovieRepository : IDisposable
    {
        IEnumerable<Movie> FindAll();
        Movie FindById(int id);
        void Delete(Movie movie);
        void Insert(Movie movie);
        void Update(Movie movie);
        void Save();
    }
}
