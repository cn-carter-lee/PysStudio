<%@ Page Language="C#" AutoEventWireup="true" CodeFile="site_info.aspx.cs" Inherits="site_info" %>
<%@ Register Src="Controls\top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="Controls\bottom.ascx" TagName="bottom" TagPrefix="uc2" %>
<%@ Register src="Controls\Sites_Left_Box.ascx" tagname="Sites_Left_Box" tagprefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <%=siteInfo.SeoString %>
    <link href="style/main.css" rel="stylesheet" type="text/css" />
    <style type="text/css"> 
    .banner{width:100%;height:260px;background:url(images/news_banner.gif) top no-repeat;}
    .news_banner{background:url(images/left_news.jpg) top no-repeat;}
    </style>
    <script type="text/javascript" src="js/main.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <uc1:top ID="Top1" runat="server" />
    
    <div class="content" style="margin-top:10px;">
    <div class="banner"></div>
    <div class="site_content hidden">
        <div class="title">
            <div class="left">优秀网站|SITES</div>       
        </div>
        <div class="info_detail_title">
            <%=siteInfo.Title%>
        </div>
        <div class="info_detail_hit">来源：PYS STUDIO&nbsp;&nbsp;时间：<%=siteInfo.Addtime%>&nbsp;&nbsp【<a href="javascript:history.back()">返 回</a>】</div>
        <div class="info_detail_content infocontent">
            <%=siteInfo.Content%>
        </div>
    </div>
    </div>
<div class="clear"></div>
    <uc2:bottom ID="Bottom1" runat="server" />
    </form>
</body>
</html>
