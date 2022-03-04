using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class Franchise
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        public string Name { get; set; }


        [MaxLength(1200)]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();

    }
}
