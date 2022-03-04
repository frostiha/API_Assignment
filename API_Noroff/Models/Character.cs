using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class Character
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string FullName { get; set; }

        [MaxLength(50)]
        public string Alias { get; set; }


        [MaxLength(20)]
        public string Gender { get; set; }


        [MaxLength(200)]
        public string Picture { get; set; }

        public List<Movie> Movies { get; set; } = new List<Movie>();

    }
}
