using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //default route is /[Controller]/[ActionName]/[Parameters]
        //Controller methods are known as action methods - they return an ActionResult or something that derives from ActionResult

        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //If passing something to a view you must use an ActionResult
        public ActionResult Welcome(string name, int numTimes = 1)
        {

            //ViewBag is a dynamic object, which means you can put whatever you want in to it; the ViewBag object has no defined properties until you put something inside it.
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}