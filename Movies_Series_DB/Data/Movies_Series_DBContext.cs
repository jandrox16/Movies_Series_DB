using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies_Series_DB.Models;

namespace Movies_Series_DB.Data
{
    public class Movies_Series_DBContext : DbContext
    {
        public Movies_Series_DBContext(DbContextOptions<Movies_Series_DBContext> options)
            : base(options)
        {
        }

        public DbSet<Movies_Series_DB.Models.Pelicula> Pelicula { get; set; }

        public DbSet<Movies_Series_DB.Models.Casting> Casting { get; set; }
    }
}
