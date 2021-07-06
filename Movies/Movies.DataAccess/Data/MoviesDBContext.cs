using Microsoft.EntityFrameworkCore;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.DataAccess.Data
{
  public class MoviesDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasOne(m => m.Genre).WithMany(g => g.Movies).HasForeignKey(m=>m.GenreId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
