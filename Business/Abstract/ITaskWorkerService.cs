using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITaskWorkerService
    {
        TaskWorker GetById(int id);
        List<TaskWorker> GetAll();
        List<TaskWorker> GetByWorkerUserId(int userId);

        List<TaskWorker> GetByWorkerUserIdDo(int userId); //Urgent && Important
        List<TaskWorker> GetByWorkerUserIdSchedule(int userId);
        List<TaskWorker> GetByWorkerUserIdLater(int userId);
        List<TaskWorker> GetByWorkerUserIdDelegate(int userId);




        void Add(TaskWorker entity);
        void Update(TaskWorker entity);
        void Delete(TaskWorker entity);
    }
}
