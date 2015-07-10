using Domain;
using Infrastructure;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RuneService : IRuneService
    {
        private ApplicationDbContext _dc;
        public RuneService()
        {
            _dc = new ApplicationDbContext();
        }
        

        public Rune Get(int id)
        {
            var rune = (from r in _dc.Runes 
                       where r.Id == id 
                       select r).FirstOrDefault();
            return rune;
        }

        public IList<Rune> GetList()
        {
            return _dc.Runes.ToList();
        }

        public void Create(Rune rune)
        {
            //Test if I still need to ensure unique entries when Name and not Id is Key.
                        
            _dc.Runes.Add(rune);
            _dc.SaveChanges();
        }

        public void Edit(Rune rune)
        {
            var original = _dc.Runes.Find(rune.Name);
            if (original != null)
            {
                original.Name = rune.Name;
                original.Character = rune.Character;
                original.Short = rune.Short;
                original.Meaning = rune.Meaning;
                original.Extras = rune.Extras;
                original.Cardinal = rune.Cardinal;

                _dc.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var original = _dc.Runes.Find(id);
            _dc.Runes.Remove(original);
            _dc.SaveChanges();
        }

        public void LockRune(int id)
        {
            var current = _dc.Runes.Find(id);
            current.Locked = true;
            _dc.SaveChanges();
        }
    
    }
}
