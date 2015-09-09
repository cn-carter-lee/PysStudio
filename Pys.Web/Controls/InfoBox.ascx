<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InfoBox.ascx.cs" Inherits="Pys.Web.InfoBox" %>
<table border="0" cellpadding="0" cellspacing="0" class="list">
  <asp:Repeater ID="listInfo" runat="server">
  <ItemTemplate>
      <tr>
        <td style="height:24px;"><a href='<%#Url.ToLower().Replace("num",DataBinder.Eval(Container,"DataItem.id").ToString()) %>'><%#DataBinder.Eval(Container, "DataItem.m_title").ToString()%></a></td>
      </tr>
      </ItemTemplate>
  </asp:Repeater>
</table>