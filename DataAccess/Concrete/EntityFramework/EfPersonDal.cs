using Core.Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonDal : EfEntityRepositoryBase<Person, TaskManagerContext>, IPersonDal
    {
        public EfPersonDal(TaskManagerContext context) : base(context)
        {
        }
    }
}
