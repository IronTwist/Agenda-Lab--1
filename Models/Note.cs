using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public class Note
    {   
        public int Id { get; set; }

        [Required, MinLength(3)]
        public string Name { get; set; }

        [Required]
        public DateTime Data {get; set; }

        [Required, MaxLength(1024)]
        public string Task { get; set; }

        public bool Checked { get; set; }
    }
}
