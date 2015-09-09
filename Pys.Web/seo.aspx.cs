using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pys.Web
{
    public partial class seo : System.Web.UI.Page
    {
        protected string strNavInfo;
        protected void Page_Load(object sender, EventArgs e)
        {
            listSeoInfo.DataSource = DataProvider.Instance.GetListSeoInfo();
            listSeoInfo.DataBind();
            strNavInfo = "";
        }
    }
}