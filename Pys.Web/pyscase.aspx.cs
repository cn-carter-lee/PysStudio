using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Pys.Entity;
using System.Text;

public partial class pyscase : System.Web.UI.Page
{
    protected string strInfo;
    protected string strNavInfo;
    protected string strTypeName = "服务案例";
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadInfo();
    }

    private void LoadInfo()
    {
        /*
        List<CaseInfo> listCases = DataProvider.Instance.GetListCases();
        StringBuilder sbResult = new StringBuilder();
        foreach (CaseInfo caseInfo in listCases)
        {
            sbResult.Append("<table  class=\"case_tb\"  border=\"0\" cellpadding=\"0\" cellspacing=\"0\">");
            sbResult.Append("<tr>");
            sbResult.Append("<td class=\"image_td\" rowspan=\"4\">");
            sbResult.Append("<a href=\"pyscase_info.aspx?id=" + caseInfo.CaseId.ToString() + "\"><img class=\"b_img\" src=\"ImageUpload/" + caseInfo.ImageName + "\" alt=\"" + caseInfo.Name + "\" /></a>");
            sbResult.Append("</td>");
            sbResult.Append("<td style=\"font-weight:bold; color:#4d545a\">" + caseInfo.Title + "</td>");
            sbResult.Append("</tr>");
            sbResult.Append("<tr>");
            sbResult.Append("<td style=\"color:#afb2b7;\">" + caseInfo.PublishTime.ToString("yyyy/MM/dd") + "</td>");
            sbResult.Append("</tr>");
            sbResult.Append("<tr>");
            sbResult.Append("<td valign=\"top\">" + caseInfo.Description + "</td>");
            sbResult.Append("</tr>");
            sbResult.Append("<tr>");
            sbResult.Append("<td style=\"\" valign=\"middle\" class=\"detail_td\"><a href=\"pyscase_info.aspx?id=" + caseInfo.CaseId.ToString() + "\"> 详 细 </a></td>");
            sbResult.Append("</tr>");
            sbResult.Append("</table>");
        }
        strInfo = sbResult.ToString();
         */
    }
}
