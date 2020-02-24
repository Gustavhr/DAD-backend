using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DADback_end.Model;
using DADback_end.Model.Context;

namespace DADback_end.Services.Implementation
{
    public class DisciplinasServicesImpl : IDisciplinasService
    {
        private MySqlContext _context;

        public DisciplinasServicesImpl(MySqlContext context)
        {
            _context = context;
        }


        public Disciplinas Create(Disciplinas disciplina)
        {

            try
            {
                _context.Add(disciplina);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return disciplina;
        }

        public void Delete(long id)
        {

            var result = _context.disciplinas.SingleOrDefault(p => p.id.Equals(id));

            try
            {
                if (result != null) _context.disciplinas.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Disciplinas> FindAll()
        {
            return _context.disciplinas.ToList();
        }

        public Disciplinas Findbyid(long id)
        {
            return _context.disciplinas.SingleOrDefault(p => p.id.Equals(id));
        }

        public Disciplinas Update(Disciplinas disciplina)
        {
            if (!Exist(disciplina.id)) return new Disciplinas();

            var result = _context.disciplinas.SingleOrDefault(p => p.id.Equals(disciplina.id));
          
            try
            {
                _context.Entry(result).CurrentValues.SetValues(disciplina);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return disciplina;
        }

        private bool Exist(long ? id)
        {
            return _context.disciplinas.Any(p => p.id.Equals(id));
        }
    }
}
