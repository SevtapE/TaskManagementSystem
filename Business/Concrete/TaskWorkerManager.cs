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
    public class TaskWorkerManager : ITaskWorkerService
    {
        ITaskWorkerDal _taskWorkerDal;

        public TaskWorkerManager(ITaskWorkerDal taskWorkerDal)
        {
            _taskWorkerDal = taskWorkerDal;
        }

        public void Add(TaskWorker entity)
        {
            _taskWorkerDal.Add(entity);   
        }

        public void Delete(TaskWorker entity)
        {
            _taskWorkerDal.Delete(entity);
        }

        public List<TaskWorker> GetAll()
        {
           return _taskWorkerDal.GetAll();
        }

        public List<TaskWorker> GetByWorkerUserId(int userId)
        {
            //get tasks with 
            return _taskWorkerDal.GetAll(filter: (x =>( x.Worker.UserId == userId)|| (x.Task.Person.UserId==userId)));

        }

        //Urgent && Important
        public List<TaskWorker> GetByWorkerUserIdDo(int userId) 
        {
            return _taskWorkerDal.GetAll(filter: (x => ((x.Worker.UserId == userId) || (x.Task.Person.UserId == userId)) &&((x.Task.Urgent)&&x.Task.Important)));

        }

        //Not Urgent && Important
        public List<TaskWorker> GetByWorkerUserIdSchedule(int userId)
        {
            return _taskWorkerDal.GetAll(filter: (x => ((x.Worker.UserId == userId) || (x.Task.Person.UserId == userId)) && ((x.Task.Urgent==false) && x.Task.Important)));

        }

        //Urgent && Not Important
        public List<TaskWorker> GetByWorkerUserIdLater(int userId)
        {
            return _taskWorkerDal.GetAll(filter: (x => ((x.Worker.UserId == userId) || (x.Task.Person.UserId == userId)) && ((x.Task.Urgent) && x.Task.Important==false)));

        }

        //Not Urgent && Not Important
        public List<TaskWorker> GetByWorkerUserIdDelegate(int userId)
        {
            return _taskWorkerDal.GetAll(filter: (x => ((x.Worker.UserId == userId) || (x.Task.Person.UserId == userId)) && ((x.Task.Urgent==false) && x.Task.Important==false)));

        }

        public TaskWorker GetById(int id)
        {
            return _taskWorkerDal.Get(x=>x.Id == id);
        }

        public void Update(TaskWorker entity)
        {
            _taskWorkerDal.Update(entity);
        }
    }
}
