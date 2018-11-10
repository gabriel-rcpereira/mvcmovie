using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}
