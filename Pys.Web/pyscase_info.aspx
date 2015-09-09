<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pyscase_info.aspx.cs" Inherits="pyscase_info" %>
<%@ Register Src="Controls/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register src="Controls/bottom.ascx" tagname="bottom" tagprefix="uc2" %>
<%@ Register src="Controls/Sites_Left_Box.ascx" tagname="Sites_Left_Box" tagprefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <%=caseInfo.SeoString%>
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
    <div class="left_box fl">
        <uc3:Sites_Left_Box ID="Sites_Left_Box1" runat="server" LeftTitle="服务案例" RightTitle="CASE" />
    </div>
    <div class="rightbox fr hidden">
        <div class="right_title">
            <div class="right_title_left"><%=caseInfo.TypeName%></div>
            <div class="right_title_right"></div>
        </div>
        <div class="right_info_top"></div>
        <div class="right_into_middle">
            <div class="info_detail_title">
            <%=caseInfo.Title%>
            </div>
            <div class="info_detail_hit">来源：PYS STUDIO&nbsp;&nbsp;时间：<%=caseInfo.PublishTime%> &nbsp;&nbsp【<a href="javascript:history.back()">返 回</a>】</div>
            <div class="info_detail_content">
            <%=caseInfo.Content%>
            </div>
        </div>
        <div class="right_info_bottom"></div>
    </div>
    </div>
<div class="clear"></div>
    <uc2:bottom ID="Bottom1" runat="server" />
    </form>
</body>
</html>
