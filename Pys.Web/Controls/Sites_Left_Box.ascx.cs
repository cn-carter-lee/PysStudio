using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pys.Web
{
    public partial class Sites_Left_Box : System.Web.UI.UserControl
    {

        private SiteBoxType _boxType;
        public SiteBoxType BoxType
        {
            set { _boxType = value; }
            get { return _boxType; }
        }
        protected string _leftTitle;

        protected string _rightTitle;

        protected string _typeUrl;


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string _strsql = "";
                switch (_boxType)
                {
                    case SiteBoxType.PSYCASE:
                        _leftTitle = "服务案例";
                        _rightTitle = "CASE";
                        _strsql = "select * from pcase_type order by order_flag desc";
                        _typeUrl = "psycase.aspx";
                        break;
                    case SiteBoxType.SITES:
                        _leftTitle = "优秀网站";
                        _rightTitle = "SITES";
                        _strsql = "select * from sites_type order by order_flag desc";
                        _typeUrl = "sites.aspx";
                        break;
                    case SiteBoxType.SEO:
                        _leftTitle = "搜索优化";
                        _rightTitle = "SEO";
                        _strsql = "select * from seo_type order by order_flag desc";
                        _typeUrl = "seo.aspx";
                        break;
                    case SiteBoxType.NEWS:
                        _leftTitle = "新闻中心";
                        _rightTitle = "NEWS";
                        _strsql = "select * from info_type order by order_flag desc";
                        _typeUrl = "news.aspx";
                        break;
                    case SiteBoxType.MODULE:
                        _leftTitle = "常用模块";
                        _rightTitle = "MODULE";
                        _strsql = "select * from module_type order by order_flag desc";
                        _typeUrl = "module.aspx";
                        break;
                    case SiteBoxType.DOWNLOAD:
                        _leftTitle = "下载中心";
                        _rightTitle = "DOWNLOAD";
                        _strsql = "select * from file_type order by order_flag desc";
                        _typeUrl = "download.aspx";
                        break;
                }
                
                listNewsTypes.DataSource = null;
                listNewsTypes.DataBind();
            }
            catch { }   
        }
    }
}
public enum SiteBoxType
{
    PSYCASE,
    SITES,
    SEO,
    NEWS,
    MODULE,
    DOWNLOAD
}

