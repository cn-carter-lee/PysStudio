using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pys.Entity;
using Pys.Studio.Web.Models;

namespace Pys.Studio.Web.Controllers
{
    public class SiteController : BaseController
    {
        public ActionResult Index()
        {
            SiteIndexModel siteIndexModel = new SiteIndexModel()
            {
                ListSites = PysProvider.GetListSiteInfo(),
                SeoString = PysProvider.GetModuleInfoByName("sites").SeoString
            };
            return View(siteIndexModel);
        }

        public ActionResult Info(int id)
        {
            SiteInfo siteInfo = PysProvider.GetSiteInfoById(id);
            return View(siteInfo);
        }
    }
}
