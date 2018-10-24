using Ninject;
using School.Domain.Abstract;
using School.Domain.Concerte;
using School.Domain.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.WebUI.Infrastructure
{
    public class NinjectDepdenceyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDepdenceyResolver(IKernel KernelParam)
        {
            kernel = KernelParam;
            addBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        public void addBindings()
        {
            kernel.Bind<IUnitOfWork>()
                .To<UnitOfWork>()
                .WithConstructorArgument("context",
                new SchoolDbContext());
        }
    }
}