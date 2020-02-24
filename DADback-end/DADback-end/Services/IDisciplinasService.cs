using System;
using DADback_end.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DADback_end.Services.Implementation
{
    public interface IDisciplinasService
    {
        Disciplinas Create(Disciplinas disciplina);

        Disciplinas Findbyid(long id);

        List<Disciplinas> FindAll();

        Disciplinas Update(Disciplinas disciplina);

        void Delete(long id);

    }
}
