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
    public class EfClarificationDal : EfEntityRepositoryBase<Clarification, TaskManagerContext>, IClarificationDal
    {
        public EfClarificationDal(TaskManagerContext context) : base(context)
        {
        }
    }
}
