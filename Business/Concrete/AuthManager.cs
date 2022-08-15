using Business.Abstract;
using Core.Core.Security.Dtos;
using Core.Core.Security.Entities;
using Core.Core.Security.Hashing;
using Core.Core.Security.Jwt;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {

        IUserService _userService;
        ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public AccessToken CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return accessToken;
        }

        public User Login(UserForLoginDto userForLoginDto)
        {
            var checkForLogin = _userService.GetByMail(userForLoginDto.Email);
            if (checkForLogin == null)
            {
                return null;
                //Exception later on

            }
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, checkForLogin.PasswordHash, checkForLogin.PasswordSalt))
            {
                return null; 
            }

            return checkForLogin;
        }

        public User Register(UserForRegisterDto userForRegisterDto)
        {
            var checkForRegister = _userService.GetByMail(userForRegisterDto.Email);
            if (checkForRegister != null)
            {
                return null;
            }
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);

            var user = new User
            {
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                Email = userForRegisterDto.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true

            };
            _userService.Add(user);
            return checkForRegister;


        }

       

        public bool UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return true;
            }
            return false;

        }

    }
}
