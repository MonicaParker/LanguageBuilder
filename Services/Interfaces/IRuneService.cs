using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IRuneService
    {
        Domain.Rune Get(int id);
        System.Collections.Generic.IList<Domain.Rune> GetList();
        void Create(Domain.Rune rune);
        void Delete(int id);
        void Edit(Domain.Rune rune);
        void LockRune(int id);
    }
}
