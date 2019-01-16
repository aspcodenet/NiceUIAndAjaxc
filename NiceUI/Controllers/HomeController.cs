using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NiceUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult GetCategories()
        {
            var model = new ViewModels.CategoryListViewModel();
            model.Categories.AddRange(new[]{
                new ViewModels.CategoryViewModel{ Id=1,Name="sdfadassda"},
                new ViewModels.CategoryViewModel{ Id=2,Name="sfasdf"},
                new ViewModels.CategoryViewModel{ Id=3,Name="ewqqwe"}
            });
            return View(model);
        }

        public ActionResult GetPartialCategories()
        {
            var model = new ViewModels.CategoryListViewModel();
            model.Categories.AddRange(new[]{
                new ViewModels.CategoryViewModel{ Id=1,Name="ajax sdfadassda"},
                new ViewModels.CategoryViewModel{ Id=2,Name="ajax sfasdf"},
                new ViewModels.CategoryViewModel{ Id=3,Name="ajax ewqqwe"}
            });
            return PartialView("GetCategories", model);
        }

        public JsonResult GetFirstCategory()
        {
            var model = new ViewModels.CategoryViewModel { Id = 1, Name = "ajax sdfadassda" };
            return Json(model,JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCategoriesJson()
        {
            var model = new ViewModels.CategoryListViewModel();
            model.Categories.AddRange(new[]{
                new ViewModels.CategoryViewModel{ Id=1,Name="ajax sdfadassda"},
                new ViewModels.CategoryViewModel{ Id=2,Name="ajax sfasdf"},
                new ViewModels.CategoryViewModel{ Id=3,Name="ajax ewqqwe"}
            });
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        




        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}