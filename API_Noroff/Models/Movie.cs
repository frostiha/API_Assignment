using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(140)]
        public string Title { get; set; }


        [MaxLength(40)]
        public string Genre { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [MaxLength(120)]
        public string Director { get; set; }

        [MaxLength(200)]
        public string Picture { get; set; }

        [MaxLength(200)]
        public string Trailer { get; set; }

        // many to many
        public List<Character> Characters { get; set; } = new List<Character>();

        // one to many
        public Franchise Franchise { get; set; }

    }
}
