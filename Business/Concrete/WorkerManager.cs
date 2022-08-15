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
    public class WorkerManager : IWorkerService
    {
        IWorkerDal _workerDal;

        public WorkerManager(IWorkerDal adminDal)
        {
            _workerDal = adminDal;
        }

        public void Add(Worker entity)
        {
            _workerDal.Add(entity);   
        }

        public void Delete(Worker entity)
        {
            _workerDal.Delete(entity);
        }

        public List<Worker> GetAll()
        {
           return _workerDal.GetAll();
        }

        public Worker GetById(int id)
        {
            return _workerDal.Get(x=>x.Id == id);
        }

        public void Update(Worker entity)
        {
            _workerDal.Update(entity);
        }
    }
}
