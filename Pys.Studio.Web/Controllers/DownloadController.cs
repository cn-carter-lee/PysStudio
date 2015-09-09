using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pys.Studio.Web.Models;
using Pys.Entity;

namespace Pys.Studio.Web.Controllers
{
    public class DownloadController : BaseController
    {
        public ActionResult Index()
        {
            DownloadIndexModel downloadIndexModel = new DownloadIndexModel()
            {
                ListDownloadInfo = PysProvider.GetListDownloadInfo(),
                SeoString = PysProvider.GetModuleInfoByName("download").SeoString
            };
            return View(downloadIndexModel);
        }

        public ActionResult Info(int id)
        {
            DownloadInfo downloadInfo = PysProvider.GetDownloadInfoById(id);
            return View(downloadInfo);
        }
    }
}
