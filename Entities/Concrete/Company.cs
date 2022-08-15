using Core.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Company : IEntity
    {
        public Company()
        {
            Employees=new HashSet<Employee>();
        }

        public Company(int companyId, string companyName) : this()
        {
            CompanyId = companyId;
            CompanyName = companyName;
        }

        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
