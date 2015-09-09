using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pys.Entity;
using Pys.Studio.Web.Models;

namespace Pys.Studio.Web.Controllers
{
    public class SeoController : BaseController
    {
        public ActionResult Index()
        {
            SeoIndexModel seoIndexModel = new SeoIndexModel()
            {
                ListSeoInfo = PysProvider.GetListSeoInfo(),
                SeoString = PysProvider.GetModuleInfoByName("seo").SeoString
            };
            return View(seoIndexModel);
        }

        public ActionResult Info(int id)
        {
            SeoInfo seoInfo = PysProvider.GetSeoInfoById(id);
            return View(seoInfo);
        }
    }
}
