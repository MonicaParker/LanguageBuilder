using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    class Word
    {
        public int Id { get; set; }
        public List<Rune> Cluster { get; set; }

    }
}
