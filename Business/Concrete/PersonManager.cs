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
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public void Add(Person entity)
        {
            _personDal.Add(entity);   
        }

        public void Delete(Person entity)
        {
            _personDal.Delete(entity);
        }

        public List<Person> GetAll()
        {
           return _personDal.GetAll();
        }

        public Person GetById(int id)
        {
            return _personDal.Get(x=>x.Id == id);
        }
  
        public void Update(Person entity)
        {
            _personDal.Update(entity);
        }
    }
}
