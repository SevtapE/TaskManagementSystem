using Business.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{

    public class WorkerController : Controller
    {
        IWorkerService _workerService;
        IUserService _userService;
        ICompanyService _companyService;
        IManagerService _managerService;

        public WorkerController(IWorkerService workerService, IUserService userService, ICompanyService companyService, IManagerService managerService)
        {
            _workerService = workerService;
            _userService = userService;
            _companyService = companyService;
            _managerService = managerService;
        }
        public ActionResult Index()
        {
            var workers = _workerService.GetAll();
            return View(workers);
        }
        [HttpGet]
        public ActionResult AddWorker()
        {
            List<SelectListItem> users = new List<SelectListItem>(from x in _userService.GetAllActive()
                                                                  select new SelectListItem
                                                                  {
                                                                      Text = x.FirstName + " " + x.LastName,
                                                                      Value = x.Id.ToString()

                                                                  }).ToList();
            ViewBag.Users = users;
            List<SelectListItem> managers = new List<SelectListItem>(from x in _managerService.GetAll()
                                                                           select new SelectListItem
                                                                           {
                                                                               Text = x.User.FirstName + " " + x.User.LastName,
                                                                               Value = x.Id.ToString()

                                                                           }).ToList();
            ViewBag.Managers = managers;
            List<SelectListItem> companies = new List<SelectListItem>(from x in _companyService.GetAll()
                                                                      select new SelectListItem
                                                                      {
                                                                          Text = x.CompanyName,
                                                                          Value = x.CompanyId.ToString()

                                                                      }).ToList();
            ViewBag.Companies = companies;
            return View();
        }

        [HttpPost]
        public ActionResult AddWorker(Entities.Concrete.Worker worker)
        {
            _workerService.Add(worker);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateWorker(int id)
        {
            var workerToUpdate = _workerService.GetById(id);

            List<SelectListItem> usersUpdate = new List<SelectListItem>(from x in _userService.GetAllActive()
                                                                        select new SelectListItem
                                                                        {
                                                                            Text = x.FirstName + " " + x.LastName,
                                                                            Value = x.Id.ToString()

                                                                        }).ToList();
            ViewBag.UsersUpdate = usersUpdate;
            List<SelectListItem> managersUpdate = new List<SelectListItem>(from x in _managerService.GetAll()
                                                                        select new SelectListItem
                                                                        {
                                                                            Text = x.User.FirstName + " " + x.User.LastName,
                                                                            Value = x.Id.ToString()

                                                                        }).ToList();
            ViewBag.ManagersUpdate = managersUpdate;
            List<SelectListItem> companiesUpdate = new List<SelectListItem>(from x in _companyService.GetAll()
                                                                            select new SelectListItem
                                                                            {
                                                                                Text = x.CompanyName,
                                                                                Value = x.CompanyId.ToString()

                                                                            }).ToList();
            ViewBag.CompaniesUpdate = companiesUpdate;
            return View(workerToUpdate);
        }
        [HttpPost]
        public ActionResult UpdateWorker(Entities.Concrete.Worker worker)
        {
            _workerService.Update(worker);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult DeleteWorker(int id)
        {
            var workerToDelete = _workerService.GetById(id);
            _workerService.Delete(workerToDelete);
            return RedirectToAction("Index");
        }
    }
}
