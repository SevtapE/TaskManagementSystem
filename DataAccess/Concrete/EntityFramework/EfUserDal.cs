using Core.Core.DataAccess.Concrete.EntityFramework;
using Core.Core.Security.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, TaskManagerContext>, IUserDal
    {
        public EfUserDal(TaskManagerContext context) : base(context)
        {
        }

        public List<OperationClaim> GetClaims(User user)
        {
            

                var result = from operationClaim in Context.OperationClaims
                             join userOperationClaim in Context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim
                             {
                                 Id = operationClaim.Id,
                                 Name = operationClaim.Name
                             };
                return result.ToList();

            
        }
    }
}
