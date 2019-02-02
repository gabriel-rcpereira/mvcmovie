using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Model.DatabaseCore.Entity
{
    public interface IGenreRepository : IDisposable
    {
        IEnumerable<Genre> FindAll();
        Genre FindById(int id);
        void Delete(Genre genre);
        void Update(Genre genre);
        void Insert(Genre genre);
        void Save();
    }
}
