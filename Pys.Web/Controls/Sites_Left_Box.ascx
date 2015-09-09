<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sites_Left_Box.ascx.cs" Inherits="Pys.Web.Sites_Left_Box" %>

<div class="left_title"><table cellpadding="0" cellspacing="0" border="0" style="width:80%;" align="center"><tr><td><span style="color:#f00;font-weight:bold;font-
size:14px;"><%=_leftTitle%></span><span style="color:#555;font-weight:bold;margin-left:10px;font-size:14px;"><%=_rightTitle%></span></td></tr></table></div>
<div class="left_space"></div>
<div>
    <ul>
        <asp:Repeater ID="listNewsTypes" runat="server">
            <ItemTemplate>
            <li><a href='<%=_typeUrl %>?type=<%#DataBinder.Eval(Container,"DataItem.typeid") %>'><%#DataBinder.Eval(Container,"DataItem.typename") %></a></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
    <asp:Repeater ID="Repeater1" runat="server">
    </asp:Repeater>
</div>
<div class="left_bottom"></div>