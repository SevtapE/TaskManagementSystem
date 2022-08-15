using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonService
    {
        Person GetById(int id);
      
        List<Person> GetAll();
        void Add(Person entity);
        void Update(Person entity);
        void Delete(Person entity);
    }
}
