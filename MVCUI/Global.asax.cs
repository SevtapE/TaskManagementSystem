using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Integration.Mvc;
using Business.Abstract;
using Business.Concrete;
using Core.Core.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<AdminManager>().As<IAdminService>().SingleInstance();
            builder.RegisterType<EfAdminDal>().As<IAdminDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();


            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();


            builder.RegisterType<TaskWorkerManager>().As<ITaskWorkerService>().SingleInstance();
            builder.RegisterType<EfTaskWorkerDal>().As<ITaskWorkerDal>().SingleInstance();


            builder.RegisterType<ClarificationManager>().As<IClarificationService>().SingleInstance();
            builder.RegisterType<EfClarificationDal>().As<IClarificationDal>().SingleInstance();


            builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>().SingleInstance();



            builder.RegisterType<DocumentManager>().As<IDocumentService>().SingleInstance();
            builder.RegisterType<EfDocumentDal>().As<IDocumentDal>().SingleInstance();


            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().SingleInstance();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>().SingleInstance();


            builder.RegisterType<ManagerManager>().As<IManagerService>().SingleInstance();
            builder.RegisterType<EfManagerDal>().As<IManagerDal>().SingleInstance();



            builder.RegisterType<PersonManager>().As<IPersonService>().SingleInstance();
            builder.RegisterType<EfPersonDal>().As<IPersonDal>().SingleInstance();



            builder.RegisterType<TaskManager>().As<ITaskService>().SingleInstance();
            builder.RegisterType<EfTaskDal>().As<ITaskDal>().SingleInstance();



            builder.RegisterType<WorkerManager>().As<IWorkerService>().SingleInstance();
            builder.RegisterType<EfWorkerDal>().As<IWorkerDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterType<TaskManagerContext>().AsSelf().AsImplementedInterfaces().InstancePerDependency();

            //builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>().SingleInstance();


            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));



            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
