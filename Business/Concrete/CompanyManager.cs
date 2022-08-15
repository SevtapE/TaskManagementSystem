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
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal adminDal)
        {
            _companyDal = adminDal;
        }

        public void Add(Company entity)
        {
            _companyDal.Add(entity);   
        }

        public void Delete(Company entity)
        {
            _companyDal.Delete(entity);
        }

        public List<Company> GetAll()
        {
           return _companyDal.GetAll();
        }

        public Company GetById(int id)
        {
            return _companyDal.Get(x=>x.CompanyId == id);
        }

        public void Update(Company entity)
        {
            _companyDal.Update(entity);
        }
    }
}
