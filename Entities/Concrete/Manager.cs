using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Manager:Employee
    {
        public Manager()
        {
            Workers = new HashSet<Worker>();

        }

        public Manager(int id, int userId, string employeeRegistrationNumber, int companyId,string title) : this()
        {
            Id = Id;
            UserId = userId;
            EmployeeRegistrationNumber = employeeRegistrationNumber;
            CompanyId = companyId;
            Title = title;
        }

        public string Title { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}
