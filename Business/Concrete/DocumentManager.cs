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
    public class DocumentManager : IDocumentService
    {
        IDocumentDal _documentDal;

        public DocumentManager(IDocumentDal adminDal)
        {
            _documentDal = adminDal;
        }

        public void Add(Document entity)
        {
            _documentDal.Add(entity);   
        }

        public void Delete(Document entity)
        {
            _documentDal.Delete(entity);
        }

        public List<Document> GetAll()
        {
           return _documentDal.GetAll();
        }

        public Document GetById(int id)
        {
            return _documentDal.Get(x=>x.Id == id);
        }

        public void Update(Document entity)
        {
            _documentDal.Update(entity);
        }
    }
}
