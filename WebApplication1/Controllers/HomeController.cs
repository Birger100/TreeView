using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var testModel = new TestModel
            {
                Id = 1,
                Name = "test",
                TreeViewModels = PopulateList(),
                TreeViewModels2 = PopulateList2()

            };
            return View(testModel);
        }
        public ActionResult Create(TestModel model)
        {
            var testModel = new TestModel
            {
                Id = 1,
                Name = "test",
                TreeViewModels = PopulateList(),
                TreeViewModels2 = PopulateList2()

            };

            return View("Index", testModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        private List<TreeViewModel> PopulateList2()
        {
            var list = new List<TreeViewModel>();

            list.Add(new TreeViewModel { Id = 111, Name = "Top 1", ParentId = 0 });
            list.Add(new TreeViewModel { Id = 1121, Name = "Top 2", ParentId = 0 });
            list.Add(new TreeViewModel { Id = 113, Name = "Top 3", ParentId = 0 });
            list.Add(new TreeViewModel { Id = 114, Name = "Top 4", ParentId = 0 });

            //top 1 childern
            list.Add(new TreeViewModel { Id = 115, Name = "T1-Child 1", ParentId = 1 });
            list.Add(new TreeViewModel { Id = 116, Name = "T1-Child 2", ParentId = 1 });
            list.Add(new TreeViewModel { Id = 117, Name = "T1-Child 3", ParentId = 1 });

            //top 2 childern
            list.Add(new TreeViewModel { Id = 118, Name = "T2-Child 1", ParentId = 2 });
            list.Add(new TreeViewModel { Id = 119, Name = "T2-Child 2", ParentId = 2 });

            //t2-child 1 children
            list.Add(new TreeViewModel { Id = 1110, Name = "T2-Child 1-1", ParentId = 6 });
            list.Add(new TreeViewModel { Id = 1111, Name = "T2-Child 1-2", ParentId = 6 });
            return list;
        }
        private List<TreeViewModel> PopulateList()
        {
            var list = new List<TreeViewModel>();

            list.Add(new TreeViewModel { Id = 1, Name = "Top 1", ParentId = 0 });
            list.Add(new TreeViewModel { Id = 2, Name = "Top 2", ParentId = 0 });
            list.Add(new TreeViewModel { Id = 3, Name = "Top 3", ParentId = 0 });
            list.Add(new TreeViewModel { Id = 4, Name = "Top 4", ParentId = 0 });

            //top 1 childern
            list.Add(new TreeViewModel { Id = 5, Name = "T1-Child 1", ParentId = 1 });
            list.Add(new TreeViewModel { Id = 6, Name = "T1-Child 2", ParentId = 1 });
            list.Add(new TreeViewModel { Id = 7, Name = "T1-Child 3", ParentId = 1 });

            //top 2 childern
            list.Add(new TreeViewModel { Id = 8, Name = "T2-Child 1", ParentId = 2 });
            list.Add(new TreeViewModel { Id = 9, Name = "T2-Child 2", ParentId = 2 });

            //t2-child 1 children
            list.Add(new TreeViewModel { Id = 10, Name = "T2-Child 1-1", ParentId = 6 });
            list.Add(new TreeViewModel { Id = 11, Name = "T2-Child 1-2", ParentId = 6 });
            return list;
        }
    }
}