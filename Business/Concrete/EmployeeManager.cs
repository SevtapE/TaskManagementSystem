using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal adminDal)
        {
            _employeeDal = adminDal;
        }

        public void Add(Employee entity)
        {
            _employeeDal.Add(entity);   
        }

        public void Delete(Employee entity)
        {
            _employeeDal.Delete(entity);
        }

        public List<Employee> GetAll()
        {
           return _employeeDal.GetAll();
        }

        public List<Employee> GetByCompany(int id)
        {
            return _employeeDal.GetAll(filter: (x => (x.CompanyId== id)));

        }
        public Employee GetById(int id)
        {
            return _employeeDal.Get(x=>x.Id == id);
        }

        public void Update(Employee entity)
        {
            _employeeDal.Update(entity);
        }
    }
}
