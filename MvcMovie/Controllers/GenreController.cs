using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using Service.ApplicationService.Contract;
using Service.ApplicationService.Vo;

namespace MvcMovie.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService _genreService;

        private readonly MvcMovieContext _context;

        public GenreController(MvcMovieContext context,
            IGenreService genreService)
        {
            _context = context;
            _genreService = genreService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_genreService.findAllGenre());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] GenreVo genreVo)
        {
            if (ModelState.IsValid)
            {
                _genreService.Insert(genreVo);
                _genreService.Save();
                
                return RedirectToAction(nameof(Index));
            }
            return View(genreVo);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue || id <= 0)
                return NotFound();

            var genreVo = _genreService.FindById(id.Value);
            if (genreVo == null)
                return NotFound();

            return View(genreVo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id", "Name")] GenreVo genreVo)
        {
            if (id <= 0)
                return NotFound();

            if (ModelState.IsValid)
            {
                _genreService.Update(genreVo);
                _genreService.Save();

                return RedirectToAction(nameof(Index));
            }
            return View(genreVo);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (!id.HasValue || id <= 0)
            {
                return NotFound();
            }

            var genreVo = _genreService.FindById(id.Value);
            if (genreVo == null)
            {
                return NotFound();
            }

            return View(genreVo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var genreVo = _genreService.FindById(id);
            _genreService.Delete(genreVo);
            _genreService.Save();

            return RedirectToAction(nameof(Index));
        }
    }
}