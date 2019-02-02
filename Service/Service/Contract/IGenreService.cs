using Model.DatabaseCore.Entity;
using Service.ApplicationService.Vo;
using System.Collections.Generic;

namespace Service.ApplicationService.Contract
{
    public interface IGenreService
    {
        IEnumerable<GenreVo> findAllGenre();
        void Insert(GenreVo genre);
        void Save();
        GenreVo FindById(int id);
        void Update(GenreVo genre);
        void Delete(GenreVo genre);
    }
}