using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task = Entities.Concrete.Task;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        ITaskDal _taskDal;

        public TaskManager(ITaskDal adminDal)
        {
            _taskDal = adminDal;
        }

        public void Add(Task entity)
        {
            _taskDal.Add(entity);   
        }

        public void Delete(Task entity)
        {
            _taskDal.Delete(entity);
        }

        public List<Task> GetAll()
        {
           return _taskDal.GetAll();
        }

        public Task GetById(int id)
        {
            return _taskDal.Get(x=>x.Id == id);
        }

        public void Update(Task entity)
        {
            _taskDal.Update(entity);
        }
    }
}
