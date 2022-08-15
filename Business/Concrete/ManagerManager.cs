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
    public class ManagerManager : IManagerService
    {
        IManagerDal _managerDal;

        public ManagerManager(IManagerDal adminDal)
        {
            _managerDal = adminDal;
        }

        public void Add(Manager entity)
        {
            _managerDal.Add(entity);   
        }

        public void Delete(Manager entity)
        {
            _managerDal.Delete(entity);
        }

        public List<Manager> GetAll()
        {
           return _managerDal.GetAll();
        }

        public List<Manager> GetAllByCompany(int id)
        {
            return _managerDal.GetAll(x=>x.CompanyId==id);

        }

        public Manager GetById(int id)
        {
            return _managerDal.Get(x=>x.Id == id);
        }

        public void Update(Manager entity)
        {
            _managerDal.Update(entity);
        }
    }
}
