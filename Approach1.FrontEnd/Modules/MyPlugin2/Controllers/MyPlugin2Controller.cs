using Approach1.Core.Service;
using Approach1.Core.Model;
using System.ComponentModel.Composition;
using System.Web.Mvc;
using Approach1.FrontEnd.Modules.MyPlugin2.Models;

namespace Approach1.FrontEnd.Modules.MyPlugin2.Controllers
{
    [Export("MyPlugin2", typeof(IController))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class MyPlugin2Controller : Controller
    {
        private readonly IBrandService brandService;

        public MyPlugin2Controller(IBrandService brandSer)
        {
            this.brandService = brandSer;
        }

        public ActionResult Index()
        {
            ViewBag.TestModel = new MyPlugin2Model() { Foo = "This is Hello from MEF Plugin 2" };
            return View();
        }

        public ActionResult DisplayBranchCodes()
        {
            var codes = this.brandService.GetAllBrands();
            return View(codes);
        }

    }
}
