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
    public class NewsIndexModel:SeoBaseModel
    {
        public List<NewsInfo> ListNews;
    }
}
