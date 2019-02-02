using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieEditViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<SelectListItem> Genres { get; set; }
        public int GenreIdSelected { get; set; }
    }
}
