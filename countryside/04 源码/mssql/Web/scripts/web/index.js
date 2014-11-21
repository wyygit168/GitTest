
//首页上部右侧轮换菜单事件
function indextoprightmenu() {
    $("#divNewTitle>div").hover(function () {
        $(this).attr("class", "R_NewTopTitleItemSel");
        $(this).siblings().attr("class", "R_NewTopTitleItem");
        var index = $("#divNewTitle>div").index(this);
        var showObj = $("#divShow >div:nth-child(" + parseInt(index + 1) + ")")
        showObj.attr("style", "display:block");
        showObj.siblings().attr("style", "display:none");
    });
}

$(function () {
    indextoprightmenu();
});