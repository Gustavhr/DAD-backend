using DADback_end.Model;
using DADback_end.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DADback_end.Services.Implementation
{
    public class ProfessorServicesImpl : IProfessorService
    { 
    private MySqlContext _context;

    public ProfessorServicesImpl(MySqlContext context)
    {
        _context = context;
    }


    public Professor Create(Professor prof)
    {

        try
        {
            _context.Add(prof);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return prof;
    }

        public List<Professor> Create(List<Professor> prof)
        {

            try
            {
                foreach (Professor item in prof)
                {
                    _context.Add(item);
                }
               
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return prof;
        }

        public void Delete(int id)
    {

        var result = _context.professor.SingleOrDefault(p => p.id.Equals(id));

        try
        {
            if (result != null) _context.professor.Remove(result);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }

    public List<Professor> FindAll()
    {
        return _context.professor.ToList();
    }

    public Professor Findbyid(int id)
    {
        return _context.professor.SingleOrDefault(p => p.id.Equals(id));
    }

    public Professor Update(Professor prof)
    {
        if (!Exist(prof.id)) return new Professor();

        var result = _context.professor.SingleOrDefault(p => p.id.Equals(prof.id));

        try
        {
            _context.Entry(result).CurrentValues.SetValues(prof);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return prof;
    }

    private bool Exist(int? id)
    {
        return _context.professor.Any(p => p.id.Equals(id));
    }
}
}
