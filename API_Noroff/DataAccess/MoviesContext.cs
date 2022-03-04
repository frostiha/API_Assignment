using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDataAccessLibrary.DataAccess
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions options) : base(options) { }

        // Creates the following tables.
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Franchise> Franchises { get; set; }

    }
}
