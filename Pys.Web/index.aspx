<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>
<%@ Register Src="Controls/top.ascx" TagName="top" TagPrefix="Top" %>
<%@ Register src="Controls/bottom.ascx" tagname="bottom" tagprefix="Bottom" %>
<%@ Register Src="Controls/InfoBox.ascx" TagName="infoBox" TagPrefix="InfoBox" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=uff8" />
<%= DataProvider.Instance.GetModuleInfoByName("Index").SeoString%>
<link href="style/main.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/main.js"></script>
<%=strScrollLink %>
</head>
<body>
    <form id="form1" runat="server">
    <Top:top id="Top1" runat="server" />
    <div class="content">
        <div id="homescroll">
            <div class="scrollfilter fl" id="fc"><a id="changeurl" href="#nogo" target="_blank"><%=strScrollImgageInfo %></a></div>
            <div class="scrolltip fr">
                <ul><%=strScrollTextInfo%></ul>                  
            </div>
        </div>
        <div class="homebox">
           <div class="box fl">
               <div class="title"><span class="chi_word">新闻动态</span> | <span class="numletter">NEWS</span></div>
               <InfoBox:InfoBox ID="InfoBox1" runat="server" TypeID="1" Url="newsinfo.aspx?id=num"  TableName="info" />
           </div>   
           <div class="box middlebox fl">
               <div class="title"><span class="chi_word">服务案例</span> | <span class="numletter">CASE</span></div>
               <InfoBox:InfoBox ID="InfoBox2" runat="server" TypeID="2" TableName="pcase" Url="psycase_info.aspx?id=num" />
           </div> 
           <div class="box fr">
               <div class="title"><span class="chi_word"><span class="chi_word">优秀网站</span> | <span class="numletter">WEBSITE</span></div>
                <InfoBox:InfoBox ID="InfoBox3" runat="server" TypeID="4" TableName="sites" Url="site_info.aspx?id=num" />
           </div>
        </div>
        <div class="clear"></div>
        <div class="hidden"></div>
    </div>
    <Bottom:bottom ID="Bottom" runat="server" />    
    </form>
</body>
</html>
<script type="text/javascript">
    var indexvari=1;
    var tt;
    var key=0;
    function changeImg(){
        try{
            with(fc){
                filters[0].Apply(); 
            }
        }
        catch(err){}
        try{
            for(c=1;c<=5;c++){
               $("my_pic"+c).className="hide";
               $("pic"+c).className='unselect';
            }
            $("my_pic"+indexvari).className="showblock"
            $("pic"+indexvari).className='select';
            $("changeurl").href=link_url[indexvari-1];
        }
        catch(err){}
        
        try{with(fc){filters[0].Play(duration=2);filters[0].Transition=23;}} catch(err){}
        indexvari++;
        if(indexvari==6) indexvari=1;
        tt = setTimeout("changeImg()",3000);
    }
    
    function clickchange(num){
        indexvari=num;
        window.clearTimeout(tt);
        changeImg();
    }
    window.onload= changeImg;
</script>