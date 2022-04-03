using Business.Abstract;
using Business.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ITaskService>().To<TaskManager>().InSingletonScope();
        }
    }
}
