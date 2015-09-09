using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pys.Data;

namespace Pys.Studio.Web.Controllers
{
    public class BaseController : Controller
    {
        protected IDataProvider PysProvider;

        public BaseController(IDataProvider provider)
        {
            this.PysProvider = provider;
        }

        public BaseController()
            : this(new PysDataProvider())
        {

        }
    }
}
