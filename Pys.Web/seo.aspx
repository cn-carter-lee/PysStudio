<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="seo.aspx.cs" Inherits="Pys.Web.seo" %>
<%@ Register Src="Controls\top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register src="Controls\bottom.ascx" tagname="bottom" tagprefix="uc2" %>
<%@ Register src="Controls\Sites_Left_Box.ascx" tagname="Sites_Left_Box" tagprefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <%= DataProvider.Instance.GetModuleInfoByName("seo").SeoString%>
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
        <uc3:Sites_Left_Box ID="Sites_Left_Box1" runat="server" BoxType="SEO"  />
        <asp:Repeater ID="Repeater1" runat="server">
        </asp:Repeater>
    </div>
    <div class="rightbox fr hidden">
        <div class="right_title">
            <div class="right_title_left">搜索优化 | SEO</div>
            <div class="right_title_right"><a href="">搜索优化</a> &gt;&gt;网页设计</div>
        </div>
        <div class="right_info_top"></div>
        <div class="right_into_middle">
            <table class="" style="width:680px;margin-left:20px;" cellpadding="0" cellspacing="0">
            <asp:Repeater ID="listSeoInfo" runat="server">
                <ItemTemplate>
                    <tr>
                        <td class="into_list_title"><a href='seo_info.aspx?id=<%#DataBinder.Eval(Container,"DataItem.SeoId") %>'><%#DataBinder.Eval(Container, "DataItem.Title")%></a></td>
                        <td class="into_list_time"><%#DataBinder.Eval(Container, "DataItem.addtime")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </table>
        <%=strNavInfo %>
        </div>
        <div class="right_info_bottom"></div>
    </div>
    </div>
    <div class="clear"></div>       
    </form>
</body>
</html>