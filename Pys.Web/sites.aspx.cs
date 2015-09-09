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
using System.Collections.Generic;
using Pys.Entity;
using System.Text;

public partial class sites : System.Web.UI.Page
{
    protected string strInfo;
    protected string strNavInfo;

    protected void Page_Load(object sender, EventArgs e)
    {
        List<SiteInfo> sites = DataProvider.Instance.GetListSiteInfo();
        StringBuilder sbResult = new StringBuilder();
        foreach (SiteInfo siteInfo in sites)
        {
            sbResult.Append("<table  class=\"site_tb\"  border=\"0\" cellpadding=\"0\" cellspacing=\"0\">");
            sbResult.Append("<tr>");
            sbResult.Append("<td style=\"width:128px;\" rowspan=\"4\">");
            sbResult.Append("<a href=\"site_info.aspx?id=" + siteInfo.SiteId.ToString() + "\"><img class=\"b_img\" src=\"ImageUpload/" + siteInfo.ImageName + "\" width=\"112\" height=\"112\" alt=\"\" /></a>");
            sbResult.Append("</td>");
            sbResult.Append("<td class=\"title_td\">" + siteInfo.Title + "</td>");
            sbResult.Append("</tr>");
            sbResult.Append("<tr>");
            sbResult.Append("<td style=\"color:#afb2b7;\">" + siteInfo.AddTime.ToString("yyyy/MM/dd") + "</td>");
            sbResult.Append("</tr>");
            sbResult.Append("<tr>");
            sbResult.Append("<td valign=\"top\" style=\"color:#4d545a\">" + siteInfo.Description + "</td>");
            sbResult.Append("</tr>");
            sbResult.Append("<tr>");
            sbResult.Append("<td class=\"detail_td\" valign=\"middle\"><a href=\"site_info.aspx?id=" + siteInfo.SiteId.ToString() + "\"> 详 细 </a></td>");
            sbResult.Append("</tr>");
            sbResult.Append("</table>");
        }
        strInfo = sbResult.ToString();
    }
}
