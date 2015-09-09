using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using Pys.Entity;

namespace Pys.Studio.Web.Models
{
    public class HomeModel : SeoBaseModel
    {
        public List<ScrollItem> ListScrollItems;
        public List<NewsInfo> ListNews;
        public List<CaseInfo> ListCases;
        public List<SiteInfo> ListSites;
    }
}
