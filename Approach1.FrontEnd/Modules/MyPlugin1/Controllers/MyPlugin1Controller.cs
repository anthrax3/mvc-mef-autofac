using Approach1.FrontEnd.Modules.MyPlugin1.Models;
using System.ComponentModel.Composition;
using System.Web.Mvc;

namespace Approach1.FrontEnd.Modules.MyPlugin1.Controllers
{
    [Export("MyPlugin1", typeof(IController))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class MyPlugin1Controller : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            ViewBag.TestModel = new MyPlugin1Model() { Foo = "This is Hello from MEF Plugin 1" };
            return View();
        }

    }
}
