using Business.Abstract;
using Entities.Concrete;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{
   
  
    public class CompanyController : Controller
    {
        ICompanyService _companyService;

       
        public CompanyController(ICompanyService companyService) 
        {
            _companyService = companyService;
        }
    
        public ActionResult Index()
        {
          var companies= _companyService.GetAll();
            return View(companies);
        }
        [HttpGet]
        public ActionResult AddCompany()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCompany(Company company)
        {
            _companyService.Add(company);
            return RedirectToAction("Index","Company");
        }
        [HttpGet]
        public ActionResult UpdateCompany(int id)
        {
            var companyToEdit = _companyService.GetById(id);
            return View(companyToEdit);
        }
        [HttpPost]
        public ActionResult UpdateCompany(Company company)
        {
            _companyService.Update(company);
            return RedirectToAction("Index", "Company");

        }
        [HttpGet]
        public ActionResult DeleteCompany(int id)
        {
            var companyToDelete = _companyService.GetById(id);
            _companyService.Delete(companyToDelete);
            return RedirectToAction("Index", "Company");

        }

        [HttpGet]
        public ActionResult GetCompanyEmployees(int id)
        {
            ViewBag.Id = id;
            return RedirectToAction("Index");
        }


    }
}
