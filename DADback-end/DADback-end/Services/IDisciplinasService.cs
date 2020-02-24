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

        Disciplinas Findbyid(int id);

        List<Disciplinas> FindAll();

        Disciplinas Update(Disciplinas disciplina);

        void Delete(int id);

    }
}
