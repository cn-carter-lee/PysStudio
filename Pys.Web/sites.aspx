<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sites.aspx.cs" Inherits="sites" %>
<%@ Register Src="Controls\top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="Controls\bottom.ascx" TagName="bottom" TagPrefix="uc2" %>
<%@ Register Src="Controls\Sites_Left_Box.ascx" TagName="Sites_Left_Box" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <%=DataProvider.Instance.GetModuleInfoByName("sites").SeoString%>
    <link href="style/main.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .banner
        {
            width: 100%;
            height: 260px;
            background: url(images/news_banner.gif) top no-repeat;
        }
        .news_banner
        {
            background: url(images/left_news.jpg) top no-repeat;
        }
    </style>
    <script type="text/javascript" src="js/main.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <uc1:top ID="Top1" runat="server" />
    <div class="content" style="margin-top: 10px;">
        <div class="banner">
        </div>
        <div class="left_box fl">
            <uc3:Sites_Left_Box ID="Sites_Left_Box1" runat="server" BoxType="SITES" />
        </div>
        <div class="rightbox fr hidden">
            <div class="right_title">
                <div class="right_title_left">
                    优秀网站 | SITES</div>
                <div class="right_title_right">
                </div>
            </div>
            <div class="right_info_top">
            </div>
            <div class="right_into_middle">
                <br />
                <%=strInfo %>
                <div class="clear">
                </div>
                <%=strNavInfo %>
            </div>
            <div class="right_info_bottom">
            </div>
        </div>
    </div>
    <div class="content" style="margin-top: 20px;">
    </div>
    <div class="clear">
    </div>
    <uc2:bottom ID="Bottom1" runat="server" />
    </form>
</body>
</html>
