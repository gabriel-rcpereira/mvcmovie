using AutoMapper;
using Model.DatabaseCore.Entity;
using Service.ApplicationService.Contract;
using Service.ApplicationService.Vo;
using System;
using System.Collections.Generic;

namespace Service.ApplicationService
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public GenreService(IGenreRepository genreRepository,
            IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public void Delete(GenreVo genreVo)
        {
            _genreRepository.Delete(_mapper.Map<GenreVo, Genre>(genreVo));
        }

        public IEnumerable<GenreVo> findAllGenre()
        {
            var genres = _genreRepository.FindAll();
            List<GenreVo> genresVo = new List<GenreVo>();

            new List<Genre>(genres).ForEach(genre =>
            {
                genresVo.Add(_mapper.Map<Genre, GenreVo>(genre));
            });

            return genresVo;
        }

        public GenreVo FindById(int id)
        {
            return _mapper.Map<Genre, GenreVo>(_genreRepository.FindById(id));
        }

        public void Insert(GenreVo genreVo)
        {
            _genreRepository.Insert(_mapper.Map<GenreVo, Genre>(genreVo));
        }

        public void Save()
        {
            _genreRepository.Save();
        }

        public void Update(GenreVo genreVo)
        {
            _genreRepository.Update(_mapper.Map<GenreVo, Genre>(genreVo));
        }
    }
}
