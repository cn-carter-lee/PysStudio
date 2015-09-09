function selectNav(o)
{
    o.className='topnav_ul_li_s';
}
function unSelectNav(o)
{
    o.className='nav_ul_li';
}

function $(id) {
    return document.getElementById(id);
}

function overTopMenu(element) {
    if(element.className == "select") {
        return;
    }
    element.className = "overbtn";
}

function outTopMenu(element) {
    if(element.className == "select") {
        return;
    }
    element.className = "";
}
