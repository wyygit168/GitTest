<%@ Application Language="C#" %> 
<%@ Import Namespace="System.Web.Routing" %>
<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        //在应用程序启动时运行的代码
        PersistenceLayer.Setting.Instance().DatabaseMapFile = Server.MapPath("~") + "\\config\\DatabaseMap.config";
        //RegisterRoutes(RouteTable.Routes);
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //在应用程序关闭时运行的代码

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        //在出现未处理的错误时运行的代码

    }

    void Session_Start(object sender, EventArgs e) 
    {
        //在新会话启动时运行的代码

    }

    void Session_End(object sender, EventArgs e) 
    {
        //在会话结束时运行的代码。 
        // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为
        // InProc 时，才会引发 Session_End 事件。如果会话模式 
        //设置为 StateServer 或 SQLServer，则不会引发该事件。

    }
    
    //void RegisterRoutes( RouteCollection routes)
    //{

    //    var defaults = new RouteValueDictionary { { "iscache", "1" }};
    //    //var defaults = new RouteValueDictionary();
    //    routes.MapPageRoute("index", "index/{iscache}/", "~/index.aspx", false, defaults);//首页重写

    //    //routes.MapPageRoute("urlrewrite2",
    //    //"area/{areacode}/{days}.html",
    //    //"~/WebForm2.aspx", false, defaults);
        
    //    //var defaults2 = new RouteValueDictionary { { "days", "" } };
    //    //routes.MapPageRoute("urlrewrite2",
    //    //"{days}.html",
    //    //"~/WebForm2.aspx", false, defaults2);

    //}  

</script>
