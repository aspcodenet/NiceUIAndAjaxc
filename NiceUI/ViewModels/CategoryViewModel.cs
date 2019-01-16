using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NiceUI.ViewModels
{

    public class CategoryListViewModel
    {
        public CategoryListViewModel()
        {
            Categories = new List<CategoryViewModel>();
        }
        public List<CategoryViewModel> Categories { get; set; }
    }


    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}