using Business.Abstract;
using Business.Concrete;
using Core.Core.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers
{

    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            

           // services.AddDbContext<TaskManagerContext>(options =>
           //options.UseSqlServer(configuration.GetConnectionString("TaskManagerConnectionString")));

            services.AddScoped<IAdminService, AdminManager>();
            services.AddScoped<IAdminDal, EfAdminDal>();

            services.AddScoped<IAuthService, AuthManager>();

            services.AddScoped<ITokenHelper, JwtHelper>();



            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, EfUserDal>();

            services.AddScoped<ITaskWorkerService, TaskWorkerManager>();
            services.AddScoped<ITaskWorkerDal, EfTaskWorkerDal>();

            services.AddScoped<IClarificationService, ClarificationManager>();
            services.AddScoped<IClarificationDal, EfClarificationDal>();

            services.AddScoped<ICompanyService, CompanyManager>();
            services.AddScoped<ICompanyDal, EfCompanyDal>();

            services.AddScoped<IDocumentService, DocumentManager>();
            services.AddScoped<IDocumentDal, EfDocumentDal>();

            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IEmployeeDal, EfEmployeeDal>();

            services.AddScoped<IManagerService, ManagerManager>();
            services.AddScoped<IManagerDal, EfManagerDal>();

            services.AddScoped<IPersonService, PersonManager>();
            services.AddScoped<IPersonDal, EfPersonDal>();

            services.AddScoped<ITaskService, TaskManager>();
            services.AddScoped<ITaskDal, EfTaskDal>();

            services.AddScoped<IWorkerService, WorkerManager>();
            services.AddScoped<IWorkerDal, EfWorkerDal>();


            return services;
        }
    }
}