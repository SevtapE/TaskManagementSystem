using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Worker:Employee
    {
        public Worker()
        {
           
        }

        public Worker(int id, int userId, string employeeRegistrationNumber, int companyId,int? managerId) : this()
        {
            Id = Id;
            UserId = userId;
            EmployeeRegistrationNumber = employeeRegistrationNumber;
            CompanyId = companyId;
            ManagerId = managerId;
        }

         public int? ManagerId { get; set; }
        public virtual Manager Manager { get; set; }

       
    }
}
