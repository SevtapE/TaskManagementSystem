using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWorkerService
    {
        Worker GetById(int id);
        List<Worker> GetAll();
        void Add(Worker entity);
        void Update(Worker entity);
        void Delete(Worker entity);
    }
}
