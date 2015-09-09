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
using System.Text;
using Pys.Entity;
public partial class index : System.Web.UI.Page
{
    protected string strScrollLink;
    protected string strScrollImgageInfo;
    protected string strScrollTextInfo;

    protected void Page_Load(object sender, EventArgs e)
    {        
        LoadScrollLink();
    }

    private void LoadScrollLink()
    {
        StringBuilder sbImageInfo = new StringBuilder();
        StringBuilder sbScrollLink = new StringBuilder();
        StringBuilder sbScrollTextInfo = new StringBuilder();
        sbScrollLink.Append("<script language=\"javascript\" type=\"text/javascript\">");
        sbScrollLink.Append("var link_url=[");
        System.Collections.Generic.List<ScrollItem> listPsyScrollItem = DataProvider.Instance.GetIndexScrollItems();
        for (int i = 0; i < listPsyScrollItem.Count; i++)
        {
            sbImageInfo.Append(" <img src=\"ImageUpload/about_scroll_");
            sbImageInfo.Append((i + 1).ToString());
            sbImageInfo.Append(".jpg\" alt=\"");
            sbImageInfo.Append(listPsyScrollItem[i].Name);
            sbImageInfo.Append("\"");
            sbImageInfo.Append(" id=\"my_pic" + (i + 1).ToString() + "\"  class=\"");

            if (i == 0)
            {
                sbImageInfo.Append("mscrollpic");
                sbScrollTextInfo.Append("<li id=\"pic1\" class=\"select\"><a href=\"" + listPsyScrollItem[i].Url + "\">&nbsp;&nbsp;" + listPsyScrollItem[i].Title + "</a></li>");
            }
            else
            {
                sbImageInfo.Append("n_mscrollpic");
                sbScrollLink.Append(",");
                sbScrollTextInfo.Append("<li id=\"pic" + (i + 1).ToString() + "\" class=\"select\"><a href=\"" + listPsyScrollItem[i].Url + "\"  target=\"_blank\">&nbsp;&nbsp;" + listPsyScrollItem[i].Title + "</a></li>");
            }
            sbImageInfo.Append("\" />");
            sbScrollLink.Append("\"" + listPsyScrollItem[i].Url + "\"");
        }
        sbScrollLink.Append("];</script>");
        strScrollLink = sbScrollLink.ToString();
        strScrollImgageInfo = sbImageInfo.ToString();
        strScrollTextInfo = sbScrollTextInfo.ToString();
    }
}
