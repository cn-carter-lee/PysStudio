<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pyscase.aspx.cs" Inherits="pyscase" %>
<%@ Register Src="Controls\top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="Controls\bottom.ascx" TagName="bottom" TagPrefix="uc2" %>
<%@ Register src="Controls\Sites_Left_Box.ascx" tagname="Sites_Left_Box" tagprefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <%= DataProvider.Instance.GetModuleInfoByName("pyscase").SeoString%>
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
            <uc3:Sites_Left_Box ID="Sites_Left_Box1" runat="server"  />    
    </div>
    <div class="rightbox fr hidden">
        <div class="right_title">
            <div class="right_title_left"><%=strTypeName%></div>
            <div class="right_title_right"></div>
        </div>
        <div class="right_info_top"></div>
        <div style="background:url(images/right_bg.png) repeat-y"><br />  
            <%=strInfo %>
            <%=strNavInfo %>
        </div>
        <div class="clear"></div>
        <div class="right_info_bottom"></div>
    </div>
    </div>
    <div class="clear"></div>
    <uc2:bottom ID="Bottom1" runat="server" />
    </form>
</body>
</html>
