using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.OleDb;
using Pys.Entity;

public partial class pyscase_info : System.Web.UI.Page
{
    protected CaseInfo caseInfo;
    protected void Page_Load(object sender, EventArgs e)
    {
        int id=Convert.ToInt32(Request["id"]);
        caseInfo = DataProvider.Instance.GetCaseById(id);
    }
}