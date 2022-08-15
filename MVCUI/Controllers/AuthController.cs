using Business.Abstract;
using Business.Concrete;
using Core.Core.Security.Dtos;
using Core.Core.Security.Jwt;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCUI.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        IAuthService _authService;


        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var registered = _authService.Register(userForRegisterDto);
            if (registered == null)
            {
                return RedirectToAction("Login");
            }
           // var accessToken = _authService.CreateAccessToken(registered);

            return RedirectToAction("/Home/Index");
        }


        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public  ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var loggedIn = _authService.Login(userForLoginDto);
            if (loggedIn == null)
            {
                return View();
            }
           // var accessToken = _authService.CreateAccessToken(loggedIn);
            
            return RedirectToAction("Index", "Home");

        }
    }
  
}