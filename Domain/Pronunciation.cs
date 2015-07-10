using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Pronunciation
    {
        public int Id { get; set; }
        //One for each "letter"
        public ValidChars Char { get; set; }
        //An audio element
        public string Example { get; set; }
        public string Exception { get; set; }
        public string Output { get; set; }
    }
}
