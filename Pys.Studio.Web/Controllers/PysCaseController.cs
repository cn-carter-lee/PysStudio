using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pys.Studio.Web.Models;
using Pys.Entity;

namespace Pys.Studio.Web.Controllers
{
    public class PysCaseController : BaseController
    {
        public ActionResult Index()
        {
            PysCaseIndexModel pysCaseIndexModel = new PysCaseIndexModel()
            {
                ListCases = PysProvider.GetListCases(),
                SeoString = PysProvider.GetModuleInfoByName("pyscase").SeoString
            };
            return View(pysCaseIndexModel);
        }


        public ActionResult Info(int id)
        {
            CaseInfo caseInfo = PysProvider.GetCaseById(id);
            return View(caseInfo);
        }
    }
}
