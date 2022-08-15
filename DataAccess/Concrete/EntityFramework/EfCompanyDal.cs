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
    public class EfCompanyDal : EfEntityRepositoryBase<Company, TaskManagerContext>, ICompanyDal
    {
        public EfCompanyDal(TaskManagerContext context) : base(context)
        {
        }
    }
}
