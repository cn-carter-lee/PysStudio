using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pys.Studio.Web.Models;
using Pys.Entity;
using Pys.Data;
using System.Data;

namespace Pys.Studio.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //DataTable dt = PysDataBase.GetDataTable("select *,format(m_addtime,'yyyy-MM-dd') as addtime from modules");
            //foreach (DataRow row in dt.Rows)
            //{
            //    FunctionInfo functionInfo = new FunctionInfo()
            //    {
            //        Title = row["m_title"].ToString(),
            //        Keywords = row["m_keywords"].ToString(),
            //        Description = row["m_description"].ToString(),
            //        Content = row["m_content"].ToString(),
            //        AddTime = Convert.ToDateTime(row["addtime"])
            //    };
            //    PysProvider.AddFunctionInfo(functionInfo);
            //}
            var model = new HomeModel()
            {
                ListNews = PysProvider.GetListNews(),
                ListSites = PysProvider.GetListSiteInfo(),
                ListCases = PysProvider.GetListCases(),
                ListScrollItems = PysProvider.GetIndexScrollItems(),
                SeoString = PysProvider.GetModuleInfoByName("index").SeoString
            };
            return View(model);
        }

        public ActionResult Info(string name)
        {
            HelpInfoModel helpInfoModel = new HelpInfoModel()
            {
                HelpInfo = PysProvider.GetHelpInfoByName(name),
                ListHelpInfo = PysProvider.GetListHelpInfo()
            };
            return View("Info", helpInfoModel);
        }

        public ActionResult About()
        {
            return GetInfoPage("about");
        }

        public ActionResult Introduction()
        {
            return GetInfoPage("introduction");
        }

        public ActionResult Contact()
        {
            return GetInfoPage("contact");
        }

        public ActionResult Statement()
        {
            return GetInfoPage("statement");
        }

        public ActionResult FrdLink()
        {
            return GetInfoPage("frdlink");
        }

        private ActionResult GetInfoPage(string name)
        {
            HelpInfoModel helpInfoModel = new HelpInfoModel()
                {
                    HelpInfo = PysProvider.GetHelpInfoByName(name),
                    ListHelpInfo = PysProvider.GetListHelpInfo()
                };
            return View("Info", helpInfoModel);
        }
    }
}
