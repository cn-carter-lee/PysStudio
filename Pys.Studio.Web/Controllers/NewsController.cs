using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pys.Entity;
using Pys.Studio.Web.Models;

namespace Pys.Studio.Web.Controllers
{
    public class NewsController : BaseController
    {
        public ActionResult Index()
        {
            NewsIndexModel newsIndexModel = new NewsIndexModel()
            {
                ListNews = PysProvider.GetListNews(),
                SeoString = PysProvider.GetModuleInfoByName("news").SeoString
            };
            return View(newsIndexModel);
        }

        public ActionResult Info(int id)
        {
            NewsInfo newsInfo = PysProvider.GetNewsById(id);
            return View(newsInfo);
        }
    }
}
