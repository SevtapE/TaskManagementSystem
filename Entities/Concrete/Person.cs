using Core.Core.Entities.Abstract;
using Core.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person : IEntity
    {
        public Person()
        {

        }

        public Person(int id, int userId) : this()
        {
            Id = Id;
            UserId = userId;
        }

        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }


    }
}
