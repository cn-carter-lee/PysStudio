using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pys.Web
{
    public partial class top : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.EnableViewState = false;
            string strRawUrl = Request.RawUrl;
            if (strRawUrl.Contains("index.aspx"))
            {
                menu_index.Attributes.Add("class", "select");
            }
            else if (strRawUrl.Contains("psycase.aspx") || strRawUrl.Contains("psycase_info"))
            {
                menu_psycase.Attributes.Add("class", "select");
            }
            else if (strRawUrl.Contains("sites.aspx") || strRawUrl.Contains("site_info"))
            {
                menu_sites.Attributes.Add("class", "select");
            }
            else if (strRawUrl.Contains("seo.aspx") || strRawUrl.Contains("seo_info"))
            {
                menu_seo.Attributes.Add("class", "select");
            }
            else if (strRawUrl.Contains("news") || strRawUrl.Contains("newsinfo"))
            {
                menu_news.Attributes.Add("class", "select");
            }
            else if (strRawUrl.Contains("download.aspx"))
            {
                menu_download.Attributes.Add("class", "select");
            }
            else if (strRawUrl.Contains("module.aspx") || strRawUrl.Contains("module_info.aspx"))
            {
                menu_module.Attributes.Add("class", "select");
            }
        }
    }
}