using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MvcMovie.Models
{
    public class Genre
    {
        public int ID { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        public IList<Movie> Movies { get; set; }
    }
}
