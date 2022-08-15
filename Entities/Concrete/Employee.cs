using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Employee : Person
    {
        public Employee()
        {

        }
        public Employee(int id, int userId,string employeeRegistrationNumber, int companyId) : this()
        {
            Id = Id;
            UserId = userId;
            EmployeeRegistrationNumber = employeeRegistrationNumber;
            CompanyId = companyId;
        }

        public string EmployeeRegistrationNumber { get; set; } //E3453 9384UH gibi bir data

        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
