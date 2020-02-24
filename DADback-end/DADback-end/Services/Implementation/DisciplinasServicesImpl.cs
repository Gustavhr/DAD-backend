using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DADback_end.Model;

namespace DADback_end.Services.Implementation
{
    public class DisciplinasServicesImpl : IDisciplinasService
    {
        public Disciplinas Create(Disciplinas disciplina)
        {
            return disciplina;
        }

        public void Delete(long id)
        {
            
        }

        public List<Disciplinas> FindAll()
        {
            List<Disciplinas> disciplinas = new List<Disciplinas>();

            Disciplinas disc = Findbyid(1);

            disciplinas.Add(disc);

            return disciplinas;
        }

        public Disciplinas Findbyid(long id)
        {
            return new Disciplinas {
                id = 1,
                nome = "AED"
            };
        }

        public Disciplinas Update(Disciplinas disciplina)
        {
            return disciplina;
        }
    }
}
