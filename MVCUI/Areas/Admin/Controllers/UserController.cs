using Business.Abstract;
using Core.Core.Security.Dtos;
using Core.Core.Security.Entities;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{
  
    public class UserController : Controller
    {
        IUserService _useryService;
        IAuthService _authService;

        public UserController(IUserService useryService, IAuthService authService)
        {
            _useryService = useryService;
            _authService = authService;
        }
        public ActionResult Index()
        {
            var users = _useryService.GetAll();
            return View(users);
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(UserForRegisterDto userForRegisterDto)
        {
            _authService.Register(userForRegisterDto);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateUser(int id)
        {
           var userToEdit = _useryService.GetById(id);
            UserForUpdateDto userForUpdateDto = new UserForUpdateDto();
            userForUpdateDto.User=userToEdit;
            return View(userForUpdateDto);
        }
        [HttpPost]
        public ActionResult UpdateUser(UserForUpdateDto userForUpdateDto)
        {
             _useryService.Update(userForUpdateDto);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteUser(int id)
        {
            var userToDelete = _useryService.GetById(id);
            _useryService.Delete(userToDelete);
            return RedirectToAction("Index");
        }

    }
}
