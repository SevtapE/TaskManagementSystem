using Core.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Core.Security.Entities
{
    public class OperationClaim:IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public OperationClaim()
        {
        }

        public OperationClaim(int id,string name):this()
        {
            Id = id;
            Name = name;
        }
    }
}
