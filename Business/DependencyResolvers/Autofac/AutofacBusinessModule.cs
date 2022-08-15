using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Core.Security.Jwt;
using Core.Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    class AutofacBusinessModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
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

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
