using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Models
{
    public class Movie : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Film adı boş olamaz")]
        public string Title { get; set; }
        public decimal? Price { get; set; }
        public string PosterPath { get; set; }

        public int? GenreId { get; set; } //fk

        //Navigation Property
        public virtual Genre Genre { get; set; }
        public virtual IList<MovieActor> Actors { get; set; }


    }
}
