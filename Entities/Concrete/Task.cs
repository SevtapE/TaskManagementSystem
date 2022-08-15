using Core.Core.Entities.Abstract;
using Entities.Concrete;
using Entities.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Task:IEntity
    {
        public Task()
        {

        }

        public Task(int id, string title, string content,int? companyId, DateTime startDate, DateTime endDate, DateTime deadline, DateTime creationDate, bool urgent, bool important, TaskState taskState, int? personId) : this()
        {
            Id = id;
            Title = title;
            Content = content;
            StartDate = startDate;
            EndDate = endDate;
            Deadline = deadline;
            CreationDate = creationDate;
            Urgent = urgent;
            Important = important;
            TaskState = taskState;
            PersonId = personId;
            CompanyId = companyId;
        }
        #region 
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
      
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime CreationDate { get; set; }
   
        public bool Urgent { get; set; }
        public bool Important { get; set; }

        public TaskState TaskState { get; set; }

        public int? CompanyId { get; set; }
        public int? PersonId { get; set; }//Oluşturan kişi task'ın sahibi kimin oluşturduğunu bileceğiz.

        #endregion
       
        public virtual Person Person { get; set; } //Task'i oluşturan kişisi
        public virtual Company Company { get; set; }
        public virtual ICollection<Clarification> Clarifications { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
       



    }
}
