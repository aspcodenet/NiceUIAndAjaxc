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

        [HttpGet]
        public ActionResult Edit()
        {
            var model = new ViewModels.TestEditViewModel();
            model.AvailableGoals = SetupGoals();
            model.Groups = SetupGroups();
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(ViewModels.TestEditViewModel model)
        {
            if(!ModelState.IsValid)
            {

            }
            return View(model);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        protected List<SelectListItem> SetupGroups()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{ Text = "Löpning", Value="lopning" },
                new SelectListItem{ Text = "Styrketräning", Value="styrketraning" },
                new SelectListItem{ Text = "Teknik", Value="teknik" }
            };
        }

        protected List<SelectListItem> SetupGoals()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{ Text = "Nybörjare", Value="nybörjare" },
                new SelectListItem{ Text = "Bra träning", Value="goodtraining" },
                new SelectListItem{ Text = "Teknik", Value="teknik" },
                new SelectListItem{ Text = "Springa ett lopp", Value="springalopp" },
                new SelectListItem{ Text = "Springa 5km", Value="springa5k" },
                new SelectListItem{ Text = "Springa 10km", Value="springa10k" },
                new SelectListItem{ Text = "Springa halvmaraton", Value="springahalvmaraton" },
                new SelectListItem{ Text = "Springa maraton", Value="springahalvmaraton" },
            };
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