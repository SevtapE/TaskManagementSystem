using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IClarificationService
    {
        Clarification GetById(int id);
        List<Clarification> GetAll();
      
        List<Clarification> GetByTaskId(int taskId);

        void Add(Clarification entity);
        void Update(Clarification entity);
        void Delete(Clarification entity);
    }
}
