using Business.Abstract;
using Entities.Concrete;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{

    public class EmployeeController : Controller
    {
        IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public ActionResult Index()
        {
            var employees = _employeeService.GetAll();
            return View(employees);
        }

        public ActionResult GetByCompany(int id)
        {

            var employees = _employeeService.GetByCompany(id);
          
            return View(employees);
        }
        //[HttpGet]
        //public ActionResult AddManager()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult AddManager(Entities.Concrete.Manager manager)
        //{
        //    _managerService.Add(manager);
        //    return RedirectToAction("Index");
        //}


        //[HttpGet]
        //public ActionResult UpdateManager(int id)
        //{
        //    var managerToUpdate = _managerService.GetById(id);
        //    return View(managerToUpdate);
        //}
        //[HttpPost]
        //public ActionResult UpdateManager(Entities.Concrete.Manager manager)
        //{
        //    _managerService.Update(manager);
        //    return RedirectToAction("Index");
        //}


        //[HttpGet]
        //public ActionResult DeleteManager(int id)
        //{
        //    var managerToDelete = _managerService.GetById(id);
        //    _managerService.Delete(managerToDelete);
        //    return RedirectToAction("Index");
        //}
    }
}
