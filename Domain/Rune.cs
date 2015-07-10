using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Rune
    {
        public int Id { get; set; }
        //Transliterated name. Consider making this the key.
        public string Name { get; set; }
        //Uploaded image. Must be uniform height and width.
        public string Character { get; set; }
        public string Short { get; set; }
        //Description
        public string Meaning { get; set; }
        public string Extras { get; set; }
        //For sorting
        public bool Cardinal { get; set; }
        public bool Locked { get; set; }
    }
}
