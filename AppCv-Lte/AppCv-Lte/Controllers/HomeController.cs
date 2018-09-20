using System.Web.Mvc;

namespace AppCv_Lte.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //el codigo fue modificado correctamente desde github.
            return View();
        }

        public ActionResult AnotherLink()
        {
            return View("Index");
        }
    }
}
