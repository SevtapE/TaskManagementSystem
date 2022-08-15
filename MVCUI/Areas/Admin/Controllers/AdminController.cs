using Business.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{

   
    public class AdminController : Controller
    {
        IAdminService _adminService;
        IUserService _userService;

        public AdminController(IAdminService adminService, IUserService userService)
        {
            _adminService = adminService;
            _userService = userService;
        }
        public ActionResult Index()
        {
            var admins = _adminService.GetAll();
            return View(admins);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            List<SelectListItem> users= new List<SelectListItem>( from x in _userService.GetAllActive()
                                                                  select new SelectListItem
                                                                  {
                                                                      Text = x.FirstName + " " + x.LastName,
                                                                      Value = x.Id.ToString()

                                                                  }).ToList();
            ViewBag.Users=users;
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(Entities.Concrete.Admin admin)
        {
            _adminService.Add(admin);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateAdmin(int id)
        {
            var adminToUpdate = _adminService.GetById(id);

            List<SelectListItem> usersUpdate = new List<SelectListItem>(from x in _userService.GetAllActive()
                                                                  select new SelectListItem
                                                                  {
                                                                      Text = x.FirstName + " " + x.LastName,
                                                                      Value = x.Id.ToString()

                                                                  }).ToList();
            ViewBag.UsersUpdate = usersUpdate;
          
            return View(adminToUpdate);
        }
        [HttpPost]
        public ActionResult UpdateAdmin(Entities.Concrete.Admin admin)
        {
            _adminService.Update(admin);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult DeleteAdmin(int id)
        {
            var adminToDelete = _adminService.GetById(id);
            _adminService.Delete(adminToDelete);
            return RedirectToAction("Index");
        }
    }
}
