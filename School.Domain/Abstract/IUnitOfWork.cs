using School.Domain.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Abstract
{
   public interface IUnitOfWork : IDisposable
    {
        IStudentRepository students { get; }

        int Complete();
    }
}
