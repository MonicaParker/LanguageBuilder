using Domain;
using Runes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Seeder
    {
        public static void Seed(ApplicationDbContext db, bool runes = false)
        {
            if (runes) SeedRunes(db);
        }

        private static void SeedRunes(ApplicationDbContext db)
        {
            var runes = new List<Rune> 
            {
                new Rune {
                    Id = 1,
                    Name = "Rau",
                    Character = "ra",
                    Short = "form",
                    Meaning = "An outline or distinction.",
                    Extras = "Cardinal",
                    Cardinal = true
                 
                },
                new Rune {
                    Id = 2,
                    Name = "Gal",
                    Character = "g",
                    Short = "wave",
                    Meaning = "A momentum or crescendo.",
                    Extras = "Cardinal",
                    Cardinal = true
                   
                 
                },
                new Rune {
                    Id = 3,
                    Name = "Ea",
                    Character = "e",
                    Short = "gale",
                    Meaning = "A force or power.",
                    Extras = "Cardinal",
                    Cardinal = true
                  
                },
                new Rune {
                    Id = 4,
                    Name = "Rur",
                    Character = "ru",
                    Short = "blaze",
                    Meaning = "Energy or vitality.",
                    Extras = "Cardinal",
                    Cardinal = true
                   
                },
                 new Rune {
                    Id = 5,
                    Name = "At",
                    Character = "a",
                    Short = "stop",
                    Meaning = "A cease or completion.",
                    Extras = "Cardinal",
                    Cardinal = true
                    
                },
                new Rune {
                    Id = 6,
                    Name = "Bor",
                    Character = "b",
                    Short = "trunk",
                    Meaning = "Strength or experience.",
                    Extras = "Cardinal",
                    Cardinal = true
                },
                new Rune {
                    Id = 7,
                    Name = "Hrul",
                    Character = "h",
                    Short = "flesh",
                    Meaning = "Substance or material.",
                    Extras = "Cardinal",
                    Cardinal = true
                },
                new Rune {
                    Id = 8,
                    Name = "Sir",
                    Character = "s",
                    Short = "ray",
                    Meaning = "A direction or refinement.",
                    Extras = "Cardinal",
                    Cardinal = true
                },
                 new Rune {
                    Id = 9,
                    Name = "Wi",
                    Character = "w",
                    Short = "shallow",
                    Meaning = "A flatness or lack of complexity.",
                    Extras = "Not necessarily an adjective.",
                    Cardinal = false
                },
                new Rune {
                    Id = 10,
                    Name = "Iy",
                    Character = "i",
                    Short = "road",
                    Meaning = "Established tradition or habit.",
                    Extras = "Behavior, maybe.",
                    Cardinal = false
                },
                new Rune {
                    Id = 11,
                    Name = "Gyo",
                    Character = "gy",
                    Short = "far",
                    Meaning = "Immeasurable distance.",
                    Extras = "Doesn't have to be immeasurable. Modify to specify.",
                    Cardinal = false
                }

                //Extras are generating in the table as null, for some reason. 
            };
            foreach (var rune in runes)
            {
                if (!db.Runes.Any(r => r.Id == rune.Id)) db.Runes.Add(rune);
            }
            db.SaveChanges();

        }
    }
}
