using Core.Core.Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Clarification:IEntity
    {
        public Clarification()
        {

        }

        public Clarification(int id, string title, string content, DateTime creationDate, int? taskId, int personId) : this()
        {
            Id = id;
            Title = title;
            Content = content;
            CreationDate = creationDate;
            TaskId = taskId;
            PersonId = personId;
       
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }

        public int? TaskId { get; set; }//clarification'lar task a yazılıyor
        public int PersonId { get; set; }//clarification'ın yazarı

        public virtual Task Task { get; set; }
        public virtual Person Person { get; set; }


    }
}
