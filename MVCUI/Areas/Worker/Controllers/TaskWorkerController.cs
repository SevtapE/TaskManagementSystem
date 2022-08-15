using Business.Abstract;
using System.Web.Mvc;

namespace MVCUI.Areas.Worker.Controllers
{
   
    public class TaskWorkerController : Controller
    {
        ITaskWorkerService _taskWorkerService;


        public TaskWorkerController(IWorkerService _taskWorkerService)
        {
            _taskWorkerService = _taskWorkerService;
        }
        //my tasks
        public ActionResult Index()
        {
            //yukarı id eklicem sessiondan gelen 
            //id userId'yi taşıyor
            int id = 1;
            ViewBag.Id = id;
            var tasks = _taskWorkerService.GetByWorkerUserId(id);
            return View(tasks);
        }
        public ActionResult TaskDetails(int id)
        {

            return View();
        }
    }
}
