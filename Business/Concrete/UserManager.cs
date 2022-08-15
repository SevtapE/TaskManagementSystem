using Business.Abstract;
using Core.Core.Security.Dtos;
using Core.Core.Security.Entities;
using Core.Core.Security.Hashing;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User entity)
        {
            _userDal.Add(entity);   
        }

        public void Delete(User entity)
        {
            entity.Status=false;
            _userDal.Update(entity);
        }

        public List<User> GetAll()
        {
            
           return _userDal.GetAll();
        }

        public List<User> GetAllActive()
        {

            return _userDal.GetAll(x=>x.Status==true);
        }
        public User GetById(int id)
        {
            return _userDal.Get(x=>x.Id == id);
        }

        public void Update(UserForUpdateDto userForUpdateDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForUpdateDto.Password, out passwordHash, out passwordSalt);
            userForUpdateDto.User.PasswordSalt = passwordSalt;
            userForUpdateDto.User.PasswordHash=passwordHash;
            _userDal.Update(userForUpdateDto.User);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(x => x.Email == email);

        }
       public  List<OperationClaim> GetClaims(User user)
        {
          return  _userDal.GetClaims(user);




        }


    }
}
