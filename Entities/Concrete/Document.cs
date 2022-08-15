using Core.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Document:IEntity
    {
        public Document()
        {

        }

        public Document(int id, string name, string link, int taskId) : this()
        {
            Id = id;
            Name = name;
            Link = link;
            TaskId = taskId;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }
    }
}
