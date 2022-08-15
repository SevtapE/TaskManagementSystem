using Core.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TaskWorker:IEntity
    {
        public TaskWorker()
        {

        }

        public TaskWorker(int ıd, int taskId, int workerId)
        {
            Id = ıd;
            TaskId = taskId;
            WorkerId = workerId;
        }

        public int Id { get; set; }
        public int TaskId { get; set; }
        public int WorkerId { get; set; }

        public virtual Task Task { get; set; }
        public virtual Worker Worker { get; set; }


    }
}
