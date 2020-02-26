using DADback_end.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DADback_end.Services
{
    public interface IProfessorService
    {
        Professor Create(Professor disciplina);

        List<Professor> Create(List<Professor> disciplina);

        Professor Findbyid(int id);

        List<Professor> FindAll();

        Professor Update(Professor disciplina);

        void Delete(int id);
    }
}
