using School.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Domain.Abstract.Repositories;
using School.Domain.DAL;
using School.Domain.Concerte.Repositories;

namespace School.Domain.Concerte
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolDbContext _context;

        public UnitOfWork(SchoolDbContext context)
        {
            _context = context;
            students = new StudentRepository(context);
        }
        public IStudentRepository students { get; private set; }

        public int Complete()
        {
            
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
