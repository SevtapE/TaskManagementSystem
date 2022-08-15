using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IManagerService
    {
        Manager GetById(int id);
        List<Manager> GetAll();
        List<Manager> GetAllByCompany(int id);
        void Add(Manager entity);
        void Update(Manager entity);
        void Delete(Manager entity);
    }
}
