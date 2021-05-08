using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Data {get; set; }
        public string Task { get; set; }

        public bool Checked { get; set; }
    }
}
