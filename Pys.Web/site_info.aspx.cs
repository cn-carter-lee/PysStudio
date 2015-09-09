using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;
using Pys.Entity;
public partial class site_info : System.Web.UI.Page
{
    protected SiteInfo siteInfo;
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request["id"]);
        siteInfo = DataProvider.Instance.GetSiteInfoById(id);
    }
}
