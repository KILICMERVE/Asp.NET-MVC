using Autofac;
using Autofac.Integration.Mvc;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AspNetMvcUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {


            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<TaskManager>().As<ITaskService>();
            builder.RegisterType<EfTaskDal>().As<ITaskDal>();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
