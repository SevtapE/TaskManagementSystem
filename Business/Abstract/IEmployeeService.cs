using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        Employee GetById(int id);
        List<Employee> GetAll();
        List<Employee> GetByCompany(int id);
        void Add(Employee entity);
        void Update(Employee entity);
        void Delete(Employee entity);
    }
}
