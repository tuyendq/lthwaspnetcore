using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie.Mvc.Models;

    public class MovieMvcContext : DbContext
    {
        public MovieMvcContext (DbContextOptions<MovieMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Movie.Mvc.Models.Movie> Movie { get; set; } = default!;
    }
