using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pys.Entity;
using Pys.Studio.Web.Models;

namespace Pys.Studio.Web.Controllers
{
    public class FunctionController : BaseController
    {
        public ActionResult Index()
        {
            FunctionIndexModel functionIndexModel = new FunctionIndexModel()
            {
                ListFunction = PysProvider.GetListPysFunction(),
                SeoString = PysProvider.GetModuleInfoByName("module").SeoString
            };
            return View(functionIndexModel);
        }

        public ActionResult Info(int id)
        {
            FunctionInfo moduleInfo = PysProvider.GetPysFunctionById(id);
            return View(moduleInfo);
        }
    }
}
