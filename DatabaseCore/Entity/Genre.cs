using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Model.DatabaseCore.Entity
{
    public class Genre
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string Name { get; set; }

        public IList<Movie> Movies { get; set; }
    }
}
