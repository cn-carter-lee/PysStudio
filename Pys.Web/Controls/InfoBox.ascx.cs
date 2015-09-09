using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pys.Web
{
    public partial class InfoBox : System.Web.UI.UserControl
    {
        public int TypeID { set; get; }

        public string Url { set; get; }

        public string TableName { set; get; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (TableName.Length <= 0) return;
            listInfo.DataSource = null;
            listInfo.DataBind();
        }
    }
}