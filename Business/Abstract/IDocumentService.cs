using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDocumentService
    {
        Document GetById(int id);
        List<Document> GetAll();
        void Add(Document entity);
        void Update(Document entity);
        void Delete(Document entity);
    }
}
