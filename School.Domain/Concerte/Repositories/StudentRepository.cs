using School.Domain.Abstract.Repositories;
using School.Domain.DAL;
using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Concerte.Repositories
{
   public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(SchoolDbContext Context) 
            : base(Context)
        {

        }
    }
}
