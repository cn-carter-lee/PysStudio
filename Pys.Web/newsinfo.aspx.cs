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

public partial class newsinfo : System.Web.UI.Page
{
    protected string strSeoInfo = "";
    protected string strTitle;
    protected string strContent;
    protected string strPublishTime;
    protected string strSource;
    protected NewsInfo newsInfo;
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request["id"]);
        newsInfo = DataProvider.Instance.GetNewsById(id);
        strSeoInfo = "";
        strPublishTime = newsInfo.AddTime.ToString("yyyy-MM-dd");
    }
}
