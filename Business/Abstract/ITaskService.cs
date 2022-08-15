using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Entities.Concrete.Task;

namespace Business.Abstract
{
    public interface ITaskService
    {
        Task GetById(int id);
        List<Task> GetAll();

        void Add(Task entity);
        void Update(Task entity);
        void Delete(Task entity);
    }
}
