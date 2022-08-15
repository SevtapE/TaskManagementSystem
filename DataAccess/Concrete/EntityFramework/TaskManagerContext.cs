using Core.Core.Security.Entities;
using Entities.Concrete;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Task = Entities.Concrete.Task;


namespace DataAccess.Concrete.EntityFramework
{
    public class TaskManagerContext : DbContext
    {

        //protected IConfiguration Configuration { get; set; }
        //public TaskManagerContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        //{
        //    Configuration = configuration;
        //}


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TaskManagerProjectDB;Trusted_Connection=true");
        //}


        public DbSet<Admin> Admins { get; set; }
        public DbSet<Clarification> Clarifications { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<TaskWorker> Assignments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

      



           
                modelBuilder.Entity<UserOperationClaim>().ToTable("UserOperationClaims").HasKey(k => k.Id);
                modelBuilder.Entity<UserOperationClaim>().Property(p => p.Id).HasColumnName("Id");
                modelBuilder.Entity<UserOperationClaim>().Property(p => p.UserId).HasColumnName("UserId");
                modelBuilder.Entity<UserOperationClaim>().Property(p => p.OperationClaimId).HasColumnName("OperationClaimId");


                modelBuilder.Entity<User>().ToTable("Users").HasKey(k => k.Id);
                modelBuilder.Entity<User>().Property(p => p.Id).HasColumnName("Id");
                modelBuilder.Entity<User>().Property(p => p.FirstName).HasColumnName("FirstName");
                modelBuilder.Entity<User>().Property(p => p.LastName).HasColumnName("LastName");
                modelBuilder.Entity<User>().Property(p => p.Email).HasColumnName("Email");
                modelBuilder.Entity<User>().Property(p => p.PasswordHash).HasColumnName("PasswordHash");
                modelBuilder.Entity<User>().Property(p => p.PasswordSalt).HasColumnName("PasswordSalt");
                modelBuilder.Entity<User>().Property(p => p.Status).HasColumnName("Status");


                modelBuilder.Entity<OperationClaim>().ToTable("OperationClaims").HasKey(k => k.Id);
                modelBuilder.Entity<OperationClaim>().Property(p => p.Id).HasColumnName("Id");
                modelBuilder.Entity<OperationClaim>().Property(p => p.Name).HasColumnName("Name");


           

           
                modelBuilder.Entity<Admin>().ToTable("Admins");
                modelBuilder.Entity<Admin>().Property(a => a.AdminDescription).HasColumnName("AdminDescription");

           
          
                modelBuilder.Entity<Clarification>().ToTable("Clarifications").HasKey(c => c.Id);
                modelBuilder.Entity<Clarification>().Property(c => c.Title).HasColumnName("Title");
                modelBuilder.Entity<Clarification>().Property(c => c.Content).HasColumnName("Content");
                modelBuilder.Entity<Clarification>().Property(c => c.CreationDate).HasColumnName("CreationDate");
                modelBuilder.Entity<Clarification>().Property(c => c.TaskId).HasColumnName("TaskId");
                modelBuilder.Entity<Clarification>().Property(c => c.PersonId).HasColumnName("PersonId");
                //modelBuilder.Entity<Clarification>().HasOne(c => c.Task);
                //modelBuilder.Entity<Clarification>().HasOne(c => c.Person);


                modelBuilder.Entity<TaskWorker>().ToTable("TaskWorkers").HasKey(c => c.Id);
                modelBuilder.Entity<TaskWorker>().Property(c => c.TaskId).HasColumnName("TaskId");
                modelBuilder.Entity<TaskWorker>().Property(c => c.WorkerId).HasColumnName("WorkerId");



          
          
                modelBuilder.Entity<Company>().ToTable("Companies").HasKey(c => c.CompanyId);
                modelBuilder.Entity<Company>().Property(p => p.CompanyName).HasColumnName("CompanyName");
                modelBuilder.Entity<Company>().HasMany(c => c.Employees);



        
         
                modelBuilder.Entity<Document>().ToTable("Documents").HasKey(c => c.Id);
                modelBuilder.Entity<Document>().Property(p => p.Name).HasColumnName("Name");
                modelBuilder.Entity<Document>().Property(p => p.Link).HasColumnName("Link");
                modelBuilder.Entity<Document>().Property(p => p.TaskId).HasColumnName("TaskId");
               //modelBuilder.Entity<Document>().HasOne(p => p.Task);




        
           
                modelBuilder.Entity<Employee>().ToTable("Employees");

                modelBuilder.Entity<Employee>().Property(p => p.EmployeeRegistrationNumber).HasColumnName("EmployeeRegistrationNumber");
                modelBuilder.Entity<Employee>().Property(p => p.CompanyId).HasColumnName("CompanyId");
                //modelBuilder.Entity<Employee>().HasOne(p => p.Company);

            

            
                modelBuilder.Entity<Manager>().ToTable("Managers");
                modelBuilder.Entity<Manager>().Property(p => p.Title).HasColumnName("Title");
                modelBuilder.Entity<Manager>().HasMany(p => p.Workers);

           
          
                modelBuilder.Entity<Person>().ToTable("Persons").HasKey(k => k.Id);
                modelBuilder.Entity<Person>().Property(p => p.UserId).HasColumnName("UserId");
                //modelBuilder.Entity<Person>().HasOne(c => c.User);

            

           
                modelBuilder.Entity<Task>().ToTable("Tasks").HasKey(k => k.Id);
                modelBuilder.Entity<Task>().Property(p => p.Title).HasColumnName("Title");
                modelBuilder.Entity<Task>().Property(p => p.Content).HasColumnName("Content");
                modelBuilder.Entity<Task>().Property(p => p.StartDate).HasColumnName("StartDate");
                modelBuilder.Entity<Task>().Property(p => p.EndDate).HasColumnName("EndDate");
                modelBuilder.Entity<Task>().Property(p => p.Deadline).HasColumnName("Deadline");
                modelBuilder.Entity<Task>().Property(p => p.CreationDate).HasColumnName("CreationDate");
                modelBuilder.Entity<Task>().Property(p => p.Urgent).HasColumnName("Urgent");
                modelBuilder.Entity<Task>().Property(p => p.Important).HasColumnName("Important");
                modelBuilder.Entity<Task>().Property(p => p.TaskState).HasColumnName("TaskState");
                modelBuilder.Entity<Task>().Property(p => p.CompanyId).HasColumnName("CompanyId");
                modelBuilder.Entity<Task>().Property(p => p.PersonId).HasColumnName("PersonId");
                //modelBuilder.Entity<Task>().HasOne(p => p.Company);
                //modelBuilder.Entity<Task>().HasOne(p => p.Person);
                modelBuilder.Entity<Task>().HasMany(p => p.Clarifications);
                modelBuilder.Entity<Task>().HasMany(p => p.Documents);


           

           
                modelBuilder.Entity<Worker>().ToTable("Workers");
                modelBuilder.Entity<Worker>().Property(p => p.ManagerId).HasColumnName("ManagerId");
                //modelBuilder.Entity<Worker>().HasOne(p => p.Manager);


        }

    }
}
