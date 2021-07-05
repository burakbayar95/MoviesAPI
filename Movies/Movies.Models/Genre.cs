using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Models
{
    public class Genre : IEntity // tür

    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public int Name { get; set; }

        public virtual IList<Movie> Movies { get; set; }




    }
}
