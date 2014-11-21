$(function () {
    $("div.top>a").click(function () {
        var v_$this = $(this);
        var v_type = $(this).attr("atype");
        var v_name = $(this).html();
        var v_ctype = $("#lblTitle").attr("atype");
        var v_cname = $("#lblTitle").html();
        var v_ul = $(this).parent().next("div").children().children().children().children("ul");
        var pars = "action=farmingnews&extend1=" + v_type + "&extend2=" + v_ctype + "&s=" + Math.random();
        var axd = getURL() + "farmingnews_country.axd";
        ajaxfunc(axd, pars, errorfunc, function (data) {
            var strArray = data.split('!@#$%%$#@!');
            if (strArray.length == 2) {
                v_$this.attr("atype", v_ctype);
                $("#lblTitle").attr("atype", v_type);
                v_$this.html(v_cname);
                v_ul.html(strArray[0])
                var strArray2 = strArray[1].split('$$$$');
                if (strArray2.length == 3) {
                    $('#lblTitle').html(v_name);
                    var v_tr = strArray2[0];
                    v_tr += ("<tr><td colspan=\"2\" style=\"text-align: right;\"><div class=\"pageBar\" id=\"divPageBar\">");
                    v_tr += strArray2[1];
                    v_tr += "</div> </td> </tr>";
                    $("#tbContent").html(v_tr);
                }
            }
        })
    });

    $("div.more a").click(function () {
        var v_$this = $(this);
        var v_ul = v_$this.parent().parent().prev("div").children().children("ul");
        var v_a = v_$this.parent().parent().parent().parent().prev("div").children("a");
        var v_type = v_a.attr("atype");
        var v_name = v_a.html();
        var v_ctype = $("#lblTitle").attr("atype");
        var v_cname = $("#lblTitle").html();
        //alert(v_type + ":::" + v_name); 
        var pars = "action=farmingnews&extend1=" + v_type + "&extend2=" + v_ctype + "&s=" + Math.random();
        var axd = getURL() + "farmingnews_country.axd";
        ajaxfunc(axd, pars, errorfunc, function (data) {
            var strArray = data.split('!@#$%%$#@!');
            if (strArray.length == 2) {
                v_a.attr("atype", v_ctype);
                $("#lblTitle").attr("atype", v_type);
                v_a.html(v_cname);
                v_ul.html(strArray[0])
                var strArray2 = strArray[1].split('$$$$');
                if (strArray2.length == 3) {
                    $('#lblTitle').html(v_name);
                    var v_tr = strArray2[0];
                    v_tr += ("<tr><td colspan=\"2\" style=\"text-align: right;\"><div class=\"pageBar\" id=\"divPageBar\">");
                    v_tr += strArray2[1];
                    v_tr += "</div> </td> </tr>";
                    $("#tbContent").html(v_tr);
                }
            }
        })
    });
});