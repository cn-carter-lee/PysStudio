using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pys.Studio.Web.Models;
using Pys.Entity;

namespace Pys.Studio.Web.Controllers
{
    public class BlogController : BaseController
    {
        //
        // GET: /Blog/

        public ActionResult Index()
        {
            TestCalendar test = new TestCalendar();
            ViewBag.Content = test.Generate();
            BlogIndexModel blogIndexModel = new BlogIndexModel()
            {
                ListBlogs = PysProvider.GetListBlogInfo(),
                SeoString = PysProvider.GetModuleInfoByName("blog").SeoString
            };
            return View(blogIndexModel);
        }

        public ActionResult Info(int id)
        {
            BlogInfo blogInfo = PysProvider.GetBlogInfoById(id);
            ViewBag.Content = "";
            return View(blogInfo);
        }
    }
}
